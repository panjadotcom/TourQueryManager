namespace TourQueryManager
{
    partial class FrmAdminPage
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
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnViewUsrReport = new System.Windows.Forms.Button();
            this.btnViewQueryReport = new System.Windows.Forms.Button();
            this.btnCreateQuery = new System.Windows.Forms.Button();
            this.btnCreateAgent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUser.Location = new System.Drawing.Point(176, 66);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(159, 109);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnViewUsrReport
            // 
            this.btnViewUsrReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUsrReport.Location = new System.Drawing.Point(177, 181);
            this.btnViewUsrReport.Name = "btnViewUsrReport";
            this.btnViewUsrReport.Size = new System.Drawing.Size(158, 109);
            this.btnViewUsrReport.TabIndex = 1;
            this.btnViewUsrReport.Text = "View User Report";
            this.btnViewUsrReport.UseVisualStyleBackColor = true;
            // 
            // btnViewQueryReport
            // 
            this.btnViewQueryReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewQueryReport.Location = new System.Drawing.Point(342, 181);
            this.btnViewQueryReport.Name = "btnViewQueryReport";
            this.btnViewQueryReport.Size = new System.Drawing.Size(158, 109);
            this.btnViewQueryReport.TabIndex = 3;
            this.btnViewQueryReport.Text = "View Query Report";
            this.btnViewQueryReport.UseVisualStyleBackColor = true;
            // 
            // btnCreateQuery
            // 
            this.btnCreateQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateQuery.Location = new System.Drawing.Point(341, 66);
            this.btnCreateQuery.Name = "btnCreateQuery";
            this.btnCreateQuery.Size = new System.Drawing.Size(159, 109);
            this.btnCreateQuery.TabIndex = 2;
            this.btnCreateQuery.Text = "Create Query";
            this.btnCreateQuery.UseVisualStyleBackColor = true;
            this.btnCreateQuery.Click += new System.EventHandler(this.btnCreateQuery_Click);
            // 
            // btnCreateAgent
            // 
            this.btnCreateAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAgent.Location = new System.Drawing.Point(12, 66);
            this.btnCreateAgent.Name = "btnCreateAgent";
            this.btnCreateAgent.Size = new System.Drawing.Size(159, 109);
            this.btnCreateAgent.TabIndex = 4;
            this.btnCreateAgent.Text = "Create Agent";
            this.btnCreateAgent.UseVisualStyleBackColor = true;
            this.btnCreateAgent.Click += new System.EventHandler(this.btnCreateAgent_Click);
            // 
            // FrmAdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 380);
            this.Controls.Add(this.btnCreateAgent);
            this.Controls.Add(this.btnViewQueryReport);
            this.Controls.Add(this.btnCreateQuery);
            this.Controls.Add(this.btnViewUsrReport);
            this.Controls.Add(this.btnCreateUser);
            this.MaximizeBox = false;
            this.Name = "FrmAdminPage";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.FrmAdminPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnViewUsrReport;
        private System.Windows.Forms.Button btnViewQueryReport;
        private System.Windows.Forms.Button btnCreateQuery;
        private System.Windows.Forms.Button btnCreateAgent;
    }
}