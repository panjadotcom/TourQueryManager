namespace TourQueryManager
{
    partial class FrmUserPage
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
            this.BtnAssignQueries = new System.Windows.Forms.Button();
            this.BtnCompletedQueries = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.DataGrdVuUserQueries = new System.Windows.Forms.DataGridView();
            this.QueryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrdVuUserQueries)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAssignQueries
            // 
            this.BtnAssignQueries.Location = new System.Drawing.Point(97, 12);
            this.BtnAssignQueries.Name = "BtnAssignQueries";
            this.BtnAssignQueries.Size = new System.Drawing.Size(120, 34);
            this.BtnAssignQueries.TabIndex = 0;
            this.BtnAssignQueries.Text = "Assigned Queries";
            this.BtnAssignQueries.UseVisualStyleBackColor = true;
            this.BtnAssignQueries.Click += new System.EventHandler(this.BtnAssignQueries_Click);
            // 
            // BtnCompletedQueries
            // 
            this.BtnCompletedQueries.Location = new System.Drawing.Point(289, 12);
            this.BtnCompletedQueries.Name = "BtnCompletedQueries";
            this.BtnCompletedQueries.Size = new System.Drawing.Size(120, 34);
            this.BtnCompletedQueries.TabIndex = 1;
            this.BtnCompletedQueries.Text = "Completed Queries";
            this.BtnCompletedQueries.UseVisualStyleBackColor = true;
            this.BtnCompletedQueries.Click += new System.EventHandler(this.BtnCompletedQueries_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(860, 259);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(77, 27);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // DataGrdVuUserQueries
            // 
            this.DataGrdVuUserQueries.AllowUserToAddRows = false;
            this.DataGrdVuUserQueries.AllowUserToDeleteRows = false;
            this.DataGrdVuUserQueries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrdVuUserQueries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QueryId,
            this.Location,
            this.fromDate,
            this.toDate,
            this.AssignedDate});
            this.DataGrdVuUserQueries.Location = new System.Drawing.Point(12, 52);
            this.DataGrdVuUserQueries.Name = "DataGrdVuUserQueries";
            this.DataGrdVuUserQueries.ReadOnly = true;
            this.DataGrdVuUserQueries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrdVuUserQueries.Size = new System.Drawing.Size(925, 150);
            this.DataGrdVuUserQueries.TabIndex = 3;
            this.DataGrdVuUserQueries.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrdVuUserQueries_CellContentDoubleClick);
            // 
            // QueryId
            // 
            this.QueryId.HeaderText = "QUERY ID";
            this.QueryId.Name = "QueryId";
            this.QueryId.ReadOnly = true;
            this.QueryId.Width = 200;
            // 
            // Location
            // 
            this.Location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Location.HeaderText = "LOCATION";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // fromDate
            // 
            this.fromDate.HeaderText = "FROM DATE";
            this.fromDate.Name = "fromDate";
            this.fromDate.ReadOnly = true;
            this.fromDate.Width = 125;
            // 
            // toDate
            // 
            this.toDate.HeaderText = "TO DATE";
            this.toDate.Name = "toDate";
            this.toDate.ReadOnly = true;
            this.toDate.Width = 125;
            // 
            // AssignedDate
            // 
            this.AssignedDate.HeaderText = "ASSIGNED DATE";
            this.AssignedDate.Name = "AssignedDate";
            this.AssignedDate.ReadOnly = true;
            this.AssignedDate.Width = 125;
            // 
            // FrmUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 298);
            this.Controls.Add(this.DataGrdVuUserQueries);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnCompletedQueries);
            this.Controls.Add(this.BtnAssignQueries);
            this.MaximizeBox = false;
            this.Name = "FrmUserPage";
            this.Text = "User";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrdVuUserQueries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAssignQueries;
        private System.Windows.Forms.Button BtnCompletedQueries;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.DataGridView DataGrdVuUserQueries;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedDate;
    }
}