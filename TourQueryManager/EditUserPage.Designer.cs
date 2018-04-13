namespace TourQueryManager
{
    partial class FrmEditUserPage
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtboxPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtboxInfo = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtboxEmailId = new System.Windows.Forms.TextBox();
            this.lblEmailId = new System.Windows.Forms.Label();
            this.txtboxUserId = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(122, 111);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Location = new System.Drawing.Point(214, 108);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(278, 20);
            this.txtboxUsername.TabIndex = 3;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(214, 148);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '*';
            this.txtboxPassword.Size = new System.Drawing.Size(278, 20);
            this.txtboxPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(122, 151);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // txtboxPhone
            // 
            this.txtboxPhone.Location = new System.Drawing.Point(214, 230);
            this.txtboxPhone.Name = "txtboxPhone";
            this.txtboxPhone.Size = new System.Drawing.Size(278, 20);
            this.txtboxPhone.TabIndex = 9;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(122, 233);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 13);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Phone No";
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(214, 190);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(278, 20);
            this.txtboxName.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(122, 193);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // txtboxInfo
            // 
            this.txtboxInfo.Location = new System.Drawing.Point(214, 313);
            this.txtboxInfo.Multiline = true;
            this.txtboxInfo.Name = "txtboxInfo";
            this.txtboxInfo.Size = new System.Drawing.Size(278, 137);
            this.txtboxInfo.TabIndex = 13;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(122, 368);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(74, 13);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.Text = "Additional Info";
            // 
            // txtboxEmailId
            // 
            this.txtboxEmailId.Location = new System.Drawing.Point(214, 273);
            this.txtboxEmailId.Name = "txtboxEmailId";
            this.txtboxEmailId.Size = new System.Drawing.Size(278, 20);
            this.txtboxEmailId.TabIndex = 11;
            // 
            // lblEmailId
            // 
            this.lblEmailId.AutoSize = true;
            this.lblEmailId.Location = new System.Drawing.Point(122, 276);
            this.lblEmailId.Name = "lblEmailId";
            this.lblEmailId.Size = new System.Drawing.Size(44, 13);
            this.lblEmailId.TabIndex = 10;
            this.lblEmailId.Text = "Email Id";
            // 
            // txtboxUserId
            // 
            this.txtboxUserId.Location = new System.Drawing.Point(214, 64);
            this.txtboxUserId.Name = "txtboxUserId";
            this.txtboxUserId.ReadOnly = true;
            this.txtboxUserId.Size = new System.Drawing.Size(73, 20);
            this.txtboxUserId.TabIndex = 1;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(122, 67);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(38, 13);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "UserId";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(366, 482);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 37);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmEditUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 573);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtboxInfo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtboxEmailId);
            this.Controls.Add(this.lblEmailId);
            this.Controls.Add(this.txtboxUserId);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.txtboxPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtboxUsername);
            this.Controls.Add(this.lblUsername);
            this.MaximizeBox = false;
            this.Name = "FrmEditUserPage";
            this.Text = "New User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEditUserPage_FormClosing);
            this.Load += new System.EventHandler(this.FrmEditUserPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtboxUsername;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtboxPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtboxInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtboxEmailId;
        private System.Windows.Forms.Label lblEmailId;
        private System.Windows.Forms.TextBox txtboxUserId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Button btnUpdate;
    }
}