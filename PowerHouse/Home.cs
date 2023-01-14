using System;
using System.IO;
using System.Data;
using System.Management;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text;

namespace PowerHouse
{
    public partial class Home : Form
    {
        const double BytesInMB = 1048576;
        const double BytesInGB = 1073741824;
        private int OldFocusedIndex = 0;

        public Home()
        {
            InitializeComponent();
            // pull stats
            // Load_processes();
            Storage_info();
            Cpu_info();
            Os_info();
            Ram_info();
            // set timer to auto refresh
            Timer timerRefresh = new Timer
            {
                Interval = (15 * 1000) // 10 seconds
            };
            timerRefresh.Tick += new EventHandler(TimerRefresh_Tick);
            // start the refresh counter
            timerRefresh.Start();
            // start the process counter
            timer.Start();
        }
        private void RefreshStats()
        {
            // load all processes
            Load_processes();
            // select the process last selected by the user
            list_processes.SelectedIndex = OldFocusedIndex;
            // load the storage
            Storage_info();
            // load the ram
            Ram_info();
        }
        // load information about operating system
        private void Os_info()
        {
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();
            StringBuilder sb = new StringBuilder();

            try
            {
                string Version = "";
                string Architecute = "";
                string Build = "";
                string DeviceName = "";

                foreach (ManagementObject result in results)
                {
                    // total visible memory
                    Version = (string)result["Caption"];
                    Architecute = (string)result["OSArchitecture"];
                    DeviceName = (string)result["CSName"];
                    Build = (string)result["BuildNumber"];
                    // append results
                    sb.AppendLine(string.Format("Windows Version : " + Version));
                    sb.AppendLine(string.Format("OS Architecture : " + Architecute));
                    sb.AppendLine(string.Format("Device Name : " + DeviceName));
                    sb.AppendLine(string.Format("Build Number : " + Build));
                }

                // display result
                lbl_storage_info.Text = (sb.ToString());
            }
            catch (Exception)
            {
                // display result
                lbl_storage_info.Text = "Storage data unavailable";
            }
        }
        // load information about ram
        private void Ram_info()
        {
            // refer to the Win32 API point to the OperatingSystem class
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();
            // use a string bulder to stack multiple lines of results in one control
            StringBuilder sb = new StringBuilder();

            try
            {
                // declare variables
                double MemorySize = 0;
                double FreeMemory = 0;
                double VirtualMemory = 0;
                // need to loop through the API data
                foreach (ManagementObject result in results)
                {
                    // total visible memory
                    MemorySize = Convert.ToDouble(result["TotalVisibleMemorySize"]);
                    // has to be converted to bytes for user friendliness
                    double MemorySize_GB = Math.Round((MemorySize / (1024 * 1024)), 2);
                    // total virtual memory
                    FreeMemory = Convert.ToDouble(result["FreePhysicalMemory"]);
                    // has to be converted to bytes for user friendliness
                    double FreeMemory_GB = Math.Round((FreeMemory / (1024 * 1024)), 2);
                    // virtual memory
                    VirtualMemory = Convert.ToDouble(result["FreeVirtualMemory"]);
                    // convert to friendly result
                    double VirtualMemory_GB = Math.Round((VirtualMemory / (1024 * 1024)), 2);
                    // append results
                    sb.AppendLine(string.Format(("Total Useable Ram : " + MemorySize_GB + "GB")));
                    sb.AppendLine(string.Format(("Used Ram : " + (MemorySize_GB - FreeMemory_GB) + "GB")));
                    sb.AppendLine(string.Format(("Available Ram : " + FreeMemory_GB + "GB")));
                    sb.AppendLine(string.Format(("Virtual Memory : " + VirtualMemory_GB + "GB")));
                }

                // display result
                lbl_ram_info.Text = sb.ToString();
            }
            catch (Exception)
            {
                // display result
                lbl_ram_info.Text = "Ram data unavailable";
            }
            
        }
        // load information about the cpu
        private void Cpu_info()
        {
            // call classes to pull cpu name
            SelectQuery Sq = new SelectQuery("Win32_Processor");
            ManagementObjectSearcher objOSDetails = new ManagementObjectSearcher(Sq);
            ManagementObjectCollection osDetailsCollection = objOSDetails.Get();
            StringBuilder sb = new StringBuilder();

            foreach (ManagementObject mo in osDetailsCollection)
            {
                sb.AppendLine(string.Format("Name : {0}", (string)mo["Name"]));
                sb.AppendLine(string.Format("Physical Cores : {0}", mo["NumberOfCores"]).ToString());
                sb.AppendLine(string.Format("Logical Processors : {0}", mo["NumberOfLogicalProcessors"]).ToString());
                sb.AppendLine(string.Format("Status : {0}", (string)mo["Status"]));
                sb.AppendLine(string.Format("Architecture : {0}", "x" + (ushort)mo["DataWidth"]));
            }
            try
            {
                lbl_cpu_model.Text = sb.ToString();
            }
            catch (Exception)
            {
                lbl_cpu_model.Text = "Processor Model unknow";
            }
        }
        // load active counters using the timer class
        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                float fcpu = pCPU.NextValue();
                float fram = pRAM.NextValue();
                float fwrite = pWRITE.NextValue();
                float fread = pREAD.NextValue();

                progress_cpu.Value = (int)fcpu;
                progress_ram.Value = (int)fram;
                progress_read.Value = (int)fread / (int)BytesInMB;

                progress_write.Value = (int)Math.Round((int)fwrite / BytesInMB);

                lbl_cpu_stat.Text = string.Format("{0:0}%", fcpu);
                lbl_ram_stat.Text = string.Format("{0:0}%", fram);
                lbl_disk_stat.Text = string.Format("{0:} MB", Math.Round((fwrite / BytesInMB), 1));
                lbl_read_stat.Text = string.Format("{0:} MB", Math.Round((fread / BytesInMB), 1));

                chart_cpu.Series["CPU"].Points.AddY(fcpu);
                chart_ram.Series["RAM"].Points.AddY(fram);
                chart_disk.Series["DISK"].Points.AddY(Math.Round(fwrite / BytesInMB));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // load information about the processor
        private void Load_processes()
        {
            list_processes.Items.Clear();
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                if (!String.IsNullOrEmpty(p.MainWindowTitle))
                {
                    try
                    {
                        list_processes.Items.Add(p.ProcessName);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Failed to load processes!", "Assistant");
                    }
                }
            }
        }
        // closes an application the user has pointed to
        private void Close_Click(object sender, EventArgs e)
        {
            foreach(var process in Process.GetProcessesByName(list_processes.Text)){
                try
                {
                    process.Kill();
                    Load_processes();
                }
                catch (Exception)
                {
                    MessageBox.Show("Access Denied!", "Assistant");
                } 
            }
        }
        // load information about the storage
        private void Storage_info()
        {

            string path = "C:\\Windows";
            string rootDir = Directory.GetDirectoryRoot(path);

            //Get all information of Drive i.e C
            DriveInfo driveInfo = new DriveInfo(rootDir);
            // convert storage in byte to gb and round by 1
            double availableFreeSpace = Math.Round((driveInfo.AvailableFreeSpace / BytesInGB), 1);
            //curating driver stats for user
            double totalSize = Math.Round((driveInfo.TotalSize / BytesInGB));
            double StoragePercentage = (100 / totalSize) * availableFreeSpace;
            double StorageUsage = 100 - Math.Round(StoragePercentage, 1);
            // append to labels
            lbl_storage_stat.Text = availableFreeSpace + " GB";
            lbl_space.Text = totalSize.ToString() + " GB";
            // set progress bar level
            progress_storage.Value = (int)StorageUsage;
        }
        // pull stats every now and then
        private void TimerRefresh_Tick(object sender, EventArgs e)
        {
            RefreshStats();
        }
        // save the current selected application
        private void List_processes_SelectedIndexChanged(object sender, EventArgs e)
        {
            OldFocusedIndex = list_processes.SelectedIndex;
        }
    }
}
