using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Data.Entity;

namespace AJGenesis.UI
{
    public partial class frmAJGenesisUI : Form
    {
        private SqlConnection activeConnection = null;
        private SqlConnection ActiveConnection { get { if (activeConnection == null) activeConnection = GetConnection(); return activeConnection; } }

        public frmAJGenesisUI()
        {
            InitializeComponent();
        }

        #region Private Events
        private void Form1_Load(object sender, EventArgs e)
        {
            String[] cs = new String[ConfigurationManager.ConnectionStrings.Count];
            for (int i = 0; i < ConfigurationManager.ConnectionStrings.Count; i++)
                cs[i] = ((ConnectionStringSettings)ConfigurationManager.ConnectionStrings[i]).Name;
            cboStringConnections.DataSource = cs;

            txtAPPFolderName.Text = ConfigurationManager.AppSettings["DefaultAPPFolderName"].Trim();
            txtModelsAPPFolderName.Text = ConfigurationManager.AppSettings["ModelsAPPFolderName"].Trim();
            txtTemnplateAPPFolderName.Text = ConfigurationManager.AppSettings["TemnplateAPPFolderName"].Trim();
            txtTaskAPPFolderName.Text = ConfigurationManager.AppSettings["TaskAPPFolderName"].Trim();
            txtSolutionAPPFileName.Text = ConfigurationManager.AppSettings["SolutionAPPFileName"].Trim();
            
            RefreshData();
        }

        private void cboStringConnections_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblConnectionString.Text = ConfigurationManager.ConnectionStrings[cboStringConnections.Text].ConnectionString;
                //btnGetTableInfo_Click(btnGetTableInfo, e);
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }
        }

        private void btnGetTableInfo_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = GetDataTableInfo();
                foreach (DataRow row in dt.Rows)
                {
                    String fileName = txtAPPFolderName.Text + txtModelsAPPFolderName.Text + row["TableName"].ToString() + ".xml";
                    //row["CM"] = !File.Exists(fileName);
                }
                pbProgressBar.Maximum = dt.Rows.Count - 1;
                pbProgressBar.Value = 0;
                gvTableInfo.DataSource = dt;
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkUseUserModel_CheckedChanged(object sender, EventArgs e)
        {
            chkUseGeneratedModel.Checked = !chkUseUserModel.Checked;
        }

        private void btnGetFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.SelectedPath = txtAPPFolderName.Text;
            fb.ShowDialog(this);
            if (fb.SelectedPath != null)
                txtAPPFolderName.Text = fb.SelectedPath;
            if (!txtAPPFolderName.Text.EndsWith("\\"))
                txtAPPFolderName.Text += "\\";
            RefreshData();
        }

        private void chkUseExistingModels_CheckedChanged(object sender, EventArgs e)
        {
            cboStringConnections.Enabled = !chkUseExistingModels.Checked;
            btnGetTableInfo.Enabled = !chkUseExistingModels.Checked;
        }
        #endregion

        #region Private Methods
        private void RefreshData()
        {
            chkUseUserModel.Enabled = File.Exists(txtAPPFolderName.Text.Trim() + txtModelsAPPFolderName.Text.Trim() + "Model.xml");
            chkUseUserModel.Checked = !chkUseGeneratedModel.Checked;
            if (!chkUseUserModel.Enabled)
            {
                chkUseGeneratedModel.Checked = true;
            }
            chkDeleteExistingControllers.Enabled = FolderHasFiles(txtAPPFolderName.Text + "app\\controllers");
            chkDeleteExistingHelpers.Enabled = FolderHasFiles(txtAPPFolderName.Text + "app\\helpers");
            chkDeleteExistingModels.Enabled = FolderHasFiles(txtAPPFolderName.Text + "app\\models");
            if (!chkDeleteExistingControllers.Enabled) chkDeleteExistingControllers.Checked = false;
            if (!chkDeleteExistingHelpers.Enabled) chkDeleteExistingHelpers.Checked = false;
            if (!chkDeleteExistingModels.Enabled) chkDeleteExistingModels.Checked = false;
            lblProgressMsg.Text = "";
        }

        private void ShowException(Exception ex)
        {
            MessageBox.Show(this, ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private SqlConnection GetConnection()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(lblConnectionString.Text);
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }
            return (con);
        }

        private DataTable GetDataTableInfo()
        {
            return GetDataTable("SELECT Name TableName, CAST(1 as BIT) CM, CAST(1 as BIT) CV FROM SYS.TABLES ORDER BY Name");
        }

        private DataTable GetDataTable(String SqlStatment)
        {
            DataTable dt = null;
            try
            {
                if (ActiveConnection.State != ConnectionState.Open) ActiveConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(SqlStatment, ActiveConnection);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }
            return (dt);
        }

        private String GetXMLFileName(String Name)
        {
            return txtAPPFolderName.Text.Trim() + txtModelsAPPFolderName.Text.Trim() + Name + ".xml";
        }

        private void Generate()
        {
            try
            {
                if (!chkUseExistingModels.Checked)
                {
                    if (gvTableInfo.DataSource == null)
                        throw new Exception("Debe seleccionar una base de datos y obtener la estructura");
                    DataTable dt = (DataTable)gvTableInfo.DataSource;
                    pbProgressBar.Value = 0;
                    pbProgressBar.Maximum = dt.Rows.Count;
                    pbProgressBar.Minimum = 0;
                    lblProgressMsg.Text = "Generating XML Models";
                    lblProgressMsg.Refresh();
                    foreach (DataRow row in dt.Rows)
                    {
                        pbProgressBar.Value++;
                        CreateFileFromTable(row["TableName"].ToString());
                    }
                    lblProgressMsg.Text = "Generating Ruby Files";
                    lblProgressMsg.Refresh();
                    if (chkUseGeneratedModel.Checked) CreateModelFile(dt);
                }
                if (chkDeleteExistingControllers.Checked) DeleteFilesInFolder(txtAPPFolderName.Text + "app\\controllers");
                if (chkDeleteExistingHelpers.Checked) DeleteFilesInFolder(txtAPPFolderName.Text + "app\\helpers");
                if (chkDeleteExistingModels.Checked) DeleteFilesInFolder(txtAPPFolderName.Text + "app\\models");
                if (chkRunAJGenesis.Checked) CreateAndRunBATFile();
                RefreshData();
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }
        }

        private void CreateAndRunBATFile()
        {
            try
            {
                String fileName = txtAPPFolderName.Text.Trim() + "Generate.AJGenesis.UI.cmd";
                if (File.Exists(fileName)) File.Delete(fileName);
                String modelName = "Model.xml";
                String fileText = @".\AjGenesis\AjGenesis.Console " + txtModelsAPPFolderName.Text;
                if (chkUseGeneratedModel.Checked) modelName = "Model.AJGenesis.UI.xml";
                fileText += modelName;
                if (chkUseMetaData.Checked)
                    fileText += " " + txtModelsAPPFolderName.Text + "MetaData.xml";
                if (chkUseCompleteModel.Checked)
                    fileText += " " + txtTaskAPPFolderName.Text + "CompleteModel.ajg";
                if (txtSolutionAPPFileName.Text.Contains("\\"))
                    fileText += " " + txtSolutionAPPFileName.Text;
                else
                    fileText += " " + txtTaskAPPFolderName.Text + txtSolutionAPPFileName.Text;

                //WriteFile(fileName, @".\AjGenesis\AjGenesis.Console Model\" 
                //    + modelName + @".xml Model\Metadata.xml Tasks\CompleteModel.ajg Tasks\GenSolution.ajg", false);
                WriteFile(fileName, fileText, false);
                Process myProcess = new Process();
                myProcess.StartInfo.FileName = fileName;
                myProcess.StartInfo.WorkingDirectory = txtAPPFolderName.Text;
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                lblProgressMsg.Text = "Runing AJGenesis BAT";
                lblProgressMsg.Refresh();
                myProcess.Start();
                myProcess.WaitForExit();
                myProcess.Close();
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }
        }

        private void CreateFileFromTable(String TableName)
        {
            CreateFileFromTable(GetXMLFileName(TableName), TableName);
        }

        private void CreateFileFromTable(String FileName, String TableName)
        {
            try
            {
                DataTable dtColumns = GetDataTable( "SELECT Name "
                    + ", (SELECT Name FROM SYS.TYPES T WHERE t.system_type_id = C.system_type_id) typeName "
                    + ", max_length, [precision], is_nullable, is_identity "
                    + "FROM SYS.COLUMNS C WHERE object_id = OBJECT_ID( '" + TableName + "', 'U')");
                StringBuilder sb = new StringBuilder();
                sb.Append("<?xml version='1.0' encoding='ISO-8859-1' standalone='yes'?>" + Environment.NewLine);
                sb.Append("<Table>" + Environment.NewLine);
                sb.Append("	<Name>" + TableName + "</Name>" + Environment.NewLine);
                sb.Append("	<SqlName>" + TableName + "</SqlName>" + Environment.NewLine);
                sb.Append("	<SqlSchema>dbo</SqlSchema>" + Environment.NewLine);
                sb.Append("	<SingleName>" + Inflector.MakeSingular(TableName) + "</SingleName>" + Environment.NewLine);
                sb.Append("	<Description>" + GetDescription(Inflector.MakeSingular(TableName)) + "</Description>" + Environment.NewLine);
                sb.Append("	<SetDescription>" + GetSetDescription(TableName) + "</SetDescription>" + Environment.NewLine);

                sb.Append("	<ControllerName>" + GetSetDescription(TableName).Replace(" ", "") + "</ControllerName>" + Environment.NewLine);
                sb.Append("	<ControllerClass>" + GetDescription(Inflector.MakeSingular(TableName)).Replace(" ", "")+ "</ControllerClass>" + Environment.NewLine);
                
                sb.Append("	<Columns>" + Environment.NewLine);
                foreach (DataRow row in dtColumns.Rows)
                {
                    sb.Append("		<Column>" + Environment.NewLine);
                    sb.Append("			<Name>" + row["Name"].ToString() + "</Name>" + Environment.NewLine);
                    sb.Append("			<Description>" + GetDescription(row["Name"].ToString()) + "</Description>" + Environment.NewLine);
                    sb.Append("			<SqlName>" + row["Name"].ToString() + "</SqlName>" + Environment.NewLine);
                    if (Convert.ToBoolean(row["is_identity"]))
                        sb.Append("			<IsKey>True</IsKey>" + Environment.NewLine);
                    if (row["Name"].ToString().EndsWith("_id"))
                        sb.Append("			<Reference>" + Inflector.MakePlural( row["Name"].ToString().Replace("_id", "")) + "</Reference>" + Environment.NewLine);
                    sb.Append("			<DataType>" + row["typeName"].ToString() + "</DataType>" + Environment.NewLine);
                    sb.Append("			<SystemType>" + GetNETType(row["typeName"].ToString()) + "</SystemType>" + Environment.NewLine);
                    sb.Append("			<IsNullable>" + (Convert.ToBoolean(row["is_nullable"]) ? "YES" : "NO") + "</IsNullable>" + Environment.NewLine);
                    sb.Append("		</Column>" + Environment.NewLine);
                }
                sb.Append("	</Columns>" + Environment.NewLine);
                sb.Append("</Table>" + Environment.NewLine);
                WriteFile(FileName, sb.ToString(), false);
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }
        }

        private void CreateModelFile(DataTable dt)
        {
            try
            {
                pbProgressBar.Value = 0;
                pbProgressBar.Maximum = dt.Rows.Count;
                pbProgressBar.Minimum = 0;
                String fileName = GetXMLFileName("Model.AJGenesis.UI");
                StringBuilder sb = new StringBuilder();
                sb.Append("<?xml version='1.0' encoding='ISO-8859-1' standalone='yes'?>" + Environment.NewLine);
                sb.Append("<Project>" + Environment.NewLine);
                sb.Append("	<Name>" + cboStringConnections.Text + "</Name>" + Environment.NewLine);
                sb.Append("	<Title>" + cboStringConnections.Text + "</Title>" + Environment.NewLine);
                sb.Append("	<Database>" + Environment.NewLine);
                sb.Append("		<Name>" + cboStringConnections.Text + "</Name>" + Environment.NewLine);
                sb.Append("		<Host>(local)</Host>" + Environment.NewLine);
                sb.Append("	</Database>" + Environment.NewLine);
                sb.Append("	<Tables>" + Environment.NewLine);
                foreach (DataRow row in dt.Rows)
                {
                    pbProgressBar.Value++;
                    //if (Convert.ToBoolean(row["CV"]))
                    sb.Append("		<Table Source='" + row["TableName"].ToString() + ".xml' />" + Environment.NewLine);
                }
                sb.Append("	</Tables>" + Environment.NewLine);
                sb.Append("</Project>" + Environment.NewLine);
                WriteFile(fileName, sb.ToString(), false);
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }
        }

        protected Boolean WriteFile(String fileName, String fileText, Boolean appendText)
        {
            try
            {
                TextWriter newFile = new StreamWriter(fileName, appendText);
                newFile.WriteLine(fileText);
                newFile.Close();
            }
            catch
            {
                //Do Nothing
            }
            return File.Exists(fileName);
        }

        private String GetNETType(String SqlType)
        {
            String netType = "";
            switch (SqlType)
            {
                case "bit":
                    netType = "Boolean";
                    break;
                case "char":
                    netType = "String";
                    break;
                case "decimal":
                    netType = "Decimal";
                    break;
                case "datetime":
                    netType = "DateTime";
                    break;
                case "int":
                    netType = "Int32";
                    break;
                case "numeric":
                    netType = "Decimal";
                    break;
                case "text":
                    netType = "String";
                    break;
                case "varchar":
                    netType = "String";
                    break;
                default:
                    break;
            }
            return (netType);
        }

        private String GetDescription(String Name)
        {
            String Desc = Name.Replace("_", " ");
            if (Desc.EndsWith(" id"))
                Desc = Desc.Replace(" id", "");
            if (Desc.Contains(" "))
            {
                String[] aDesc = Desc.Split(" ".ToCharArray());
                Desc = "";
                for (int i = 0; i < aDesc.Length; i++)
                {
                    Desc += Proper(aDesc[i]);
                    if (i < (aDesc.Length - 1))
                        Desc += " ";
                }
            }
            return Proper(Desc);
        }

        private String GetSetDescription(String Name)
        {
            String SetDesc = "";
            String[] GetDesc = GetDescription(Name).Split(" ".ToCharArray());
            for (int i = 0; i < GetDesc.Length; i++)
            {
                if (i == (GetDesc.Length - 1))
                    SetDesc += Inflector.MakePlural(Proper(GetDesc[i]));
                else
                    SetDesc += GetDesc[i] + " ";
            }
            return (SetDesc.Trim());
        }

        private String Proper(String Name)
        {
            return Name.Substring(0,1).ToUpper() + Name.Substring(1);
        }

        private Boolean FolderHasFiles(String FolderName)
        {
            Boolean isOk = false;
            if (Directory.Exists(FolderName))
            {
                try
                {
                    isOk = new DirectoryInfo(FolderName).GetFiles().Length > 0;
                }
                catch
                {
                    //Do Nothing
                }
            }
            return (isOk);
        }

        private void DeleteFilesInFolder(String FolderName)
        {
            if (FolderHasFiles(FolderName))
            {
                FileInfo[] files = new DirectoryInfo(FolderName).GetFiles();
                lblProgressMsg.Text = "Delete files from " + FolderName;
                lblProgressMsg.Refresh();
                foreach (FileInfo file in files)
                    if (File.Exists(file.FullName)) file.Delete();
            }
        }
        #endregion
    }
}
