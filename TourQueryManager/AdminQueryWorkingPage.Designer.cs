namespace TourQueryManager
{
    partial class FrmAdminQueryWorkingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminQueryWorkingPage));
            this.DataGrdVuAdminQueries = new System.Windows.Forms.DataGridView();
            this.BtnExit = new System.Windows.Forms.Button();
            this.saveFileDialogItinerary = new System.Windows.Forms.SaveFileDialog();
            this.queryStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrdVuAdminQueries)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrdVuAdminQueries
            // 
            this.DataGrdVuAdminQueries.AllowUserToAddRows = false;
            this.DataGrdVuAdminQueries.AllowUserToDeleteRows = false;
            this.DataGrdVuAdminQueries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrdVuAdminQueries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrdVuAdminQueries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.queryStage,
            this.queryId,
            this.name,
            this.Location,
            this.FromDate,
            this.ToDate,
            this.AssignedDate});
            this.DataGrdVuAdminQueries.Location = new System.Drawing.Point(12, 12);
            this.DataGrdVuAdminQueries.MultiSelect = false;
            this.DataGrdVuAdminQueries.Name = "DataGrdVuAdminQueries";
            this.DataGrdVuAdminQueries.ReadOnly = true;
            this.DataGrdVuAdminQueries.RowHeadersVisible = false;
            this.DataGrdVuAdminQueries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrdVuAdminQueries.Size = new System.Drawing.Size(1036, 380);
            this.DataGrdVuAdminQueries.TabIndex = 0;
            this.DataGrdVuAdminQueries.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrdVuAdminQueries_CellDoubleClick);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(920, 398);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(128, 39);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // saveFileDialogItinerary
            // 
            this.saveFileDialogItinerary.DefaultExt = "pdf";
            // 
            // queryStage
            // 
            this.queryStage.HeaderText = "CURRENT STAGE";
            this.queryStage.Name = "queryStage";
            this.queryStage.ReadOnly = true;
            this.queryStage.Width = 200;
            // 
            // queryId
            // 
            this.queryId.HeaderText = "QUERY ID";
            this.queryId.Name = "queryId";
            this.queryId.ReadOnly = true;
            this.queryId.Width = 200;
            // 
            // name
            // 
            this.name.HeaderText = "NAME";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // Location
            // 
            this.Location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Location.HeaderText = "LOCATION";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // FromDate
            // 
            this.FromDate.HeaderText = "FROM DATE";
            this.FromDate.Name = "FromDate";
            this.FromDate.ReadOnly = true;
            this.FromDate.Width = 125;
            // 
            // ToDate
            // 
            this.ToDate.HeaderText = "TO DATE";
            this.ToDate.Name = "ToDate";
            this.ToDate.ReadOnly = true;
            this.ToDate.Width = 125;
            // 
            // AssignedDate
            // 
            this.AssignedDate.HeaderText = "ASSIGNED DATE";
            this.AssignedDate.Name = "AssignedDate";
            this.AssignedDate.ReadOnly = true;
            this.AssignedDate.Width = 125;
            // 
            // FrmAdminQueryWorkingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 449);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.DataGrdVuAdminQueries);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminQueryWorkingPage";
            this.Text = "Admin Working";
            this.Load += new System.EventHandler(this.FrmAdminQueryWorkingPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrdVuAdminQueries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrdVuAdminQueries;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.SaveFileDialog saveFileDialogItinerary;
        private System.Windows.Forms.DataGridViewTextBoxColumn queryStage;
        private System.Windows.Forms.DataGridViewTextBoxColumn queryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedDate;
    }
}