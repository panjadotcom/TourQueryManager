﻿namespace TourQueryManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQueryWorkingPage));
            this.dataGrdVuWorkingHotels = new System.Windows.Forms.DataGridView();
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
            this.txtboxQueryDetails = new System.Windows.Forms.TextBox();
            this.lblQueryDetails = new System.Windows.Forms.Label();
            this.CmbboxWrkngHtlSector = new System.Windows.Forms.ComboBox();
            this.CmbboxWrkngHtlLocation = new System.Windows.Forms.ComboBox();
            this.CmbboxWrkngHtlRoomType = new System.Windows.Forms.ComboBox();
            this.CmbboxWrkngHtlHotel = new System.Windows.Forms.ComboBox();
            this.CmbboxWrkngHtlMealPlan = new System.Windows.Forms.ComboBox();
            this.numericUpDownNoOfPersons = new System.Windows.Forms.NumericUpDown();
            this.buttonHotelAddRow = new System.Windows.Forms.Button();
            this.labelWorkingHotelNoOfPersons = new System.Windows.Forms.Label();
            this.openFileDialogForHotelExcel = new System.Windows.Forms.OpenFileDialog();
            this.lblWorkingHotelSector = new System.Windows.Forms.Label();
            this.lblWorkingHotelCity = new System.Windows.Forms.Label();
            this.lblWorkingHotelHotel = new System.Windows.Forms.Label();
            this.lblWrkngHotelRoomType = new System.Windows.Forms.Label();
            this.lblWrkngHotelRoomInfo = new System.Windows.Forms.Label();
            this.lblWorkingHotelMealPlan = new System.Windows.Forms.Label();
            this.ButtonWorkingDone = new System.Windows.Forms.Button();
            this.ButtonWorkingCancel = new System.Windows.Forms.Button();
            this.lblWorkingDayAndHotelRoomInfo = new System.Windows.Forms.Label();
            this.lblWorkingArrivalTime = new System.Windows.Forms.Label();
            this.lblWorkingHotelInfo = new System.Windows.Forms.Label();
            this.lblWorkingTravelInfo = new System.Windows.Forms.Label();
            this.lblWrkngCarType = new System.Windows.Forms.Label();
            this.CmbboxWrkngCarType = new System.Windows.Forms.ComboBox();
            this.lblWrkngNoOfCars = new System.Windows.Forms.Label();
            this.numericUpDownNoOfCars = new System.Windows.Forms.NumericUpDown();
            this.lblWrkngCarPurpose = new System.Windows.Forms.Label();
            this.CmbboxWrkngCarPurpose = new System.Windows.Forms.ComboBox();
            this.lblWorkingNoOfGuids = new System.Windows.Forms.Label();
            this.lblWorkingNoOfSims = new System.Windows.Forms.Label();
            this.lblWorkingUserComment = new System.Windows.Forms.Label();
            this.lblWorkingAdditionalCost = new System.Windows.Forms.Label();
            this.txtboxWorkingAdditionalCost = new System.Windows.Forms.TextBox();
            this.txtboxWorkingUserComment = new System.Windows.Forms.TextBox();
            this.dttmpkrWorkingArvlTime = new System.Windows.Forms.DateTimePicker();
            this.chkBoxWorkingGuide = new System.Windows.Forms.CheckBox();
            this.chkBoxWorkingSim = new System.Windows.Forms.CheckBox();
            this.lblWorkingRoomNo = new System.Windows.Forms.Label();
            this.numericUpDownWorkingRoomNo = new System.Windows.Forms.NumericUpDown();
            this.btnWorkingAddRoom = new System.Windows.Forms.Button();
            this.txtboxWorkingNarration = new System.Windows.Forms.TextBox();
            this.lblWorkingNarration = new System.Windows.Forms.Label();
            this.dataGridViewRoomsInfo = new System.Windows.Forms.DataGridView();
            this.numericUpDownWorkingDayNo = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerWorkingArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.lblWorkingHotelRating = new System.Windows.Forms.Label();
            this.CmbboxWrkngHtlHotelRating = new System.Windows.Forms.ComboBox();
            this.wrkRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrkRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrkMealPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrkExtraBed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrkPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdVuWorkingHotels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkingRoomNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomsInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkingDayNo)).BeginInit();
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
            this.dataGrdVuWorkingHotels.Location = new System.Drawing.Point(15, 481);
            this.dataGrdVuWorkingHotels.MultiSelect = false;
            this.dataGrdVuWorkingHotels.Name = "dataGrdVuWorkingHotels";
            this.dataGrdVuWorkingHotels.ReadOnly = true;
            this.dataGrdVuWorkingHotels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrdVuWorkingHotels.Size = new System.Drawing.Size(1187, 162);
            this.dataGrdVuWorkingHotels.TabIndex = 0;
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
            // txtboxQueryDetails
            // 
            this.txtboxQueryDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxQueryDetails.Location = new System.Drawing.Point(15, 25);
            this.txtboxQueryDetails.Multiline = true;
            this.txtboxQueryDetails.Name = "txtboxQueryDetails";
            this.txtboxQueryDetails.ReadOnly = true;
            this.txtboxQueryDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxQueryDetails.Size = new System.Drawing.Size(456, 450);
            this.txtboxQueryDetails.TabIndex = 1;
            // 
            // lblQueryDetails
            // 
            this.lblQueryDetails.AutoSize = true;
            this.lblQueryDetails.Location = new System.Drawing.Point(12, 9);
            this.lblQueryDetails.Name = "lblQueryDetails";
            this.lblQueryDetails.Size = new System.Drawing.Size(93, 13);
            this.lblQueryDetails.TabIndex = 2;
            this.lblQueryDetails.Text = "QUERY DETAILS";
            // 
            // CmbboxWrkngHtlSector
            // 
            this.CmbboxWrkngHtlSector.FormattingEnabled = true;
            this.CmbboxWrkngHtlSector.Location = new System.Drawing.Point(670, 83);
            this.CmbboxWrkngHtlSector.Name = "CmbboxWrkngHtlSector";
            this.CmbboxWrkngHtlSector.Size = new System.Drawing.Size(121, 21);
            this.CmbboxWrkngHtlSector.TabIndex = 2;
            this.CmbboxWrkngHtlSector.SelectedIndexChanged += new System.EventHandler(this.CmbboxWrkngHtlSector_SelectedIndexChanged);
            // 
            // CmbboxWrkngHtlLocation
            // 
            this.CmbboxWrkngHtlLocation.FormattingEnabled = true;
            this.CmbboxWrkngHtlLocation.Location = new System.Drawing.Point(670, 111);
            this.CmbboxWrkngHtlLocation.Name = "CmbboxWrkngHtlLocation";
            this.CmbboxWrkngHtlLocation.Size = new System.Drawing.Size(121, 21);
            this.CmbboxWrkngHtlLocation.TabIndex = 3;
            this.CmbboxWrkngHtlLocation.SelectedIndexChanged += new System.EventHandler(this.CmbboxWrkngHtlLocation_SelectedIndexChanged);
            // 
            // CmbboxWrkngHtlRoomType
            // 
            this.CmbboxWrkngHtlRoomType.FormattingEnabled = true;
            this.CmbboxWrkngHtlRoomType.Location = new System.Drawing.Point(670, 223);
            this.CmbboxWrkngHtlRoomType.Name = "CmbboxWrkngHtlRoomType";
            this.CmbboxWrkngHtlRoomType.Size = new System.Drawing.Size(121, 21);
            this.CmbboxWrkngHtlRoomType.TabIndex = 3;
            this.CmbboxWrkngHtlRoomType.SelectedIndexChanged += new System.EventHandler(this.CmbboxWrkngHtlRoomType_SelectedIndexChanged);
            // 
            // CmbboxWrkngHtlHotel
            // 
            this.CmbboxWrkngHtlHotel.FormattingEnabled = true;
            this.CmbboxWrkngHtlHotel.Location = new System.Drawing.Point(669, 166);
            this.CmbboxWrkngHtlHotel.Name = "CmbboxWrkngHtlHotel";
            this.CmbboxWrkngHtlHotel.Size = new System.Drawing.Size(121, 21);
            this.CmbboxWrkngHtlHotel.TabIndex = 5;
            this.CmbboxWrkngHtlHotel.SelectedIndexChanged += new System.EventHandler(this.CmbboxWrkngHtlHotel_SelectedIndexChanged);
            // 
            // CmbboxWrkngHtlMealPlan
            // 
            this.CmbboxWrkngHtlMealPlan.FormattingEnabled = true;
            this.CmbboxWrkngHtlMealPlan.Location = new System.Drawing.Point(670, 274);
            this.CmbboxWrkngHtlMealPlan.Name = "CmbboxWrkngHtlMealPlan";
            this.CmbboxWrkngHtlMealPlan.Size = new System.Drawing.Size(144, 21);
            this.CmbboxWrkngHtlMealPlan.TabIndex = 3;
            this.CmbboxWrkngHtlMealPlan.SelectedIndexChanged += new System.EventHandler(this.CmbboxWrkngHtlMealPlan_SelectedIndexChanged);
            // 
            // numericUpDownNoOfPersons
            // 
            this.numericUpDownNoOfPersons.Location = new System.Drawing.Point(671, 248);
            this.numericUpDownNoOfPersons.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownNoOfPersons.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNoOfPersons.Name = "numericUpDownNoOfPersons";
            this.numericUpDownNoOfPersons.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownNoOfPersons.TabIndex = 4;
            this.numericUpDownNoOfPersons.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNoOfPersons.ValueChanged += new System.EventHandler(this.numericUpDownExtraBed_ValueChanged);
            // 
            // buttonHotelAddRow
            // 
            this.buttonHotelAddRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHotelAddRow.Location = new System.Drawing.Point(1096, 452);
            this.buttonHotelAddRow.Name = "buttonHotelAddRow";
            this.buttonHotelAddRow.Size = new System.Drawing.Size(97, 23);
            this.buttonHotelAddRow.TabIndex = 5;
            this.buttonHotelAddRow.Text = "NEXT DAY";
            this.buttonHotelAddRow.UseVisualStyleBackColor = true;
            this.buttonHotelAddRow.Click += new System.EventHandler(this.buttonHotelAddRow_Click);
            // 
            // labelWorkingHotelNoOfPersons
            // 
            this.labelWorkingHotelNoOfPersons.AutoSize = true;
            this.labelWorkingHotelNoOfPersons.Location = new System.Drawing.Point(543, 250);
            this.labelWorkingHotelNoOfPersons.Name = "labelWorkingHotelNoOfPersons";
            this.labelWorkingHotelNoOfPersons.Size = new System.Drawing.Size(88, 13);
            this.labelWorkingHotelNoOfPersons.TabIndex = 6;
            this.labelWorkingHotelNoOfPersons.Text = "NO OF PERSON";
            // 
            // openFileDialogForHotelExcel
            // 
            this.openFileDialogForHotelExcel.DefaultExt = "xls";
            this.openFileDialogForHotelExcel.Filter = "Excel 2007 file (*.xls)|*.xls|Excel 2010 file (*.xlsx)|*.xlsx|All (*.*)|*.*";
            this.openFileDialogForHotelExcel.Title = "Select Excel file for Hotel Listing";
            // 
            // lblWorkingHotelSector
            // 
            this.lblWorkingHotelSector.AutoSize = true;
            this.lblWorkingHotelSector.Location = new System.Drawing.Point(542, 86);
            this.lblWorkingHotelSector.Name = "lblWorkingHotelSector";
            this.lblWorkingHotelSector.Size = new System.Drawing.Size(51, 13);
            this.lblWorkingHotelSector.TabIndex = 6;
            this.lblWorkingHotelSector.Text = "SECTOR";
            // 
            // lblWorkingHotelCity
            // 
            this.lblWorkingHotelCity.AutoSize = true;
            this.lblWorkingHotelCity.Location = new System.Drawing.Point(543, 110);
            this.lblWorkingHotelCity.Name = "lblWorkingHotelCity";
            this.lblWorkingHotelCity.Size = new System.Drawing.Size(31, 13);
            this.lblWorkingHotelCity.TabIndex = 6;
            this.lblWorkingHotelCity.Text = "CITY";
            // 
            // lblWorkingHotelHotel
            // 
            this.lblWorkingHotelHotel.AutoSize = true;
            this.lblWorkingHotelHotel.Location = new System.Drawing.Point(542, 166);
            this.lblWorkingHotelHotel.Name = "lblWorkingHotelHotel";
            this.lblWorkingHotelHotel.Size = new System.Drawing.Size(43, 13);
            this.lblWorkingHotelHotel.TabIndex = 6;
            this.lblWorkingHotelHotel.Text = "HOTEL";
            // 
            // lblWrkngHotelRoomType
            // 
            this.lblWrkngHotelRoomType.AutoSize = true;
            this.lblWrkngHotelRoomType.Location = new System.Drawing.Point(542, 223);
            this.lblWrkngHotelRoomType.Name = "lblWrkngHotelRoomType";
            this.lblWrkngHotelRoomType.Size = new System.Drawing.Size(71, 13);
            this.lblWrkngHotelRoomType.TabIndex = 6;
            this.lblWrkngHotelRoomType.Text = "ROOM TYPE";
            // 
            // lblWrkngHotelRoomInfo
            // 
            this.lblWrkngHotelRoomInfo.AutoSize = true;
            this.lblWrkngHotelRoomInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrkngHotelRoomInfo.Location = new System.Drawing.Point(522, 193);
            this.lblWrkngHotelRoomInfo.Name = "lblWrkngHotelRoomInfo";
            this.lblWrkngHotelRoomInfo.Size = new System.Drawing.Size(106, 17);
            this.lblWrkngHotelRoomInfo.TabIndex = 6;
            this.lblWrkngHotelRoomInfo.Text = "ROOM INFO :";
            // 
            // lblWorkingHotelMealPlan
            // 
            this.lblWorkingHotelMealPlan.AutoSize = true;
            this.lblWorkingHotelMealPlan.Location = new System.Drawing.Point(542, 274);
            this.lblWorkingHotelMealPlan.Name = "lblWorkingHotelMealPlan";
            this.lblWorkingHotelMealPlan.Size = new System.Drawing.Size(67, 13);
            this.lblWorkingHotelMealPlan.TabIndex = 6;
            this.lblWorkingHotelMealPlan.Text = "MEAL PLAN";
            this.lblWorkingHotelMealPlan.Click += new System.EventHandler(this.lblWorkingHotelMealPlan_Click);
            // 
            // ButtonWorkingDone
            // 
            this.ButtonWorkingDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonWorkingDone.Location = new System.Drawing.Point(1103, 649);
            this.ButtonWorkingDone.Name = "ButtonWorkingDone";
            this.ButtonWorkingDone.Size = new System.Drawing.Size(97, 23);
            this.ButtonWorkingDone.TabIndex = 5;
            this.ButtonWorkingDone.Text = "FINISH";
            this.ButtonWorkingDone.UseVisualStyleBackColor = true;
            this.ButtonWorkingDone.Click += new System.EventHandler(this.ButtonWorkingDone_Click);
            // 
            // ButtonWorkingCancel
            // 
            this.ButtonWorkingCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonWorkingCancel.Location = new System.Drawing.Point(1000, 649);
            this.ButtonWorkingCancel.Name = "ButtonWorkingCancel";
            this.ButtonWorkingCancel.Size = new System.Drawing.Size(97, 23);
            this.ButtonWorkingCancel.TabIndex = 5;
            this.ButtonWorkingCancel.Text = "CANCEL";
            this.ButtonWorkingCancel.UseVisualStyleBackColor = true;
            this.ButtonWorkingCancel.Click += new System.EventHandler(this.ButtonWorkingCancel_Click);
            // 
            // lblWorkingDayAndHotelRoomInfo
            // 
            this.lblWorkingDayAndHotelRoomInfo.AutoSize = true;
            this.lblWorkingDayAndHotelRoomInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkingDayAndHotelRoomInfo.Location = new System.Drawing.Point(522, 12);
            this.lblWorkingDayAndHotelRoomInfo.Name = "lblWorkingDayAndHotelRoomInfo";
            this.lblWorkingDayAndHotelRoomInfo.Size = new System.Drawing.Size(46, 17);
            this.lblWorkingDayAndHotelRoomInfo.TabIndex = 9;
            this.lblWorkingDayAndHotelRoomInfo.Text = "Day :";
            // 
            // lblWorkingArrivalTime
            // 
            this.lblWorkingArrivalTime.AutoSize = true;
            this.lblWorkingArrivalTime.Location = new System.Drawing.Point(527, 39);
            this.lblWorkingArrivalTime.Name = "lblWorkingArrivalTime";
            this.lblWorkingArrivalTime.Size = new System.Drawing.Size(82, 13);
            this.lblWorkingArrivalTime.TabIndex = 10;
            this.lblWorkingArrivalTime.Text = "ARRIVAL TIME";
            // 
            // lblWorkingHotelInfo
            // 
            this.lblWorkingHotelInfo.AutoSize = true;
            this.lblWorkingHotelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkingHotelInfo.Location = new System.Drawing.Point(532, 64);
            this.lblWorkingHotelInfo.Name = "lblWorkingHotelInfo";
            this.lblWorkingHotelInfo.Size = new System.Drawing.Size(70, 17);
            this.lblWorkingHotelInfo.TabIndex = 11;
            this.lblWorkingHotelInfo.Text = "HOTEL :";
            // 
            // lblWorkingTravelInfo
            // 
            this.lblWorkingTravelInfo.AutoSize = true;
            this.lblWorkingTravelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkingTravelInfo.Location = new System.Drawing.Point(913, 64);
            this.lblWorkingTravelInfo.Name = "lblWorkingTravelInfo";
            this.lblWorkingTravelInfo.Size = new System.Drawing.Size(78, 17);
            this.lblWorkingTravelInfo.TabIndex = 12;
            this.lblWorkingTravelInfo.Text = "TRAVEL :";
            // 
            // lblWrkngCarType
            // 
            this.lblWrkngCarType.AutoSize = true;
            this.lblWrkngCarType.Location = new System.Drawing.Point(935, 110);
            this.lblWrkngCarType.Name = "lblWrkngCarType";
            this.lblWrkngCarType.Size = new System.Drawing.Size(60, 13);
            this.lblWrkngCarType.TabIndex = 14;
            this.lblWrkngCarType.Text = "CAR TYPE";
            // 
            // CmbboxWrkngCarType
            // 
            this.CmbboxWrkngCarType.FormattingEnabled = true;
            this.CmbboxWrkngCarType.Items.AddRange(new object[] {
            "HATCH BACK (4 SEATER)",
            "SEDAN (4 SEATER)",
            "SUV (7 SEATER)",
            "BUS (12 SEATER)",
            "BUS (17 SEATER)"});
            this.CmbboxWrkngCarType.Location = new System.Drawing.Point(1073, 109);
            this.CmbboxWrkngCarType.Name = "CmbboxWrkngCarType";
            this.CmbboxWrkngCarType.Size = new System.Drawing.Size(121, 21);
            this.CmbboxWrkngCarType.TabIndex = 13;
            // 
            // lblWrkngNoOfCars
            // 
            this.lblWrkngNoOfCars.AutoSize = true;
            this.lblWrkngNoOfCars.Location = new System.Drawing.Point(934, 86);
            this.lblWrkngNoOfCars.Name = "lblWrkngNoOfCars";
            this.lblWrkngNoOfCars.Size = new System.Drawing.Size(75, 13);
            this.lblWrkngNoOfCars.TabIndex = 17;
            this.lblWrkngNoOfCars.Text = "NO. OF CARS";
            // 
            // numericUpDownNoOfCars
            // 
            this.numericUpDownNoOfCars.Location = new System.Drawing.Point(1072, 83);
            this.numericUpDownNoOfCars.Name = "numericUpDownNoOfCars";
            this.numericUpDownNoOfCars.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownNoOfCars.TabIndex = 19;
            // 
            // lblWrkngCarPurpose
            // 
            this.lblWrkngCarPurpose.AutoSize = true;
            this.lblWrkngCarPurpose.Location = new System.Drawing.Point(935, 143);
            this.lblWrkngCarPurpose.Name = "lblWrkngCarPurpose";
            this.lblWrkngCarPurpose.Size = new System.Drawing.Size(84, 13);
            this.lblWrkngCarPurpose.TabIndex = 20;
            this.lblWrkngCarPurpose.Text = "CAR PURPOSE";
            // 
            // CmbboxWrkngCarPurpose
            // 
            this.CmbboxWrkngCarPurpose.FormattingEnabled = true;
            this.CmbboxWrkngCarPurpose.Items.AddRange(new object[] {
            "Full Day",
            "Half Day",
            "Airport Arrival",
            "Airport Departure"});
            this.CmbboxWrkngCarPurpose.Location = new System.Drawing.Point(1072, 143);
            this.CmbboxWrkngCarPurpose.Name = "CmbboxWrkngCarPurpose";
            this.CmbboxWrkngCarPurpose.Size = new System.Drawing.Size(121, 21);
            this.CmbboxWrkngCarPurpose.TabIndex = 21;
            // 
            // lblWorkingNoOfGuids
            // 
            this.lblWorkingNoOfGuids.AutoSize = true;
            this.lblWorkingNoOfGuids.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkingNoOfGuids.Location = new System.Drawing.Point(913, 183);
            this.lblWorkingNoOfGuids.Name = "lblWorkingNoOfGuids";
            this.lblWorkingNoOfGuids.Size = new System.Drawing.Size(130, 15);
            this.lblWorkingNoOfGuids.TabIndex = 22;
            this.lblWorkingNoOfGuids.Text = " GUIDE REQUIRED";
            // 
            // lblWorkingNoOfSims
            // 
            this.lblWorkingNoOfSims.AutoSize = true;
            this.lblWorkingNoOfSims.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkingNoOfSims.Location = new System.Drawing.Point(914, 209);
            this.lblWorkingNoOfSims.Name = "lblWorkingNoOfSims";
            this.lblWorkingNoOfSims.Size = new System.Drawing.Size(112, 15);
            this.lblWorkingNoOfSims.TabIndex = 24;
            this.lblWorkingNoOfSims.Text = " SIM REQUIRED";
            // 
            // lblWorkingUserComment
            // 
            this.lblWorkingUserComment.AutoSize = true;
            this.lblWorkingUserComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkingUserComment.Location = new System.Drawing.Point(932, 346);
            this.lblWorkingUserComment.Name = "lblWorkingUserComment";
            this.lblWorkingUserComment.Size = new System.Drawing.Size(119, 15);
            this.lblWorkingUserComment.TabIndex = 26;
            this.lblWorkingUserComment.Text = "USER COMMENT";
            this.lblWorkingUserComment.Click += new System.EventHandler(this.lblWorkingNarration_Click);
            // 
            // lblWorkingAdditionalCost
            // 
            this.lblWorkingAdditionalCost.AutoSize = true;
            this.lblWorkingAdditionalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkingAdditionalCost.Location = new System.Drawing.Point(919, 236);
            this.lblWorkingAdditionalCost.Name = "lblWorkingAdditionalCost";
            this.lblWorkingAdditionalCost.Size = new System.Drawing.Size(154, 15);
            this.lblWorkingAdditionalCost.TabIndex = 27;
            this.lblWorkingAdditionalCost.Text = "ADDITIONAL COST(Rs)";
            // 
            // txtboxWorkingAdditionalCost
            // 
            this.txtboxWorkingAdditionalCost.Location = new System.Drawing.Point(1073, 234);
            this.txtboxWorkingAdditionalCost.Name = "txtboxWorkingAdditionalCost";
            this.txtboxWorkingAdditionalCost.Size = new System.Drawing.Size(100, 20);
            this.txtboxWorkingAdditionalCost.TabIndex = 28;
            // 
            // txtboxWorkingUserComment
            // 
            this.txtboxWorkingUserComment.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtboxWorkingUserComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxWorkingUserComment.Location = new System.Drawing.Point(935, 364);
            this.txtboxWorkingUserComment.Multiline = true;
            this.txtboxWorkingUserComment.Name = "txtboxWorkingUserComment";
            this.txtboxWorkingUserComment.ReadOnly = true;
            this.txtboxWorkingUserComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtboxWorkingUserComment.Size = new System.Drawing.Size(258, 73);
            this.txtboxWorkingUserComment.TabIndex = 30;
            // 
            // dttmpkrWorkingArvlTime
            // 
            this.dttmpkrWorkingArvlTime.Checked = false;
            this.dttmpkrWorkingArvlTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dttmpkrWorkingArvlTime.Location = new System.Drawing.Point(670, 39);
            this.dttmpkrWorkingArvlTime.Name = "dttmpkrWorkingArvlTime";
            this.dttmpkrWorkingArvlTime.ShowUpDown = true;
            this.dttmpkrWorkingArvlTime.Size = new System.Drawing.Size(96, 20);
            this.dttmpkrWorkingArvlTime.TabIndex = 1;
            // 
            // chkBoxWorkingGuide
            // 
            this.chkBoxWorkingGuide.AutoSize = true;
            this.chkBoxWorkingGuide.Location = new System.Drawing.Point(1073, 180);
            this.chkBoxWorkingGuide.Name = "chkBoxWorkingGuide";
            this.chkBoxWorkingGuide.Size = new System.Drawing.Size(68, 17);
            this.chkBoxWorkingGuide.TabIndex = 38;
            this.chkBoxWorkingGuide.Text = "YES/NO";
            this.chkBoxWorkingGuide.UseVisualStyleBackColor = true;
            // 
            // chkBoxWorkingSim
            // 
            this.chkBoxWorkingSim.AutoSize = true;
            this.chkBoxWorkingSim.Location = new System.Drawing.Point(1072, 209);
            this.chkBoxWorkingSim.Name = "chkBoxWorkingSim";
            this.chkBoxWorkingSim.Size = new System.Drawing.Size(68, 17);
            this.chkBoxWorkingSim.TabIndex = 39;
            this.chkBoxWorkingSim.Text = "YES/NO";
            this.chkBoxWorkingSim.UseVisualStyleBackColor = true;
            // 
            // lblWorkingRoomNo
            // 
            this.lblWorkingRoomNo.AutoSize = true;
            this.lblWorkingRoomNo.Location = new System.Drawing.Point(667, 199);
            this.lblWorkingRoomNo.Name = "lblWorkingRoomNo";
            this.lblWorkingRoomNo.Size = new System.Drawing.Size(68, 13);
            this.lblWorkingRoomNo.TabIndex = 40;
            this.lblWorkingRoomNo.Text = "ROOM NO : ";
            // 
            // numericUpDownWorkingRoomNo
            // 
            this.numericUpDownWorkingRoomNo.Enabled = false;
            this.numericUpDownWorkingRoomNo.Location = new System.Drawing.Point(741, 195);
            this.numericUpDownWorkingRoomNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWorkingRoomNo.Name = "numericUpDownWorkingRoomNo";
            this.numericUpDownWorkingRoomNo.ReadOnly = true;
            this.numericUpDownWorkingRoomNo.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownWorkingRoomNo.TabIndex = 41;
            this.numericUpDownWorkingRoomNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnWorkingAddRoom
            // 
            this.btnWorkingAddRoom.Location = new System.Drawing.Point(820, 290);
            this.btnWorkingAddRoom.Name = "btnWorkingAddRoom";
            this.btnWorkingAddRoom.Size = new System.Drawing.Size(97, 23);
            this.btnWorkingAddRoom.TabIndex = 42;
            this.btnWorkingAddRoom.Text = "ADD ROOM";
            this.btnWorkingAddRoom.UseVisualStyleBackColor = true;
            this.btnWorkingAddRoom.Click += new System.EventHandler(this.btnWorkingAddRoom_Click);
            // 
            // txtboxWorkingNarration
            // 
            this.txtboxWorkingNarration.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtboxWorkingNarration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxWorkingNarration.Location = new System.Drawing.Point(935, 276);
            this.txtboxWorkingNarration.Multiline = true;
            this.txtboxWorkingNarration.Name = "txtboxWorkingNarration";
            this.txtboxWorkingNarration.ReadOnly = true;
            this.txtboxWorkingNarration.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtboxWorkingNarration.Size = new System.Drawing.Size(258, 68);
            this.txtboxWorkingNarration.TabIndex = 44;
            // 
            // lblWorkingNarration
            // 
            this.lblWorkingNarration.AutoSize = true;
            this.lblWorkingNarration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkingNarration.Location = new System.Drawing.Point(920, 257);
            this.lblWorkingNarration.Name = "lblWorkingNarration";
            this.lblWorkingNarration.Size = new System.Drawing.Size(85, 15);
            this.lblWorkingNarration.TabIndex = 43;
            this.lblWorkingNarration.Text = "NARRATION";
            // 
            // dataGridViewRoomsInfo
            // 
            this.dataGridViewRoomsInfo.AllowUserToAddRows = false;
            this.dataGridViewRoomsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoomsInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wrkRoom,
            this.wrkRoomType,
            this.wrkMealPlan,
            this.wrkExtraBed,
            this.wrkPrice});
            this.dataGridViewRoomsInfo.Location = new System.Drawing.Point(477, 319);
            this.dataGridViewRoomsInfo.MultiSelect = false;
            this.dataGridViewRoomsInfo.Name = "dataGridViewRoomsInfo";
            this.dataGridViewRoomsInfo.ReadOnly = true;
            this.dataGridViewRoomsInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRoomsInfo.Size = new System.Drawing.Size(440, 149);
            this.dataGridViewRoomsInfo.TabIndex = 45;
            // 
            // numericUpDownWorkingDayNo
            // 
            this.numericUpDownWorkingDayNo.Enabled = false;
            this.numericUpDownWorkingDayNo.Location = new System.Drawing.Point(570, 12);
            this.numericUpDownWorkingDayNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWorkingDayNo.Name = "numericUpDownWorkingDayNo";
            this.numericUpDownWorkingDayNo.ReadOnly = true;
            this.numericUpDownWorkingDayNo.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownWorkingDayNo.TabIndex = 46;
            this.numericUpDownWorkingDayNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePickerWorkingArrivalDate
            // 
            this.dateTimePickerWorkingArrivalDate.Location = new System.Drawing.Point(670, 13);
            this.dateTimePickerWorkingArrivalDate.Name = "dateTimePickerWorkingArrivalDate";
            this.dateTimePickerWorkingArrivalDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerWorkingArrivalDate.TabIndex = 0;
            // 
            // lblWorkingHotelRating
            // 
            this.lblWorkingHotelRating.AutoSize = true;
            this.lblWorkingHotelRating.Location = new System.Drawing.Point(543, 138);
            this.lblWorkingHotelRating.Name = "lblWorkingHotelRating";
            this.lblWorkingHotelRating.Size = new System.Drawing.Size(87, 13);
            this.lblWorkingHotelRating.TabIndex = 49;
            this.lblWorkingHotelRating.Text = "HOTEL RATING";
            // 
            // CmbboxWrkngHtlHotelRating
            // 
            this.CmbboxWrkngHtlHotelRating.FormattingEnabled = true;
            this.CmbboxWrkngHtlHotelRating.Location = new System.Drawing.Point(670, 138);
            this.CmbboxWrkngHtlHotelRating.Name = "CmbboxWrkngHtlHotelRating";
            this.CmbboxWrkngHtlHotelRating.Size = new System.Drawing.Size(121, 21);
            this.CmbboxWrkngHtlHotelRating.TabIndex = 4;
            this.CmbboxWrkngHtlHotelRating.SelectedIndexChanged += new System.EventHandler(this.CmbboxWrkngHtlHotelRating_SelectedIndexChanged);
            // 
            // wrkRoom
            // 
            this.wrkRoom.HeaderText = "ROOM";
            this.wrkRoom.Name = "wrkRoom";
            this.wrkRoom.ReadOnly = true;
            this.wrkRoom.Width = 50;
            // 
            // wrkRoomType
            // 
            this.wrkRoomType.HeaderText = "ROOM TYPE";
            this.wrkRoomType.Name = "wrkRoomType";
            this.wrkRoomType.ReadOnly = true;
            this.wrkRoomType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wrkRoomType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // wrkMealPlan
            // 
            this.wrkMealPlan.HeaderText = "MEAL PLAN";
            this.wrkMealPlan.Name = "wrkMealPlan";
            this.wrkMealPlan.ReadOnly = true;
            this.wrkMealPlan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wrkMealPlan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // wrkExtraBed
            // 
            this.wrkExtraBed.HeaderText = "EXTRA BED";
            this.wrkExtraBed.Name = "wrkExtraBed";
            this.wrkExtraBed.ReadOnly = true;
            this.wrkExtraBed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wrkExtraBed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // wrkPrice
            // 
            this.wrkPrice.HeaderText = "PRICE";
            this.wrkPrice.Name = "wrkPrice";
            this.wrkPrice.ReadOnly = true;
            this.wrkPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmQueryWorkingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 684);
            this.Controls.Add(this.lblWorkingHotelRating);
            this.Controls.Add(this.CmbboxWrkngHtlHotelRating);
            this.Controls.Add(this.dateTimePickerWorkingArrivalDate);
            this.Controls.Add(this.numericUpDownWorkingDayNo);
            this.Controls.Add(this.dataGridViewRoomsInfo);
            this.Controls.Add(this.txtboxWorkingNarration);
            this.Controls.Add(this.lblWorkingNarration);
            this.Controls.Add(this.btnWorkingAddRoom);
            this.Controls.Add(this.numericUpDownWorkingRoomNo);
            this.Controls.Add(this.lblWorkingRoomNo);
            this.Controls.Add(this.chkBoxWorkingSim);
            this.Controls.Add(this.chkBoxWorkingGuide);
            this.Controls.Add(this.dttmpkrWorkingArvlTime);
            this.Controls.Add(this.txtboxWorkingUserComment);
            this.Controls.Add(this.txtboxWorkingAdditionalCost);
            this.Controls.Add(this.lblWorkingAdditionalCost);
            this.Controls.Add(this.lblWorkingUserComment);
            this.Controls.Add(this.lblWorkingNoOfSims);
            this.Controls.Add(this.lblWorkingNoOfGuids);
            this.Controls.Add(this.CmbboxWrkngCarPurpose);
            this.Controls.Add(this.lblWrkngCarPurpose);
            this.Controls.Add(this.numericUpDownNoOfCars);
            this.Controls.Add(this.lblWrkngNoOfCars);
            this.Controls.Add(this.lblWrkngCarType);
            this.Controls.Add(this.CmbboxWrkngCarType);
            this.Controls.Add(this.lblWorkingTravelInfo);
            this.Controls.Add(this.lblWorkingHotelInfo);
            this.Controls.Add(this.lblWorkingArrivalTime);
            this.Controls.Add(this.lblWorkingDayAndHotelRoomInfo);
            this.Controls.Add(this.lblWorkingHotelMealPlan);
            this.Controls.Add(this.lblWrkngHotelRoomInfo);
            this.Controls.Add(this.labelWorkingHotelNoOfPersons);
            this.Controls.Add(this.lblWrkngHotelRoomType);
            this.Controls.Add(this.lblWorkingHotelHotel);
            this.Controls.Add(this.lblWorkingHotelCity);
            this.Controls.Add(this.lblWorkingHotelSector);
            this.Controls.Add(this.ButtonWorkingCancel);
            this.Controls.Add(this.ButtonWorkingDone);
            this.Controls.Add(this.buttonHotelAddRow);
            this.Controls.Add(this.numericUpDownNoOfPersons);
            this.Controls.Add(this.CmbboxWrkngHtlHotel);
            this.Controls.Add(this.CmbboxWrkngHtlMealPlan);
            this.Controls.Add(this.CmbboxWrkngHtlRoomType);
            this.Controls.Add(this.CmbboxWrkngHtlLocation);
            this.Controls.Add(this.CmbboxWrkngHtlSector);
            this.Controls.Add(this.lblQueryDetails);
            this.Controls.Add(this.txtboxQueryDetails);
            this.Controls.Add(this.dataGrdVuWorkingHotels);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQueryWorkingPage";
            this.Text = "Working";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmQueryWorkingPage_FormClosing);
            this.Load += new System.EventHandler(this.FrmQueryWorkingPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdVuWorkingHotels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkingRoomNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomsInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkingDayNo)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDownNoOfPersons;
        private System.Windows.Forms.Button buttonHotelAddRow;
        private System.Windows.Forms.Label labelWorkingHotelNoOfPersons;
        private System.Windows.Forms.OpenFileDialog openFileDialogForHotelExcel;
        private System.Windows.Forms.Label lblWorkingHotelSector;
        private System.Windows.Forms.Label lblWorkingHotelCity;
        private System.Windows.Forms.Label lblWorkingHotelHotel;
        private System.Windows.Forms.Label lblWrkngHotelRoomType;
        private System.Windows.Forms.Label lblWrkngHotelRoomInfo;
        private System.Windows.Forms.Label lblWorkingHotelMealPlan;
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
        private System.Windows.Forms.Label lblWorkingDayAndHotelRoomInfo;
        private System.Windows.Forms.Label lblWorkingArrivalTime;
        private System.Windows.Forms.Label lblWorkingHotelInfo;
        private System.Windows.Forms.Label lblWorkingTravelInfo;
        private System.Windows.Forms.Label lblWrkngCarType;
        private System.Windows.Forms.ComboBox CmbboxWrkngCarType;
        private System.Windows.Forms.Label lblWrkngNoOfCars;
        private System.Windows.Forms.NumericUpDown numericUpDownNoOfCars;
        private System.Windows.Forms.Label lblWrkngCarPurpose;
        private System.Windows.Forms.ComboBox CmbboxWrkngCarPurpose;
        private System.Windows.Forms.Label lblWorkingNoOfGuids;
        private System.Windows.Forms.Label lblWorkingNoOfSims;
        private System.Windows.Forms.Label lblWorkingUserComment;
        private System.Windows.Forms.Label lblWorkingAdditionalCost;
        private System.Windows.Forms.TextBox txtboxWorkingAdditionalCost;
        private System.Windows.Forms.TextBox txtboxWorkingUserComment;
        private System.Windows.Forms.DateTimePicker dttmpkrWorkingArvlTime;
        private System.Windows.Forms.CheckBox chkBoxWorkingGuide;
        private System.Windows.Forms.CheckBox chkBoxWorkingSim;
        private System.Windows.Forms.Label lblWorkingRoomNo;
        private System.Windows.Forms.NumericUpDown numericUpDownWorkingRoomNo;
        private System.Windows.Forms.Button btnWorkingAddRoom;
        private System.Windows.Forms.TextBox txtboxWorkingNarration;
        private System.Windows.Forms.Label lblWorkingNarration;
        private System.Windows.Forms.DataGridView dataGridViewRoomsInfo;
        private System.Windows.Forms.NumericUpDown numericUpDownWorkingDayNo;
        private System.Windows.Forms.DateTimePicker dateTimePickerWorkingArrivalDate;
        private System.Windows.Forms.Label lblWorkingHotelRating;
        private System.Windows.Forms.ComboBox CmbboxWrkngHtlHotelRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrkRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrkRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrkMealPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrkExtraBed;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrkPrice;
    }
}