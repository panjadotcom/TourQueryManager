﻿namespace TourQueryManager
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
            this.BtnReports = new System.Windows.Forms.Button();
            this.btnCreateQuery = new System.Windows.Forms.Button();
            this.btnCreateAgent = new System.Windows.Forms.Button();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.BtnRestore = new System.Windows.Forms.Button();
            this.BtnBackUp = new System.Windows.Forms.Button();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUser.Location = new System.Drawing.Point(3, 133);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(170, 124);
            this.btnCreateUser.TabIndex = 4;
            this.btnCreateUser.Text = "USERS";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // BtnReports
            // 
            this.BtnReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReports.Location = new System.Drawing.Point(179, 3);
            this.BtnReports.Name = "BtnReports";
            this.BtnReports.Size = new System.Drawing.Size(170, 124);
            this.BtnReports.TabIndex = 5;
            this.BtnReports.Text = "REPORTS";
            this.BtnReports.UseVisualStyleBackColor = true;
            this.BtnReports.Click += new System.EventHandler(this.BtnReports_Click);
            // 
            // btnCreateQuery
            // 
            this.btnCreateQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateQuery.Location = new System.Drawing.Point(3, 3);
            this.btnCreateQuery.Name = "btnCreateQuery";
            this.btnCreateQuery.Size = new System.Drawing.Size(170, 124);
            this.btnCreateQuery.TabIndex = 0;
            this.btnCreateQuery.Text = "QUERIES";
            this.btnCreateQuery.UseVisualStyleBackColor = true;
            this.btnCreateQuery.Click += new System.EventHandler(this.btnCreateQuery_Click);
            // 
            // btnCreateAgent
            // 
            this.btnCreateAgent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAgent.Location = new System.Drawing.Point(179, 133);
            this.btnCreateAgent.Name = "btnCreateAgent";
            this.btnCreateAgent.Size = new System.Drawing.Size(170, 124);
            this.btnCreateAgent.TabIndex = 3;
            this.btnCreateAgent.Text = "AGENTS";
            this.btnCreateAgent.UseVisualStyleBackColor = true;
            this.btnCreateAgent.Click += new System.EventHandler(this.btnCreateAgent_Click);
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelButtons.ColumnCount = 2;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.Controls.Add(this.BtnBackUp, 0, 2);
            this.tableLayoutPanelButtons.Controls.Add(this.BtnRestore, 0, 2);
            this.tableLayoutPanelButtons.Controls.Add(this.btnCreateAgent, 1, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.btnCreateQuery, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.btnCreateUser, 0, 1);
            this.tableLayoutPanelButtons.Controls.Add(this.BtnReports, 1, 0);
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 3;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(352, 391);
            this.tableLayoutPanelButtons.TabIndex = 6;
            // 
            // BtnRestore
            // 
            this.BtnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestore.Location = new System.Drawing.Point(179, 263);
            this.BtnRestore.Name = "BtnRestore";
            this.BtnRestore.Size = new System.Drawing.Size(170, 125);
            this.BtnRestore.TabIndex = 6;
            this.BtnRestore.Text = "RESTORE";
            this.BtnRestore.UseVisualStyleBackColor = true;
            this.BtnRestore.Click += new System.EventHandler(this.BtnBackUpRestore_Click);
            // 
            // BtnBackUp
            // 
            this.BtnBackUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackUp.Location = new System.Drawing.Point(3, 263);
            this.BtnBackUp.Name = "BtnBackUp";
            this.BtnBackUp.Size = new System.Drawing.Size(170, 125);
            this.BtnBackUp.TabIndex = 7;
            this.BtnBackUp.Text = "BACKUP";
            this.BtnBackUp.UseVisualStyleBackColor = true;
            this.BtnBackUp.Click += new System.EventHandler(this.BtnBackUpRestore_Click);
            // 
            // FrmAdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 415);
            this.Controls.Add(this.tableLayoutPanelButtons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminPage";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.FrmAdminPage_Load);
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button BtnReports;
        private System.Windows.Forms.Button btnCreateQuery;
        private System.Windows.Forms.Button btnCreateAgent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button BtnBackUp;
        private System.Windows.Forms.Button BtnRestore;
    }
}