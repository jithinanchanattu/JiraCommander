using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CodeReaper
{
    public partial class FirstControl : PageControl
    {
        DataSet AuthorsDataSet = null;
        public FirstControl()
        {
            InitializeComponent();
        }
		
        private void button1_Click(object sender, EventArgs e)
        {
            var lxmlPath = Properties.Settings.Default["xmlPath"].ToString();
            var linputPath = Properties.Settings.Default["inputPath"].ToString();
            var loutputPath = Properties.Settings.Default["outputPath"].ToString();

            if (IsSuccess == true)
            {
                ReadPAGEXmlData(lxmlPath, linputPath);
            }
        }

        private void ReadPAGEXmlData(string lxmlPath, string linputPath)
        {
            int i = 0;
            string filePath = lxmlPath;

            foreach (string file in Directory.EnumerateFiles(filePath, "*.xml"))
            {
                if (i == 0)
                {
                    filePath = file;
                }
                else
                    break;

                i++;
            }
			
            try  
            {
                AuthorsDataSet = new DataSet();
                AuthorsDataSet.ReadXml(filePath);

                string rootfolder = linputPath;
                string[] files = Directory.GetFiles(rootfolder, "*.*", SearchOption.AllDirectories);
                foreach (string file in files)
                {
                    try
                    {
						//CODE-REAPER HACK
                        //Page Specific Function and Process
                    }
                    catch(Exception) { 
                    }
                }

                string[] folderEntries = Directory.GetDirectories(linputPath);
                foreach (string folderName in folderEntries)
                {
					//CODE-REAPER HACK
					//Page Specific Function and Process
                }
            }  
            catch (Exception Ex)  
            {  
                throw Ex;  
            }

        }
    }
}
