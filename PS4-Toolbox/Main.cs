using PS4_Toolbox.Properties;
using System;
using System.Windows.Forms;
using libframe4;
using System.IO;
using System.Drawing;

namespace PS4_Toolbox
{
    public partial class Main : Form
    {
        public FRAME4 PS4;

        ModuleList ModuleList;
        ProcessList ProcessList;
        ProcessInfo ProcessInfo;

        int CurrentProcessID = -1;
        int CurrentPrxHandle = -1;

        public Main()
        {
            InitializeComponent();
        }

        private string GetConsoleIP()
        {
            return Settings.Default.ConsoleIP;
        }

        private void SaveSettings()
        {
            if (BoxConsoleIP.Text != "0.0.0.0")
            {
                Settings.Default.ConsoleIP = BoxConsoleIP.Text;
                Settings.Default.Save();
            }
        }

        private void LoadSettings()
        {
            BoxConsoleIP.Text = GetConsoleIP();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            BtnBrowse.Enabled = false;
            BtnBrowse.Visible = false;
            LoadSettings();
        }

        private void Main_Close(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        void RefreshModules()
        {
            if (PS4.IsConnected && CurrentProcessID != -1)
            {
                ModuleGridView.Rows.Clear();

                ModuleList = PS4.GetModuleList(CurrentProcessID);

                for (int i = 0; i < ModuleList.entries.Length; i++)
                {
                    if (ModuleList.entries[i].handle != 0)
                    {
                        string name = ModuleList.entries[i].name;
                        string handle = ModuleList.entries[i].handle.ToString("X");
                        string textSeg = "0x" + ModuleList.entries[i].text_address.ToString("X") + " Size: 0x" + ModuleList.entries[i].text_size;
                        string dataSeg = "0x" + ModuleList.entries[i].data_address.ToString("X") + " Size: 0x" + ModuleList.entries[i].data_size;

                        ModuleGridView.Rows.Add(new object[] { name, handle, textSeg, dataSeg });
                    }
                }
            }
        }

        void RefreshProcesses()
        {
            if (PS4.IsConnected)
            {
                ProcessesGridView.Rows.Clear();

                ProcessList = PS4.GetProcessList();

                for (int i = 0; i < ProcessList.processes.Length; i++)
                {
                    if (ProcessList.processes[i].name != "")
                    {
                        ProcessInfo = PS4.GetProcessInfo(ProcessList.processes[i].pid);



                        string name = ProcessInfo.name;
                        string id = ProcessInfo.pid.ToString();
                        string titleId = ProcessInfo.titleid;
                        string contentId = ProcessInfo.contentid;
                        string path = ProcessInfo.path;

                        ProcessesGridView.Rows.Add(new object[] { name, id, titleId, contentId, path });

                        ProcessesGridView.Rows[0].Selected = false;

                        if (ProcessInfo.name.Contains("default"))
                        {
                            int index = i;
                            ProcessesGridView.Rows[index].DefaultCellStyle.ForeColor = Color.Purple;
                            ProcessesGridView.Rows[index].Selected = true;
                        }
                        else if (ProcessInfo.name.Contains("eboot"))
                        {
                            int index = i;
                            ProcessesGridView.Rows[index].DefaultCellStyle.ForeColor = Color.Purple;
                            ProcessesGridView.Rows[index].Selected = true;
                        }
                    }
                }
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            // need to send frame4 payload here, so we dont have to rely on third party applications
            PS4 = new FRAME4(BoxConsoleIP.Text);
            try
            {
                PS4.Connect();
                StatusLabel.Text = "Status: Connected";
            }
            catch (Exception ex)
            {
                StatusLabel.Text = "Status: Failed To Connect!";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAttach_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(ProcessesGridView.Rows[ProcessesGridView.CurrentCell.RowIndex].Cells[1].Value);
            CurrentProcessID = pid;
            CurrentProcessLabel.Text = "Process: " + PS4.GetProcessInfo(CurrentProcessID).name + " TitleID: " + PS4.GetProcessInfo(CurrentProcessID).titleid;
            RefreshModules();
        }

        private void BtnRefreshProcesses_Click(object sender, EventArgs e)
        {
            RefreshProcesses();
        }

        int LoadModule(string path)
        {
            return PS4.LoadPRX(PS4.GetProcessInfo(CurrentProcessID).name, path);
        }

        void UnloadModule(int handle)
        {
            PS4.UnloadPRX(PS4.GetProcessInfo(CurrentProcessID).name, handle);
        }

        private void BtnLoadModule_Click(object sender, EventArgs e)
        {
            string modulepath = BoxModulePath.Text;
            string modulename = Path.GetFileName(modulepath);
            try
            {
                if (!BoxModulePath.Text.Contains("data"))
                {
                    // ftp the sprx to the console
                }
                else
                {
                    if (LoadModule(BoxModulePath.Text) != 0)
                    {
                        RefreshModules();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUnloadModule_Click(object sender, EventArgs e)
        {
            int prxhandle = Convert.ToInt32(ModuleGridView.Rows[ModuleGridView.CurrentCell.RowIndex].Cells[1].Value.ToString(), 16);
            CurrentPrxHandle = prxhandle;
            UnloadModule(CurrentPrxHandle);
            RefreshModules();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog Ofd = new OpenFileDialog();
            Ofd.Filter = "PS4 SPRX|*.sprx";

            if (Ofd.ShowDialog() == DialogResult.OK)
            {
                BoxModulePath.Text = Ofd.FileName;
            }
        }
    }
}