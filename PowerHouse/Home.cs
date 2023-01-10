using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerHouse
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            progress_cpu.Value = (int)fcpu;
            progress_ram.Value = (int)fram;
            lbl_cpu_stat.Text = string.Format("{0:0.00}%", fcpu);
            lbl_ram_stat.Text = string.Format("{0:0.00}%", fram);
            chart_cpu.Series["CPU"].Points.AddY(fcpu);
            chart_ram.Series["RAM"].Points.AddY(fram);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer.Start();
            load_processes();
        }

        private void load_processes()
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process p in processes)
            {
                if (!String.IsNullOrEmpty(p.MainWindowTitle))
                {
                    listBox1.Items.Add(p.MainWindowTitle);
                }
            }
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(569, 404);
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(569, 203);
        }

    }
}
