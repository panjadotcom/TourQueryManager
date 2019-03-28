namespace TourQueryManager
{
    partial class FrmSettingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettingPage));
            this.txtBoxDbSrvrIp = new System.Windows.Forms.TextBox();
            this.lblDbServerIp = new System.Windows.Forms.Label();
            this.lblDbServerPort = new System.Windows.Forms.Label();
            this.txtBoxDbSrvrPort = new System.Windows.Forms.TextBox();
            this.lblDbUsername = new System.Windows.Forms.Label();
            this.txtBoxDbUsrName = new System.Windows.Forms.TextBox();
            this.lblDbPasswd = new System.Windows.Forms.Label();
            this.txtBoxDbPasswd = new System.Windows.Forms.TextBox();
            this.txtBoxConnString = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnTstConn = new System.Windows.Forms.Button();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtBoxDatabase = new System.Windows.Forms.TextBox();
            this.PctrBoxSetting = new System.Windows.Forms.PictureBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.BtnRestoreDatabase = new System.Windows.Forms.Button();
            this.lblMySqlWorkingDirectory = new System.Windows.Forms.Label();
            this.txtBoxMysqlWorkingDirectory = new System.Windows.Forms.TextBox();
            this.BtnMysqlWorkingDirectory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PctrBoxSetting)).BeginInit();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxDbSrvrIp
            // 
            this.txtBoxDbSrvrIp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDbSrvrIp.Location = new System.Drawing.Point(448, 12);
            this.txtBoxDbSrvrIp.Name = "txtBoxDbSrvrIp";
            this.txtBoxDbSrvrIp.Size = new System.Drawing.Size(116, 20);
            this.txtBoxDbSrvrIp.TabIndex = 1;
            this.txtBoxDbSrvrIp.Leave += new System.EventHandler(this.UpdateConnectionString);
            // 
            // lblDbServerIp
            // 
            this.lblDbServerIp.AutoSize = true;
            this.lblDbServerIp.Location = new System.Drawing.Point(360, 15);
            this.lblDbServerIp.Name = "lblDbServerIp";
            this.lblDbServerIp.Size = new System.Drawing.Size(82, 13);
            this.lblDbServerIp.TabIndex = 8;
            this.lblDbServerIp.Text = "DB SERVER IP";
            // 
            // lblDbServerPort
            // 
            this.lblDbServerPort.AutoSize = true;
            this.lblDbServerPort.Location = new System.Drawing.Point(340, 62);
            this.lblDbServerPort.Name = "lblDbServerPort";
            this.lblDbServerPort.Size = new System.Drawing.Size(102, 13);
            this.lblDbServerPort.TabIndex = 9;
            this.lblDbServerPort.Text = "DB SERVER PORT";
            // 
            // txtBoxDbSrvrPort
            // 
            this.txtBoxDbSrvrPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDbSrvrPort.Location = new System.Drawing.Point(448, 59);
            this.txtBoxDbSrvrPort.Name = "txtBoxDbSrvrPort";
            this.txtBoxDbSrvrPort.Size = new System.Drawing.Size(116, 20);
            this.txtBoxDbSrvrPort.TabIndex = 2;
            this.txtBoxDbSrvrPort.Text = "3306";
            this.txtBoxDbSrvrPort.Leave += new System.EventHandler(this.UpdateConnectionString);
            // 
            // lblDbUsername
            // 
            this.lblDbUsername.AutoSize = true;
            this.lblDbUsername.Location = new System.Drawing.Point(356, 109);
            this.lblDbUsername.Name = "lblDbUsername";
            this.lblDbUsername.Size = new System.Drawing.Size(86, 13);
            this.lblDbUsername.TabIndex = 10;
            this.lblDbUsername.Text = "DB-USERNAME";
            // 
            // txtBoxDbUsrName
            // 
            this.txtBoxDbUsrName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDbUsrName.Location = new System.Drawing.Point(448, 106);
            this.txtBoxDbUsrName.Name = "txtBoxDbUsrName";
            this.txtBoxDbUsrName.Size = new System.Drawing.Size(116, 20);
            this.txtBoxDbUsrName.TabIndex = 3;
            this.txtBoxDbUsrName.Leave += new System.EventHandler(this.UpdateConnectionString);
            // 
            // lblDbPasswd
            // 
            this.lblDbPasswd.AutoSize = true;
            this.lblDbPasswd.Location = new System.Drawing.Point(354, 156);
            this.lblDbPasswd.Name = "lblDbPasswd";
            this.lblDbPasswd.Size = new System.Drawing.Size(88, 13);
            this.lblDbPasswd.TabIndex = 11;
            this.lblDbPasswd.Text = "DB-PASSWORD";
            // 
            // txtBoxDbPasswd
            // 
            this.txtBoxDbPasswd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDbPasswd.Location = new System.Drawing.Point(448, 153);
            this.txtBoxDbPasswd.Name = "txtBoxDbPasswd";
            this.txtBoxDbPasswd.Size = new System.Drawing.Size(116, 20);
            this.txtBoxDbPasswd.TabIndex = 4;
            this.txtBoxDbPasswd.Leave += new System.EventHandler(this.UpdateConnectionString);
            // 
            // txtBoxConnString
            // 
            this.txtBoxConnString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxConnString.Location = new System.Drawing.Point(12, 241);
            this.txtBoxConnString.Name = "txtBoxConnString";
            this.txtBoxConnString.Size = new System.Drawing.Size(552, 20);
            this.txtBoxConnString.TabIndex = 6;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUpdate.Location = new System.Drawing.Point(279, 3);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(270, 31);
            this.BtnUpdate.TabIndex = 0;
            this.BtnUpdate.Text = "UPDATE";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnTstConn
            // 
            this.BtnTstConn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnTstConn.Location = new System.Drawing.Point(3, 3);
            this.BtnTstConn.Name = "BtnTstConn";
            this.BtnTstConn.Size = new System.Drawing.Size(270, 31);
            this.BtnTstConn.TabIndex = 7;
            this.BtnTstConn.Text = "TEST CONNECTION";
            this.BtnTstConn.UseVisualStyleBackColor = true;
            this.BtnTstConn.Click += new System.EventHandler(this.BtnTstConn_Click);
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(378, 203);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(64, 13);
            this.lblDatabase.TabIndex = 12;
            this.lblDatabase.Text = "DATABASE";
            this.lblDatabase.Leave += new System.EventHandler(this.UpdateConnectionString);
            // 
            // txtBoxDatabase
            // 
            this.txtBoxDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDatabase.Location = new System.Drawing.Point(448, 200);
            this.txtBoxDatabase.Name = "txtBoxDatabase";
            this.txtBoxDatabase.Size = new System.Drawing.Size(116, 20);
            this.txtBoxDatabase.TabIndex = 5;
            this.txtBoxDatabase.Leave += new System.EventHandler(this.UpdateConnectionString);
            // 
            // PctrBoxSetting
            // 
            this.PctrBoxSetting.Image = global::TourQueryManager.Properties.Resources.Setting;
            this.PctrBoxSetting.Location = new System.Drawing.Point(12, 12);
            this.PctrBoxSetting.Name = "PctrBoxSetting";
            this.PctrBoxSetting.Size = new System.Drawing.Size(275, 223);
            this.PctrBoxSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctrBoxSetting.TabIndex = 32;
            this.PctrBoxSetting.TabStop = false;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancel.Location = new System.Drawing.Point(279, 40);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(270, 31);
            this.BtnCancel.TabIndex = 33;
            this.BtnCancel.Text = "EXIT";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelButtons.ColumnCount = 2;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.Controls.Add(this.BtnRestoreDatabase, 0, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.BtnTstConn, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.BtnCancel, 1, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.BtnUpdate, 1, 0);
            this.tableLayoutPanelButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(12, 319);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 2;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(552, 74);
            this.tableLayoutPanelButtons.TabIndex = 34;
            // 
            // BtnRestoreDatabase
            // 
            this.BtnRestoreDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRestoreDatabase.Location = new System.Drawing.Point(3, 40);
            this.BtnRestoreDatabase.Name = "BtnRestoreDatabase";
            this.BtnRestoreDatabase.Size = new System.Drawing.Size(270, 31);
            this.BtnRestoreDatabase.TabIndex = 34;
            this.BtnRestoreDatabase.Text = "RESTORE DATABASE";
            this.BtnRestoreDatabase.UseVisualStyleBackColor = true;
            this.BtnRestoreDatabase.Click += new System.EventHandler(this.BtnRestoreDatabase_Click);
            // 
            // lblMySqlWorkingDirectory
            // 
            this.lblMySqlWorkingDirectory.AutoSize = true;
            this.lblMySqlWorkingDirectory.Location = new System.Drawing.Point(12, 283);
            this.lblMySqlWorkingDirectory.Name = "lblMySqlWorkingDirectory";
            this.lblMySqlWorkingDirectory.Size = new System.Drawing.Size(110, 13);
            this.lblMySqlWorkingDirectory.TabIndex = 36;
            this.lblMySqlWorkingDirectory.Text = "MYSQL DIRECTORY";
            // 
            // txtBoxMysqlWorkingDirectory
            // 
            this.txtBoxMysqlWorkingDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxMysqlWorkingDirectory.Location = new System.Drawing.Point(128, 279);
            this.txtBoxMysqlWorkingDirectory.Name = "txtBoxMysqlWorkingDirectory";
            this.txtBoxMysqlWorkingDirectory.Size = new System.Drawing.Size(355, 20);
            this.txtBoxMysqlWorkingDirectory.TabIndex = 35;
            // 
            // BtnMysqlWorkingDirectory
            // 
            this.BtnMysqlWorkingDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMysqlWorkingDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMysqlWorkingDirectory.Location = new System.Drawing.Point(489, 278);
            this.BtnMysqlWorkingDirectory.Name = "BtnMysqlWorkingDirectory";
            this.BtnMysqlWorkingDirectory.Size = new System.Drawing.Size(75, 23);
            this.BtnMysqlWorkingDirectory.TabIndex = 37;
            this.BtnMysqlWorkingDirectory.Text = "browse";
            this.BtnMysqlWorkingDirectory.UseVisualStyleBackColor = true;
            this.BtnMysqlWorkingDirectory.Click += new System.EventHandler(this.BtnMysqlWorkingDirectory_Click);
            // 
            // FrmSettingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 405);
            this.Controls.Add(this.BtnMysqlWorkingDirectory);
            this.Controls.Add(this.lblMySqlWorkingDirectory);
            this.Controls.Add(this.txtBoxMysqlWorkingDirectory);
            this.Controls.Add(this.tableLayoutPanelButtons);
            this.Controls.Add(this.PctrBoxSetting);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.txtBoxDatabase);
            this.Controls.Add(this.txtBoxConnString);
            this.Controls.Add(this.lblDbPasswd);
            this.Controls.Add(this.txtBoxDbPasswd);
            this.Controls.Add(this.lblDbUsername);
            this.Controls.Add(this.txtBoxDbUsrName);
            this.Controls.Add(this.lblDbServerPort);
            this.Controls.Add(this.txtBoxDbSrvrPort);
            this.Controls.Add(this.lblDbServerIp);
            this.Controls.Add(this.txtBoxDbSrvrIp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettingPage";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FrmSettingPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctrBoxSetting)).EndInit();
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxDbSrvrIp;
        private System.Windows.Forms.Label lblDbServerIp;
        private System.Windows.Forms.Label lblDbServerPort;
        private System.Windows.Forms.TextBox txtBoxDbSrvrPort;
        private System.Windows.Forms.Label lblDbUsername;
        private System.Windows.Forms.TextBox txtBoxDbUsrName;
        private System.Windows.Forms.Label lblDbPasswd;
        private System.Windows.Forms.TextBox txtBoxDbPasswd;
        private System.Windows.Forms.TextBox txtBoxConnString;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnTstConn;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.TextBox txtBoxDatabase;
        private System.Windows.Forms.PictureBox PctrBoxSetting;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button BtnRestoreDatabase;
        private System.Windows.Forms.Label lblMySqlWorkingDirectory;
        private System.Windows.Forms.TextBox txtBoxMysqlWorkingDirectory;
        private System.Windows.Forms.Button BtnMysqlWorkingDirectory;
    }
}