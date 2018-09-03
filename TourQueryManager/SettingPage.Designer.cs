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
            ((System.ComponentModel.ISupportInitialize)(this.PctrBoxSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxDbSrvrIp
            // 
            this.txtBoxDbSrvrIp.Location = new System.Drawing.Point(437, 12);
            this.txtBoxDbSrvrIp.Name = "txtBoxDbSrvrIp";
            this.txtBoxDbSrvrIp.Size = new System.Drawing.Size(158, 20);
            this.txtBoxDbSrvrIp.TabIndex = 1;
            this.txtBoxDbSrvrIp.Leave += new System.EventHandler(this.UpdateConnectionString);
            // 
            // lblDbServerIp
            // 
            this.lblDbServerIp.AutoSize = true;
            this.lblDbServerIp.Location = new System.Drawing.Point(349, 16);
            this.lblDbServerIp.Name = "lblDbServerIp";
            this.lblDbServerIp.Size = new System.Drawing.Size(82, 13);
            this.lblDbServerIp.TabIndex = 8;
            this.lblDbServerIp.Text = "DB SERVER IP";
            // 
            // lblDbServerPort
            // 
            this.lblDbServerPort.AutoSize = true;
            this.lblDbServerPort.Location = new System.Drawing.Point(329, 63);
            this.lblDbServerPort.Name = "lblDbServerPort";
            this.lblDbServerPort.Size = new System.Drawing.Size(102, 13);
            this.lblDbServerPort.TabIndex = 9;
            this.lblDbServerPort.Text = "DB SERVER PORT";
            // 
            // txtBoxDbSrvrPort
            // 
            this.txtBoxDbSrvrPort.Location = new System.Drawing.Point(437, 59);
            this.txtBoxDbSrvrPort.Name = "txtBoxDbSrvrPort";
            this.txtBoxDbSrvrPort.Size = new System.Drawing.Size(158, 20);
            this.txtBoxDbSrvrPort.TabIndex = 2;
            this.txtBoxDbSrvrPort.Text = "3306";
            this.txtBoxDbSrvrPort.Leave += new System.EventHandler(this.UpdateConnectionString);
            // 
            // lblDbUsername
            // 
            this.lblDbUsername.AutoSize = true;
            this.lblDbUsername.Location = new System.Drawing.Point(345, 110);
            this.lblDbUsername.Name = "lblDbUsername";
            this.lblDbUsername.Size = new System.Drawing.Size(86, 13);
            this.lblDbUsername.TabIndex = 10;
            this.lblDbUsername.Text = "DB-USERNAME";
            // 
            // txtBoxDbUsrName
            // 
            this.txtBoxDbUsrName.Location = new System.Drawing.Point(437, 106);
            this.txtBoxDbUsrName.Name = "txtBoxDbUsrName";
            this.txtBoxDbUsrName.Size = new System.Drawing.Size(158, 20);
            this.txtBoxDbUsrName.TabIndex = 3;
            this.txtBoxDbUsrName.Leave += new System.EventHandler(this.UpdateConnectionString);
            // 
            // lblDbPasswd
            // 
            this.lblDbPasswd.AutoSize = true;
            this.lblDbPasswd.Location = new System.Drawing.Point(343, 157);
            this.lblDbPasswd.Name = "lblDbPasswd";
            this.lblDbPasswd.Size = new System.Drawing.Size(88, 13);
            this.lblDbPasswd.TabIndex = 11;
            this.lblDbPasswd.Text = "DB-PASSWORD";
            // 
            // txtBoxDbPasswd
            // 
            this.txtBoxDbPasswd.Location = new System.Drawing.Point(437, 153);
            this.txtBoxDbPasswd.Name = "txtBoxDbPasswd";
            this.txtBoxDbPasswd.Size = new System.Drawing.Size(158, 20);
            this.txtBoxDbPasswd.TabIndex = 4;
            this.txtBoxDbPasswd.Leave += new System.EventHandler(this.UpdateConnectionString);
            // 
            // txtBoxConnString
            // 
            this.txtBoxConnString.Location = new System.Drawing.Point(12, 241);
            this.txtBoxConnString.Name = "txtBoxConnString";
            this.txtBoxConnString.Size = new System.Drawing.Size(583, 20);
            this.txtBoxConnString.TabIndex = 6;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(461, 283);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(134, 23);
            this.BtnUpdate.TabIndex = 0;
            this.BtnUpdate.Text = "UPDATE";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnTstConn
            // 
            this.BtnTstConn.Location = new System.Drawing.Point(12, 283);
            this.BtnTstConn.Name = "BtnTstConn";
            this.BtnTstConn.Size = new System.Drawing.Size(134, 23);
            this.BtnTstConn.TabIndex = 7;
            this.BtnTstConn.Text = "TEST CONNECTION";
            this.BtnTstConn.UseVisualStyleBackColor = true;
            this.BtnTstConn.Click += new System.EventHandler(this.BtnTstConn_Click);
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(367, 204);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(64, 13);
            this.lblDatabase.TabIndex = 12;
            this.lblDatabase.Text = "DATABASE";
            this.lblDatabase.Leave += new System.EventHandler(this.UpdateConnectionString);
            // 
            // txtBoxDatabase
            // 
            this.txtBoxDatabase.Location = new System.Drawing.Point(437, 200);
            this.txtBoxDatabase.Name = "txtBoxDatabase";
            this.txtBoxDatabase.Size = new System.Drawing.Size(158, 20);
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
            this.BtnCancel.Location = new System.Drawing.Point(246, 283);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(134, 23);
            this.BtnCancel.TabIndex = 33;
            this.BtnCancel.Text = "CANCEL";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmSettingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 329);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.PctrBoxSetting);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.txtBoxDatabase);
            this.Controls.Add(this.BtnTstConn);
            this.Controls.Add(this.BtnUpdate);
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
    }
}