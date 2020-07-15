using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeReaper
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            CreateControl.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            CreateControl.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnSettings.Height;
            SidePanel.Top = btnSettings.Top;
            mySecondCustmControl1.BringToFront();
        }

        private void firstCustomControl1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/better-code-collaboration/CodeReaper/"); 
        }
        
        private void button14_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/better-code-collaboration/CodeReaper/");
        }
    }
}
