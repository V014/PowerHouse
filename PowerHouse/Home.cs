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
        

        public Home()
        {
            InitializeComponent();
            timer.Start();
            Load_processes();
            Storage_info();
            Cpu_info();
            Os_info();
            Ram_info();
        }

        private void Os_info()
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

            lbl_storage_stat.Text = availableFreeSpace + " GB";
            
            progress_storage.Value = (int)StorageUsage;

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

        private void Ram_info()
        {
            ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
            ManagementObjectCollection results = searcher.Get();
            StringBuilder sb = new StringBuilder();

            try
            {
                double MemorySize = 0;
                double FreeMemory = 0;

                foreach (ManagementObject result in results)
                {
                    // total visible memory
                    MemorySize = Convert.ToDouble(result["TotalVisibleMemorySize"]);
                    double MemorySize_GB = Math.Round((MemorySize / (1024 * 1024)), 2);
                    // total virtual memory
                    FreeMemory = Convert.ToDouble(result["FreePhysicalMemory"]);
                    double FreeMemory_GB = Math.Round((FreeMemory / (1024 * 1024)), 2);
                    // append results
                    sb.AppendLine(string.Format(("Total Useable Ram : " + MemorySize_GB + "GB")));
                    sb.AppendLine(string.Format(("Used Ram : " + (MemorySize_GB - FreeMemory_GB) + "GB")));
                    sb.AppendLine(string.Format(("Available Ram : " + FreeMemory_GB + "GB")));
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

        private void Timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            float fdisk = pDISK.NextValue();

            progress_cpu.Value = (int)fcpu;
            progress_ram.Value = (int)fram;
            try
            {
                progress_disk.Value = (int)Math.Round((int)fdisk / BytesInMB);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            lbl_cpu_stat.Text = string.Format("{0:0}%", fcpu);
            lbl_ram_stat.Text = string.Format("{0:0}%", fram);
            lbl_disk_stat.Text = string.Format("{0:} MB", Math.Round((fdisk / BytesInMB), 1));

            chart_cpu.Series["CPU"].Points.AddY(fcpu);
            chart_ram.Series["RAM"].Points.AddY(fram);
            chart_disk.Series["DISK"].Points.AddY(Math.Round(fdisk / BytesInMB));
        }

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

        private void Storage_info()
        {
            
            
        }
    }
}
