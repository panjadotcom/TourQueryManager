namespace TourQueryManager
{
    partial class FrmQueryWorkingPage
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
            this.dataGrdVuWorkingHotels = new System.Windows.Forms.DataGridView();
            this.txtboxQueryDetails = new System.Windows.Forms.TextBox();
            this.lblQueryDetails = new System.Windows.Forms.Label();
            this.CmbboxWrkngHtlSector = new System.Windows.Forms.ComboBox();
            this.CmbboxWrkngHtlLocation = new System.Windows.Forms.ComboBox();
            this.CmbboxWrkngHtlRoomType = new System.Windows.Forms.ComboBox();
            this.CmbboxWrkngHtlHotel = new System.Windows.Forms.ComboBox();
            this.CmbboxWrkngHtlMealPlan = new System.Windows.Forms.ComboBox();
            this.numericUpDownExtraBed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownExtraMeal = new System.Windows.Forms.NumericUpDown();
            this.buttonHotelAddRow = new System.Windows.Forms.Button();
            this.labelWorkingHotelExtraBed = new System.Windows.Forms.Label();
            this.labelWorkingHotelExtraMeal = new System.Windows.Forms.Label();
            this.openFileDialogForHotelExcel = new System.Windows.Forms.OpenFileDialog();
            this.ButtonSelectHotelExcelFile = new System.Windows.Forms.Button();
            this.lblWorkingHotelSector = new System.Windows.Forms.Label();
            this.lblWorkingHotelCity = new System.Windows.Forms.Label();
            this.lblWorkingHotelHotel = new System.Windows.Forms.Label();
            this.lblWorkingHotelRoomType = new System.Windows.Forms.Label();
            this.numericUpDownRoomNo = new System.Windows.Forms.NumericUpDown();
            this.lblWorkingHotelRoomNo = new System.Windows.Forms.Label();
            this.lblWorkingHotelMealPlan = new System.Windows.Forms.Label();
            this.lblWorkingHotelDayNo = new System.Windows.Forms.Label();
            this.numericUpDownWorkingHotelDayNo = new System.Windows.Forms.NumericUpDown();
            this.ButtonWorkingDone = new System.Windows.Forms.Button();
            this.ButtonWorkingCancel = new System.Windows.Forms.Button();
            this.DAYS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MealPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtraBed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtraMeal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdVuWorkingHotels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExtraBed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExtraMeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoomNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkingHotelDayNo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrdVuWorkingHotels
            // 
            this.dataGrdVuWorkingHotels.AllowUserToAddRows = false;
            this.dataGrdVuWorkingHotels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrdVuWorkingHotels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DAYS,
            this.RoomNo,
            this.Sector,
            this.Location,
            this.Hotel,
            this.RoomType,
            this.MealPlan,
            this.ExtraBed,
            this.ExtraMeal,
            this.HotelPrice});
            this.dataGrdVuWorkingHotels.Location = new System.Drawing.Point(12, 169);
            this.dataGrdVuWorkingHotels.MultiSelect = false;
            this.dataGrdVuWorkingHotels.Name = "dataGrdVuWorkingHotels";
            this.dataGrdVuWorkingHotels.ReadOnly = true;
            this.dataGrdVuWorkingHotels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrdVuWorkingHotels.Size = new System.Drawing.Size(1187, 188);
            this.dataGrdVuWorkingHotels.TabIndex = 0;
            // 
            // txtboxQueryDetails
            // 
            this.txtboxQueryDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxQueryDetails.Location = new System.Drawing.Point(12, 65);
            this.txtboxQueryDetails.Multiline = true;
            this.txtboxQueryDetails.Name = "txtboxQueryDetails";
            this.txtboxQueryDetails.ReadOnly = true;
            this.txtboxQueryDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxQueryDetails.Size = new System.Drawing.Size(1187, 98);
            this.txtboxQueryDetails.TabIndex = 1;
            // 
            // lblQueryDetails
            // 
            this.lblQueryDetails.AutoSize = true;
            this.lblQueryDetails.Location = new System.Drawing.Point(12, 49);
            this.lblQueryDetails.Name = "lblQueryDetails";
            this.lblQueryDetails.Size = new System.Drawing.Size(93, 13);
            this.lblQueryDetails.TabIndex = 2;
            this.lblQueryDetails.Text = "QUERY DETAILS";
            // 
            // CmbboxWrkngHtlSector
            // 
            this.CmbboxWrkngHtlSector.FormattingEnabled = true;
            this.CmbboxWrkngHtlSector.Location = new System.Drawing.Point(231, 363);
            this.CmbboxWrkngHtlSector.Name = "CmbboxWrkngHtlSector";
            this.CmbboxWrkngHtlSector.Size = new System.Drawing.Size(121, 21);
            this.CmbboxWrkngHtlSector.TabIndex = 3;
            this.CmbboxWrkngHtlSector.SelectedIndexChanged += new System.EventHandler(this.CmbboxWrkngHtlSector_SelectedIndexChanged);
            // 
            // CmbboxWrkngHtlLocation
            // 
            this.CmbboxWrkngHtlLocation.FormattingEnabled = true;
            this.CmbboxWrkngHtlLocation.Location = new System.Drawing.Point(231, 390);
            this.CmbboxWrkngHtlLocation.Name = "CmbboxWrkngHtlLocation";
            this.CmbboxWrkngHtlLocation.Size = new System.Drawing.Size(121, 21);
            this.CmbboxWrkngHtlLocation.TabIndex = 3;
            this.CmbboxWrkngHtlLocation.SelectedIndexChanged += new System.EventHandler(this.CmbboxWrkngHtlLocation_SelectedIndexChanged);
            // 
            // CmbboxWrkngHtlRoomType
            // 
            this.CmbboxWrkngHtlRoomType.FormattingEnabled = true;
            this.CmbboxWrkngHtlRoomType.Location = new System.Drawing.Point(458, 389);
            this.CmbboxWrkngHtlRoomType.Name = "CmbboxWrkngHtlRoomType";
            this.CmbboxWrkngHtlRoomType.Size = new System.Drawing.Size(121, 21);
            this.CmbboxWrkngHtlRoomType.TabIndex = 3;
            // 
            // CmbboxWrkngHtlHotel
            // 
            this.CmbboxWrkngHtlHotel.FormattingEnabled = true;
            this.CmbboxWrkngHtlHotel.Location = new System.Drawing.Point(458, 362);
            this.CmbboxWrkngHtlHotel.Name = "CmbboxWrkngHtlHotel";
            this.CmbboxWrkngHtlHotel.Size = new System.Drawing.Size(121, 21);
            this.CmbboxWrkngHtlHotel.TabIndex = 3;
            this.CmbboxWrkngHtlHotel.SelectedIndexChanged += new System.EventHandler(this.CmbboxWrkngHtlHotel_SelectedIndexChanged);
            // 
            // CmbboxWrkngHtlMealPlan
            // 
            this.CmbboxWrkngHtlMealPlan.FormattingEnabled = true;
            this.CmbboxWrkngHtlMealPlan.Location = new System.Drawing.Point(832, 363);
            this.CmbboxWrkngHtlMealPlan.Name = "CmbboxWrkngHtlMealPlan";
            this.CmbboxWrkngHtlMealPlan.Size = new System.Drawing.Size(172, 21);
            this.CmbboxWrkngHtlMealPlan.TabIndex = 3;
            // 
            // numericUpDownExtraBed
            // 
            this.numericUpDownExtraBed.Location = new System.Drawing.Point(832, 389);
            this.numericUpDownExtraBed.Name = "numericUpDownExtraBed";
            this.numericUpDownExtraBed.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownExtraBed.TabIndex = 4;
            // 
            // numericUpDownExtraMeal
            // 
            this.numericUpDownExtraMeal.Location = new System.Drawing.Point(965, 391);
            this.numericUpDownExtraMeal.Name = "numericUpDownExtraMeal";
            this.numericUpDownExtraMeal.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownExtraMeal.TabIndex = 4;
            // 
            // buttonHotelAddRow
            // 
            this.buttonHotelAddRow.Location = new System.Drawing.Point(1102, 363);
            this.buttonHotelAddRow.Name = "buttonHotelAddRow";
            this.buttonHotelAddRow.Size = new System.Drawing.Size(97, 23);
            this.buttonHotelAddRow.TabIndex = 5;
            this.buttonHotelAddRow.Text = "ADD";
            this.buttonHotelAddRow.UseVisualStyleBackColor = true;
            this.buttonHotelAddRow.Click += new System.EventHandler(this.buttonHotelAddRow_Click);
            // 
            // labelWorkingHotelExtraBed
            // 
            this.labelWorkingHotelExtraBed.AutoSize = true;
            this.labelWorkingHotelExtraBed.Location = new System.Drawing.Point(744, 393);
            this.labelWorkingHotelExtraBed.Name = "labelWorkingHotelExtraBed";
            this.labelWorkingHotelExtraBed.Size = new System.Drawing.Size(75, 13);
            this.labelWorkingHotelExtraBed.TabIndex = 6;
            this.labelWorkingHotelExtraBed.Text = "EXTRA BEDS";
            // 
            // labelWorkingHotelExtraMeal
            // 
            this.labelWorkingHotelExtraMeal.AutoSize = true;
            this.labelWorkingHotelExtraMeal.Location = new System.Drawing.Point(877, 393);
            this.labelWorkingHotelExtraMeal.Name = "labelWorkingHotelExtraMeal";
            this.labelWorkingHotelExtraMeal.Size = new System.Drawing.Size(82, 13);
            this.labelWorkingHotelExtraMeal.TabIndex = 6;
            this.labelWorkingHotelExtraMeal.Text = "EXTRA MEALS";
            // 
            // openFileDialogForHotelExcel
            // 
            this.openFileDialogForHotelExcel.DefaultExt = "xls";
            this.openFileDialogForHotelExcel.Filter = "Excel 2007 file (*.xls)|*.xls|Excel 2010 file (*.xlsx)|*.xlsx|All (*.*)|*.*";
            this.openFileDialogForHotelExcel.Title = "Select Excel file for Hotel Listing";
            // 
            // ButtonSelectHotelExcelFile
            // 
            this.ButtonSelectHotelExcelFile.Location = new System.Drawing.Point(12, 363);
            this.ButtonSelectHotelExcelFile.Name = "ButtonSelectHotelExcelFile";
            this.ButtonSelectHotelExcelFile.Size = new System.Drawing.Size(144, 23);
            this.ButtonSelectHotelExcelFile.TabIndex = 5;
            this.ButtonSelectHotelExcelFile.Text = "SELECT HOTEL EXCEL";
            this.ButtonSelectHotelExcelFile.UseVisualStyleBackColor = true;
            this.ButtonSelectHotelExcelFile.Click += new System.EventHandler(this.ButtonSelectHotelExcelFile_Click);
            // 
            // lblWorkingHotelSector
            // 
            this.lblWorkingHotelSector.AutoSize = true;
            this.lblWorkingHotelSector.Location = new System.Drawing.Point(162, 368);
            this.lblWorkingHotelSector.Name = "lblWorkingHotelSector";
            this.lblWorkingHotelSector.Size = new System.Drawing.Size(51, 13);
            this.lblWorkingHotelSector.TabIndex = 6;
            this.lblWorkingHotelSector.Text = "SECTOR";
            // 
            // lblWorkingHotelCity
            // 
            this.lblWorkingHotelCity.AutoSize = true;
            this.lblWorkingHotelCity.Location = new System.Drawing.Point(162, 393);
            this.lblWorkingHotelCity.Name = "lblWorkingHotelCity";
            this.lblWorkingHotelCity.Size = new System.Drawing.Size(31, 13);
            this.lblWorkingHotelCity.TabIndex = 6;
            this.lblWorkingHotelCity.Text = "CITY";
            // 
            // lblWorkingHotelHotel
            // 
            this.lblWorkingHotelHotel.AutoSize = true;
            this.lblWorkingHotelHotel.Location = new System.Drawing.Point(409, 365);
            this.lblWorkingHotelHotel.Name = "lblWorkingHotelHotel";
            this.lblWorkingHotelHotel.Size = new System.Drawing.Size(43, 13);
            this.lblWorkingHotelHotel.TabIndex = 6;
            this.lblWorkingHotelHotel.Text = "HOTEL";
            // 
            // lblWorkingHotelRoomType
            // 
            this.lblWorkingHotelRoomType.AutoSize = true;
            this.lblWorkingHotelRoomType.Location = new System.Drawing.Point(381, 393);
            this.lblWorkingHotelRoomType.Name = "lblWorkingHotelRoomType";
            this.lblWorkingHotelRoomType.Size = new System.Drawing.Size(71, 13);
            this.lblWorkingHotelRoomType.TabIndex = 6;
            this.lblWorkingHotelRoomType.Text = "ROOM TYPE";
            // 
            // numericUpDownRoomNo
            // 
            this.numericUpDownRoomNo.Location = new System.Drawing.Point(690, 389);
            this.numericUpDownRoomNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRoomNo.Name = "numericUpDownRoomNo";
            this.numericUpDownRoomNo.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownRoomNo.TabIndex = 4;
            this.numericUpDownRoomNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblWorkingHotelRoomNo
            // 
            this.lblWorkingHotelRoomNo.AutoSize = true;
            this.lblWorkingHotelRoomNo.Location = new System.Drawing.Point(607, 392);
            this.lblWorkingHotelRoomNo.Name = "lblWorkingHotelRoomNo";
            this.lblWorkingHotelRoomNo.Size = new System.Drawing.Size(62, 13);
            this.lblWorkingHotelRoomNo.TabIndex = 6;
            this.lblWorkingHotelRoomNo.Text = "ROOM NO.";
            // 
            // lblWorkingHotelMealPlan
            // 
            this.lblWorkingHotelMealPlan.AutoSize = true;
            this.lblWorkingHotelMealPlan.Location = new System.Drawing.Point(759, 366);
            this.lblWorkingHotelMealPlan.Name = "lblWorkingHotelMealPlan";
            this.lblWorkingHotelMealPlan.Size = new System.Drawing.Size(67, 13);
            this.lblWorkingHotelMealPlan.TabIndex = 6;
            this.lblWorkingHotelMealPlan.Text = "MEAL PLAN";
            // 
            // lblWorkingHotelDayNo
            // 
            this.lblWorkingHotelDayNo.AutoSize = true;
            this.lblWorkingHotelDayNo.Location = new System.Drawing.Point(607, 366);
            this.lblWorkingHotelDayNo.Name = "lblWorkingHotelDayNo";
            this.lblWorkingHotelDayNo.Size = new System.Drawing.Size(51, 13);
            this.lblWorkingHotelDayNo.TabIndex = 8;
            this.lblWorkingHotelDayNo.Text = "DAY NO.";
            // 
            // numericUpDownWorkingHotelDayNo
            // 
            this.numericUpDownWorkingHotelDayNo.Location = new System.Drawing.Point(690, 363);
            this.numericUpDownWorkingHotelDayNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWorkingHotelDayNo.Name = "numericUpDownWorkingHotelDayNo";
            this.numericUpDownWorkingHotelDayNo.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownWorkingHotelDayNo.TabIndex = 7;
            this.numericUpDownWorkingHotelDayNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ButtonWorkingDone
            // 
            this.ButtonWorkingDone.Location = new System.Drawing.Point(1102, 579);
            this.ButtonWorkingDone.Name = "ButtonWorkingDone";
            this.ButtonWorkingDone.Size = new System.Drawing.Size(97, 23);
            this.ButtonWorkingDone.TabIndex = 5;
            this.ButtonWorkingDone.Text = "DONE";
            this.ButtonWorkingDone.UseVisualStyleBackColor = true;
            this.ButtonWorkingDone.Click += new System.EventHandler(this.ButtonWorkingDone_Click);
            // 
            // ButtonWorkingCancel
            // 
            this.ButtonWorkingCancel.Location = new System.Drawing.Point(999, 579);
            this.ButtonWorkingCancel.Name = "ButtonWorkingCancel";
            this.ButtonWorkingCancel.Size = new System.Drawing.Size(97, 23);
            this.ButtonWorkingCancel.TabIndex = 5;
            this.ButtonWorkingCancel.Text = "CANCEL";
            this.ButtonWorkingCancel.UseVisualStyleBackColor = true;
            this.ButtonWorkingCancel.Click += new System.EventHandler(this.ButtonWorkingCancel_Click);
            // 
            // DAYS
            // 
            this.DAYS.HeaderText = "DAY";
            this.DAYS.Name = "DAYS";
            this.DAYS.ReadOnly = true;
            this.DAYS.Width = 50;
            // 
            // RoomNo
            // 
            this.RoomNo.HeaderText = "ROOM";
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.ReadOnly = true;
            this.RoomNo.Width = 50;
            // 
            // Sector
            // 
            this.Sector.HeaderText = "SECTOR";
            this.Sector.Name = "Sector";
            this.Sector.ReadOnly = true;
            this.Sector.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sector.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Sector.Width = 150;
            // 
            // Location
            // 
            this.Location.HeaderText = "LOCATION";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            this.Location.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Location.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Location.Width = 150;
            // 
            // Hotel
            // 
            this.Hotel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Hotel.HeaderText = "HOTEL";
            this.Hotel.Name = "Hotel";
            this.Hotel.ReadOnly = true;
            this.Hotel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hotel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RoomType
            // 
            this.RoomType.HeaderText = "ROOM TYPE";
            this.RoomType.Name = "RoomType";
            this.RoomType.ReadOnly = true;
            this.RoomType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MealPlan
            // 
            this.MealPlan.HeaderText = "MEAL PLAN";
            this.MealPlan.Name = "MealPlan";
            this.MealPlan.ReadOnly = true;
            this.MealPlan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MealPlan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ExtraBed
            // 
            this.ExtraBed.HeaderText = "EXTRA BED";
            this.ExtraBed.Name = "ExtraBed";
            this.ExtraBed.ReadOnly = true;
            this.ExtraBed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ExtraBed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ExtraMeal
            // 
            this.ExtraMeal.HeaderText = "EXTRA MEAL";
            this.ExtraMeal.Name = "ExtraMeal";
            this.ExtraMeal.ReadOnly = true;
            this.ExtraMeal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ExtraMeal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HotelPrice
            // 
            this.HotelPrice.HeaderText = "PRICE";
            this.HotelPrice.Name = "HotelPrice";
            this.HotelPrice.ReadOnly = true;
            this.HotelPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmQueryWorkingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 614);
            this.Controls.Add(this.lblWorkingHotelDayNo);
            this.Controls.Add(this.numericUpDownWorkingHotelDayNo);
            this.Controls.Add(this.labelWorkingHotelExtraMeal);
            this.Controls.Add(this.lblWorkingHotelMealPlan);
            this.Controls.Add(this.lblWorkingHotelRoomNo);
            this.Controls.Add(this.labelWorkingHotelExtraBed);
            this.Controls.Add(this.lblWorkingHotelRoomType);
            this.Controls.Add(this.lblWorkingHotelHotel);
            this.Controls.Add(this.lblWorkingHotelCity);
            this.Controls.Add(this.lblWorkingHotelSector);
            this.Controls.Add(this.ButtonSelectHotelExcelFile);
            this.Controls.Add(this.ButtonWorkingCancel);
            this.Controls.Add(this.ButtonWorkingDone);
            this.Controls.Add(this.buttonHotelAddRow);
            this.Controls.Add(this.numericUpDownExtraMeal);
            this.Controls.Add(this.numericUpDownRoomNo);
            this.Controls.Add(this.numericUpDownExtraBed);
            this.Controls.Add(this.CmbboxWrkngHtlHotel);
            this.Controls.Add(this.CmbboxWrkngHtlMealPlan);
            this.Controls.Add(this.CmbboxWrkngHtlRoomType);
            this.Controls.Add(this.CmbboxWrkngHtlLocation);
            this.Controls.Add(this.CmbboxWrkngHtlSector);
            this.Controls.Add(this.lblQueryDetails);
            this.Controls.Add(this.txtboxQueryDetails);
            this.Controls.Add(this.dataGrdVuWorkingHotels);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQueryWorkingPage";
            this.Text = "Working";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmQueryWorkingPage_FormClosing);
            this.Load += new System.EventHandler(this.FrmQueryWorkingPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdVuWorkingHotels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExtraBed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExtraMeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoomNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkingHotelDayNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrdVuWorkingHotels;
        private System.Windows.Forms.TextBox txtboxQueryDetails;
        private System.Windows.Forms.Label lblQueryDetails;
        private System.Windows.Forms.ComboBox CmbboxWrkngHtlSector;
        private System.Windows.Forms.ComboBox CmbboxWrkngHtlLocation;
        private System.Windows.Forms.ComboBox CmbboxWrkngHtlRoomType;
        private System.Windows.Forms.ComboBox CmbboxWrkngHtlHotel;
        private System.Windows.Forms.ComboBox CmbboxWrkngHtlMealPlan;
        private System.Windows.Forms.NumericUpDown numericUpDownExtraBed;
        private System.Windows.Forms.NumericUpDown numericUpDownExtraMeal;
        private System.Windows.Forms.Button buttonHotelAddRow;
        private System.Windows.Forms.Label labelWorkingHotelExtraBed;
        private System.Windows.Forms.Label labelWorkingHotelExtraMeal;
        private System.Windows.Forms.OpenFileDialog openFileDialogForHotelExcel;
        private System.Windows.Forms.Button ButtonSelectHotelExcelFile;
        private System.Windows.Forms.Label lblWorkingHotelSector;
        private System.Windows.Forms.Label lblWorkingHotelCity;
        private System.Windows.Forms.Label lblWorkingHotelHotel;
        private System.Windows.Forms.Label lblWorkingHotelRoomType;
        private System.Windows.Forms.NumericUpDown numericUpDownRoomNo;
        private System.Windows.Forms.Label lblWorkingHotelRoomNo;
        private System.Windows.Forms.Label lblWorkingHotelMealPlan;
        private System.Windows.Forms.Label lblWorkingHotelDayNo;
        private System.Windows.Forms.NumericUpDown numericUpDownWorkingHotelDayNo;
        private System.Windows.Forms.Button ButtonWorkingDone;
        private System.Windows.Forms.Button ButtonWorkingCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAYS;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MealPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtraBed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtraMeal;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelPrice;
    }
}