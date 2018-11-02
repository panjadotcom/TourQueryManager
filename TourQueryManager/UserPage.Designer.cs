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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserPage));
            this.BtnExit = new System.Windows.Forms.Button();
            this.DataGrdVuUserQueries = new System.Windows.Forms.DataGridView();
            this.QueryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueryState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnHotelInfo = new System.Windows.Forms.Button();
            this.grpBoxQueries = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelQueryOptions = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonCompletedItinerary = new System.Windows.Forms.RadioButton();
            this.radioButtonAllQueries = new System.Windows.Forms.RadioButton();
            this.radioButtonWorkingVouchers = new System.Windows.Forms.RadioButton();
            this.radioButtonWorkingItinary = new System.Windows.Forms.RadioButton();
            this.radioButtonCompletedBooking = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrdVuUserQueries)).BeginInit();
            this.grpBoxQueries.SuspendLayout();
            this.tableLayoutPanelQueryOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.Location = new System.Drawing.Point(778, 249);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(150, 27);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // DataGrdVuUserQueries
            // 
            this.DataGrdVuUserQueries.AllowUserToAddRows = false;
            this.DataGrdVuUserQueries.AllowUserToDeleteRows = false;
            this.DataGrdVuUserQueries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrdVuUserQueries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrdVuUserQueries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QueryId,
            this.QueryState,
            this.Location,
            this.fromDate,
            this.toDate,
            this.AssignedDate});
            this.DataGrdVuUserQueries.Location = new System.Drawing.Point(12, 90);
            this.DataGrdVuUserQueries.Name = "DataGrdVuUserQueries";
            this.DataGrdVuUserQueries.ReadOnly = true;
            this.DataGrdVuUserQueries.RowHeadersVisible = false;
            this.DataGrdVuUserQueries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrdVuUserQueries.Size = new System.Drawing.Size(916, 150);
            this.DataGrdVuUserQueries.TabIndex = 3;
            this.DataGrdVuUserQueries.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrdVuUserQueries_CellContentDoubleClick);
            // 
            // QueryId
            // 
            this.QueryId.HeaderText = "QUERY ID";
            this.QueryId.Name = "QueryId";
            this.QueryId.ReadOnly = true;
            this.QueryId.Width = 150;
            // 
            // QueryState
            // 
            this.QueryState.HeaderText = "STATE";
            this.QueryState.Name = "QueryState";
            this.QueryState.ReadOnly = true;
            this.QueryState.Width = 50;
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
            // BtnHotelInfo
            // 
            this.BtnHotelInfo.AutoSize = true;
            this.BtnHotelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnHotelInfo.Location = new System.Drawing.Point(758, 3);
            this.BtnHotelInfo.Name = "BtnHotelInfo";
            this.BtnHotelInfo.Size = new System.Drawing.Size(149, 53);
            this.BtnHotelInfo.TabIndex = 4;
            this.BtnHotelInfo.Text = "HOTEL INFIRMATION";
            this.BtnHotelInfo.UseVisualStyleBackColor = true;
            this.BtnHotelInfo.Click += new System.EventHandler(this.BtnHotelInfo_Click);
            // 
            // grpBoxQueries
            // 
            this.grpBoxQueries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxQueries.Controls.Add(this.tableLayoutPanelQueryOptions);
            this.grpBoxQueries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxQueries.Location = new System.Drawing.Point(12, 12);
            this.grpBoxQueries.Name = "grpBoxQueries";
            this.grpBoxQueries.Size = new System.Drawing.Size(916, 78);
            this.grpBoxQueries.TabIndex = 5;
            this.grpBoxQueries.TabStop = false;
            // 
            // tableLayoutPanelQueryOptions
            // 
            this.tableLayoutPanelQueryOptions.ColumnCount = 6;
            this.tableLayoutPanelQueryOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelQueryOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelQueryOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelQueryOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelQueryOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelQueryOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelQueryOptions.Controls.Add(this.radioButtonCompletedItinerary, 1, 0);
            this.tableLayoutPanelQueryOptions.Controls.Add(this.radioButtonAllQueries, 4, 0);
            this.tableLayoutPanelQueryOptions.Controls.Add(this.BtnHotelInfo, 5, 0);
            this.tableLayoutPanelQueryOptions.Controls.Add(this.radioButtonWorkingVouchers, 2, 0);
            this.tableLayoutPanelQueryOptions.Controls.Add(this.radioButtonWorkingItinary, 0, 0);
            this.tableLayoutPanelQueryOptions.Controls.Add(this.radioButtonCompletedBooking, 3, 0);
            this.tableLayoutPanelQueryOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelQueryOptions.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelQueryOptions.Name = "tableLayoutPanelQueryOptions";
            this.tableLayoutPanelQueryOptions.RowCount = 1;
            this.tableLayoutPanelQueryOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelQueryOptions.Size = new System.Drawing.Size(910, 59);
            this.tableLayoutPanelQueryOptions.TabIndex = 0;
            // 
            // radioButtonCompletedItinerary
            // 
            this.radioButtonCompletedItinerary.AutoSize = true;
            this.radioButtonCompletedItinerary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonCompletedItinerary.Location = new System.Drawing.Point(305, 3);
            this.radioButtonCompletedItinerary.Name = "radioButtonCompletedItinerary";
            this.radioButtonCompletedItinerary.Size = new System.Drawing.Size(145, 53);
            this.radioButtonCompletedItinerary.TabIndex = 7;
            this.radioButtonCompletedItinerary.TabStop = true;
            this.radioButtonCompletedItinerary.Text = "COMPLETED ITINERARY";
            this.radioButtonCompletedItinerary.UseVisualStyleBackColor = true;
            this.radioButtonCompletedItinerary.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButtonAllQueries
            // 
            this.radioButtonAllQueries.AutoSize = true;
            this.radioButtonAllQueries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonAllQueries.Location = new System.Drawing.Point(607, 3);
            this.radioButtonAllQueries.Name = "radioButtonAllQueries";
            this.radioButtonAllQueries.Size = new System.Drawing.Size(145, 53);
            this.radioButtonAllQueries.TabIndex = 5;
            this.radioButtonAllQueries.TabStop = true;
            this.radioButtonAllQueries.Text = "ALL QUERIES";
            this.radioButtonAllQueries.UseVisualStyleBackColor = true;
            this.radioButtonAllQueries.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButtonWorkingVouchers
            // 
            this.radioButtonWorkingVouchers.AutoSize = true;
            this.radioButtonWorkingVouchers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonWorkingVouchers.Location = new System.Drawing.Point(154, 3);
            this.radioButtonWorkingVouchers.Name = "radioButtonWorkingVouchers";
            this.radioButtonWorkingVouchers.Size = new System.Drawing.Size(145, 53);
            this.radioButtonWorkingVouchers.TabIndex = 0;
            this.radioButtonWorkingVouchers.TabStop = true;
            this.radioButtonWorkingVouchers.Text = "PENDING BOOKING";
            this.radioButtonWorkingVouchers.UseVisualStyleBackColor = true;
            this.radioButtonWorkingVouchers.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButtonWorkingItinary
            // 
            this.radioButtonWorkingItinary.AutoSize = true;
            this.radioButtonWorkingItinary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonWorkingItinary.Location = new System.Drawing.Point(3, 3);
            this.radioButtonWorkingItinary.Name = "radioButtonWorkingItinary";
            this.radioButtonWorkingItinary.Size = new System.Drawing.Size(145, 53);
            this.radioButtonWorkingItinary.TabIndex = 1;
            this.radioButtonWorkingItinary.TabStop = true;
            this.radioButtonWorkingItinary.Text = "PENDING ITINERARY";
            this.radioButtonWorkingItinary.UseVisualStyleBackColor = true;
            this.radioButtonWorkingItinary.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButtonCompletedBooking
            // 
            this.radioButtonCompletedBooking.AutoSize = true;
            this.radioButtonCompletedBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonCompletedBooking.Location = new System.Drawing.Point(456, 3);
            this.radioButtonCompletedBooking.Name = "radioButtonCompletedBooking";
            this.radioButtonCompletedBooking.Size = new System.Drawing.Size(145, 53);
            this.radioButtonCompletedBooking.TabIndex = 3;
            this.radioButtonCompletedBooking.TabStop = true;
            this.radioButtonCompletedBooking.Text = "COMPLETED BOOKING";
            this.radioButtonCompletedBooking.UseVisualStyleBackColor = true;
            this.radioButtonCompletedBooking.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // FrmUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 288);
            this.Controls.Add(this.grpBoxQueries);
            this.Controls.Add(this.DataGrdVuUserQueries);
            this.Controls.Add(this.BtnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmUserPage";
            this.Text = "User";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrdVuUserQueries)).EndInit();
            this.grpBoxQueries.ResumeLayout(false);
            this.tableLayoutPanelQueryOptions.ResumeLayout(false);
            this.tableLayoutPanelQueryOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.DataGridView DataGrdVuUserQueries;
        private System.Windows.Forms.Button BtnHotelInfo;
        private System.Windows.Forms.GroupBox grpBoxQueries;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelQueryOptions;
        private System.Windows.Forms.RadioButton radioButtonCompletedItinerary;
        private System.Windows.Forms.RadioButton radioButtonAllQueries;
        private System.Windows.Forms.RadioButton radioButtonWorkingVouchers;
        private System.Windows.Forms.RadioButton radioButtonWorkingItinary;
        private System.Windows.Forms.RadioButton radioButtonCompletedBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueryState;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignedDate;
    }
}