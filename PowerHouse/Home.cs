using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerHouse
{
    public partial class Home : Form
    {
        TabControl dynamicTabControl = new TabControl();
        public Home()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            bunifuProgressBarCPU.Value = (int)fcpu;
            bunifuProgressBarRAM.Value = (int)fram;
            //lblCPU.Text = string.Format("{0:0.00}%", fcpu);
            //lblRAM.Text = string.Format("{0:0.00}%", fram);
            chart_cpu.Series["CPU"].Points.AddY(fcpu);
            chart_ram.Series["RAM"].Points.AddY(fram);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer.Start();
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
