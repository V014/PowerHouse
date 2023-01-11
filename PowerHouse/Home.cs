using System;
using System.IO;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace PowerHouse
{
    public partial class Home : Form
    {
        const double BytesInMB = 1048576;
        const double BytesInGB = 1073741824;
        public Home()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
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

            lbl_cpu_stat.Text = string.Format("{0:0.00}%", fcpu);
            lbl_ram_stat.Text = string.Format("{0:0.00}%", fram);
            lbl_disk_stat.Text = string.Format("{0:} MB", Math.Round((fdisk / BytesInMB), 1));

            chart_cpu.Series["CPU"].Points.AddY(fcpu);
            chart_ram.Series["RAM"].Points.AddY(fram);
            chart_disk.Series["DISK"].Points.AddY(Math.Round(fdisk / BytesInMB));
        }
        
        private void Home_Load(object sender, EventArgs e)
        {
            timer.Start();
            load_processes();
            Storage_info();
        }

        private void load_processes()
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
                    load_processes();
                }
                catch (Exception)
                {
                    MessageBox.Show("Access Denied!", "Assistant");
                } 
            }
        }

        private void Storage_info()
        {
            
            string path = "C:\\Windows";
            string rootDir = Directory.GetDirectoryRoot(path);

            //Get all information of Drive i.e C
            DriveInfo driveInfo = new DriveInfo(rootDir);
            // convert storage in byte to gb and round by 1
            double availableFreeSpace = Math.Round((driveInfo.AvailableFreeSpace / BytesInGB), 1);
            string driveFormat = driveInfo.DriveFormat;
            string name = driveInfo.Name;
            long totalSize = driveInfo.TotalSize;

            lbl_drive_letter.Text = name;
            lbl_drive_format.Text = driveFormat;
            lbl_size.Text = availableFreeSpace.ToString() + "GB";
        }
    }
}
