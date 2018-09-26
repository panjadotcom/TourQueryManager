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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQueryWorkingPage));
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
            this.lblWorkingHotelMealPlan = new System.Windows.Forms.Label();
            this.ButtonWorkingDone = new System.Windows.Forms.Button();
            this.ButtonWorkingCancel = new System.Windows.Forms.Button();
            this.lblWorkingDayAndHotelRoomInfo = new System.Windows.Forms.Label();
            this.lblWorkingArrivalTime = new System.Windows.Forms.Label();
            this.lblWrkngCarType = new System.Windows.Forms.Label();
            this.CmbboxWrkngCarType = new System.Windows.Forms.ComboBox();
            this.lblWrkngNoOfCars = new System.Windows.Forms.Label();
            this.numericUpDownNoOfCars = new System.Windows.Forms.NumericUpDown();
            this.lblWrkngCarPurpose = new System.Windows.Forms.Label();
            this.CmbboxWrkngCarPurpose = new System.Windows.Forms.ComboBox();
            this.lblWorkingAdditionalCost = new System.Windows.Forms.Label();
            this.txtboxWorkingAdditionalCost = new System.Windows.Forms.TextBox();
            this.txtboxTourInclusions = new System.Windows.Forms.TextBox();
            this.dttmpkrWorkingArvlTime = new System.Windows.Forms.DateTimePicker();
            this.chkBoxWorkingGuide = new System.Windows.Forms.CheckBox();
            this.chkBoxWorkingSim = new System.Windows.Forms.CheckBox();
            this.btnWorkingAddRoom = new System.Windows.Forms.Button();
            this.txtboxNarration = new System.Windows.Forms.TextBox();
            this.lblWorkingNarration = new System.Windows.Forms.Label();
            this.dataGridViewRoomsInfo = new System.Windows.Forms.DataGridView();
            this.hotelRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrkRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wrkMealPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelSingleBedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelDoubleShairingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HotelExtraBedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePickerWorkingArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.lblWorkingHotelRating = new System.Windows.Forms.Label();
            this.CmbboxWrkngHtlHotelRating = new System.Windows.Forms.ComboBox();
            this.txtboxNarrationHeader = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbboxWrkngSeasonType = new System.Windows.Forms.ComboBox();
            this.txtboxWorkingFlightCost = new System.Windows.Forms.TextBox();
            this.lblCarCost = new System.Windows.Forms.Label();
            this.grpboxTravelDetails = new System.Windows.Forms.GroupBox();
            this.groupBoxFlightDetails = new System.Windows.Forms.GroupBox();
            this.txtBoxFlightPrice = new System.Windows.Forms.TextBox();
            this.lblFlightCost = new System.Windows.Forms.Label();
            this.txtboxFlightToCity = new System.Windows.Forms.TextBox();
            this.lblFlightToCity = new System.Windows.Forms.Label();
            this.txtboxFlightFromCity = new System.Windows.Forms.TextBox();
            this.lblFlightFromCity = new System.Windows.Forms.Label();
            this.txtBoxFlightNo = new System.Windows.Forms.TextBox();
            this.lblFlightNo = new System.Windows.Forms.Label();
            this.checkBoxTravelDetails = new System.Windows.Forms.CheckBox();
            this.checkBoxFlightDetails = new System.Windows.Forms.CheckBox();
            this.groupBoxHotelDetails = new System.Windows.Forms.GroupBox();
            this.lblDayCounter = new System.Windows.Forms.Label();
            this.chkBoxTourInclusions = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomsInfo)).BeginInit();
            this.grpboxTravelDetails.SuspendLayout();
            this.groupBoxFlightDetails.SuspendLayout();
            this.groupBoxHotelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtboxQueryDetails
            // 
            this.txtboxQueryDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxQueryDetails.Location = new System.Drawing.Point(15, 25);
            this.txtboxQueryDetails.Multiline = true;
            this.txtboxQueryDetails.Name = "txtboxQueryDetails";
            this.txtboxQueryDetails.ReadOnly = true;
            this.txtboxQueryDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxQueryDetails.Size = new System.Drawing.Size(416, 498);
            this.txtboxQueryDetails.TabIndex = 18;
            // 
            // lblQueryDetails
            // 
            this.lblQueryDetails.AutoSize = true;
            this.lblQueryDetails.Location = new System.Drawing.Point(12, 9);
            this.lblQueryDetails.Name = "lblQueryDetails";
            this.lblQueryDetails.Size = new System.Drawing.Size(93, 13);
            this.lblQueryDetails.TabIndex = 19;
            this.lblQueryDetails.Text = "QUERY DETAILS";
            // 
            // CmbboxWrkngHtlSector
            // 
            this.CmbboxWrkngHtlSector.FormattingEnabled = true;
            this.CmbboxWrkngHtlSector.Location = new System.Drawing.Point(134, 19);
            this.CmbboxWrkngHtlSector.Name = "CmbboxWrkngHtlSector";
            this.CmbboxWrkngHtlSector.Size = new System.Drawing.Size(315, 21);
            this.CmbboxWrkngHtlSector.TabIndex = 0;
            this.CmbboxWrkngHtlSector.SelectedIndexChanged += new System.EventHandler(this.CmbboxWrkngHtlSector_SelectedIndexChanged);
            // 
            // CmbboxWrkngHtlLocation
            // 
            this.CmbboxWrkngHtlLocation.FormattingEnabled = true;
            this.CmbboxWrkngHtlLocation.Location = new System.Drawing.Point(134, 53);
            this.CmbboxWrkngHtlLocation.Name = "CmbboxWrkngHtlLocation";
            this.CmbboxWrkngHtlLocation.Size = new System.Drawing.Size(315, 21);
            this.CmbboxWrkngHtlLocation.TabIndex = 1;
            this.CmbboxWrkngHtlLocation.SelectedIndexChanged += new System.EventHandler(this.CmbboxWrkngHtlLocation_SelectedIndexChanged);
            // 
            // CmbboxWrkngHtlRoomType
            // 
            this.CmbboxWrkngHtlRoomType.FormattingEnabled = true;
            this.CmbboxWrkngHtlRoomType.Location = new System.Drawing.Point(133, 155);
            this.CmbboxWrkngHtlRoomType.Name = "CmbboxWrkngHtlRoomType";
            this.CmbboxWrkngHtlRoomType.Size = new System.Drawing.Size(316, 21);
            this.CmbboxWrkngHtlRoomType.TabIndex = 4;
            this.CmbboxWrkngHtlRoomType.SelectedIndexChanged += new System.EventHandler(this.CmbboxWrkngHtlRoomType_SelectedIndexChanged);
            // 
            // CmbboxWrkngHtlHotel
            // 
            this.CmbboxWrkngHtlHotel.FormattingEnabled = true;
            this.CmbboxWrkngHtlHotel.Location = new System.Drawing.Point(133, 121);
            this.CmbboxWrkngHtlHotel.Name = "CmbboxWrkngHtlHotel";
            this.CmbboxWrkngHtlHotel.Size = new System.Drawing.Size(316, 21);
            this.CmbboxWrkngHtlHotel.TabIndex = 3;
            this.CmbboxWrkngHtlHotel.SelectedIndexChanged += new System.EventHandler(this.CmbboxWrkngHtlHotel_SelectedIndexChanged);
            // 
            // CmbboxWrkngHtlMealPlan
            // 
            this.CmbboxWrkngHtlMealPlan.FormattingEnabled = true;
            this.CmbboxWrkngHtlMealPlan.Location = new System.Drawing.Point(133, 223);
            this.CmbboxWrkngHtlMealPlan.Name = "CmbboxWrkngHtlMealPlan";
            this.CmbboxWrkngHtlMealPlan.Size = new System.Drawing.Size(316, 21);
            this.CmbboxWrkngHtlMealPlan.TabIndex = 6;
            this.CmbboxWrkngHtlMealPlan.SelectedIndexChanged += new System.EventHandler(this.CmbboxWrkngHtlMealPlan_SelectedIndexChanged);
            // 
            // numericUpDownNoOfPersons
            // 
            this.numericUpDownNoOfPersons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNoOfPersons.Location = new System.Drawing.Point(1283, 14);
            this.numericUpDownNoOfPersons.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNoOfPersons.Name = "numericUpDownNoOfPersons";
            this.numericUpDownNoOfPersons.Size = new System.Drawing.Size(39, 23);
            this.numericUpDownNoOfPersons.TabIndex = 2;
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
            this.buttonHotelAddRow.Location = new System.Drawing.Point(1089, 608);
            this.buttonHotelAddRow.Name = "buttonHotelAddRow";
            this.buttonHotelAddRow.Size = new System.Drawing.Size(120, 23);
            this.buttonHotelAddRow.TabIndex = 15;
            this.buttonHotelAddRow.Text = "NEXT DAY";
            this.buttonHotelAddRow.UseVisualStyleBackColor = true;
            this.buttonHotelAddRow.Click += new System.EventHandler(this.buttonHotelAddRow_Click);
            // 
            // labelWorkingHotelNoOfPersons
            // 
            this.labelWorkingHotelNoOfPersons.AutoSize = true;
            this.labelWorkingHotelNoOfPersons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkingHotelNoOfPersons.Location = new System.Drawing.Point(1151, 17);
            this.labelWorkingHotelNoOfPersons.Name = "labelWorkingHotelNoOfPersons";
            this.labelWorkingHotelNoOfPersons.Size = new System.Drawing.Size(126, 17);
            this.labelWorkingHotelNoOfPersons.TabIndex = 23;
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
            this.lblWorkingHotelSector.Location = new System.Drawing.Point(70, 23);
            this.lblWorkingHotelSector.Name = "lblWorkingHotelSector";
            this.lblWorkingHotelSector.Size = new System.Drawing.Size(57, 13);
            this.lblWorkingHotelSector.TabIndex = 8;
            this.lblWorkingHotelSector.Text = "SECTOR";
            // 
            // lblWorkingHotelCity
            // 
            this.lblWorkingHotelCity.AutoSize = true;
            this.lblWorkingHotelCity.Location = new System.Drawing.Point(92, 57);
            this.lblWorkingHotelCity.Name = "lblWorkingHotelCity";
            this.lblWorkingHotelCity.Size = new System.Drawing.Size(35, 13);
            this.lblWorkingHotelCity.TabIndex = 9;
            this.lblWorkingHotelCity.Text = "CITY";
            // 
            // lblWorkingHotelHotel
            // 
            this.lblWorkingHotelHotel.AutoSize = true;
            this.lblWorkingHotelHotel.Location = new System.Drawing.Point(79, 125);
            this.lblWorkingHotelHotel.Name = "lblWorkingHotelHotel";
            this.lblWorkingHotelHotel.Size = new System.Drawing.Size(48, 13);
            this.lblWorkingHotelHotel.TabIndex = 11;
            this.lblWorkingHotelHotel.Text = "HOTEL";
            // 
            // lblWrkngHotelRoomType
            // 
            this.lblWrkngHotelRoomType.AutoSize = true;
            this.lblWrkngHotelRoomType.Location = new System.Drawing.Point(47, 159);
            this.lblWrkngHotelRoomType.Name = "lblWrkngHotelRoomType";
            this.lblWrkngHotelRoomType.Size = new System.Drawing.Size(80, 13);
            this.lblWrkngHotelRoomType.TabIndex = 12;
            this.lblWrkngHotelRoomType.Text = "ROOM TYPE";
            // 
            // lblWorkingHotelMealPlan
            // 
            this.lblWorkingHotelMealPlan.AutoSize = true;
            this.lblWorkingHotelMealPlan.Location = new System.Drawing.Point(51, 227);
            this.lblWorkingHotelMealPlan.Name = "lblWorkingHotelMealPlan";
            this.lblWorkingHotelMealPlan.Size = new System.Drawing.Size(76, 13);
            this.lblWorkingHotelMealPlan.TabIndex = 14;
            this.lblWorkingHotelMealPlan.Text = "MEAL PLAN";
            // 
            // ButtonWorkingDone
            // 
            this.ButtonWorkingDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonWorkingDone.Location = new System.Drawing.Point(1239, 608);
            this.ButtonWorkingDone.Name = "ButtonWorkingDone";
            this.ButtonWorkingDone.Size = new System.Drawing.Size(120, 23);
            this.ButtonWorkingDone.TabIndex = 17;
            this.ButtonWorkingDone.Text = "FINISH";
            this.ButtonWorkingDone.UseVisualStyleBackColor = true;
            this.ButtonWorkingDone.Click += new System.EventHandler(this.ButtonWorkingDone_Click);
            // 
            // ButtonWorkingCancel
            // 
            this.ButtonWorkingCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonWorkingCancel.Location = new System.Drawing.Point(939, 608);
            this.ButtonWorkingCancel.Name = "ButtonWorkingCancel";
            this.ButtonWorkingCancel.Size = new System.Drawing.Size(120, 23);
            this.ButtonWorkingCancel.TabIndex = 16;
            this.ButtonWorkingCancel.Text = "CANCEL";
            this.ButtonWorkingCancel.UseVisualStyleBackColor = true;
            this.ButtonWorkingCancel.Click += new System.EventHandler(this.ButtonWorkingCancel_Click);
            // 
            // lblWorkingDayAndHotelRoomInfo
            // 
            this.lblWorkingDayAndHotelRoomInfo.AutoSize = true;
            this.lblWorkingDayAndHotelRoomInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkingDayAndHotelRoomInfo.Location = new System.Drawing.Point(464, 15);
            this.lblWorkingDayAndHotelRoomInfo.Name = "lblWorkingDayAndHotelRoomInfo";
            this.lblWorkingDayAndHotelRoomInfo.Size = new System.Drawing.Size(50, 20);
            this.lblWorkingDayAndHotelRoomInfo.TabIndex = 20;
            this.lblWorkingDayAndHotelRoomInfo.Text = "Day :";
            // 
            // lblWorkingArrivalTime
            // 
            this.lblWorkingArrivalTime.AutoSize = true;
            this.lblWorkingArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkingArrivalTime.Location = new System.Drawing.Point(891, 17);
            this.lblWorkingArrivalTime.Name = "lblWorkingArrivalTime";
            this.lblWorkingArrivalTime.Size = new System.Drawing.Size(114, 17);
            this.lblWorkingArrivalTime.TabIndex = 22;
            this.lblWorkingArrivalTime.Text = "ARRIVAL TIME";
            // 
            // lblWrkngCarType
            // 
            this.lblWrkngCarType.AutoSize = true;
            this.lblWrkngCarType.Location = new System.Drawing.Point(44, 54);
            this.lblWrkngCarType.Name = "lblWrkngCarType";
            this.lblWrkngCarType.Size = new System.Drawing.Size(68, 13);
            this.lblWrkngCarType.TabIndex = 5;
            this.lblWrkngCarType.Text = "CAR TYPE";
            // 
            // CmbboxWrkngCarType
            // 
            this.CmbboxWrkngCarType.FormattingEnabled = true;
            this.CmbboxWrkngCarType.Items.AddRange(new object[] {
            "SELECT CAR TYPE",
            "HATCH BACK (4 SEATER)",
            "SEDAN (4 SEATER)",
            "SUV (7 SEATER)",
            "BUS (12 SEATER)",
            "BUS (17 SEATER)"});
            this.CmbboxWrkngCarType.Location = new System.Drawing.Point(118, 50);
            this.CmbboxWrkngCarType.Name = "CmbboxWrkngCarType";
            this.CmbboxWrkngCarType.Size = new System.Drawing.Size(121, 21);
            this.CmbboxWrkngCarType.TabIndex = 1;
            // 
            // lblWrkngNoOfCars
            // 
            this.lblWrkngNoOfCars.AutoSize = true;
            this.lblWrkngNoOfCars.Location = new System.Drawing.Point(26, 23);
            this.lblWrkngNoOfCars.Name = "lblWrkngNoOfCars";
            this.lblWrkngNoOfCars.Size = new System.Drawing.Size(86, 13);
            this.lblWrkngNoOfCars.TabIndex = 4;
            this.lblWrkngNoOfCars.Text = "NO. OF CARS";
            // 
            // numericUpDownNoOfCars
            // 
            this.numericUpDownNoOfCars.Location = new System.Drawing.Point(118, 19);
            this.numericUpDownNoOfCars.Name = "numericUpDownNoOfCars";
            this.numericUpDownNoOfCars.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownNoOfCars.TabIndex = 0;
            this.numericUpDownNoOfCars.ValueChanged += new System.EventHandler(this.numericUpDownNoOfCars_ValueChanged);
            // 
            // lblWrkngCarPurpose
            // 
            this.lblWrkngCarPurpose.AutoSize = true;
            this.lblWrkngCarPurpose.Location = new System.Drawing.Point(17, 86);
            this.lblWrkngCarPurpose.Name = "lblWrkngCarPurpose";
            this.lblWrkngCarPurpose.Size = new System.Drawing.Size(95, 13);
            this.lblWrkngCarPurpose.TabIndex = 6;
            this.lblWrkngCarPurpose.Text = "CAR PURPOSE";
            // 
            // CmbboxWrkngCarPurpose
            // 
            this.CmbboxWrkngCarPurpose.FormattingEnabled = true;
            this.CmbboxWrkngCarPurpose.Items.AddRange(new object[] {
            "SELECT PURPOSE",
            "FULL DAY",
            "HALF DAY",
            "AIRPORT ARIVAL",
            "AIRPORT DEPARTURE"});
            this.CmbboxWrkngCarPurpose.Location = new System.Drawing.Point(118, 82);
            this.CmbboxWrkngCarPurpose.Name = "CmbboxWrkngCarPurpose";
            this.CmbboxWrkngCarPurpose.Size = new System.Drawing.Size(121, 21);
            this.CmbboxWrkngCarPurpose.TabIndex = 2;
            // 
            // lblWorkingAdditionalCost
            // 
            this.lblWorkingAdditionalCost.AutoSize = true;
            this.lblWorkingAdditionalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkingAdditionalCost.Location = new System.Drawing.Point(1075, 283);
            this.lblWorkingAdditionalCost.Name = "lblWorkingAdditionalCost";
            this.lblWorkingAdditionalCost.Size = new System.Drawing.Size(178, 17);
            this.lblWorkingAdditionalCost.TabIndex = 25;
            this.lblWorkingAdditionalCost.Text = "ADDITIONAL COST(Rs)";
            // 
            // txtboxWorkingAdditionalCost
            // 
            this.txtboxWorkingAdditionalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxWorkingAdditionalCost.Location = new System.Drawing.Point(1259, 280);
            this.txtboxWorkingAdditionalCost.Name = "txtboxWorkingAdditionalCost";
            this.txtboxWorkingAdditionalCost.Size = new System.Drawing.Size(100, 23);
            this.txtboxWorkingAdditionalCost.TabIndex = 12;
            this.txtboxWorkingAdditionalCost.Text = "0";
            // 
            // txtboxTourInclusions
            // 
            this.txtboxTourInclusions.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtboxTourInclusions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxTourInclusions.Location = new System.Drawing.Point(938, 357);
            this.txtboxTourInclusions.Multiline = true;
            this.txtboxTourInclusions.Name = "txtboxTourInclusions";
            this.txtboxTourInclusions.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtboxTourInclusions.Size = new System.Drawing.Size(421, 207);
            this.txtboxTourInclusions.TabIndex = 14;
            // 
            // dttmpkrWorkingArvlTime
            // 
            this.dttmpkrWorkingArvlTime.Checked = false;
            this.dttmpkrWorkingArvlTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttmpkrWorkingArvlTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dttmpkrWorkingArvlTime.Location = new System.Drawing.Point(1011, 14);
            this.dttmpkrWorkingArvlTime.Name = "dttmpkrWorkingArvlTime";
            this.dttmpkrWorkingArvlTime.ShowUpDown = true;
            this.dttmpkrWorkingArvlTime.Size = new System.Drawing.Size(96, 23);
            this.dttmpkrWorkingArvlTime.TabIndex = 1;
            // 
            // chkBoxWorkingGuide
            // 
            this.chkBoxWorkingGuide.AutoSize = true;
            this.chkBoxWorkingGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxWorkingGuide.Location = new System.Drawing.Point(938, 59);
            this.chkBoxWorkingGuide.Name = "chkBoxWorkingGuide";
            this.chkBoxWorkingGuide.Size = new System.Drawing.Size(169, 21);
            this.chkBoxWorkingGuide.TabIndex = 8;
            this.chkBoxWorkingGuide.Text = "GUIDE REQUIRED?";
            this.chkBoxWorkingGuide.UseVisualStyleBackColor = true;
            // 
            // chkBoxWorkingSim
            // 
            this.chkBoxWorkingSim.AutoSize = true;
            this.chkBoxWorkingSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxWorkingSim.Location = new System.Drawing.Point(938, 86);
            this.chkBoxWorkingSim.Name = "chkBoxWorkingSim";
            this.chkBoxWorkingSim.Size = new System.Drawing.Size(147, 21);
            this.chkBoxWorkingSim.TabIndex = 9;
            this.chkBoxWorkingSim.Text = "SIM REQUIRED?";
            this.chkBoxWorkingSim.UseVisualStyleBackColor = true;
            // 
            // btnWorkingAddRoom
            // 
            this.btnWorkingAddRoom.Location = new System.Drawing.Point(6, 257);
            this.btnWorkingAddRoom.Name = "btnWorkingAddRoom";
            this.btnWorkingAddRoom.Size = new System.Drawing.Size(443, 23);
            this.btnWorkingAddRoom.TabIndex = 7;
            this.btnWorkingAddRoom.Text = "ADD DIFFERENT HOTEL FOR SAME DAY";
            this.btnWorkingAddRoom.UseVisualStyleBackColor = true;
            this.btnWorkingAddRoom.Click += new System.EventHandler(this.btnWorkingAddRoom_Click);
            // 
            // txtboxNarration
            // 
            this.txtboxNarration.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtboxNarration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNarration.Location = new System.Drawing.Point(938, 145);
            this.txtboxNarration.Multiline = true;
            this.txtboxNarration.Name = "txtboxNarration";
            this.txtboxNarration.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtboxNarration.Size = new System.Drawing.Size(421, 115);
            this.txtboxNarration.TabIndex = 11;
            // 
            // lblWorkingNarration
            // 
            this.lblWorkingNarration.AutoSize = true;
            this.lblWorkingNarration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkingNarration.Location = new System.Drawing.Point(936, 119);
            this.lblWorkingNarration.Name = "lblWorkingNarration";
            this.lblWorkingNarration.Size = new System.Drawing.Size(98, 17);
            this.lblWorkingNarration.TabIndex = 24;
            this.lblWorkingNarration.Text = "NARRATION";
            // 
            // dataGridViewRoomsInfo
            // 
            this.dataGridViewRoomsInfo.AllowUserToAddRows = false;
            this.dataGridViewRoomsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoomsInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hotelRating,
            this.HotelId,
            this.wrkRoomType,
            this.wrkMealPlan,
            this.HotelSingleBedPrice,
            this.HotelDoubleShairingPrice,
            this.HotelExtraBedPrice});
            this.dataGridViewRoomsInfo.Location = new System.Drawing.Point(6, 286);
            this.dataGridViewRoomsInfo.MultiSelect = false;
            this.dataGridViewRoomsInfo.Name = "dataGridViewRoomsInfo";
            this.dataGridViewRoomsInfo.ReadOnly = true;
            this.dataGridViewRoomsInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRoomsInfo.Size = new System.Drawing.Size(443, 126);
            this.dataGridViewRoomsInfo.TabIndex = 8;
            // 
            // hotelRating
            // 
            this.hotelRating.FillWeight = 70F;
            this.hotelRating.HeaderText = "HOTEL RATING";
            this.hotelRating.Name = "hotelRating";
            this.hotelRating.ReadOnly = true;
            this.hotelRating.Width = 50;
            // 
            // HotelId
            // 
            this.HotelId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HotelId.HeaderText = "HOTEL ID";
            this.HotelId.Name = "HotelId";
            this.HotelId.ReadOnly = true;
            // 
            // wrkRoomType
            // 
            this.wrkRoomType.HeaderText = "ROOM TYPE";
            this.wrkRoomType.Name = "wrkRoomType";
            this.wrkRoomType.ReadOnly = true;
            this.wrkRoomType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wrkRoomType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.wrkRoomType.Width = 80;
            // 
            // wrkMealPlan
            // 
            this.wrkMealPlan.HeaderText = "MEAL PLAN";
            this.wrkMealPlan.Name = "wrkMealPlan";
            this.wrkMealPlan.ReadOnly = true;
            this.wrkMealPlan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.wrkMealPlan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.wrkMealPlan.Width = 80;
            // 
            // HotelSingleBedPrice
            // 
            this.HotelSingleBedPrice.HeaderText = "SINGLE BED PRICE";
            this.HotelSingleBedPrice.Name = "HotelSingleBedPrice";
            this.HotelSingleBedPrice.ReadOnly = true;
            // 
            // HotelDoubleShairingPrice
            // 
            this.HotelDoubleShairingPrice.HeaderText = "DOUBLE BED PRICE";
            this.HotelDoubleShairingPrice.Name = "HotelDoubleShairingPrice";
            this.HotelDoubleShairingPrice.ReadOnly = true;
            // 
            // HotelExtraBedPrice
            // 
            this.HotelExtraBedPrice.HeaderText = "EXTRA BED PRICE";
            this.HotelExtraBedPrice.Name = "HotelExtraBedPrice";
            this.HotelExtraBedPrice.ReadOnly = true;
            // 
            // dateTimePickerWorkingArrivalDate
            // 
            this.dateTimePickerWorkingArrivalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerWorkingArrivalDate.Location = new System.Drawing.Point(571, 12);
            this.dateTimePickerWorkingArrivalDate.Name = "dateTimePickerWorkingArrivalDate";
            this.dateTimePickerWorkingArrivalDate.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerWorkingArrivalDate.TabIndex = 0;
            this.dateTimePickerWorkingArrivalDate.ValueChanged += new System.EventHandler(this.dateTimePickerWorkingArrivalDate_ValueChanged);
            // 
            // lblWorkingHotelRating
            // 
            this.lblWorkingHotelRating.AutoSize = true;
            this.lblWorkingHotelRating.Location = new System.Drawing.Point(28, 91);
            this.lblWorkingHotelRating.Name = "lblWorkingHotelRating";
            this.lblWorkingHotelRating.Size = new System.Drawing.Size(99, 13);
            this.lblWorkingHotelRating.TabIndex = 10;
            this.lblWorkingHotelRating.Text = "HOTEL RATING";
            // 
            // CmbboxWrkngHtlHotelRating
            // 
            this.CmbboxWrkngHtlHotelRating.FormattingEnabled = true;
            this.CmbboxWrkngHtlHotelRating.Location = new System.Drawing.Point(134, 87);
            this.CmbboxWrkngHtlHotelRating.Name = "CmbboxWrkngHtlHotelRating";
            this.CmbboxWrkngHtlHotelRating.Size = new System.Drawing.Size(315, 21);
            this.CmbboxWrkngHtlHotelRating.TabIndex = 2;
            this.CmbboxWrkngHtlHotelRating.SelectedIndexChanged += new System.EventHandler(this.CmbboxWrkngHtlHotelRating_SelectedIndexChanged);
            // 
            // txtboxNarrationHeader
            // 
            this.txtboxNarrationHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNarrationHeader.Location = new System.Drawing.Point(1040, 116);
            this.txtboxNarrationHeader.Name = "txtboxNarrationHeader";
            this.txtboxNarrationHeader.Size = new System.Drawing.Size(319, 23);
            this.txtboxNarrationHeader.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "SEASON TYPE";
            // 
            // CmbboxWrkngSeasonType
            // 
            this.CmbboxWrkngSeasonType.FormattingEnabled = true;
            this.CmbboxWrkngSeasonType.Location = new System.Drawing.Point(133, 189);
            this.CmbboxWrkngSeasonType.Name = "CmbboxWrkngSeasonType";
            this.CmbboxWrkngSeasonType.Size = new System.Drawing.Size(316, 21);
            this.CmbboxWrkngSeasonType.TabIndex = 5;
            this.CmbboxWrkngSeasonType.SelectedIndexChanged += new System.EventHandler(this.CmbboxWrkngSeasonType_SelectedIndexChanged);
            // 
            // txtboxWorkingFlightCost
            // 
            this.txtboxWorkingFlightCost.Location = new System.Drawing.Point(118, 114);
            this.txtboxWorkingFlightCost.Name = "txtboxWorkingFlightCost";
            this.txtboxWorkingFlightCost.Size = new System.Drawing.Size(121, 20);
            this.txtboxWorkingFlightCost.TabIndex = 3;
            this.txtboxWorkingFlightCost.Text = "0";
            // 
            // lblCarCost
            // 
            this.lblCarCost.AutoSize = true;
            this.lblCarCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarCost.Location = new System.Drawing.Point(6, 117);
            this.lblCarCost.Name = "lblCarCost";
            this.lblCarCost.Size = new System.Drawing.Size(106, 15);
            this.lblCarCost.TabIndex = 7;
            this.lblCarCost.Text = "PER CAR COST";
            // 
            // grpboxTravelDetails
            // 
            this.grpboxTravelDetails.Controls.Add(this.lblWrkngNoOfCars);
            this.grpboxTravelDetails.Controls.Add(this.txtboxWorkingFlightCost);
            this.grpboxTravelDetails.Controls.Add(this.CmbboxWrkngCarType);
            this.grpboxTravelDetails.Controls.Add(this.lblCarCost);
            this.grpboxTravelDetails.Controls.Add(this.lblWrkngCarType);
            this.grpboxTravelDetails.Controls.Add(this.numericUpDownNoOfCars);
            this.grpboxTravelDetails.Controls.Add(this.lblWrkngCarPurpose);
            this.grpboxTravelDetails.Controls.Add(this.CmbboxWrkngCarPurpose);
            this.grpboxTravelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxTravelDetails.Location = new System.Drawing.Point(434, 491);
            this.grpboxTravelDetails.Name = "grpboxTravelDetails";
            this.grpboxTravelDetails.Size = new System.Drawing.Size(248, 140);
            this.grpboxTravelDetails.TabIndex = 5;
            this.grpboxTravelDetails.TabStop = false;
            this.grpboxTravelDetails.Text = "TRAVEL:";
            // 
            // groupBoxFlightDetails
            // 
            this.groupBoxFlightDetails.Controls.Add(this.txtBoxFlightPrice);
            this.groupBoxFlightDetails.Controls.Add(this.lblFlightCost);
            this.groupBoxFlightDetails.Controls.Add(this.txtboxFlightToCity);
            this.groupBoxFlightDetails.Controls.Add(this.lblFlightToCity);
            this.groupBoxFlightDetails.Controls.Add(this.txtboxFlightFromCity);
            this.groupBoxFlightDetails.Controls.Add(this.lblFlightFromCity);
            this.groupBoxFlightDetails.Controls.Add(this.txtBoxFlightNo);
            this.groupBoxFlightDetails.Controls.Add(this.lblFlightNo);
            this.groupBoxFlightDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFlightDetails.Location = new System.Drawing.Point(688, 491);
            this.groupBoxFlightDetails.Name = "groupBoxFlightDetails";
            this.groupBoxFlightDetails.Size = new System.Drawing.Size(207, 140);
            this.groupBoxFlightDetails.TabIndex = 7;
            this.groupBoxFlightDetails.TabStop = false;
            this.groupBoxFlightDetails.Text = "FLIGHTS";
            // 
            // txtBoxFlightPrice
            // 
            this.txtBoxFlightPrice.Location = new System.Drawing.Point(98, 115);
            this.txtBoxFlightPrice.Name = "txtBoxFlightPrice";
            this.txtBoxFlightPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFlightPrice.TabIndex = 3;
            // 
            // lblFlightCost
            // 
            this.lblFlightCost.AutoSize = true;
            this.lblFlightCost.Location = new System.Drawing.Point(6, 117);
            this.lblFlightCost.Name = "lblFlightCost";
            this.lblFlightCost.Size = new System.Drawing.Size(86, 13);
            this.lblFlightCost.TabIndex = 7;
            this.lblFlightCost.Text = "PRICE/SEAT:";
            // 
            // txtboxFlightToCity
            // 
            this.txtboxFlightToCity.Location = new System.Drawing.Point(98, 84);
            this.txtboxFlightToCity.Name = "txtboxFlightToCity";
            this.txtboxFlightToCity.Size = new System.Drawing.Size(100, 20);
            this.txtboxFlightToCity.TabIndex = 2;
            // 
            // lblFlightToCity
            // 
            this.lblFlightToCity.AutoSize = true;
            this.lblFlightToCity.Location = new System.Drawing.Point(64, 88);
            this.lblFlightToCity.Name = "lblFlightToCity";
            this.lblFlightToCity.Size = new System.Drawing.Size(28, 13);
            this.lblFlightToCity.TabIndex = 6;
            this.lblFlightToCity.Text = "TO:";
            // 
            // txtboxFlightFromCity
            // 
            this.txtboxFlightFromCity.Location = new System.Drawing.Point(98, 53);
            this.txtboxFlightFromCity.Name = "txtboxFlightFromCity";
            this.txtboxFlightFromCity.Size = new System.Drawing.Size(100, 20);
            this.txtboxFlightFromCity.TabIndex = 1;
            // 
            // lblFlightFromCity
            // 
            this.lblFlightFromCity.AutoSize = true;
            this.lblFlightFromCity.Location = new System.Drawing.Point(46, 57);
            this.lblFlightFromCity.Name = "lblFlightFromCity";
            this.lblFlightFromCity.Size = new System.Drawing.Size(46, 13);
            this.lblFlightFromCity.TabIndex = 5;
            this.lblFlightFromCity.Text = "FROM:";
            // 
            // txtBoxFlightNo
            // 
            this.txtBoxFlightNo.Location = new System.Drawing.Point(98, 22);
            this.txtBoxFlightNo.Name = "txtBoxFlightNo";
            this.txtBoxFlightNo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFlightNo.TabIndex = 0;
            // 
            // lblFlightNo
            // 
            this.lblFlightNo.AutoSize = true;
            this.lblFlightNo.Location = new System.Drawing.Point(24, 26);
            this.lblFlightNo.Name = "lblFlightNo";
            this.lblFlightNo.Size = new System.Drawing.Size(68, 13);
            this.lblFlightNo.TabIndex = 4;
            this.lblFlightNo.Text = "FLIGT NO:";
            // 
            // checkBoxTravelDetails
            // 
            this.checkBoxTravelDetails.AutoSize = true;
            this.checkBoxTravelDetails.Location = new System.Drawing.Point(437, 468);
            this.checkBoxTravelDetails.Name = "checkBoxTravelDetails";
            this.checkBoxTravelDetails.Size = new System.Drawing.Size(156, 17);
            this.checkBoxTravelDetails.TabIndex = 4;
            this.checkBoxTravelDetails.Text = "ENTER TRAVEL DETAILS";
            this.checkBoxTravelDetails.UseVisualStyleBackColor = true;
            this.checkBoxTravelDetails.CheckedChanged += new System.EventHandler(this.checkBoxTravelDetails_CheckedChanged);
            // 
            // checkBoxFlightDetails
            // 
            this.checkBoxFlightDetails.AutoSize = true;
            this.checkBoxFlightDetails.Location = new System.Drawing.Point(688, 468);
            this.checkBoxFlightDetails.Name = "checkBoxFlightDetails";
            this.checkBoxFlightDetails.Size = new System.Drawing.Size(152, 17);
            this.checkBoxFlightDetails.TabIndex = 6;
            this.checkBoxFlightDetails.Text = "ENTER FLIGHT DETAILS";
            this.checkBoxFlightDetails.UseVisualStyleBackColor = true;
            this.checkBoxFlightDetails.CheckedChanged += new System.EventHandler(this.checkBoxFlightDetails_CheckedChanged);
            // 
            // groupBoxHotelDetails
            // 
            this.groupBoxHotelDetails.Controls.Add(this.lblWorkingHotelSector);
            this.groupBoxHotelDetails.Controls.Add(this.CmbboxWrkngHtlSector);
            this.groupBoxHotelDetails.Controls.Add(this.CmbboxWrkngHtlLocation);
            this.groupBoxHotelDetails.Controls.Add(this.CmbboxWrkngHtlRoomType);
            this.groupBoxHotelDetails.Controls.Add(this.CmbboxWrkngHtlMealPlan);
            this.groupBoxHotelDetails.Controls.Add(this.label1);
            this.groupBoxHotelDetails.Controls.Add(this.CmbboxWrkngHtlHotel);
            this.groupBoxHotelDetails.Controls.Add(this.CmbboxWrkngSeasonType);
            this.groupBoxHotelDetails.Controls.Add(this.dataGridViewRoomsInfo);
            this.groupBoxHotelDetails.Controls.Add(this.lblWorkingHotelCity);
            this.groupBoxHotelDetails.Controls.Add(this.lblWorkingHotelHotel);
            this.groupBoxHotelDetails.Controls.Add(this.lblWorkingHotelRating);
            this.groupBoxHotelDetails.Controls.Add(this.lblWrkngHotelRoomType);
            this.groupBoxHotelDetails.Controls.Add(this.CmbboxWrkngHtlHotelRating);
            this.groupBoxHotelDetails.Controls.Add(this.lblWorkingHotelMealPlan);
            this.groupBoxHotelDetails.Controls.Add(this.btnWorkingAddRoom);
            this.groupBoxHotelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHotelDetails.Location = new System.Drawing.Point(437, 44);
            this.groupBoxHotelDetails.Name = "groupBoxHotelDetails";
            this.groupBoxHotelDetails.Size = new System.Drawing.Size(458, 418);
            this.groupBoxHotelDetails.TabIndex = 3;
            this.groupBoxHotelDetails.TabStop = false;
            this.groupBoxHotelDetails.Text = "HOTEL:";
            // 
            // lblDayCounter
            // 
            this.lblDayCounter.AutoSize = true;
            this.lblDayCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayCounter.Location = new System.Drawing.Point(516, 15);
            this.lblDayCounter.Name = "lblDayCounter";
            this.lblDayCounter.Size = new System.Drawing.Size(19, 20);
            this.lblDayCounter.TabIndex = 21;
            this.lblDayCounter.Text = "1";
            // 
            // chkBoxTourInclusions
            // 
            this.chkBoxTourInclusions.AutoSize = true;
            this.chkBoxTourInclusions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxTourInclusions.Location = new System.Drawing.Point(938, 330);
            this.chkBoxTourInclusions.Name = "chkBoxTourInclusions";
            this.chkBoxTourInclusions.Size = new System.Drawing.Size(224, 21);
            this.chkBoxTourInclusions.TabIndex = 13;
            this.chkBoxTourInclusions.Text = "ENTER TOUR INCLUSION?";
            this.chkBoxTourInclusions.UseVisualStyleBackColor = true;
            this.chkBoxTourInclusions.CheckedChanged += new System.EventHandler(this.chkBoxTourInclusions_CheckedChanged);
            // 
            // FrmQueryWorkingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 646);
            this.Controls.Add(this.chkBoxTourInclusions);
            this.Controls.Add(this.lblDayCounter);
            this.Controls.Add(this.groupBoxHotelDetails);
            this.Controls.Add(this.checkBoxFlightDetails);
            this.Controls.Add(this.checkBoxTravelDetails);
            this.Controls.Add(this.groupBoxFlightDetails);
            this.Controls.Add(this.grpboxTravelDetails);
            this.Controls.Add(this.txtboxNarrationHeader);
            this.Controls.Add(this.dateTimePickerWorkingArrivalDate);
            this.Controls.Add(this.txtboxNarration);
            this.Controls.Add(this.lblWorkingNarration);
            this.Controls.Add(this.chkBoxWorkingSim);
            this.Controls.Add(this.chkBoxWorkingGuide);
            this.Controls.Add(this.dttmpkrWorkingArvlTime);
            this.Controls.Add(this.txtboxTourInclusions);
            this.Controls.Add(this.txtboxWorkingAdditionalCost);
            this.Controls.Add(this.lblWorkingAdditionalCost);
            this.Controls.Add(this.lblWorkingArrivalTime);
            this.Controls.Add(this.lblWorkingDayAndHotelRoomInfo);
            this.Controls.Add(this.labelWorkingHotelNoOfPersons);
            this.Controls.Add(this.ButtonWorkingCancel);
            this.Controls.Add(this.ButtonWorkingDone);
            this.Controls.Add(this.buttonHotelAddRow);
            this.Controls.Add(this.numericUpDownNoOfPersons);
            this.Controls.Add(this.lblQueryDetails);
            this.Controls.Add(this.txtboxQueryDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQueryWorkingPage";
            this.Text = "Working";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmQueryWorkingPage_FormClosing);
            this.Load += new System.EventHandler(this.FrmQueryWorkingPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomsInfo)).EndInit();
            this.grpboxTravelDetails.ResumeLayout(false);
            this.grpboxTravelDetails.PerformLayout();
            this.groupBoxFlightDetails.ResumeLayout(false);
            this.groupBoxFlightDetails.PerformLayout();
            this.groupBoxHotelDetails.ResumeLayout(false);
            this.groupBoxHotelDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label lblWorkingHotelMealPlan;
        private System.Windows.Forms.Button ButtonWorkingDone;
        private System.Windows.Forms.Button ButtonWorkingCancel;
        private System.Windows.Forms.Label lblWorkingDayAndHotelRoomInfo;
        private System.Windows.Forms.Label lblWorkingArrivalTime;
        private System.Windows.Forms.Label lblWrkngCarType;
        private System.Windows.Forms.ComboBox CmbboxWrkngCarType;
        private System.Windows.Forms.Label lblWrkngNoOfCars;
        private System.Windows.Forms.NumericUpDown numericUpDownNoOfCars;
        private System.Windows.Forms.Label lblWrkngCarPurpose;
        private System.Windows.Forms.ComboBox CmbboxWrkngCarPurpose;
        private System.Windows.Forms.Label lblWorkingAdditionalCost;
        private System.Windows.Forms.TextBox txtboxWorkingAdditionalCost;
        private System.Windows.Forms.TextBox txtboxTourInclusions;
        private System.Windows.Forms.DateTimePicker dttmpkrWorkingArvlTime;
        private System.Windows.Forms.CheckBox chkBoxWorkingGuide;
        private System.Windows.Forms.CheckBox chkBoxWorkingSim;
        private System.Windows.Forms.Button btnWorkingAddRoom;
        private System.Windows.Forms.TextBox txtboxNarration;
        private System.Windows.Forms.Label lblWorkingNarration;
        private System.Windows.Forms.DataGridView dataGridViewRoomsInfo;
        private System.Windows.Forms.DateTimePicker dateTimePickerWorkingArrivalDate;
        private System.Windows.Forms.Label lblWorkingHotelRating;
        private System.Windows.Forms.ComboBox CmbboxWrkngHtlHotelRating;
        private System.Windows.Forms.TextBox txtboxNarrationHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbboxWrkngSeasonType;
        private System.Windows.Forms.TextBox txtboxWorkingFlightCost;
        private System.Windows.Forms.Label lblCarCost;
        private System.Windows.Forms.GroupBox grpboxTravelDetails;
        private System.Windows.Forms.GroupBox groupBoxFlightDetails;
        private System.Windows.Forms.TextBox txtBoxFlightPrice;
        private System.Windows.Forms.Label lblFlightCost;
        private System.Windows.Forms.TextBox txtboxFlightToCity;
        private System.Windows.Forms.Label lblFlightToCity;
        private System.Windows.Forms.TextBox txtboxFlightFromCity;
        private System.Windows.Forms.Label lblFlightFromCity;
        private System.Windows.Forms.TextBox txtBoxFlightNo;
        private System.Windows.Forms.Label lblFlightNo;
        private System.Windows.Forms.CheckBox checkBoxTravelDetails;
        private System.Windows.Forms.CheckBox checkBoxFlightDetails;
        private System.Windows.Forms.GroupBox groupBoxHotelDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelId;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrkRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn wrkMealPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelSingleBedPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelDoubleShairingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn HotelExtraBedPrice;
        private System.Windows.Forms.Label lblDayCounter;
        private System.Windows.Forms.CheckBox chkBoxTourInclusions;
    }
}