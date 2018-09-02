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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminPage));
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.BtnGenerateVouchers = new System.Windows.Forms.Button();
            this.BtnGenerateReports = new System.Windows.Forms.Button();
            this.btnCreateQuery = new System.Windows.Forms.Button();
            this.btnCreateAgent = new System.Windows.Forms.Button();
            this.BtnGenerateItinerary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUser.Location = new System.Drawing.Point(176, 66);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(159, 109);
            this.btnCreateUser.TabIndex = 0;
            this.btnCreateUser.Text = "USERS";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // BtnGenerateVouchers
            // 
            this.BtnGenerateVouchers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerateVouchers.Location = new System.Drawing.Point(177, 181);
            this.BtnGenerateVouchers.Name = "BtnGenerateVouchers";
            this.BtnGenerateVouchers.Size = new System.Drawing.Size(158, 109);
            this.BtnGenerateVouchers.TabIndex = 1;
            this.BtnGenerateVouchers.Text = "GENERATE VOUCHERS";
            this.BtnGenerateVouchers.UseVisualStyleBackColor = true;
            this.BtnGenerateVouchers.Click += new System.EventHandler(this.BtnGenerateVouchers_Click);
            // 
            // BtnGenerateReports
            // 
            this.BtnGenerateReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerateReports.Location = new System.Drawing.Point(342, 181);
            this.BtnGenerateReports.Name = "BtnGenerateReports";
            this.BtnGenerateReports.Size = new System.Drawing.Size(158, 109);
            this.BtnGenerateReports.TabIndex = 3;
            this.BtnGenerateReports.Text = "GENERATE REPORTS";
            this.BtnGenerateReports.UseVisualStyleBackColor = true;
            // 
            // btnCreateQuery
            // 
            this.btnCreateQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateQuery.Location = new System.Drawing.Point(341, 66);
            this.btnCreateQuery.Name = "btnCreateQuery";
            this.btnCreateQuery.Size = new System.Drawing.Size(159, 109);
            this.btnCreateQuery.TabIndex = 2;
            this.btnCreateQuery.Text = "QUERIES";
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
            this.btnCreateAgent.Text = "AGENTS";
            this.btnCreateAgent.UseVisualStyleBackColor = true;
            this.btnCreateAgent.Click += new System.EventHandler(this.btnCreateAgent_Click);
            // 
            // BtnGenerateItinerary
            // 
            this.BtnGenerateItinerary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerateItinerary.Location = new System.Drawing.Point(13, 181);
            this.BtnGenerateItinerary.Name = "BtnGenerateItinerary";
            this.BtnGenerateItinerary.Size = new System.Drawing.Size(158, 109);
            this.BtnGenerateItinerary.TabIndex = 1;
            this.BtnGenerateItinerary.Text = "GENERATE ITINERARY";
            this.BtnGenerateItinerary.UseVisualStyleBackColor = true;
            this.BtnGenerateItinerary.Click += new System.EventHandler(this.BtnGenerateItinerary_Click);
            // 
            // FrmAdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 380);
            this.Controls.Add(this.btnCreateAgent);
            this.Controls.Add(this.BtnGenerateReports);
            this.Controls.Add(this.btnCreateQuery);
            this.Controls.Add(this.BtnGenerateItinerary);
            this.Controls.Add(this.BtnGenerateVouchers);
            this.Controls.Add(this.btnCreateUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminPage";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.FrmAdminPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button BtnGenerateVouchers;
        private System.Windows.Forms.Button BtnGenerateReports;
        private System.Windows.Forms.Button btnCreateQuery;
        private System.Windows.Forms.Button btnCreateAgent;
        private System.Windows.Forms.Button BtnGenerateItinerary;
    }
}