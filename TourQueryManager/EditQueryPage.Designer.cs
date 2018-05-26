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
            this.lnklblModifyQuery = new System.Windows.Forms.LinkLabel();
            this.grpboxHtlCtgry = new System.Windows.Forms.GroupBox();
            this.btnLoadQuery = new System.Windows.Forms.Button();
            this.btnDeleteQuery = new System.Windows.Forms.Button();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txtboxClientName = new System.Windows.Forms.TextBox();
            this.lblClientContact = new System.Windows.Forms.Label();
            this.txtboxClientContact = new System.Windows.Forms.TextBox();
            this.dttmpkrDptrDate = new System.Windows.Forms.DateTimePicker();
            this.dttmpkrArvlDate = new System.Windows.Forms.DateTimePicker();
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
            this.lblAgentId.Size = new System.Drawing.Size(78, 13);
            this.lblAgentId.TabIndex = 1;
            this.lblAgentId.Text = "AGENT NAME";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(12, 72);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(80, 13);
            this.lblUserId.TabIndex = 2;
            this.lblUserId.Text = "ASSIGNED TO";
            // 
            // lblDstnCvrd
            // 
            this.lblDstnCvrd.AutoSize = true;
            this.lblDstnCvrd.Location = new System.Drawing.Point(12, 139);
            this.lblDstnCvrd.Name = "lblDstnCvrd";
            this.lblDstnCvrd.Size = new System.Drawing.Size(135, 13);
            this.lblDstnCvrd.TabIndex = 5;
            this.lblDstnCvrd.Text = "DESTINATION COVERED";
            // 
            // lblBookDate
            // 
            this.lblBookDate.AutoSize = true;
            this.lblBookDate.Location = new System.Drawing.Point(12, 170);
            this.lblBookDate.Name = "lblBookDate";
            this.lblBookDate.Size = new System.Drawing.Size(43, 13);
            this.lblBookDate.TabIndex = 4;
            this.lblBookDate.Text = "DATES";
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(12, 108);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(41, 13);
            this.lblPlace.TabIndex = 3;
            this.lblPlace.Text = "PLACE";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(12, 480);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(52, 13);
            this.lblBudget.TabIndex = 7;
            this.lblBudget.Text = "BUDGET";
            // 
            // lblPersonCount
            // 
            this.lblPersonCount.AutoSize = true;
            this.lblPersonCount.Location = new System.Drawing.Point(12, 202);
            this.lblPersonCount.Name = "lblPersonCount";
            this.lblPersonCount.Size = new System.Drawing.Size(90, 13);
            this.lblPersonCount.TabIndex = 6;
            this.lblPersonCount.Text = "TOTAL PERSON";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(12, 514);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(37, 13);
            this.lblNote.TabIndex = 8;
            this.lblNote.Text = "NOTE";
            // 
            // lblArvlDprtCity
            // 
            this.lblArvlDprtCity.AutoSize = true;
            this.lblArvlDprtCity.Location = new System.Drawing.Point(12, 376);
            this.lblArvlDprtCity.Name = "lblArvlDprtCity";
            this.lblArvlDprtCity.Size = new System.Drawing.Size(176, 13);
            this.lblArvlDprtCity.TabIndex = 13;
            this.lblArvlDprtCity.Text = "ARRIVAL AND DEPARTURE CITY";
            // 
            // lblArvlDprtDateTime
            // 
            this.lblArvlDprtDateTime.AutoSize = true;
            this.lblArvlDprtDateTime.Location = new System.Drawing.Point(12, 339);
            this.lblArvlDprtDateTime.Name = "lblArvlDprtDateTime";
            this.lblArvlDprtDateTime.Size = new System.Drawing.Size(178, 13);
            this.lblArvlDprtDateTime.TabIndex = 12;
            this.lblArvlDprtDateTime.Text = "ARRIVAL AND DEPARTURE TIME";
            // 
            // lblHotelCtgry
            // 
            this.lblHotelCtgry.AutoSize = true;
            this.lblHotelCtgry.Location = new System.Drawing.Point(12, 304);
            this.lblHotelCtgry.Name = "lblHotelCtgry";
            this.lblHotelCtgry.Size = new System.Drawing.Size(105, 13);
            this.lblHotelCtgry.TabIndex = 11;
            this.lblHotelCtgry.Text = "HOTEL CATEGORY";
            // 
            // lblMeal
            // 
            this.lblMeal.AutoSize = true;
            this.lblMeal.Location = new System.Drawing.Point(12, 269);
            this.lblMeal.Name = "lblMeal";
            this.lblMeal.Size = new System.Drawing.Size(36, 13);
            this.lblMeal.TabIndex = 10;
            this.lblMeal.Text = "MEAL";
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Location = new System.Drawing.Point(12, 236);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(83, 13);
            this.lblRooms.TabIndex = 9;
            this.lblRooms.Text = "NO OF ROOMS";
            // 
            // lblRequirement
            // 
            this.lblRequirement.AutoSize = true;
            this.lblRequirement.Location = new System.Drawing.Point(12, 447);
            this.lblRequirement.Name = "lblRequirement";
            this.lblRequirement.Size = new System.Drawing.Size(87, 13);
            this.lblRequirement.TabIndex = 15;
            this.lblRequirement.Text = "REQUIREMENT";
            // 
            // lblVehicleCtgry
            // 
            this.lblVehicleCtgry.AutoSize = true;
            this.lblVehicleCtgry.Location = new System.Drawing.Point(12, 410);
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
            this.cmbboxAgentId.TabIndex = 17;
            // 
            // cmbboxUserId
            // 
            this.cmbboxUserId.FormattingEnabled = true;
            this.cmbboxUserId.Location = new System.Drawing.Point(254, 69);
            this.cmbboxUserId.Name = "cmbboxUserId";
            this.cmbboxUserId.Size = new System.Drawing.Size(204, 21);
            this.cmbboxUserId.TabIndex = 18;
            // 
            // nmbrUpDwnPersonAdult
            // 
            this.nmbrUpDwnPersonAdult.Location = new System.Drawing.Point(254, 200);
            this.nmbrUpDwnPersonAdult.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nmbrUpDwnPersonAdult.Name = "nmbrUpDwnPersonAdult";
            this.nmbrUpDwnPersonAdult.Size = new System.Drawing.Size(55, 20);
            this.nmbrUpDwnPersonAdult.TabIndex = 23;
            // 
            // nmbrUpDwnPersonChild
            // 
            this.nmbrUpDwnPersonChild.Location = new System.Drawing.Point(315, 200);
            this.nmbrUpDwnPersonChild.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nmbrUpDwnPersonChild.Name = "nmbrUpDwnPersonChild";
            this.nmbrUpDwnPersonChild.Size = new System.Drawing.Size(55, 20);
            this.nmbrUpDwnPersonChild.TabIndex = 24;
            // 
            // nmbrUpDwnPersonInfnt
            // 
            this.nmbrUpDwnPersonInfnt.Location = new System.Drawing.Point(376, 200);
            this.nmbrUpDwnPersonInfnt.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nmbrUpDwnPersonInfnt.Name = "nmbrUpDwnPersonInfnt";
            this.nmbrUpDwnPersonInfnt.Size = new System.Drawing.Size(55, 20);
            this.nmbrUpDwnPersonInfnt.TabIndex = 25;
            // 
            // nmbrUpDwnRoomCount
            // 
            this.nmbrUpDwnRoomCount.Location = new System.Drawing.Point(254, 229);
            this.nmbrUpDwnRoomCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmbrUpDwnRoomCount.Name = "nmbrUpDwnRoomCount";
            this.nmbrUpDwnRoomCount.Size = new System.Drawing.Size(55, 20);
            this.nmbrUpDwnRoomCount.TabIndex = 26;
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
            this.chkBox2Star.Location = new System.Drawing.Point(6, 12);
            this.chkBox2Star.Name = "chkBox2Star";
            this.chkBox2Star.Size = new System.Drawing.Size(57, 17);
            this.chkBox2Star.TabIndex = 32;
            this.chkBox2Star.Text = "BASIC";
            this.chkBox2Star.UseVisualStyleBackColor = true;
            // 
            // chkBox4Star
            // 
            this.chkBox4Star.AutoSize = true;
            this.chkBox4Star.Location = new System.Drawing.Point(146, 12);
            this.chkBox4Star.Name = "chkBox4Star";
            this.chkBox4Star.Size = new System.Drawing.Size(64, 17);
            this.chkBox4Star.TabIndex = 34;
            this.chkBox4Star.Text = "4 STAR";
            this.chkBox4Star.UseVisualStyleBackColor = true;
            // 
            // chkBox3Star
            // 
            this.chkBox3Star.AutoSize = true;
            this.chkBox3Star.Location = new System.Drawing.Point(76, 12);
            this.chkBox3Star.Name = "chkBox3Star";
            this.chkBox3Star.Size = new System.Drawing.Size(64, 17);
            this.chkBox3Star.TabIndex = 33;
            this.chkBox3Star.Text = "3 STAR";
            this.chkBox3Star.UseVisualStyleBackColor = true;
            // 
            // chkBox5Star
            // 
            this.chkBox5Star.AutoSize = true;
            this.chkBox5Star.Location = new System.Drawing.Point(216, 12);
            this.chkBox5Star.Name = "chkBox5Star";
            this.chkBox5Star.Size = new System.Drawing.Size(64, 17);
            this.chkBox5Star.TabIndex = 35;
            this.chkBox5Star.Text = "5 STAR";
            this.chkBox5Star.UseVisualStyleBackColor = true;
            // 
            // dttmpckrFromDate
            // 
            this.dttmpckrFromDate.Location = new System.Drawing.Point(254, 164);
            this.dttmpckrFromDate.Name = "dttmpckrFromDate";
            this.dttmpckrFromDate.Size = new System.Drawing.Size(204, 20);
            this.dttmpckrFromDate.TabIndex = 21;
            this.dttmpckrFromDate.ValueChanged += new System.EventHandler(this.dttmpckrFromDate_ValueChanged);
            // 
            // dttmpckrToDate
            // 
            this.dttmpckrToDate.Location = new System.Drawing.Point(464, 164);
            this.dttmpckrToDate.Name = "dttmpckrToDate";
            this.dttmpckrToDate.Size = new System.Drawing.Size(203, 20);
            this.dttmpckrToDate.TabIndex = 22;
            this.dttmpckrToDate.ValueChanged += new System.EventHandler(this.dttmpckrToDate_ValueChanged);
            // 
            // txtboxPlace
            // 
            this.txtboxPlace.Location = new System.Drawing.Point(254, 105);
            this.txtboxPlace.Name = "txtboxPlace";
            this.txtboxPlace.Size = new System.Drawing.Size(205, 20);
            this.txtboxPlace.TabIndex = 19;
            // 
            // txtboxDstnCvrd
            // 
            this.txtboxDstnCvrd.Location = new System.Drawing.Point(254, 136);
            this.txtboxDstnCvrd.Name = "txtboxDstnCvrd";
            this.txtboxDstnCvrd.Size = new System.Drawing.Size(413, 20);
            this.txtboxDstnCvrd.TabIndex = 20;
            // 
            // txtboxDptrCity
            // 
            this.txtboxDptrCity.Location = new System.Drawing.Point(360, 373);
            this.txtboxDptrCity.Name = "txtboxDptrCity";
            this.txtboxDptrCity.Size = new System.Drawing.Size(100, 20);
            this.txtboxDptrCity.TabIndex = 39;
            // 
            // txtboxArvlCity
            // 
            this.txtboxArvlCity.Location = new System.Drawing.Point(254, 373);
            this.txtboxArvlCity.Name = "txtboxArvlCity";
            this.txtboxArvlCity.Size = new System.Drawing.Size(100, 20);
            this.txtboxArvlCity.TabIndex = 38;
            // 
            // cmbboxVehicleCtgry
            // 
            this.cmbboxVehicleCtgry.FormattingEnabled = true;
            this.cmbboxVehicleCtgry.Location = new System.Drawing.Point(254, 407);
            this.cmbboxVehicleCtgry.Name = "cmbboxVehicleCtgry";
            this.cmbboxVehicleCtgry.Size = new System.Drawing.Size(121, 21);
            this.cmbboxVehicleCtgry.TabIndex = 40;
            // 
            // txtboxBudget
            // 
            this.txtboxBudget.Location = new System.Drawing.Point(254, 477);
            this.txtboxBudget.Name = "txtboxBudget";
            this.txtboxBudget.Size = new System.Drawing.Size(100, 20);
            this.txtboxBudget.TabIndex = 42;
            this.txtboxBudget.Text = "0";
            // 
            // txtboxNote
            // 
            this.txtboxNote.Location = new System.Drawing.Point(254, 511);
            this.txtboxNote.Multiline = true;
            this.txtboxNote.Name = "txtboxNote";
            this.txtboxNote.Size = new System.Drawing.Size(392, 68);
            this.txtboxNote.TabIndex = 43;
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
            this.btnUpdate.Location = new System.Drawing.Point(714, 544);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 35);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbboxQueryId
            // 
            this.cmbboxQueryId.FormattingEnabled = true;
            this.cmbboxQueryId.Location = new System.Drawing.Point(254, 6);
            this.cmbboxQueryId.Name = "cmbboxQueryId";
            this.cmbboxQueryId.Size = new System.Drawing.Size(204, 21);
            this.cmbboxQueryId.TabIndex = 49;
            // 
            // grpboxMeal
            // 
            this.grpboxMeal.Controls.Add(this.radioBtnMealNoMeal);
            this.grpboxMeal.Controls.Add(this.radioBtnMealBrkfstOnly);
            this.grpboxMeal.Controls.Add(this.radioBtnMealBrkfstDnr);
            this.grpboxMeal.Controls.Add(this.radioBtnMealBrkfstLnchDnr);
            this.grpboxMeal.Location = new System.Drawing.Point(254, 255);
            this.grpboxMeal.Name = "grpboxMeal";
            this.grpboxMeal.Size = new System.Drawing.Size(566, 38);
            this.grpboxMeal.TabIndex = 50;
            this.grpboxMeal.TabStop = false;
            // 
            // grpboxRqmnt
            // 
            this.grpboxRqmnt.Controls.Add(this.radioBtnRqmntHtlOnly);
            this.grpboxRqmnt.Controls.Add(this.radioBtnRqmntTrnsprtOnly);
            this.grpboxRqmnt.Controls.Add(this.radioBtnRqmntTourPkg);
            this.grpboxRqmnt.Controls.Add(this.radioBtnRqmntTourPlusFlight);
            this.grpboxRqmnt.Location = new System.Drawing.Point(254, 434);
            this.grpboxRqmnt.Name = "grpboxRqmnt";
            this.grpboxRqmnt.Size = new System.Drawing.Size(526, 36);
            this.grpboxRqmnt.TabIndex = 51;
            this.grpboxRqmnt.TabStop = false;
            // 
            // lnklblModifyQuery
            // 
            this.lnklblModifyQuery.AutoSize = true;
            this.lnklblModifyQuery.Location = new System.Drawing.Point(616, 4);
            this.lnklblModifyQuery.Name = "lnklblModifyQuery";
            this.lnklblModifyQuery.Size = new System.Drawing.Size(226, 13);
            this.lnklblModifyQuery.TabIndex = 52;
            this.lnklblModifyQuery.TabStop = true;
            this.lnklblModifyQuery.Text = "CLICK HERE TO MODIFY EXISTING QUERY";
            this.lnklblModifyQuery.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblModifyQuery_LinkClicked);
            // 
            // grpboxHtlCtgry
            // 
            this.grpboxHtlCtgry.Controls.Add(this.chkBox2Star);
            this.grpboxHtlCtgry.Controls.Add(this.chkBox3Star);
            this.grpboxHtlCtgry.Controls.Add(this.chkBox4Star);
            this.grpboxHtlCtgry.Controls.Add(this.chkBox5Star);
            this.grpboxHtlCtgry.Location = new System.Drawing.Point(254, 292);
            this.grpboxHtlCtgry.Name = "grpboxHtlCtgry";
            this.grpboxHtlCtgry.Size = new System.Drawing.Size(280, 39);
            this.grpboxHtlCtgry.TabIndex = 53;
            this.grpboxHtlCtgry.TabStop = false;
            // 
            // btnLoadQuery
            // 
            this.btnLoadQuery.Enabled = false;
            this.btnLoadQuery.Location = new System.Drawing.Point(470, 4);
            this.btnLoadQuery.Name = "btnLoadQuery";
            this.btnLoadQuery.Size = new System.Drawing.Size(113, 23);
            this.btnLoadQuery.TabIndex = 54;
            this.btnLoadQuery.Text = "LOAD";
            this.btnLoadQuery.UseVisualStyleBackColor = true;
            this.btnLoadQuery.Visible = false;
            this.btnLoadQuery.Click += new System.EventHandler(this.btnLoadQuery_Click);
            // 
            // btnDeleteQuery
            // 
            this.btnDeleteQuery.Enabled = false;
            this.btnDeleteQuery.Location = new System.Drawing.Point(15, 544);
            this.btnDeleteQuery.Name = "btnDeleteQuery";
            this.btnDeleteQuery.Size = new System.Drawing.Size(128, 35);
            this.btnDeleteQuery.TabIndex = 55;
            this.btnDeleteQuery.Text = "DELETE";
            this.btnDeleteQuery.UseVisualStyleBackColor = true;
            this.btnDeleteQuery.Visible = false;
            this.btnDeleteQuery.Click += new System.EventHandler(this.btnDeleteQuery_Click);
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(525, 45);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(35, 13);
            this.lblClientName.TabIndex = 56;
            this.lblClientName.Text = "Name";
            // 
            // txtboxClientName
            // 
            this.txtboxClientName.Location = new System.Drawing.Point(567, 42);
            this.txtboxClientName.Name = "txtboxClientName";
            this.txtboxClientName.Size = new System.Drawing.Size(100, 20);
            this.txtboxClientName.TabIndex = 57;
            // 
            // lblClientContact
            // 
            this.lblClientContact.AutoSize = true;
            this.lblClientContact.Location = new System.Drawing.Point(698, 45);
            this.lblClientContact.Name = "lblClientContact";
            this.lblClientContact.Size = new System.Drawing.Size(65, 13);
            this.lblClientContact.TabIndex = 58;
            this.lblClientContact.Text = "Contact Info";
            // 
            // txtboxClientContact
            // 
            this.txtboxClientContact.Location = new System.Drawing.Point(769, 42);
            this.txtboxClientContact.Name = "txtboxClientContact";
            this.txtboxClientContact.Size = new System.Drawing.Size(100, 20);
            this.txtboxClientContact.TabIndex = 59;
            // 
            // dttmpkrDptrDate
            // 
            this.dttmpkrDptrDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dttmpkrDptrDate.Location = new System.Drawing.Point(464, 333);
            this.dttmpkrDptrDate.Name = "dttmpkrDptrDate";
            this.dttmpkrDptrDate.ShowUpDown = true;
            this.dttmpkrDptrDate.Size = new System.Drawing.Size(70, 20);
            this.dttmpkrDptrDate.TabIndex = 37;
            // 
            // dttmpkrArvlDate
            // 
            this.dttmpkrArvlDate.Checked = false;
            this.dttmpkrArvlDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dttmpkrArvlDate.Location = new System.Drawing.Point(254, 333);
            this.dttmpkrArvlDate.Name = "dttmpkrArvlDate";
            this.dttmpkrArvlDate.ShowUpDown = true;
            this.dttmpkrArvlDate.Size = new System.Drawing.Size(70, 20);
            this.dttmpkrArvlDate.TabIndex = 36;
            // 
            // FrmEditQueryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 642);
            this.Controls.Add(this.txtboxClientContact);
            this.Controls.Add(this.lblClientContact);
            this.Controls.Add(this.txtboxClientName);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.btnDeleteQuery);
            this.Controls.Add(this.btnLoadQuery);
            this.Controls.Add(this.grpboxHtlCtgry);
            this.Controls.Add(this.lnklblModifyQuery);
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
        private System.Windows.Forms.LinkLabel lnklblModifyQuery;
        private System.Windows.Forms.GroupBox grpboxHtlCtgry;
        private System.Windows.Forms.Button btnLoadQuery;
        private System.Windows.Forms.Button btnDeleteQuery;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TextBox txtboxClientName;
        private System.Windows.Forms.Label lblClientContact;
        private System.Windows.Forms.TextBox txtboxClientContact;
        private System.Windows.Forms.DateTimePicker dttmpkrDptrDate;
        private System.Windows.Forms.DateTimePicker dttmpkrArvlDate;
    }
}

