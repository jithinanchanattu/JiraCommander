using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeReaper
{
    public partial class CreateMapper : UserControl
    {
        public CreateMapper()
        {
            InitializeComponent();

            txtXMLPath.Text = JiraCommander.Properties.Settings.Default["apiEndPoint"].ToString();
            txtInputFolderPath.Text = JiraCommander.Properties.Settings.Default["apiUsername"].ToString();
            txtOutputZipPath.Text = JiraCommander.Properties.Settings.Default["apiPassword"].ToString();
        }       

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new instance of FolderBrowserDialog.
            FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog();
            // A new folder button will display in FolderBrowserDialog.
            folderBrowserDlg.ShowNewFolderButton = true;
            //Show FolderBrowserDialog
            DialogResult dlgResult = folderBrowserDlg.ShowDialog();
            if (dlgResult.Equals(DialogResult.OK))
            {
                //Show selected folder path in textbox1.
                txtXMLPath.Text = folderBrowserDlg.SelectedPath;
                //Browsing start from root folder.
                Environment.SpecialFolder rootFolder = folderBrowserDlg.RootFolder;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/jithinanchanattu/CodeReaper"); 
        }
       
        private void button6_Click(object sender, EventArgs e)
        {
            JiraCommander.Properties.Settings.Default["apiEndPoint"] = txtXMLPath.Text;
            JiraCommander.Properties.Settings.Default["apiUsername"] = txtInputFolderPath.Text;
            JiraCommander.Properties.Settings.Default["apiPassword"] = txtOutputZipPath.Text;
            JiraCommander.Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JiraCommander.Properties.Settings.Default["apiEndPoint"] = txtXMLPath.Text;
            JiraCommander.Properties.Settings.Default["apiUsername"] = txtInputFolderPath.Text;
            JiraCommander.Properties.Settings.Default["apiPassword"] = txtOutputZipPath.Text;
            JiraCommander.Properties.Settings.Default.Save();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            JiraCommander.Properties.Settings.Default["apiEndPoint"] = txtXMLPath.Text;
            JiraCommander.Properties.Settings.Default["apiUsername"] = txtInputFolderPath.Text;
            JiraCommander.Properties.Settings.Default["apiPassword"] = txtOutputZipPath.Text;
            JiraCommander.Properties.Settings.Default.Save();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            // Create a new instance of FolderBrowserDialog.
            FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog();
            // A new folder button will display in FolderBrowserDialog.
            folderBrowserDlg.ShowNewFolderButton = true;
            //Show FolderBrowserDialog
            DialogResult dlgResult = folderBrowserDlg.ShowDialog();
            if (dlgResult.Equals(DialogResult.OK))
            {
                //Show selected folder path in textbox1.
                txtInputFolderPath.Text = folderBrowserDlg.SelectedPath;
                //Browsing start from root folder.
                Environment.SpecialFolder rootFolder = folderBrowserDlg.RootFolder;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Create a new instance of FolderBrowserDialog.
            FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog();
            // A new folder button will display in FolderBrowserDialog.
            folderBrowserDlg.ShowNewFolderButton = true;
            //Show FolderBrowserDialog
            DialogResult dlgResult = folderBrowserDlg.ShowDialog();
            if (dlgResult.Equals(DialogResult.OK))
            {
                //Show selected folder path in textbox1.
                txtOutputZipPath.Text = folderBrowserDlg.SelectedPath;
                //Browsing start from root folder.
                Environment.SpecialFolder rootFolder = folderBrowserDlg.RootFolder;
            }
        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            if (btnCreateMapper.Text.ToString() == "Save Settings!")
            {
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                btnCreateMapper.Text = "Change Settings!";
            }
            else
            {
                panel1.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;
                btnCreateMapper.Text = "Save Settings!";
            }
        }
    }
}
