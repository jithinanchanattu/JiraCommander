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
    public partial class AC001 : MasterPage
    {
        DataSet AuthorsDataSet = null;
        public AC001()
        {
            InitializeComponent();
        }
		
        private void btnSearchOperation(object sender, EventArgs e)
        {
            var lAC001XmlPath = Properties.Settings.Default["AC001XmlPath"].ToString();
            var lAC001InputPath = Properties.Settings.Default["AC001InputPath"].ToString();
            var lAC001OutputPath = Properties.Settings.Default["AC001OutputPath"].ToString();

            if (IsSuccess == true)
            {
                ReadAC001XmlData(lAC001XmlPath, lAC001InputPath);
            }
        }

        private void ReadAC001XmlData(string lAC001XmlPath, string lAC001InputPath)
        {
            int i = 0;
            string filePath = lAC001XmlPath;

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

                string rootfolder = lAC001InputPath;
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

                string[] folderEntries = Directory.GetDirectories(lAC001InputPath);
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
