using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Ionic.Zip;
using System.Diagnostics;
using System.Threading;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using Newtonsoft.Json;

namespace CodeReaper
{
    public partial class CreatePlayground : UserControl
    {
        DataSet AuthorsDataSet = null;
        
        public CreatePlayground()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var apiEndPoint = JiraCommander.Properties.Settings.Default["apiEndPoint"].ToString();
            var apiUsername = JiraCommander.Properties.Settings.Default["apiUsername"].ToString();
            var apiPassword = JiraCommander.Properties.Settings.Default["apiPassword"].ToString();
            var jiraIds = rhInputJiraIDs.Text;

            String baseURL = apiEndPoint;
            String loginAPI = "auth/1/session";
            String commentAPI = "auth/1/session";
            String statusAPI = "auth/1/session";
            String biExportAPI = "getbusinessintelligenceexport/1.0/message";
            String loginUserName = apiUsername;
            String loginPassWord = apiPassword;
            String exportDir = "./downloads/";
            
            JiraRequestAuth req = new JiraRequestAuth(baseURL, loginAPI, loginUserName, loginPassWord, exportDir);

            //var lxmlPath = Properties.Settings.Default["apiEndPoint"].ToString();
            //var linputPath = Properties.Settings.Default["apiUsername"].ToString();
            //var loutputPath = Properties.Settings.Default["apiPassword"].ToString();

            //bool IsSuccess = true;

            //if (lxmlPath.Trim() == "" && linputPath.Trim() == "" && loutputPath.Trim() == "")
            //{
            //    MessageBox.Show("Configuration XML Path, Input Folder Path and Output Zip Path are not defined. Please enter the values in Settings Tab and Continue.");
            //    IsSuccess = false;
            //}else
            //{
            //    if (lxmlPath.Trim() == "")
            //    {
            //        MessageBox.Show("Configuration XML Path is not defined. Please enter the value in Settings Tab and Continue.");
            //        IsSuccess = false;
            //    }

            //    if (linputPath.Trim() == "")
            //    {
            //        MessageBox.Show("Input Folder Path is not defined. Please enter the value in Settings Tab and Continue.");
            //        IsSuccess = false;
            //    }

            //    if (loutputPath.Trim() == "")
            //    {
            //        MessageBox.Show("Output Zip Path is not defined. Please enter the value in Settings Tab and Continue.");
            //        IsSuccess = false;
            //    }
            //}

            //if (IsSuccess == true)
            //{
            //    NoteWelcome.Visible = false;
            //    NoteHomeTitle.Visible = false;
            //    btnCreate.Visible = false;
            //    NoteHeader.Visible = false;
            //    NoteWarning.Visible = false;
                
            //    lblProcessing.Visible = true;
            //    imgProcessing.Visible = true;
            //    btnCancel.Visible = true;

            //    //Creating Temporary Copy of InputPath Folder
            //    linputPath = GetTemporaryFolderDir(linputPath);

            //    //Processing 
            //    ReadXmlData(lxmlPath, linputPath, loutputPath);

            //    lblProcessing.Visible = false;
            //    imgProcessing.Visible = false;
            //    btnCancel.Visible = false;

            //    infoCompleted.Visible = true;
            //    btnShowFiles.Visible = true;
            //    btnPlayAgain.Visible = true;
            //}
        }

        public string GetTemporaryFolderDir(string linputPath)
        {
            string root = linputPath;
            string temp_root = root + "_temp";

            try
            {
                var dir = new DirectoryInfo(temp_root);
                dir.Attributes = dir.Attributes & ~FileAttributes.ReadOnly;
                dir.Delete(true);
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }

            System.IO.Directory.CreateDirectory(root + "_temp");

            string[] files = Directory.GetFiles(root, "*.*", SearchOption.AllDirectories);
            
            foreach (string file in files)
            {
                var tempFile = file.Replace(linputPath, linputPath + "_temp");
                bool exists = System.IO.Directory.Exists(tempFile);

                if (!exists)
                    System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(tempFile));

                try
                {
                    System.IO.File.Copy(file, tempFile);
                }
                catch (Exception ex)
                {
                    System.IO.File.Delete(tempFile);
                    System.IO.File.Copy(file, tempFile);
                }
                
            }
            return temp_root;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            NoteWelcome.Visible = true;
            NoteHomeTitle.Visible = true;
            btnCreate.Visible = true;
            NoteHeader.Visible = true;
            NoteWarning.Visible = true;

            lblProcessing.Visible = false;
            imgProcessing.Visible = false;
            btnCancel.Visible = false;
        }

        private void ReadXmlData(string lxmlPath, string linputPath, string loutputPath)
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

            //string contents = File.ReadAllText(filePath);
            
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
                        foreach (DataTable folder in AuthorsDataSet.Tables)
                        {
                            var mapFolder = "\\" + folder.TableName + "\\"; mapFolder = mapFolder.Replace(" ", "_");
                            mapFolder = mapFolder.ToLower();

                            var dirfile = file;
                            dirfile = dirfile.Replace(" ", "_");
                            dirfile = dirfile.ToLower();

                            if (dirfile.Contains(mapFolder))
                            {
                                foreach (DataRow dr in folder.Rows)
                                {
                                    foreach (DataColumn dc in dr.Table.Columns)  //loop through the columns. 
                                    {
                                        string contents = File.ReadAllText(file);
                                        contents = contents.Replace(dc.ColumnName.ToString(), dr[dc.ColumnName].ToString());
                                        File.WriteAllText(file, contents);
                                    }
                                }
                            }
                        }
                    }
                    catch(Exception Ex) {
                        MessageBox.Show("An unhandled exception occured. Please contact the maker of this code!");
                        try
                        {
                            var dir = new DirectoryInfo(linputPath);
                            dir.Attributes = dir.Attributes & ~FileAttributes.ReadOnly;
                            dir.Delete(true);
                        }
                        catch (IOException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        throw Ex;
                    }
                }

                //zipping and packing the file
                using (ZipFile zip = new ZipFile())
                {
                    System.IO.File.Delete(loutputPath + "\\ReapedFile.zip");
                    string[] zipfiles = Directory.GetFiles(linputPath, "*.*", SearchOption.AllDirectories);
                    // add all those files to the ProjectX folder in the zip file
                    zip.AddFiles(zipfiles);
                    zip.Comment = "This zip was created at " + System.DateTime.Now.ToString("G");
                    zip.Save(loutputPath + "\\ReapedFile.zip");
                }

                //Deleting the temporary file off
                try
                {
                    var dir = new DirectoryInfo(linputPath);
                    dir.Attributes = dir.Attributes & ~FileAttributes.ReadOnly;
                    dir.Delete(true);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }  
            catch (Exception Ex)  
            {
                MessageBox.Show(Ex.Message);
                MessageBox.Show("An unhandled exception occured. Please contact the maker of this code!");
                try
                {
                    var dir = new DirectoryInfo(linputPath);
                    dir.Attributes = dir.Attributes & ~FileAttributes.ReadOnly;
                    dir.Delete(true);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                throw Ex;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var loutputPath = JiraCommander.Properties.Settings.Default["apiPassword"].ToString();
            Process.Start(loutputPath);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NoteWelcome.Visible = true;
            NoteHomeTitle.Visible = true;
            btnCreate.Visible = true;
            NoteHeader.Visible = true;
            NoteWarning.Visible = true;

            lblProcessing.Visible = false;
            imgProcessing.Visible = false;
            btnCancel.Visible = false;

            infoCompleted.Visible = false;
            btnShowFiles.Visible = false;
            btnPlayAgain.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var apiEndPoint = JiraCommander.Properties.Settings.Default["apiEndPoint"].ToString();
            var apiUsername = JiraCommander.Properties.Settings.Default["apiUsername"].ToString();
            var apiPassword = JiraCommander.Properties.Settings.Default["apiPassword"].ToString();

            String comments = rhComments.Text;
            String baseURL = apiEndPoint;
            String APIKey = rhInputJiraIDs.Text;
            String loginUserName = apiUsername;
            String loginPassWord = apiPassword;
            String exportDir = "./downloads/";

            if (APIKey != "")
            {
                if (comments != "")
                {
                    JiraRequestComment req = new JiraRequestComment(baseURL, APIKey, loginUserName, loginPassWord, exportDir, comments);
                }
                else
                {
                    MessageBox.Show("Please enter Jira comments and Retry!");
                }
            }
            else
            {
                MessageBox.Show("Please enter atleast one Jira Id and Retry!");
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var apiEndPoint = JiraCommander.Properties.Settings.Default["apiEndPoint"].ToString();
            var apiUsername = JiraCommander.Properties.Settings.Default["apiUsername"].ToString();
            var apiPassword = JiraCommander.Properties.Settings.Default["apiPassword"].ToString();

            String comments = rhComments.Text;
            String baseURL = apiEndPoint;
            String APIKey = rhInputJiraIDs.Text;
            String StatusId = rhstatusId.Text;
            String loginUserName = apiUsername;
            String loginPassWord = apiPassword;
            String exportDir = "./downloads/";

            if (APIKey != "")
            {
                if (StatusId != "")
                {
                    JiraRequestRFTStatus req = new JiraRequestRFTStatus(baseURL, APIKey, loginUserName, loginPassWord, StatusId);
                }
                else
                {
                    MessageBox.Show("Please enter the Id for the required Jira Status and Retry!");
                }
            }
            else
            {
                MessageBox.Show("Please enter atleast one Jira Id and Retry!");
            }
        }
    }

    public class JiraRequestAuth
    {
        private String loginResponse;
        private String jSessionId;
        private String baseURL;
        private String loginAPI;
        private String loginUserName;
        private String loginPassWord;
        private bool errorsOccurred;
        private JiraCookie jiraCookie; 
        // ////////////////////////////////////////////////////////////////////
        // Constructor
        // ////////////////////////////////////////////////////////////////////

        /// <summary>
        ///   This constructor is responsible for initializing all the 
        ///   properties of the class.  It then calls each the five 
        ///   basic processing functions in the proper order.  Of course,
        ///   it also handles any errors and writes a final SUCCESS 
        ///   or FAILURE message.
        /// </summary>
        public JiraRequestAuth(String newBaseURL, String newLoginAPI, String newLoginUserName, String newLoginPassWord, String newExportDir)
        {
            this.baseURL = newBaseURL;
            this.loginAPI = newLoginAPI;
            this.loginUserName = newLoginUserName;
            this.loginPassWord = newLoginPassWord;
            this.loginResponse = "";
            this.jSessionId = "";
            this.errorsOccurred = false;

            if (!errorsOccurred)
            {
                GetCookieAsync(this.baseURL + "rest/auth/1/session");
            }
        }
        // ////////////////////////////////////////////////////////////////////
        // Methods
        // ////////////////////////////////////////////////////////////////////

        public async Task<JiraCookie> GetCookieAsync(string JiraCookieEndpointUrl)
        {
            try
            {
                var apiEndPoint = JiraCommander.Properties.Settings.Default["apiEndPoint"].ToString();
                var apiUsername = JiraCommander.Properties.Settings.Default["apiUsername"].ToString();
                var apiPassword = JiraCommander.Properties.Settings.Default["apiPassword"].ToString();
                var sessionURL = apiEndPoint + "rest/auth/1/session";
                var myJsonUserNamePassword = "{\"username\":\"" + apiUsername + "\",\"password\":\"" + apiPassword + "\"}";
                using (var client = new HttpClient())
                {
                    var response = await client.PostAsync(
                        sessionURL,
                        new StringContent(myJsonUserNamePassword, Encoding.UTF8, "application/json"));
                    var json = response.Content.ReadAsStringAsync().Result;
                    JiraCommander.Properties.Settings.Default["apiSession"] = json;
                    this.jiraCookie = JsonConvert.DeserializeObject<JiraCookie>(json);
                    var dynObj = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(json);
                    this.jSessionId = dynObj["session"]["value"].Value;
                    this.loginResponse = json;                    

                    if (json != "")
                    {
                        MessageBox.Show("Successfully Authenticated to Jira!");
                    }
                    //getJsonData();
                    return jiraCookie;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in loginToJira: " + ex);
                this.errorsOccurred = true;
                return jiraCookie;
            }
        }
        
        public class JiraCookie
        {
            public Session session { get; set; }
        }

        public class Session
        {
            public string name { get; set; }
            public string value { get; set; }
        }


        /// <summary>
        ///     This method takes the response from a Jira login request and 
        ///     parses out the JSESSIONID which will be saved and used to 
        ///     authenticate future requests.
        /// </summary>
        public void parseJSessionID()
        {
            try
            {
                var dynObj = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(this.loginResponse);
                this.jSessionId = dynObj["session"]["value"].Value;
                Console.WriteLine("\njSessionId:");
                Console.WriteLine(this.jSessionId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in parseJSessionID: " + ex);
                this.errorsOccurred = true;
            }
        }


        /// <summary>
        ///     This method calls a given Jira API (using a the JSESSIONID 
        ///     property set by the call to the parseJSessionID method)
        ///     to authenticate the request), then writes the resulting 
        ///     response into the jsonData property.
        /// </summary>
        public void getJsonData()
        {
            try
            {
                //String url = this.baseURL + this.biExportAPI + "?startDate=" + this.analysisStartDate + "&endDate=" + this.analysisEndDate;
                //String url = this.baseURL + "api/2/user?username=alexA";
                //String url = this.baseURL + "api/2/issue/picker" + "?currentJQL=assignee%3Dadmin";

                String url = this.baseURL + "/rest/api/2/issue/AMS-484578/comment";

                WebRequest request = WebRequest.Create(url);
                request.Headers["Cookie"] = "JSESSIONID=" + this.jSessionId;
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                var jsonData = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in getJsonData: " + ex);
                this.errorsOccurred = true;
            }
        }
    }

    public class JiraRequestComment
    {
        private String loginResponse;
        private String jSessionId;
        private String baseURL;
        private String loginAPI;
        private String loginUserName;
        private String loginPassWord;
        private bool errorsOccurred;
        private JiraCookie jiraCookie;
        // ////////////////////////////////////////////////////////////////////
        // Constructor
        // ////////////////////////////////////////////////////////////////////

        /// <summary>
        ///   This constructor is responsible for initializing all the 
        ///   properties of the class.  It then calls each the five 
        ///   basic processing functions in the proper order.  Of course,
        ///   it also handles any errors and writes a final SUCCESS 
        ///   or FAILURE message.
        /// </summary>
        public JiraRequestComment(String newBaseURL, String APIKey, String newLoginUserName, String newLoginPassWord, String newExportDir, String comments)
        {
            this.baseURL = newBaseURL;
            this.loginAPI = APIKey;
            this.loginUserName = newLoginUserName;
            this.loginPassWord = newLoginPassWord;
            this.loginResponse = "";
            this.jSessionId = "";
            this.errorsOccurred = false;
            if (!errorsOccurred)
            {
                GetCookieAsync(this.baseURL).GetAwaiter().GetResult();
            }

            // using the method 
            String[] idlist = APIKey.Split(',');

            foreach (String id in idlist)
            {
                if (!errorsOccurred && id.Trim()!="")
                {
                    putComment(this.baseURL + "rest/api/2/issue/" + id + "/comment", comments);
                }
            }
            MessageBox.Show("Successfully Added Comments to Jira!");
        }
        // ////////////////////////////////////////////////////////////////////
        // Methods
        // ////////////////////////////////////////////////////////////////////

        public async Task<JiraCookie> GetCookieAsync(string JiraCookieEndpointUrl)
        {
            try
            {
                var apiEndPoint = JiraCommander.Properties.Settings.Default["apiEndPoint"].ToString();
                var apiUsername = JiraCommander.Properties.Settings.Default["apiUsername"].ToString();
                var apiPassword = JiraCommander.Properties.Settings.Default["apiPassword"].ToString();
                var sessionURL = apiEndPoint + "rest/auth/1/session";
                var myJsonUserNamePassword = "{\"username\":\"" + apiUsername + "\",\"password\":\"" + apiPassword + "\"}";
                using (var client = new HttpClient())
                {
                    var response = await client.PostAsync(
                        sessionURL,
                        new StringContent(myJsonUserNamePassword, Encoding.UTF8, "application/json")).ConfigureAwait(false);
                    var json = response.Content.ReadAsStringAsync().Result;
                    JiraCommander.Properties.Settings.Default["apiSession"] = json;
                    this.jiraCookie = JsonConvert.DeserializeObject<JiraCookie>(json);
                    var dynObj = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(json);
                    this.jSessionId = dynObj["session"]["value"].Value;
                    this.loginResponse = json;
                    return jiraCookie;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in loginToJira: " + ex);
                this.errorsOccurred = true;
                return jiraCookie;
            }
        }
        public class JiraCookie
        {
            public Session session { get; set; }
        }

        public class Session
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public void putComment(string apiURL, string rhComments)
        {
            try
            {
                String url = apiURL;
                string postData = "{\"body\": \"*"+ rhComments + "*\"}";
                
                if (this.jSessionId == null || this.jSessionId == "")
                {
                    String apiSession = JiraCommander.Properties.Settings.Default["apiSession"].ToString();
                    this.jSessionId = apiSession;
                }
                
                WebRequest request = WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/json";
                request.Headers["Cookie"] = "JSESSIONID=" + this.jSessionId;           
                Stream reqStream = request.GetRequestStream();
                byte[] postArray = Encoding.ASCII.GetBytes(postData);
                reqStream.Write(postArray, 0, postArray.Length);
                reqStream.Close();
                StreamReader sr = new StreamReader(request.GetResponse().GetResponseStream());
                string Result = sr.ReadToEnd();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in getJsonData: " + ex);
                this.errorsOccurred = true;
            }
        }

        //private string GetEncodedCredentials()
        //{
        //    string mergedCredentials = string.Format("{0}:{1}", this.loginUserName, this.loginPassWord);
        //    byte[] byteCredentials = UTF8Encoding.UTF8.GetBytes(mergedCredentials);
        //    return Convert.ToBase64String(byteCredentials);
        //}
        
        /// <summary>
        ///     This method calls a given Jira API (using a the JSESSIONID 
        ///     property set by the call to the parseJSessionID method)
        ///     to authenticate the request), then writes the resulting 
        ///     response into the jsonData property.
        /// </summary>
        public void getJsonData()
        {
            try
            {
                //String url = this.baseURL + this.biExportAPI + "?startDate=" + this.analysisStartDate + "&endDate=" + this.analysisEndDate;
                //String url = this.baseURL + "api/2/user?username=alexA";
                //String url = this.baseURL + "api/2/issue/picker" + "?currentJQL=assignee%3Dadmin";

                String url = this.baseURL + "/rest/api/2/issue/AMS-484578/comment";

                WebRequest request = WebRequest.Create(url);
                request.Headers["Cookie"] = "JSESSIONID=" + this.jSessionId;
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                var jsonData = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in getJsonData: " + ex);
                this.errorsOccurred = true;
            }
        }
    }


    public class JiraRequestRFTStatus
    {
        private String loginResponse;
        private String jSessionId;
        private String baseURL;
        private String loginAPI;
        private String loginUserName;
        private String loginPassWord;
        private bool errorsOccurred;
        private JiraCookie jiraCookie;
        // ////////////////////////////////////////////////////////////////////
        // Constructor
        // ////////////////////////////////////////////////////////////////////

        /// <summary>
        ///   This constructor is responsible for initializing all the 
        ///   properties of the class.  It then calls each the five 
        ///   basic processing functions in the proper order.  Of course,
        ///   it also handles any errors and writes a final SUCCESS 
        ///   or FAILURE message.
        /// </summary>
        public JiraRequestRFTStatus(String newBaseURL, String APIKey, String newLoginUserName, String newLoginPassWord, String StatusId)
        {
            this.baseURL = newBaseURL;
            this.loginAPI = APIKey;
            this.loginUserName = newLoginUserName;
            this.loginPassWord = newLoginPassWord;
            this.loginResponse = "";
            this.jSessionId = "";
            this.errorsOccurred = false;
            if (!errorsOccurred)
            {
                GetCookieAsync(this.baseURL).GetAwaiter().GetResult();
            }

            // using the method 
            String[] idlist = APIKey.Split(',');

            foreach (String id in idlist)
            {
                if (!errorsOccurred && id.Trim() != "")
                {
                    RFTStatus(this.baseURL + "rest/api/2/issue/" + id + "/transitions", StatusId);
                }
            }
            MessageBox.Show("Successfully Updated the Status in Jira!");
        }
        // ////////////////////////////////////////////////////////////////////
        // Methods
        // ////////////////////////////////////////////////////////////////////

        public async Task<JiraCookie> GetCookieAsync(string JiraCookieEndpointUrl)
        {
            try
            {
                var apiEndPoint = JiraCommander.Properties.Settings.Default["apiEndPoint"].ToString();
                var apiUsername = JiraCommander.Properties.Settings.Default["apiUsername"].ToString();
                var apiPassword = JiraCommander.Properties.Settings.Default["apiPassword"].ToString();
                var sessionURL = apiEndPoint + "rest/auth/1/session";
                var myJsonUserNamePassword = "{\"username\":\"" + apiUsername + "\",\"password\":\"" + apiPassword + "\"}";
                using (var client = new HttpClient())
                {
                    var response = await client.PostAsync(
                        sessionURL,
                        new StringContent(myJsonUserNamePassword, Encoding.UTF8, "application/json")).ConfigureAwait(false);
                    var json = response.Content.ReadAsStringAsync().Result;
                    JiraCommander.Properties.Settings.Default["apiSession"] = json;
                    this.jiraCookie = JsonConvert.DeserializeObject<JiraCookie>(json);
                    var dynObj = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(json);
                    this.jSessionId = dynObj["session"]["value"].Value;
                    this.loginResponse = json;
                    return jiraCookie;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in loginToJira: " + ex);
                this.errorsOccurred = true;
                return jiraCookie;
            }
        }
        public class JiraCookie
        {
            public Session session { get; set; }
        }

        public class Session
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public void RFTStatus(string apiURL, string StatusId)
        {
            try
            {
                String url = apiURL;
                string postData = "{\"transition\":{\"id\":\""+ StatusId + "\"}}";

                if (this.jSessionId == null || this.jSessionId == "")
                {
                    String apiSession = JiraCommander.Properties.Settings.Default["apiSession"].ToString();
                    this.jSessionId = apiSession;
                }

                WebRequest request = WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/json";
                request.Headers["Cookie"] = "JSESSIONID=" + this.jSessionId;
                Stream reqStream = request.GetRequestStream();
                byte[] postArray = Encoding.ASCII.GetBytes(postData);
                reqStream.Write(postArray, 0, postArray.Length);
                reqStream.Close();
                StreamReader sr = new StreamReader(request.GetResponse().GetResponseStream());
                string Result = sr.ReadToEnd();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in getJsonData: " + ex);
                this.errorsOccurred = true;
            }
        }
    }
}
