namespace PS4_Toolbox
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ModulesPage = new System.Windows.Forms.TabPage();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.BoxModulePath = new System.Windows.Forms.TextBox();
            this.BtnUnloadModule = new System.Windows.Forms.Button();
            this.BtnLoadModule = new System.Windows.Forms.Button();
            this.ModuleGridView = new System.Windows.Forms.DataGridView();
            this.ModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModuleHandle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModuleTextSegment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModuleDataSegment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessPage = new System.Windows.Forms.TabPage();
            this.BtnRefreshProcesses = new System.Windows.Forms.Button();
            this.BtnAttach = new System.Windows.Forms.Button();
            this.ProcessesGridView = new System.Windows.Forms.DataGridView();
            this.ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessTitleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessContentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoxConsoleIP = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CurrentProcessLabel = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.ModulesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModuleGridView)).BeginInit();
            this.ProcessPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ModulesPage);
            this.TabControl.Controls.Add(this.ProcessPage);
            this.TabControl.Location = new System.Drawing.Point(0, 38);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(674, 410);
            this.TabControl.TabIndex = 0;
            // 
            // ModulesPage
            // 
            this.ModulesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ModulesPage.Controls.Add(this.BtnBrowse);
            this.ModulesPage.Controls.Add(this.BoxModulePath);
            this.ModulesPage.Controls.Add(this.BtnUnloadModule);
            this.ModulesPage.Controls.Add(this.BtnLoadModule);
            this.ModulesPage.Controls.Add(this.ModuleGridView);
            this.ModulesPage.ForeColor = System.Drawing.Color.Black;
            this.ModulesPage.Location = new System.Drawing.Point(4, 22);
            this.ModulesPage.Name = "ModulesPage";
            this.ModulesPage.Size = new System.Drawing.Size(666, 384);
            this.ModulesPage.TabIndex = 0;
            this.ModulesPage.Text = "Modules";
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBrowse.ForeColor = System.Drawing.Color.White;
            this.BtnBrowse.Location = new System.Drawing.Point(395, 351);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(54, 27);
            this.BtnBrowse.TabIndex = 7;
            this.BtnBrowse.Text = "Browse";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // BoxModulePath
            // 
            this.BoxModulePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BoxModulePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoxModulePath.ForeColor = System.Drawing.Color.White;
            this.BoxModulePath.Location = new System.Drawing.Point(8, 356);
            this.BoxModulePath.Name = "BoxModulePath";
            this.BoxModulePath.Size = new System.Drawing.Size(381, 20);
            this.BoxModulePath.TabIndex = 6;
            this.BoxModulePath.Text = "/data/module.sprx";
            // 
            // BtnUnloadModule
            // 
            this.BtnUnloadModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnUnloadModule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnUnloadModule.ForeColor = System.Drawing.Color.White;
            this.BtnUnloadModule.Location = new System.Drawing.Point(455, 351);
            this.BtnUnloadModule.Name = "BtnUnloadModule";
            this.BtnUnloadModule.Size = new System.Drawing.Size(101, 27);
            this.BtnUnloadModule.TabIndex = 5;
            this.BtnUnloadModule.Text = "Unload";
            this.BtnUnloadModule.UseVisualStyleBackColor = true;
            this.BtnUnloadModule.Click += new System.EventHandler(this.BtnUnloadModule_Click);
            // 
            // BtnLoadModule
            // 
            this.BtnLoadModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnLoadModule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLoadModule.ForeColor = System.Drawing.Color.White;
            this.BtnLoadModule.Location = new System.Drawing.Point(562, 351);
            this.BtnLoadModule.Name = "BtnLoadModule";
            this.BtnLoadModule.Size = new System.Drawing.Size(101, 27);
            this.BtnLoadModule.TabIndex = 4;
            this.BtnLoadModule.Text = "Load";
            this.BtnLoadModule.UseVisualStyleBackColor = true;
            this.BtnLoadModule.Click += new System.EventHandler(this.BtnLoadModule_Click);
            // 
            // ModuleGridView
            // 
            this.ModuleGridView.AllowUserToAddRows = false;
            this.ModuleGridView.AllowUserToDeleteRows = false;
            this.ModuleGridView.AllowUserToResizeColumns = false;
            this.ModuleGridView.AllowUserToResizeRows = false;
            this.ModuleGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ModuleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModuleGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModuleName,
            this.ModuleHandle,
            this.ModuleTextSegment,
            this.ModuleDataSegment});
            this.ModuleGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ModuleGridView.Location = new System.Drawing.Point(3, 3);
            this.ModuleGridView.Name = "ModuleGridView";
            this.ModuleGridView.RowHeadersVisible = false;
            this.ModuleGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ModuleGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ModuleGridView.Size = new System.Drawing.Size(660, 342);
            this.ModuleGridView.TabIndex = 0;
            // 
            // ModuleName
            // 
            this.ModuleName.HeaderText = "Name";
            this.ModuleName.Name = "ModuleName";
            this.ModuleName.Width = 140;
            // 
            // ModuleHandle
            // 
            this.ModuleHandle.HeaderText = "Handle";
            this.ModuleHandle.Name = "ModuleHandle";
            this.ModuleHandle.Width = 90;
            // 
            // ModuleTextSegment
            // 
            this.ModuleTextSegment.HeaderText = "Text Segment";
            this.ModuleTextSegment.Name = "ModuleTextSegment";
            this.ModuleTextSegment.Width = 210;
            // 
            // ModuleDataSegment
            // 
            this.ModuleDataSegment.HeaderText = "Data Segment";
            this.ModuleDataSegment.Name = "ModuleDataSegment";
            this.ModuleDataSegment.Width = 210;
            // 
            // ProcessPage
            // 
            this.ProcessPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProcessPage.Controls.Add(this.BtnRefreshProcesses);
            this.ProcessPage.Controls.Add(this.BtnAttach);
            this.ProcessPage.Controls.Add(this.ProcessesGridView);
            this.ProcessPage.ForeColor = System.Drawing.Color.Black;
            this.ProcessPage.Location = new System.Drawing.Point(4, 22);
            this.ProcessPage.Name = "ProcessPage";
            this.ProcessPage.Padding = new System.Windows.Forms.Padding(3);
            this.ProcessPage.Size = new System.Drawing.Size(666, 384);
            this.ProcessPage.TabIndex = 1;
            this.ProcessPage.Text = "Processes";
            // 
            // BtnRefreshProcesses
            // 
            this.BtnRefreshProcesses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnRefreshProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRefreshProcesses.ForeColor = System.Drawing.Color.White;
            this.BtnRefreshProcesses.Location = new System.Drawing.Point(6, 349);
            this.BtnRefreshProcesses.Name = "BtnRefreshProcesses";
            this.BtnRefreshProcesses.Size = new System.Drawing.Size(101, 29);
            this.BtnRefreshProcesses.TabIndex = 4;
            this.BtnRefreshProcesses.Text = "Refresh";
            this.BtnRefreshProcesses.UseVisualStyleBackColor = true;
            this.BtnRefreshProcesses.Click += new System.EventHandler(this.BtnRefreshProcesses_Click);
            // 
            // BtnAttach
            // 
            this.BtnAttach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAttach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAttach.ForeColor = System.Drawing.Color.White;
            this.BtnAttach.Location = new System.Drawing.Point(558, 351);
            this.BtnAttach.Name = "BtnAttach";
            this.BtnAttach.Size = new System.Drawing.Size(101, 27);
            this.BtnAttach.TabIndex = 3;
            this.BtnAttach.Text = "Attach";
            this.BtnAttach.UseVisualStyleBackColor = true;
            this.BtnAttach.Click += new System.EventHandler(this.BtnAttach_Click);
            // 
            // ProcessesGridView
            // 
            this.ProcessesGridView.AllowUserToAddRows = false;
            this.ProcessesGridView.AllowUserToDeleteRows = false;
            this.ProcessesGridView.AllowUserToResizeColumns = false;
            this.ProcessesGridView.AllowUserToResizeRows = false;
            this.ProcessesGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProcessesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcessesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcessName,
            this.ProcessID,
            this.ProcessTitleID,
            this.ProcessContentID,
            this.ProcessPath});
            this.ProcessesGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProcessesGridView.Location = new System.Drawing.Point(3, 3);
            this.ProcessesGridView.Name = "ProcessesGridView";
            this.ProcessesGridView.RowHeadersVisible = false;
            this.ProcessesGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProcessesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProcessesGridView.Size = new System.Drawing.Size(660, 342);
            this.ProcessesGridView.TabIndex = 1;
            // 
            // ProcessName
            // 
            this.ProcessName.HeaderText = "Name";
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.Width = 140;
            // 
            // ProcessID
            // 
            this.ProcessID.HeaderText = "ID";
            this.ProcessID.Name = "ProcessID";
            this.ProcessID.Width = 50;
            // 
            // ProcessTitleID
            // 
            this.ProcessTitleID.HeaderText = "TitleID";
            this.ProcessTitleID.Name = "ProcessTitleID";
            this.ProcessTitleID.Width = 90;
            // 
            // ProcessContentID
            // 
            this.ProcessContentID.HeaderText = "ContentID";
            this.ProcessContentID.Name = "ProcessContentID";
            this.ProcessContentID.Width = 90;
            // 
            // ProcessPath
            // 
            this.ProcessPath.HeaderText = "Path";
            this.ProcessPath.Name = "ProcessPath";
            this.ProcessPath.Width = 260;
            // 
            // BoxConsoleIP
            // 
            this.BoxConsoleIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BoxConsoleIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoxConsoleIP.ForeColor = System.Drawing.Color.White;
            this.BoxConsoleIP.Location = new System.Drawing.Point(4, 14);
            this.BoxConsoleIP.Name = "BoxConsoleIP";
            this.BoxConsoleIP.Size = new System.Drawing.Size(97, 20);
            this.BoxConsoleIP.TabIndex = 1;
            this.BoxConsoleIP.Text = "0.0.0.0";
            // 
            // BtnConnect
            // 
            this.BtnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConnect.ForeColor = System.Drawing.Color.White;
            this.BtnConnect.Location = new System.Drawing.Point(107, 14);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(101, 20);
            this.BtnConnect.TabIndex = 2;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.White;
            this.StatusLabel.Location = new System.Drawing.Point(4, 451);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(47, 16);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "Status:";
            // 
            // CurrentProcessLabel
            // 
            this.CurrentProcessLabel.AutoSize = true;
            this.CurrentProcessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentProcessLabel.ForeColor = System.Drawing.Color.White;
            this.CurrentProcessLabel.Location = new System.Drawing.Point(334, 451);
            this.CurrentProcessLabel.Name = "CurrentProcessLabel";
            this.CurrentProcessLabel.Size = new System.Drawing.Size(60, 16);
            this.CurrentProcessLabel.TabIndex = 4;
            this.CurrentProcessLabel.Text = "Process:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(675, 471);
            this.Controls.Add(this.CurrentProcessLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.BoxConsoleIP);
            this.Controls.Add(this.TabControl);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PS4-Toolbox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Close);
            this.Load += new System.EventHandler(this.Main_Load);
            this.TabControl.ResumeLayout(false);
            this.ModulesPage.ResumeLayout(false);
            this.ModulesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModuleGridView)).EndInit();
            this.ProcessPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProcessesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage ModulesPage;
        private System.Windows.Forms.TabPage ProcessPage;
        private System.Windows.Forms.TextBox BoxConsoleIP;
        private System.Windows.Forms.DataGridView ModuleGridView;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Button BtnAttach;
        private System.Windows.Forms.DataGridView ProcessesGridView;
        private System.Windows.Forms.Button BtnRefreshProcesses;
        private System.Windows.Forms.Button BtnUnloadModule;
        private System.Windows.Forms.Button BtnLoadModule;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.TextBox BoxModulePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleHandle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleTextSegment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleDataSegment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessTitleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessContentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessPath;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label CurrentProcessLabel;
    }
}

