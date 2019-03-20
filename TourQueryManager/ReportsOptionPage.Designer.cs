namespace TourQueryManager
{
    partial class FrmReportsOptionPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportsOptionPage));
            this.menuStripReports = new System.Windows.Forms.MenuStrip();
            this.queriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allQueriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectiveQueriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectiveUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allAgentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectiveAgentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ledgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allLedgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectiveLedgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripReports
            // 
            this.menuStripReports.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queriesToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.agentsToolStripMenuItem,
            this.ledgerToolStripMenuItem});
            this.menuStripReports.Location = new System.Drawing.Point(0, 0);
            this.menuStripReports.Name = "menuStripReports";
            this.menuStripReports.Size = new System.Drawing.Size(800, 24);
            this.menuStripReports.TabIndex = 1;
            this.menuStripReports.Text = "REPORTS MENU";
            // 
            // queriesToolStripMenuItem
            // 
            this.queriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allQueriesToolStripMenuItem,
            this.selectiveQueriesToolStripMenuItem});
            this.queriesToolStripMenuItem.Name = "queriesToolStripMenuItem";
            this.queriesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.queriesToolStripMenuItem.Text = "QUERIES";
            // 
            // allQueriesToolStripMenuItem
            // 
            this.allQueriesToolStripMenuItem.Name = "allQueriesToolStripMenuItem";
            this.allQueriesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allQueriesToolStripMenuItem.Text = "All";
            this.allQueriesToolStripMenuItem.Click += new System.EventHandler(this.All_ToolStripMenuItem_Click);
            // 
            // selectiveQueriesToolStripMenuItem
            // 
            this.selectiveQueriesToolStripMenuItem.Name = "selectiveQueriesToolStripMenuItem";
            this.selectiveQueriesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectiveQueriesToolStripMenuItem.Text = "Selective";
            this.selectiveQueriesToolStripMenuItem.Click += new System.EventHandler(this.SelectiveToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allUsersToolStripMenuItem,
            this.selectiveUsersToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.usersToolStripMenuItem.Text = "USERS";
            // 
            // allUsersToolStripMenuItem
            // 
            this.allUsersToolStripMenuItem.Name = "allUsersToolStripMenuItem";
            this.allUsersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allUsersToolStripMenuItem.Text = "All";
            this.allUsersToolStripMenuItem.Click += new System.EventHandler(this.All_ToolStripMenuItem_Click);
            // 
            // selectiveUsersToolStripMenuItem
            // 
            this.selectiveUsersToolStripMenuItem.Name = "selectiveUsersToolStripMenuItem";
            this.selectiveUsersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectiveUsersToolStripMenuItem.Text = "Selective";
            this.selectiveUsersToolStripMenuItem.Click += new System.EventHandler(this.SelectiveToolStripMenuItem_Click);
            // 
            // agentsToolStripMenuItem
            // 
            this.agentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allAgentsToolStripMenuItem,
            this.selectiveAgentsToolStripMenuItem});
            this.agentsToolStripMenuItem.Name = "agentsToolStripMenuItem";
            this.agentsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.agentsToolStripMenuItem.Text = "AGENTS";
            // 
            // allAgentsToolStripMenuItem
            // 
            this.allAgentsToolStripMenuItem.Name = "allAgentsToolStripMenuItem";
            this.allAgentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allAgentsToolStripMenuItem.Text = "All";
            this.allAgentsToolStripMenuItem.Click += new System.EventHandler(this.All_ToolStripMenuItem_Click);
            // 
            // selectiveAgentsToolStripMenuItem
            // 
            this.selectiveAgentsToolStripMenuItem.Name = "selectiveAgentsToolStripMenuItem";
            this.selectiveAgentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectiveAgentsToolStripMenuItem.Text = "Selective";
            this.selectiveAgentsToolStripMenuItem.Click += new System.EventHandler(this.SelectiveToolStripMenuItem_Click);
            // 
            // ledgerToolStripMenuItem
            // 
            this.ledgerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allLedgerToolStripMenuItem,
            this.selectiveLedgerToolStripMenuItem});
            this.ledgerToolStripMenuItem.Name = "ledgerToolStripMenuItem";
            this.ledgerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ledgerToolStripMenuItem.Text = "LEDGER";
            // 
            // allLedgerToolStripMenuItem
            // 
            this.allLedgerToolStripMenuItem.Name = "allLedgerToolStripMenuItem";
            this.allLedgerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allLedgerToolStripMenuItem.Text = "All";
            this.allLedgerToolStripMenuItem.Click += new System.EventHandler(this.All_ToolStripMenuItem_Click);
            // 
            // selectiveLedgerToolStripMenuItem
            // 
            this.selectiveLedgerToolStripMenuItem.Name = "selectiveLedgerToolStripMenuItem";
            this.selectiveLedgerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectiveLedgerToolStripMenuItem.Text = "Selective";
            this.selectiveLedgerToolStripMenuItem.Click += new System.EventHandler(this.SelectiveToolStripMenuItem_Click);
            // 
            // FrmReportsOptionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStripReports);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripReports;
            this.Name = "FrmReportsOptionPage";
            this.Text = "REPORTS OPTION";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripReports.ResumeLayout(false);
            this.menuStripReports.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripReports;
        private System.Windows.Forms.ToolStripMenuItem queriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ledgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allQueriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allAgentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allLedgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectiveQueriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectiveUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectiveAgentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectiveLedgerToolStripMenuItem;
    }
}