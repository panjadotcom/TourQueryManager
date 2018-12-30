﻿namespace TourQueryManager
{
    partial class FrmEditQueryPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditQueryPage));
            this.lblQueryId = new System.Windows.Forms.Label();
            this.lblAgentId = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblDstnCvrd = new System.Windows.Forms.Label();
            this.lblBookDate = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblPersonCount = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblArvlDprtCity = new System.Windows.Forms.Label();
            this.lblArvlDprtDateTime = new System.Windows.Forms.Label();
            this.lblHotelCtgry = new System.Windows.Forms.Label();
            this.lblMeal = new System.Windows.Forms.Label();
            this.lblRooms = new System.Windows.Forms.Label();
            this.lblRequirement = new System.Windows.Forms.Label();
            this.lblVehicleCtgry = new System.Windows.Forms.Label();
            this.cmbboxAgentId = new System.Windows.Forms.ComboBox();
            this.cmbboxUserId = new System.Windows.Forms.ComboBox();
            this.nmbrUpDwnPersonAdult = new System.Windows.Forms.NumericUpDown();
            this.nmbrUpDwnPersonChild = new System.Windows.Forms.NumericUpDown();
            this.nmbrUpDwnPersonInfnt = new System.Windows.Forms.NumericUpDown();
            this.nmbrUpDwnRoomCount = new System.Windows.Forms.NumericUpDown();
            this.radioBtnMealNoMeal = new System.Windows.Forms.RadioButton();
            this.radioBtnMealBrkfstOnly = new System.Windows.Forms.RadioButton();
            this.radioBtnMealBrkfstLnchDnr = new System.Windows.Forms.RadioButton();
            this.radioBtnMealBrkfstDnr = new System.Windows.Forms.RadioButton();
            this.chkBox2Star = new System.Windows.Forms.CheckBox();
            this.chkBox4Star = new System.Windows.Forms.CheckBox();
            this.chkBox3Star = new System.Windows.Forms.CheckBox();
            this.chkBox5Star = new System.Windows.Forms.CheckBox();
            this.dttmpckrFromDate = new System.Windows.Forms.DateTimePicker();
            this.dttmpckrToDate = new System.Windows.Forms.DateTimePicker();
            this.txtboxPlace = new System.Windows.Forms.TextBox();
            this.txtboxDstnCvrd = new System.Windows.Forms.TextBox();
            this.txtboxDptrCity = new System.Windows.Forms.TextBox();
            this.txtboxArvlCity = new System.Windows.Forms.TextBox();
            this.cmbboxVehicleCtgry = new System.Windows.Forms.ComboBox();
            this.txtboxBudget = new System.Windows.Forms.TextBox();
            this.txtboxNote = new System.Windows.Forms.TextBox();
            this.radioBtnRqmntTourPlusFlight = new System.Windows.Forms.RadioButton();
            this.radioBtnRqmntTourPkg = new System.Windows.Forms.RadioButton();
            this.radioBtnRqmntTrnsprtOnly = new System.Windows.Forms.RadioButton();
            this.radioBtnRqmntHtlOnly = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbboxQueryId = new System.Windows.Forms.ComboBox();
            this.grpboxMeal = new System.Windows.Forms.GroupBox();
            this.grpboxRqmnt = new System.Windows.Forms.GroupBox();
            this.grpboxHtlCtgry = new System.Windows.Forms.GroupBox();
            this.btnDeleteQuery = new System.Windows.Forms.Button();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txtboxClientName = new System.Windows.Forms.TextBox();
            this.lblClientContact = new System.Windows.Forms.Label();
            this.txtboxClientContact = new System.Windows.Forms.TextBox();
            this.dttmpkrDptrDate = new System.Windows.Forms.DateTimePicker();
            this.dttmpkrArvlDate = new System.Windows.Forms.DateTimePicker();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.lblDepartureCity = new System.Windows.Forms.Label();
            this.lblAdults = new System.Windows.Forms.Label();
            this.lblChildren = new System.Windows.Forms.Label();
            this.lblBabies = new System.Windows.Forms.Label();
            this.txtBoxGST = new System.Windows.Forms.TextBox();
            this.lblGST = new System.Windows.Forms.Label();
            this.txtBoxMargin = new System.Windows.Forms.TextBox();
            this.lblMargin = new System.Windows.Forms.Label();
            this.lblClientInfo = new System.Windows.Forms.Label();
            this.txtBoxUsdRate = new System.Windows.Forms.TextBox();
            this.lblUsdRate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrUpDwnPersonAdult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrUpDwnPersonChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrUpDwnPersonInfnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrUpDwnRoomCount)).BeginInit();
            this.grpboxMeal.SuspendLayout();
            this.grpboxRqmnt.SuspendLayout();
            this.grpboxHtlCtgry.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQueryId
            // 
            this.lblQueryId.AutoSize = true;
            this.lblQueryId.Location = new System.Drawing.Point(12, 9);
            this.lblQueryId.Name = "lblQueryId";
            this.lblQueryId.Size = new System.Drawing.Size(56, 13);
            this.lblQueryId.TabIndex = 0;
            this.lblQueryId.Text = "QUERYID";
            // 
            // lblAgentId
            // 
            this.lblAgentId.AutoSize = true;
            this.lblAgentId.Location = new System.Drawing.Point(12, 37);
            this.lblAgentId.Name = "lblAgentId";
            this.lblAgentId.Size = new System.Drawing.Size(82, 13);
            this.lblAgentId.TabIndex = 1;
            this.lblAgentId.Text = "AGENT NAME*";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(12, 72);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(84, 13);
            this.lblUserId.TabIndex = 2;
            this.lblUserId.Text = "ASSIGNED TO*";
            // 
            // lblDstnCvrd
            // 
            this.lblDstnCvrd.AutoSize = true;
            this.lblDstnCvrd.Location = new System.Drawing.Point(12, 190);
            this.lblDstnCvrd.Name = "lblDstnCvrd";
            this.lblDstnCvrd.Size = new System.Drawing.Size(135, 13);
            this.lblDstnCvrd.TabIndex = 5;
            this.lblDstnCvrd.Text = "DESTINATION COVERED";
            // 
            // lblBookDate
            // 
            this.lblBookDate.AutoSize = true;
            this.lblBookDate.Location = new System.Drawing.Point(12, 221);
            this.lblBookDate.Name = "lblBookDate";
            this.lblBookDate.Size = new System.Drawing.Size(43, 13);
            this.lblBookDate.TabIndex = 4;
            this.lblBookDate.Text = "DATES";
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(12, 159);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(72, 13);
            this.lblPlace.TabIndex = 3;
            this.lblPlace.Text = "TOUR NAME";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(12, 531);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(52, 13);
            this.lblBudget.TabIndex = 7;
            this.lblBudget.Text = "BUDGET";
            // 
            // lblPersonCount
            // 
            this.lblPersonCount.AutoSize = true;
            this.lblPersonCount.Location = new System.Drawing.Point(12, 253);
            this.lblPersonCount.Name = "lblPersonCount";
            this.lblPersonCount.Size = new System.Drawing.Size(90, 13);
            this.lblPersonCount.TabIndex = 6;
            this.lblPersonCount.Text = "TOTAL PERSON";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(12, 565);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(37, 13);
            this.lblNote.TabIndex = 8;
            this.lblNote.Text = "NOTE";
            // 
            // lblArvlDprtCity
            // 
            this.lblArvlDprtCity.AutoSize = true;
            this.lblArvlDprtCity.Location = new System.Drawing.Point(12, 424);
            this.lblArvlDprtCity.Name = "lblArvlDprtCity";
            this.lblArvlDprtCity.Size = new System.Drawing.Size(80, 13);
            this.lblArvlDprtCity.TabIndex = 13;
            this.lblArvlDprtCity.Text = "ARRIVAL CITY";
            // 
            // lblArvlDprtDateTime
            // 
            this.lblArvlDprtDateTime.AutoSize = true;
            this.lblArvlDprtDateTime.Location = new System.Drawing.Point(12, 390);
            this.lblArvlDprtDateTime.Name = "lblArvlDprtDateTime";
            this.lblArvlDprtDateTime.Size = new System.Drawing.Size(82, 13);
            this.lblArvlDprtDateTime.TabIndex = 12;
            this.lblArvlDprtDateTime.Text = "ARRIVAL TIME";
            // 
            // lblHotelCtgry
            // 
            this.lblHotelCtgry.AutoSize = true;
            this.lblHotelCtgry.Location = new System.Drawing.Point(12, 355);
            this.lblHotelCtgry.Name = "lblHotelCtgry";
            this.lblHotelCtgry.Size = new System.Drawing.Size(105, 13);
            this.lblHotelCtgry.TabIndex = 11;
            this.lblHotelCtgry.Text = "HOTEL CATEGORY";
            // 
            // lblMeal
            // 
            this.lblMeal.AutoSize = true;
            this.lblMeal.Location = new System.Drawing.Point(12, 320);
            this.lblMeal.Name = "lblMeal";
            this.lblMeal.Size = new System.Drawing.Size(36, 13);
            this.lblMeal.TabIndex = 10;
            this.lblMeal.Text = "MEAL";
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Location = new System.Drawing.Point(12, 287);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(83, 13);
            this.lblRooms.TabIndex = 9;
            this.lblRooms.Text = "NO OF ROOMS";
            // 
            // lblRequirement
            // 
            this.lblRequirement.AutoSize = true;
            this.lblRequirement.Location = new System.Drawing.Point(12, 498);
            this.lblRequirement.Name = "lblRequirement";
            this.lblRequirement.Size = new System.Drawing.Size(87, 13);
            this.lblRequirement.TabIndex = 15;
            this.lblRequirement.Text = "REQUIREMENT";
            // 
            // lblVehicleCtgry
            // 
            this.lblVehicleCtgry.AutoSize = true;
            this.lblVehicleCtgry.Location = new System.Drawing.Point(12, 461);
            this.lblVehicleCtgry.Name = "lblVehicleCtgry";
            this.lblVehicleCtgry.Size = new System.Drawing.Size(114, 13);
            this.lblVehicleCtgry.TabIndex = 14;
            this.lblVehicleCtgry.Text = "VEHICLE CATEGORY";
            // 
            // cmbboxAgentId
            // 
            this.cmbboxAgentId.FormattingEnabled = true;
            this.cmbboxAgentId.Location = new System.Drawing.Point(254, 34);
            this.cmbboxAgentId.Name = "cmbboxAgentId";
            this.cmbboxAgentId.Size = new System.Drawing.Size(204, 21);
            this.cmbboxAgentId.TabIndex = 3;
            // 
            // cmbboxUserId
            // 
            this.cmbboxUserId.FormattingEnabled = true;
            this.cmbboxUserId.Location = new System.Drawing.Point(254, 69);
            this.cmbboxUserId.Name = "cmbboxUserId";
            this.cmbboxUserId.Size = new System.Drawing.Size(204, 21);
            this.cmbboxUserId.TabIndex = 4;
            // 
            // nmbrUpDwnPersonAdult
            // 
            this.nmbrUpDwnPersonAdult.Location = new System.Drawing.Point(307, 249);
            this.nmbrUpDwnPersonAdult.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nmbrUpDwnPersonAdult.Name = "nmbrUpDwnPersonAdult";
            this.nmbrUpDwnPersonAdult.Size = new System.Drawing.Size(55, 20);
            this.nmbrUpDwnPersonAdult.TabIndex = 11;
            // 
            // nmbrUpDwnPersonChild
            // 
            this.nmbrUpDwnPersonChild.Location = new System.Drawing.Point(463, 249);
            this.nmbrUpDwnPersonChild.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nmbrUpDwnPersonChild.Name = "nmbrUpDwnPersonChild";
            this.nmbrUpDwnPersonChild.Size = new System.Drawing.Size(55, 20);
            this.nmbrUpDwnPersonChild.TabIndex = 12;
            // 
            // nmbrUpDwnPersonInfnt
            // 
            this.nmbrUpDwnPersonInfnt.Location = new System.Drawing.Point(612, 249);
            this.nmbrUpDwnPersonInfnt.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nmbrUpDwnPersonInfnt.Name = "nmbrUpDwnPersonInfnt";
            this.nmbrUpDwnPersonInfnt.Size = new System.Drawing.Size(55, 20);
            this.nmbrUpDwnPersonInfnt.TabIndex = 13;
            // 
            // nmbrUpDwnRoomCount
            // 
            this.nmbrUpDwnRoomCount.Location = new System.Drawing.Point(254, 280);
            this.nmbrUpDwnRoomCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmbrUpDwnRoomCount.Name = "nmbrUpDwnRoomCount";
            this.nmbrUpDwnRoomCount.Size = new System.Drawing.Size(55, 20);
            this.nmbrUpDwnRoomCount.TabIndex = 14;
            // 
            // radioBtnMealNoMeal
            // 
            this.radioBtnMealNoMeal.AutoSize = true;
            this.radioBtnMealNoMeal.Location = new System.Drawing.Point(6, 14);
            this.radioBtnMealNoMeal.Name = "radioBtnMealNoMeal";
            this.radioBtnMealNoMeal.Size = new System.Drawing.Size(73, 17);
            this.radioBtnMealNoMeal.TabIndex = 27;
            this.radioBtnMealNoMeal.TabStop = true;
            this.radioBtnMealNoMeal.Text = "NO MEAL";
            this.radioBtnMealNoMeal.UseVisualStyleBackColor = true;
            // 
            // radioBtnMealBrkfstOnly
            // 
            this.radioBtnMealBrkfstOnly.AutoSize = true;
            this.radioBtnMealBrkfstOnly.Location = new System.Drawing.Point(85, 14);
            this.radioBtnMealBrkfstOnly.Name = "radioBtnMealBrkfstOnly";
            this.radioBtnMealBrkfstOnly.Size = new System.Drawing.Size(120, 17);
            this.radioBtnMealBrkfstOnly.TabIndex = 28;
            this.radioBtnMealBrkfstOnly.TabStop = true;
            this.radioBtnMealBrkfstOnly.Text = "BREAKFAST ONLY";
            this.radioBtnMealBrkfstOnly.UseVisualStyleBackColor = true;
            // 
            // radioBtnMealBrkfstLnchDnr
            // 
            this.radioBtnMealBrkfstLnchDnr.AutoSize = true;
            this.radioBtnMealBrkfstLnchDnr.Location = new System.Drawing.Point(359, 14);
            this.radioBtnMealBrkfstLnchDnr.Name = "radioBtnMealBrkfstLnchDnr";
            this.radioBtnMealBrkfstLnchDnr.Size = new System.Drawing.Size(191, 17);
            this.radioBtnMealBrkfstLnchDnr.TabIndex = 30;
            this.radioBtnMealBrkfstLnchDnr.TabStop = true;
            this.radioBtnMealBrkfstLnchDnr.Text = "BREAKFAST + LUNCH + DINNER";
            this.radioBtnMealBrkfstLnchDnr.UseVisualStyleBackColor = true;
            // 
            // radioBtnMealBrkfstDnr
            // 
            this.radioBtnMealBrkfstDnr.AutoSize = true;
            this.radioBtnMealBrkfstDnr.Location = new System.Drawing.Point(211, 14);
            this.radioBtnMealBrkfstDnr.Name = "radioBtnMealBrkfstDnr";
            this.radioBtnMealBrkfstDnr.Size = new System.Drawing.Size(142, 17);
            this.radioBtnMealBrkfstDnr.TabIndex = 29;
            this.radioBtnMealBrkfstDnr.TabStop = true;
            this.radioBtnMealBrkfstDnr.Text = "BREAKFAST + DINNER";
            this.radioBtnMealBrkfstDnr.UseVisualStyleBackColor = true;
            // 
            // chkBox2Star
            // 
            this.chkBox2Star.AutoSize = true;
            this.chkBox2Star.Location = new System.Drawing.Point(6, 16);
            this.chkBox2Star.Name = "chkBox2Star";
            this.chkBox2Star.Size = new System.Drawing.Size(86, 17);
            this.chkBox2Star.TabIndex = 32;
            this.chkBox2Star.Text = "STANDARD";
            this.chkBox2Star.UseVisualStyleBackColor = true;
            // 
            // chkBox4Star
            // 
            this.chkBox4Star.AutoSize = true;
            this.chkBox4Star.Location = new System.Drawing.Point(227, 16);
            this.chkBox4Star.Name = "chkBox4Star";
            this.chkBox4Star.Size = new System.Drawing.Size(82, 17);
            this.chkBox4Star.TabIndex = 34;
            this.chkBox4Star.Text = "SUPERIOR";
            this.chkBox4Star.UseVisualStyleBackColor = true;
            // 
            // chkBox3Star
            // 
            this.chkBox3Star.AutoSize = true;
            this.chkBox3Star.Location = new System.Drawing.Point(125, 16);
            this.chkBox3Star.Name = "chkBox3Star";
            this.chkBox3Star.Size = new System.Drawing.Size(69, 17);
            this.chkBox3Star.TabIndex = 33;
            this.chkBox3Star.Text = "DELUXE";
            this.chkBox3Star.UseVisualStyleBackColor = true;
            // 
            // chkBox5Star
            // 
            this.chkBox5Star.AutoSize = true;
            this.chkBox5Star.Location = new System.Drawing.Point(342, 16);
            this.chkBox5Star.Name = "chkBox5Star";
            this.chkBox5Star.Size = new System.Drawing.Size(70, 17);
            this.chkBox5Star.TabIndex = 35;
            this.chkBox5Star.Text = "LUXORY";
            this.chkBox5Star.UseVisualStyleBackColor = true;
            // 
            // dttmpckrFromDate
            // 
            this.dttmpckrFromDate.Location = new System.Drawing.Point(254, 215);
            this.dttmpckrFromDate.Name = "dttmpckrFromDate";
            this.dttmpckrFromDate.Size = new System.Drawing.Size(204, 20);
            this.dttmpckrFromDate.TabIndex = 9;
            this.dttmpckrFromDate.ValueChanged += new System.EventHandler(this.dttmpckrFromDate_ValueChanged);
            // 
            // dttmpckrToDate
            // 
            this.dttmpckrToDate.Location = new System.Drawing.Point(464, 215);
            this.dttmpckrToDate.Name = "dttmpckrToDate";
            this.dttmpckrToDate.Size = new System.Drawing.Size(203, 20);
            this.dttmpckrToDate.TabIndex = 10;
            this.dttmpckrToDate.ValueChanged += new System.EventHandler(this.dttmpckrToDate_ValueChanged);
            // 
            // txtboxPlace
            // 
            this.txtboxPlace.Location = new System.Drawing.Point(254, 156);
            this.txtboxPlace.Name = "txtboxPlace";
            this.txtboxPlace.Size = new System.Drawing.Size(205, 20);
            this.txtboxPlace.TabIndex = 7;
            // 
            // txtboxDstnCvrd
            // 
            this.txtboxDstnCvrd.Location = new System.Drawing.Point(254, 187);
            this.txtboxDstnCvrd.Name = "txtboxDstnCvrd";
            this.txtboxDstnCvrd.Size = new System.Drawing.Size(413, 20);
            this.txtboxDstnCvrd.TabIndex = 8;
            // 
            // txtboxDptrCity
            // 
            this.txtboxDptrCity.Location = new System.Drawing.Point(567, 420);
            this.txtboxDptrCity.Name = "txtboxDptrCity";
            this.txtboxDptrCity.Size = new System.Drawing.Size(100, 20);
            this.txtboxDptrCity.TabIndex = 20;
            // 
            // txtboxArvlCity
            // 
            this.txtboxArvlCity.Location = new System.Drawing.Point(254, 420);
            this.txtboxArvlCity.Name = "txtboxArvlCity";
            this.txtboxArvlCity.Size = new System.Drawing.Size(100, 20);
            this.txtboxArvlCity.TabIndex = 19;
            // 
            // cmbboxVehicleCtgry
            // 
            this.cmbboxVehicleCtgry.FormattingEnabled = true;
            this.cmbboxVehicleCtgry.Items.AddRange(new object[] {
            "NONE",
            "DESIER/ETIOS (SEDAN)",
            "INNOVA (SUV)",
            "SUMO/ZYLO (SUV)",
            "9 SEATOR (TAMPO TRAVEL)",
            "11 SEATOR (TAMPO TRAVEL)",
            "18 SEATOR (MINI COACH)",
            "27  SEATOR (COACH)",
            "35  SEATOR (LARGE COACH)",
            "45  SEATOR (LARGE COACH)"});
            this.cmbboxVehicleCtgry.Location = new System.Drawing.Point(254, 458);
            this.cmbboxVehicleCtgry.Name = "cmbboxVehicleCtgry";
            this.cmbboxVehicleCtgry.Size = new System.Drawing.Size(204, 21);
            this.cmbboxVehicleCtgry.TabIndex = 21;
            // 
            // txtboxBudget
            // 
            this.txtboxBudget.Location = new System.Drawing.Point(254, 528);
            this.txtboxBudget.Name = "txtboxBudget";
            this.txtboxBudget.Size = new System.Drawing.Size(100, 20);
            this.txtboxBudget.TabIndex = 23;
            this.txtboxBudget.Text = "0";
            // 
            // txtboxNote
            // 
            this.txtboxNote.Location = new System.Drawing.Point(254, 562);
            this.txtboxNote.Multiline = true;
            this.txtboxNote.Name = "txtboxNote";
            this.txtboxNote.Size = new System.Drawing.Size(392, 68);
            this.txtboxNote.TabIndex = 24;
            // 
            // radioBtnRqmntTourPlusFlight
            // 
            this.radioBtnRqmntTourPlusFlight.AutoSize = true;
            this.radioBtnRqmntTourPlusFlight.Location = new System.Drawing.Point(350, 13);
            this.radioBtnRqmntTourPlusFlight.Name = "radioBtnRqmntTourPlusFlight";
            this.radioBtnRqmntTourPlusFlight.Size = new System.Drawing.Size(159, 17);
            this.radioBtnRqmntTourPlusFlight.TabIndex = 47;
            this.radioBtnRqmntTourPlusFlight.TabStop = true;
            this.radioBtnRqmntTourPlusFlight.Text = "TOUR + FLIGHT PACKAGE";
            this.radioBtnRqmntTourPlusFlight.UseVisualStyleBackColor = true;
            // 
            // radioBtnRqmntTourPkg
            // 
            this.radioBtnRqmntTourPkg.AutoSize = true;
            this.radioBtnRqmntTourPkg.Location = new System.Drawing.Point(235, 13);
            this.radioBtnRqmntTourPkg.Name = "radioBtnRqmntTourPkg";
            this.radioBtnRqmntTourPkg.Size = new System.Drawing.Size(109, 17);
            this.radioBtnRqmntTourPkg.TabIndex = 46;
            this.radioBtnRqmntTourPkg.TabStop = true;
            this.radioBtnRqmntTourPkg.Text = "TOUR PACKAGE";
            this.radioBtnRqmntTourPkg.UseVisualStyleBackColor = true;
            // 
            // radioBtnRqmntTrnsprtOnly
            // 
            this.radioBtnRqmntTrnsprtOnly.AutoSize = true;
            this.radioBtnRqmntTrnsprtOnly.Location = new System.Drawing.Point(105, 13);
            this.radioBtnRqmntTrnsprtOnly.Name = "radioBtnRqmntTrnsprtOnly";
            this.radioBtnRqmntTrnsprtOnly.Size = new System.Drawing.Size(124, 17);
            this.radioBtnRqmntTrnsprtOnly.TabIndex = 45;
            this.radioBtnRqmntTrnsprtOnly.TabStop = true;
            this.radioBtnRqmntTrnsprtOnly.Text = "TRANSPORT ONLY";
            this.radioBtnRqmntTrnsprtOnly.UseVisualStyleBackColor = true;
            // 
            // radioBtnRqmntHtlOnly
            // 
            this.radioBtnRqmntHtlOnly.AutoSize = true;
            this.radioBtnRqmntHtlOnly.Location = new System.Drawing.Point(6, 13);
            this.radioBtnRqmntHtlOnly.Name = "radioBtnRqmntHtlOnly";
            this.radioBtnRqmntHtlOnly.Size = new System.Drawing.Size(93, 17);
            this.radioBtnRqmntHtlOnly.TabIndex = 44;
            this.radioBtnRqmntHtlOnly.TabStop = true;
            this.radioBtnRqmntHtlOnly.Text = "HOTEL ONLY";
            this.radioBtnRqmntHtlOnly.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(879, 595);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 35);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbboxQueryId
            // 
            this.cmbboxQueryId.FormattingEnabled = true;
            this.cmbboxQueryId.Location = new System.Drawing.Point(254, 5);
            this.cmbboxQueryId.Name = "cmbboxQueryId";
            this.cmbboxQueryId.Size = new System.Drawing.Size(204, 21);
            this.cmbboxQueryId.TabIndex = 0;
            this.cmbboxQueryId.SelectedIndexChanged += new System.EventHandler(this.cmbboxQueryId_SelectedIndexChanged);
            // 
            // grpboxMeal
            // 
            this.grpboxMeal.Controls.Add(this.radioBtnMealNoMeal);
            this.grpboxMeal.Controls.Add(this.radioBtnMealBrkfstOnly);
            this.grpboxMeal.Controls.Add(this.radioBtnMealBrkfstDnr);
            this.grpboxMeal.Controls.Add(this.radioBtnMealBrkfstLnchDnr);
            this.grpboxMeal.Location = new System.Drawing.Point(254, 306);
            this.grpboxMeal.Name = "grpboxMeal";
            this.grpboxMeal.Size = new System.Drawing.Size(566, 38);
            this.grpboxMeal.TabIndex = 15;
            this.grpboxMeal.TabStop = false;
            // 
            // grpboxRqmnt
            // 
            this.grpboxRqmnt.Controls.Add(this.radioBtnRqmntHtlOnly);
            this.grpboxRqmnt.Controls.Add(this.radioBtnRqmntTrnsprtOnly);
            this.grpboxRqmnt.Controls.Add(this.radioBtnRqmntTourPkg);
            this.grpboxRqmnt.Controls.Add(this.radioBtnRqmntTourPlusFlight);
            this.grpboxRqmnt.Location = new System.Drawing.Point(254, 485);
            this.grpboxRqmnt.Name = "grpboxRqmnt";
            this.grpboxRqmnt.Size = new System.Drawing.Size(526, 36);
            this.grpboxRqmnt.TabIndex = 22;
            this.grpboxRqmnt.TabStop = false;
            // 
            // grpboxHtlCtgry
            // 
            this.grpboxHtlCtgry.Controls.Add(this.chkBox2Star);
            this.grpboxHtlCtgry.Controls.Add(this.chkBox3Star);
            this.grpboxHtlCtgry.Controls.Add(this.chkBox4Star);
            this.grpboxHtlCtgry.Controls.Add(this.chkBox5Star);
            this.grpboxHtlCtgry.Location = new System.Drawing.Point(254, 343);
            this.grpboxHtlCtgry.Name = "grpboxHtlCtgry";
            this.grpboxHtlCtgry.Size = new System.Drawing.Size(413, 39);
            this.grpboxHtlCtgry.TabIndex = 16;
            this.grpboxHtlCtgry.TabStop = false;
            // 
            // btnDeleteQuery
            // 
            this.btnDeleteQuery.Enabled = false;
            this.btnDeleteQuery.Location = new System.Drawing.Point(745, 595);
            this.btnDeleteQuery.Name = "btnDeleteQuery";
            this.btnDeleteQuery.Size = new System.Drawing.Size(128, 35);
            this.btnDeleteQuery.TabIndex = 26;
            this.btnDeleteQuery.Text = "DELETE";
            this.btnDeleteQuery.UseVisualStyleBackColor = true;
            this.btnDeleteQuery.Visible = false;
            this.btnDeleteQuery.Click += new System.EventHandler(this.btnDeleteQuery_Click);
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(251, 112);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(42, 13);
            this.lblClientName.TabIndex = 56;
            this.lblClientName.Text = "NAME*";
            // 
            // txtboxClientName
            // 
            this.txtboxClientName.Location = new System.Drawing.Point(295, 109);
            this.txtboxClientName.Name = "txtboxClientName";
            this.txtboxClientName.Size = new System.Drawing.Size(100, 20);
            this.txtboxClientName.TabIndex = 5;
            // 
            // lblClientContact
            // 
            this.lblClientContact.AutoSize = true;
            this.lblClientContact.Location = new System.Drawing.Point(460, 112);
            this.lblClientContact.Name = "lblClientContact";
            this.lblClientContact.Size = new System.Drawing.Size(90, 13);
            this.lblClientContact.TabIndex = 58;
            this.lblClientContact.Text = "CONTACT INFO*";
            // 
            // txtboxClientContact
            // 
            this.txtboxClientContact.Location = new System.Drawing.Point(552, 109);
            this.txtboxClientContact.Name = "txtboxClientContact";
            this.txtboxClientContact.Size = new System.Drawing.Size(100, 20);
            this.txtboxClientContact.TabIndex = 6;
            // 
            // dttmpkrDptrDate
            // 
            this.dttmpkrDptrDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dttmpkrDptrDate.Location = new System.Drawing.Point(571, 386);
            this.dttmpkrDptrDate.Name = "dttmpkrDptrDate";
            this.dttmpkrDptrDate.ShowUpDown = true;
            this.dttmpkrDptrDate.Size = new System.Drawing.Size(96, 20);
            this.dttmpkrDptrDate.TabIndex = 18;
            // 
            // dttmpkrArvlDate
            // 
            this.dttmpkrArvlDate.Checked = false;
            this.dttmpkrArvlDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dttmpkrArvlDate.Location = new System.Drawing.Point(254, 386);
            this.dttmpkrArvlDate.Name = "dttmpkrArvlDate";
            this.dttmpkrArvlDate.ShowUpDown = true;
            this.dttmpkrArvlDate.Size = new System.Drawing.Size(116, 20);
            this.dttmpkrArvlDate.TabIndex = 17;
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Location = new System.Drawing.Point(462, 390);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(103, 13);
            this.lblDepartureTime.TabIndex = 60;
            this.lblDepartureTime.Text = "DEPARTURE TIME";
            // 
            // lblDepartureCity
            // 
            this.lblDepartureCity.AutoSize = true;
            this.lblDepartureCity.Location = new System.Drawing.Point(460, 424);
            this.lblDepartureCity.Name = "lblDepartureCity";
            this.lblDepartureCity.Size = new System.Drawing.Size(101, 13);
            this.lblDepartureCity.TabIndex = 61;
            this.lblDepartureCity.Text = "DEPARTURE CITY";
            // 
            // lblAdults
            // 
            this.lblAdults.AutoSize = true;
            this.lblAdults.Location = new System.Drawing.Point(251, 253);
            this.lblAdults.Name = "lblAdults";
            this.lblAdults.Size = new System.Drawing.Size(50, 13);
            this.lblAdults.TabIndex = 62;
            this.lblAdults.Text = "ADULTS";
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.Location = new System.Drawing.Point(396, 253);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(62, 13);
            this.lblChildren.TabIndex = 63;
            this.lblChildren.Text = "CHILDREN";
            // 
            // lblBabies
            // 
            this.lblBabies.AutoSize = true;
            this.lblBabies.Location = new System.Drawing.Point(554, 253);
            this.lblBabies.Name = "lblBabies";
            this.lblBabies.Size = new System.Drawing.Size(53, 13);
            this.lblBabies.TabIndex = 64;
            this.lblBabies.Text = "INFANTS";
            // 
            // txtBoxGST
            // 
            this.txtBoxGST.Location = new System.Drawing.Point(768, 5);
            this.txtBoxGST.Name = "txtBoxGST";
            this.txtBoxGST.Size = new System.Drawing.Size(59, 20);
            this.txtBoxGST.TabIndex = 2;
            // 
            // lblGST
            // 
            this.lblGST.AutoSize = true;
            this.lblGST.Location = new System.Drawing.Point(697, 9);
            this.lblGST.Name = "lblGST";
            this.lblGST.Size = new System.Drawing.Size(65, 13);
            this.lblGST.TabIndex = 68;
            this.lblGST.Text = "GST RATE*";
            // 
            // txtBoxMargin
            // 
            this.txtBoxMargin.Location = new System.Drawing.Point(582, 5);
            this.txtBoxMargin.Name = "txtBoxMargin";
            this.txtBoxMargin.Size = new System.Drawing.Size(63, 20);
            this.txtBoxMargin.TabIndex = 1;
            // 
            // lblMargin
            // 
            this.lblMargin.AutoSize = true;
            this.lblMargin.Location = new System.Drawing.Point(525, 9);
            this.lblMargin.Name = "lblMargin";
            this.lblMargin.Size = new System.Drawing.Size(54, 13);
            this.lblMargin.TabIndex = 67;
            this.lblMargin.Text = "MARGIN*";
            // 
            // lblClientInfo
            // 
            this.lblClientInfo.AutoSize = true;
            this.lblClientInfo.Location = new System.Drawing.Point(12, 112);
            this.lblClientInfo.Name = "lblClientInfo";
            this.lblClientInfo.Size = new System.Drawing.Size(45, 13);
            this.lblClientInfo.TabIndex = 69;
            this.lblClientInfo.Text = "CLIENT";
            // 
            // txtBoxUsdRate
            // 
            this.txtBoxUsdRate.Location = new System.Drawing.Point(959, 5);
            this.txtBoxUsdRate.Name = "txtBoxUsdRate";
            this.txtBoxUsdRate.Size = new System.Drawing.Size(48, 20);
            this.txtBoxUsdRate.TabIndex = 70;
            this.txtBoxUsdRate.Text = "0.00";
            // 
            // lblUsdRate
            // 
            this.lblUsdRate.AutoSize = true;
            this.lblUsdRate.Location = new System.Drawing.Point(888, 9);
            this.lblUsdRate.Name = "lblUsdRate";
            this.lblUsdRate.Size = new System.Drawing.Size(62, 13);
            this.lblUsdRate.TabIndex = 71;
            this.lblUsdRate.Text = "USD RATE";
            // 
            // FrmEditQueryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 642);
            this.Controls.Add(this.txtBoxUsdRate);
            this.Controls.Add(this.lblUsdRate);
            this.Controls.Add(this.lblClientInfo);
            this.Controls.Add(this.txtBoxGST);
            this.Controls.Add(this.lblGST);
            this.Controls.Add(this.txtBoxMargin);
            this.Controls.Add(this.lblMargin);
            this.Controls.Add(this.lblBabies);
            this.Controls.Add(this.lblChildren);
            this.Controls.Add(this.lblAdults);
            this.Controls.Add(this.lblDepartureCity);
            this.Controls.Add(this.lblDepartureTime);
            this.Controls.Add(this.txtboxClientContact);
            this.Controls.Add(this.lblClientContact);
            this.Controls.Add(this.txtboxClientName);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.btnDeleteQuery);
            this.Controls.Add(this.grpboxHtlCtgry);
            this.Controls.Add(this.grpboxRqmnt);
            this.Controls.Add(this.grpboxMeal);
            this.Controls.Add(this.cmbboxQueryId);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtboxNote);
            this.Controls.Add(this.txtboxBudget);
            this.Controls.Add(this.cmbboxVehicleCtgry);
            this.Controls.Add(this.txtboxDptrCity);
            this.Controls.Add(this.txtboxArvlCity);
            this.Controls.Add(this.dttmpkrDptrDate);
            this.Controls.Add(this.dttmpkrArvlDate);
            this.Controls.Add(this.nmbrUpDwnRoomCount);
            this.Controls.Add(this.nmbrUpDwnPersonInfnt);
            this.Controls.Add(this.nmbrUpDwnPersonChild);
            this.Controls.Add(this.nmbrUpDwnPersonAdult);
            this.Controls.Add(this.dttmpckrToDate);
            this.Controls.Add(this.dttmpckrFromDate);
            this.Controls.Add(this.txtboxDstnCvrd);
            this.Controls.Add(this.txtboxPlace);
            this.Controls.Add(this.cmbboxUserId);
            this.Controls.Add(this.cmbboxAgentId);
            this.Controls.Add(this.lblRequirement);
            this.Controls.Add(this.lblVehicleCtgry);
            this.Controls.Add(this.lblArvlDprtCity);
            this.Controls.Add(this.lblArvlDprtDateTime);
            this.Controls.Add(this.lblHotelCtgry);
            this.Controls.Add(this.lblMeal);
            this.Controls.Add(this.lblRooms);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblPersonCount);
            this.Controls.Add(this.lblDstnCvrd);
            this.Controls.Add(this.lblBookDate);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblAgentId);
            this.Controls.Add(this.lblQueryId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmEditQueryPage";
            this.Text = "Query";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEditQueryPage_FormClosing);
            this.Load += new System.EventHandler(this.FrmEditQueryPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmbrUpDwnPersonAdult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrUpDwnPersonChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrUpDwnPersonInfnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrUpDwnRoomCount)).EndInit();
            this.grpboxMeal.ResumeLayout(false);
            this.grpboxMeal.PerformLayout();
            this.grpboxRqmnt.ResumeLayout(false);
            this.grpboxRqmnt.PerformLayout();
            this.grpboxHtlCtgry.ResumeLayout(false);
            this.grpboxHtlCtgry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQueryId;
        private System.Windows.Forms.Label lblAgentId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblDstnCvrd;
        private System.Windows.Forms.Label lblBookDate;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblPersonCount;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblArvlDprtCity;
        private System.Windows.Forms.Label lblArvlDprtDateTime;
        private System.Windows.Forms.Label lblHotelCtgry;
        private System.Windows.Forms.Label lblMeal;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.Label lblRequirement;
        private System.Windows.Forms.Label lblVehicleCtgry;
        private System.Windows.Forms.ComboBox cmbboxAgentId;
        private System.Windows.Forms.ComboBox cmbboxUserId;
        private System.Windows.Forms.NumericUpDown nmbrUpDwnPersonAdult;
        private System.Windows.Forms.NumericUpDown nmbrUpDwnPersonChild;
        private System.Windows.Forms.NumericUpDown nmbrUpDwnPersonInfnt;
        private System.Windows.Forms.NumericUpDown nmbrUpDwnRoomCount;
        private System.Windows.Forms.RadioButton radioBtnMealNoMeal;
        private System.Windows.Forms.RadioButton radioBtnMealBrkfstOnly;
        private System.Windows.Forms.RadioButton radioBtnMealBrkfstLnchDnr;
        private System.Windows.Forms.RadioButton radioBtnMealBrkfstDnr;
        private System.Windows.Forms.CheckBox chkBox2Star;
        private System.Windows.Forms.CheckBox chkBox4Star;
        private System.Windows.Forms.CheckBox chkBox3Star;
        private System.Windows.Forms.CheckBox chkBox5Star;
        private System.Windows.Forms.DateTimePicker dttmpckrFromDate;
        private System.Windows.Forms.DateTimePicker dttmpckrToDate;
        private System.Windows.Forms.TextBox txtboxPlace;
        private System.Windows.Forms.TextBox txtboxDstnCvrd;
        private System.Windows.Forms.TextBox txtboxDptrCity;
        private System.Windows.Forms.TextBox txtboxArvlCity;
        private System.Windows.Forms.ComboBox cmbboxVehicleCtgry;
        private System.Windows.Forms.TextBox txtboxBudget;
        private System.Windows.Forms.TextBox txtboxNote;
        private System.Windows.Forms.RadioButton radioBtnRqmntTourPlusFlight;
        private System.Windows.Forms.RadioButton radioBtnRqmntTourPkg;
        private System.Windows.Forms.RadioButton radioBtnRqmntTrnsprtOnly;
        private System.Windows.Forms.RadioButton radioBtnRqmntHtlOnly;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbboxQueryId;
        private System.Windows.Forms.GroupBox grpboxMeal;
        private System.Windows.Forms.GroupBox grpboxRqmnt;
        private System.Windows.Forms.GroupBox grpboxHtlCtgry;
        private System.Windows.Forms.Button btnDeleteQuery;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TextBox txtboxClientName;
        private System.Windows.Forms.Label lblClientContact;
        private System.Windows.Forms.TextBox txtboxClientContact;
        private System.Windows.Forms.DateTimePicker dttmpkrDptrDate;
        private System.Windows.Forms.DateTimePicker dttmpkrArvlDate;
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.Label lblDepartureCity;
        private System.Windows.Forms.Label lblAdults;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.Label lblBabies;
        private System.Windows.Forms.TextBox txtBoxGST;
        private System.Windows.Forms.Label lblGST;
        private System.Windows.Forms.TextBox txtBoxMargin;
        private System.Windows.Forms.Label lblMargin;
        private System.Windows.Forms.Label lblClientInfo;
        private System.Windows.Forms.TextBox txtBoxUsdRate;
        private System.Windows.Forms.Label lblUsdRate;
    }
}

