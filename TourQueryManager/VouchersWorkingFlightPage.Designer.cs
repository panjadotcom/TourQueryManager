namespace TourQueryManager
{
    partial class FrmVouchersWorkingFlightPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVouchersWorkingFlightPage));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelInformation = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxCurrentStatus = new System.Windows.Forms.GroupBox();
            this.dataGridViewCurrentStatus = new System.Windows.Forms.DataGridView();
            this.groupBoxRequirement = new System.Windows.Forms.GroupBox();
            this.txtBoxRequirement = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelInputDetails = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxAircraftNo = new System.Windows.Forms.TextBox();
            this.txtBoxFlightClass = new System.Windows.Forms.TextBox();
            this.txtBoxFlightNo = new System.Windows.Forms.TextBox();
            this.dateTimePickerArrTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerArrDate = new System.Windows.Forms.DateTimePicker();
            this.txtBoxArrAirPort = new System.Windows.Forms.TextBox();
            this.txtBoxArrTerminal = new System.Windows.Forms.TextBox();
            this.dateTimePickerDeptTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDeptDate = new System.Windows.Forms.DateTimePicker();
            this.txtBoxDeptTerminal = new System.Windows.Forms.TextBox();
            this.txtBoxDeptAirport = new System.Windows.Forms.TextBox();
            this.lblBookingDate = new System.Windows.Forms.Label();
            this.lblPersonCount = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.txtBoxPnr = new System.Windows.Forms.TextBox();
            this.dateTimePickerIssueDate = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownPassangerCount = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewPassangerDetails = new System.Windows.Forms.DataGridView();
            this.PassangerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeatNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassangerTicketNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassangerFfy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPnrNumber = new System.Windows.Forms.Label();
            this.lblFlightNo = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblAircraftNo = new System.Windows.Forms.Label();
            this.lblDeptAirport = new System.Windows.Forms.Label();
            this.lblDeptDateTime = new System.Windows.Forms.Label();
            this.lblArrAirPort = new System.Windows.Forms.Label();
            this.lblArrDateTime = new System.Windows.Forms.Label();
            this.lblFlightDetails = new System.Windows.Forms.Label();
            this.comboBoxFlightStatus = new System.Windows.Forms.ComboBox();
            this.txtBoxAirlineRef = new System.Windows.Forms.TextBox();
            this.txtBoxMeal = new System.Windows.Forms.TextBox();
            this.numericUpDownStops = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAirLineRef = new System.Windows.Forms.Label();
            this.lblMeal = new System.Windows.Forms.Label();
            this.labelBaggage = new System.Windows.Forms.Label();
            this.lblStops = new System.Windows.Forms.Label();
            this.txtBoxFare = new System.Windows.Forms.TextBox();
            this.txtBoxGst = new System.Windows.Forms.TextBox();
            this.txtBoxSurcharge = new System.Windows.Forms.TextBox();
            this.txtBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.checkBoxConnectingFlight = new System.Windows.Forms.CheckBox();
            this.lblFare = new System.Windows.Forms.Label();
            this.lblGst = new System.Windows.Forms.Label();
            this.lblSurcharge = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtBoxBaggageLimit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanelInformation.SuspendLayout();
            this.groupBoxCurrentStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrentStatus)).BeginInit();
            this.groupBoxRequirement.SuspendLayout();
            this.tableLayoutPanelInputDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPassangerCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassangerDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStops)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanelInformation);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanelInputDetails);
            this.splitContainer1.Size = new System.Drawing.Size(957, 587);
            this.splitContainer1.SplitterDistance = 447;
            this.splitContainer1.TabIndex = 7;
            // 
            // tableLayoutPanelInformation
            // 
            this.tableLayoutPanelInformation.ColumnCount = 1;
            this.tableLayoutPanelInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelInformation.Controls.Add(this.groupBoxCurrentStatus, 0, 1);
            this.tableLayoutPanelInformation.Controls.Add(this.groupBoxRequirement, 0, 0);
            this.tableLayoutPanelInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelInformation.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelInformation.Name = "tableLayoutPanelInformation";
            this.tableLayoutPanelInformation.RowCount = 2;
            this.tableLayoutPanelInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelInformation.Size = new System.Drawing.Size(447, 587);
            this.tableLayoutPanelInformation.TabIndex = 5;
            // 
            // groupBoxCurrentStatus
            // 
            this.groupBoxCurrentStatus.Controls.Add(this.dataGridViewCurrentStatus);
            this.groupBoxCurrentStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCurrentStatus.Location = new System.Drawing.Point(3, 296);
            this.groupBoxCurrentStatus.Name = "groupBoxCurrentStatus";
            this.groupBoxCurrentStatus.Size = new System.Drawing.Size(441, 288);
            this.groupBoxCurrentStatus.TabIndex = 6;
            this.groupBoxCurrentStatus.TabStop = false;
            this.groupBoxCurrentStatus.Text = "CURRENT STATUS";
            // 
            // dataGridViewCurrentStatus
            // 
            this.dataGridViewCurrentStatus.AllowUserToAddRows = false;
            this.dataGridViewCurrentStatus.AllowUserToDeleteRows = false;
            this.dataGridViewCurrentStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCurrentStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCurrentStatus.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewCurrentStatus.MultiSelect = false;
            this.dataGridViewCurrentStatus.Name = "dataGridViewCurrentStatus";
            this.dataGridViewCurrentStatus.ReadOnly = true;
            this.dataGridViewCurrentStatus.RowHeadersVisible = false;
            this.dataGridViewCurrentStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCurrentStatus.Size = new System.Drawing.Size(435, 266);
            this.dataGridViewCurrentStatus.TabIndex = 0;
            // 
            // groupBoxRequirement
            // 
            this.groupBoxRequirement.Controls.Add(this.txtBoxRequirement);
            this.groupBoxRequirement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRequirement.Location = new System.Drawing.Point(3, 3);
            this.groupBoxRequirement.Name = "groupBoxRequirement";
            this.groupBoxRequirement.Size = new System.Drawing.Size(441, 287);
            this.groupBoxRequirement.TabIndex = 6;
            this.groupBoxRequirement.TabStop = false;
            this.groupBoxRequirement.Text = "REQUIREMENT";
            // 
            // txtBoxRequirement
            // 
            this.txtBoxRequirement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxRequirement.Location = new System.Drawing.Point(3, 19);
            this.txtBoxRequirement.Multiline = true;
            this.txtBoxRequirement.Name = "txtBoxRequirement";
            this.txtBoxRequirement.ReadOnly = true;
            this.txtBoxRequirement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxRequirement.Size = new System.Drawing.Size(435, 265);
            this.txtBoxRequirement.TabIndex = 0;
            // 
            // tableLayoutPanelInputDetails
            // 
            this.tableLayoutPanelInputDetails.ColumnCount = 12;
            this.tableLayoutPanelInputDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanelInputDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanelInputDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanelInputDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanelInputDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanelInputDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanelInputDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanelInputDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanelInputDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanelInputDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanelInputDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanelInputDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanelInputDetails.Controls.Add(this.txtBoxAircraftNo, 9, 8);
            this.tableLayoutPanelInputDetails.Controls.Add(this.txtBoxFlightClass, 6, 8);
            this.tableLayoutPanelInputDetails.Controls.Add(this.txtBoxFlightNo, 3, 8);
            this.tableLayoutPanelInputDetails.Controls.Add(this.dateTimePickerArrTime, 10, 12);
            this.tableLayoutPanelInputDetails.Controls.Add(this.dateTimePickerArrDate, 6, 12);
            this.tableLayoutPanelInputDetails.Controls.Add(this.txtBoxArrAirPort, 0, 12);
            this.tableLayoutPanelInputDetails.Controls.Add(this.txtBoxArrTerminal, 3, 12);
            this.tableLayoutPanelInputDetails.Controls.Add(this.dateTimePickerDeptTime, 10, 10);
            this.tableLayoutPanelInputDetails.Controls.Add(this.dateTimePickerDeptDate, 6, 10);
            this.tableLayoutPanelInputDetails.Controls.Add(this.txtBoxDeptTerminal, 3, 10);
            this.tableLayoutPanelInputDetails.Controls.Add(this.txtBoxDeptAirport, 0, 10);
            this.tableLayoutPanelInputDetails.Controls.Add(this.lblBookingDate, 8, 0);
            this.tableLayoutPanelInputDetails.Controls.Add(this.lblPersonCount, 5, 0);
            this.tableLayoutPanelInputDetails.Controls.Add(this.BtnDelete, 0, 24);
            this.tableLayoutPanelInputDetails.Controls.Add(this.BtnUpdate, 4, 24);
            this.tableLayoutPanelInputDetails.Controls.Add(this.BtnExit, 8, 24);
            this.tableLayoutPanelInputDetails.Controls.Add(this.txtBoxPnr, 0, 1);
            this.tableLayoutPanelInputDetails.Controls.Add(this.dateTimePickerIssueDate, 8, 1);
            this.tableLayoutPanelInputDetails.Controls.Add(this.numericUpDownPassangerCount, 5, 1);
            this.tableLayoutPanelInputDetails.Controls.Add(this.dataGridViewPassangerDetails, 0, 2);
            this.tableLayoutPanelInputDetails.Controls.Add(this.lblPnrNumber, 0, 0);
            this.tableLayoutPanelInputDetails.Controls.Add(this.lblFlightNo, 3, 7);
            this.tableLayoutPanelInputDetails.Controls.Add(this.lblClass, 6, 7);
            this.tableLayoutPanelInputDetails.Controls.Add(this.lblAircraftNo, 9, 7);
            this.tableLayoutPanelInputDetails.Controls.Add(this.lblDeptAirport, 0, 9);
            this.tableLayoutPanelInputDetails.Controls.Add(this.lblDeptDateTime, 6, 9);
            this.tableLayoutPanelInputDetails.Controls.Add(this.lblArrAirPort, 0, 11);
            this.tableLayoutPanelInputDetails.Controls.Add(this.lblArrDateTime, 6, 11);
            this.tableLayoutPanelInputDetails.Controls.Add(this.lblFlightDetails, 0, 8);
            this.tableLayoutPanelInputDetails.Controls.Add(this.comboBoxFlightStatus, 0, 14);
            this.tableLayoutPanelInputDetails.Controls.Add(this.txtBoxAirlineRef, 3, 14);
            this.tableLayoutPanelInputDetails.Controls.Add(this.txtBoxMeal, 6, 14);
            this.tableLayoutPanelInputDetails.Controls.Add(this.numericUpDownStops, 10, 14);
            this.tableLayoutPanelInputDetails.Controls.Add(this.lblStatus, 0, 13);
            this.tableLayoutPanelInputDetails.Controls.Add(this.lblAirLineRef, 3, 13);
            this.tableLayoutPanelInputDetails.Controls.Add(this.lblMeal, 6, 13);
            this.tableLayoutPanelInputDetails.Controls.Add(this.labelBaggage, 8, 13);
            this.tableLayoutPanelInputDetails.Controls.Add(this.lblStops, 10, 13);
            this.tableLayoutPanelInputDetails.Controls.Add(this.txtBoxFare, 0, 22);
            this.tableLayoutPanelInputDetails.Controls.Add(this.txtBoxGst, 3, 22);
            this.tableLayoutPanelInputDetails.Controls.Add(this.txtBoxSurcharge, 6, 22);
            this.tableLayoutPanelInputDetails.Controls.Add(this.txtBoxTotalPrice, 9, 22);
            this.tableLayoutPanelInputDetails.Controls.Add(this.checkBoxConnectingFlight, 0, 20);
            this.tableLayoutPanelInputDetails.Controls.Add(this.lblFare, 0, 21);
            this.tableLayoutPanelInputDetails.Controls.Add(this.lblGst, 3, 21);
            this.tableLayoutPanelInputDetails.Controls.Add(this.lblSurcharge, 6, 21);
            this.tableLayoutPanelInputDetails.Controls.Add(this.lblTotalPrice, 9, 21);
            this.tableLayoutPanelInputDetails.Controls.Add(this.txtBoxBaggageLimit, 8, 14);
            this.tableLayoutPanelInputDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInputDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelInputDetails.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelInputDetails.Name = "tableLayoutPanelInputDetails";
            this.tableLayoutPanelInputDetails.RowCount = 25;
            this.tableLayoutPanelInputDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelInputDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelInputDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelInputDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelInputDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelInputDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelInputDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelInputDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelInputDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelInputDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelInputDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelInputDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelInputDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelInputDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelInputDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelInputDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelInputDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelInputDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelInputDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelInputDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelInputDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelInputDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelInputDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelInputDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelInputDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanelInputDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelInputDetails.Size = new System.Drawing.Size(506, 587);
            this.tableLayoutPanelInputDetails.TabIndex = 0;
            // 
            // txtBoxAircraftNo
            // 
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.txtBoxAircraftNo, 3);
            this.txtBoxAircraftNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxAircraftNo.Location = new System.Drawing.Point(381, 187);
            this.txtBoxAircraftNo.Name = "txtBoxAircraftNo";
            this.txtBoxAircraftNo.Size = new System.Drawing.Size(122, 21);
            this.txtBoxAircraftNo.TabIndex = 7;
            // 
            // txtBoxFlightClass
            // 
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.txtBoxFlightClass, 3);
            this.txtBoxFlightClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxFlightClass.Location = new System.Drawing.Point(255, 187);
            this.txtBoxFlightClass.Name = "txtBoxFlightClass";
            this.txtBoxFlightClass.Size = new System.Drawing.Size(120, 21);
            this.txtBoxFlightClass.TabIndex = 6;
            // 
            // txtBoxFlightNo
            // 
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.txtBoxFlightNo, 3);
            this.txtBoxFlightNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxFlightNo.Location = new System.Drawing.Point(129, 187);
            this.txtBoxFlightNo.Name = "txtBoxFlightNo";
            this.txtBoxFlightNo.Size = new System.Drawing.Size(120, 21);
            this.txtBoxFlightNo.TabIndex = 5;
            // 
            // dateTimePickerArrTime
            // 
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.dateTimePickerArrTime, 2);
            this.dateTimePickerArrTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerArrTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerArrTime.Location = new System.Drawing.Point(423, 279);
            this.dateTimePickerArrTime.Name = "dateTimePickerArrTime";
            this.dateTimePickerArrTime.ShowUpDown = true;
            this.dateTimePickerArrTime.Size = new System.Drawing.Size(80, 21);
            this.dateTimePickerArrTime.TabIndex = 15;
            // 
            // dateTimePickerArrDate
            // 
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.dateTimePickerArrDate, 4);
            this.dateTimePickerArrDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerArrDate.Location = new System.Drawing.Point(255, 279);
            this.dateTimePickerArrDate.Name = "dateTimePickerArrDate";
            this.dateTimePickerArrDate.Size = new System.Drawing.Size(162, 21);
            this.dateTimePickerArrDate.TabIndex = 14;
            // 
            // txtBoxArrAirPort
            // 
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.txtBoxArrAirPort, 3);
            this.txtBoxArrAirPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxArrAirPort.Location = new System.Drawing.Point(3, 279);
            this.txtBoxArrAirPort.Name = "txtBoxArrAirPort";
            this.txtBoxArrAirPort.Size = new System.Drawing.Size(120, 21);
            this.txtBoxArrAirPort.TabIndex = 12;
            // 
            // txtBoxArrTerminal
            // 
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.txtBoxArrTerminal, 3);
            this.txtBoxArrTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxArrTerminal.Location = new System.Drawing.Point(129, 279);
            this.txtBoxArrTerminal.Name = "txtBoxArrTerminal";
            this.txtBoxArrTerminal.Size = new System.Drawing.Size(120, 21);
            this.txtBoxArrTerminal.TabIndex = 13;
            // 
            // dateTimePickerDeptTime
            // 
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.dateTimePickerDeptTime, 2);
            this.dateTimePickerDeptTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerDeptTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerDeptTime.Location = new System.Drawing.Point(423, 233);
            this.dateTimePickerDeptTime.Name = "dateTimePickerDeptTime";
            this.dateTimePickerDeptTime.ShowUpDown = true;
            this.dateTimePickerDeptTime.Size = new System.Drawing.Size(80, 21);
            this.dateTimePickerDeptTime.TabIndex = 11;
            // 
            // dateTimePickerDeptDate
            // 
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.dateTimePickerDeptDate, 4);
            this.dateTimePickerDeptDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerDeptDate.Location = new System.Drawing.Point(255, 233);
            this.dateTimePickerDeptDate.Name = "dateTimePickerDeptDate";
            this.dateTimePickerDeptDate.Size = new System.Drawing.Size(162, 21);
            this.dateTimePickerDeptDate.TabIndex = 10;
            this.dateTimePickerDeptDate.ValueChanged += new System.EventHandler(this.dateTimePickerDeptDate_ValueChanged);
            // 
            // txtBoxDeptTerminal
            // 
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.txtBoxDeptTerminal, 3);
            this.txtBoxDeptTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxDeptTerminal.Location = new System.Drawing.Point(129, 233);
            this.txtBoxDeptTerminal.Name = "txtBoxDeptTerminal";
            this.txtBoxDeptTerminal.Size = new System.Drawing.Size(120, 21);
            this.txtBoxDeptTerminal.TabIndex = 9;
            // 
            // txtBoxDeptAirport
            // 
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.txtBoxDeptAirport, 3);
            this.txtBoxDeptAirport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxDeptAirport.Location = new System.Drawing.Point(3, 233);
            this.txtBoxDeptAirport.Name = "txtBoxDeptAirport";
            this.txtBoxDeptAirport.Size = new System.Drawing.Size(120, 21);
            this.txtBoxDeptAirport.TabIndex = 8;
            // 
            // lblBookingDate
            // 
            this.lblBookingDate.AutoSize = true;
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.lblBookingDate, 3);
            this.lblBookingDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblBookingDate.Location = new System.Drawing.Point(339, 8);
            this.lblBookingDate.Name = "lblBookingDate";
            this.lblBookingDate.Size = new System.Drawing.Size(120, 15);
            this.lblBookingDate.TabIndex = 9;
            this.lblBookingDate.Text = "BOOKING DATE";
            // 
            // lblPersonCount
            // 
            this.lblPersonCount.AutoSize = true;
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.lblPersonCount, 3);
            this.lblPersonCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPersonCount.Location = new System.Drawing.Point(213, 8);
            this.lblPersonCount.Name = "lblPersonCount";
            this.lblPersonCount.Size = new System.Drawing.Size(120, 15);
            this.lblPersonCount.TabIndex = 8;
            this.lblPersonCount.Text = "TOTAL PAX";
            // 
            // BtnDelete
            // 
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.BtnDelete, 4);
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.Location = new System.Drawing.Point(3, 555);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(162, 29);
            this.BtnDelete.TabIndex = 0;
            this.BtnDelete.Text = "DELETE";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.BtnUpdate, 4);
            this.BtnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUpdate.Location = new System.Drawing.Point(171, 555);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(162, 29);
            this.BtnUpdate.TabIndex = 26;
            this.BtnUpdate.Text = "UPDATE";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnExit
            // 
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.BtnExit, 4);
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnExit.Location = new System.Drawing.Point(339, 555);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(164, 29);
            this.BtnExit.TabIndex = 27;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // txtBoxPnr
            // 
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.txtBoxPnr, 4);
            this.txtBoxPnr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxPnr.Location = new System.Drawing.Point(3, 26);
            this.txtBoxPnr.Name = "txtBoxPnr";
            this.txtBoxPnr.Size = new System.Drawing.Size(162, 21);
            this.txtBoxPnr.TabIndex = 1;
            // 
            // dateTimePickerIssueDate
            // 
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.dateTimePickerIssueDate, 4);
            this.dateTimePickerIssueDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerIssueDate.Location = new System.Drawing.Point(339, 26);
            this.dateTimePickerIssueDate.Name = "dateTimePickerIssueDate";
            this.dateTimePickerIssueDate.Size = new System.Drawing.Size(164, 21);
            this.dateTimePickerIssueDate.TabIndex = 2;
            // 
            // numericUpDownPassangerCount
            // 
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.numericUpDownPassangerCount, 2);
            this.numericUpDownPassangerCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownPassangerCount.Location = new System.Drawing.Point(213, 26);
            this.numericUpDownPassangerCount.Name = "numericUpDownPassangerCount";
            this.numericUpDownPassangerCount.Size = new System.Drawing.Size(78, 21);
            this.numericUpDownPassangerCount.TabIndex = 3;
            this.numericUpDownPassangerCount.ValueChanged += new System.EventHandler(this.numericUpDownPassangerCount_ValueChanged);
            // 
            // dataGridViewPassangerDetails
            // 
            this.dataGridViewPassangerDetails.AllowUserToAddRows = false;
            this.dataGridViewPassangerDetails.AllowUserToDeleteRows = false;
            this.dataGridViewPassangerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPassangerDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PassangerName,
            this.SeatNo,
            this.PassangerTicketNo,
            this.PassangerFfy});
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.dataGridViewPassangerDetails, 12);
            this.dataGridViewPassangerDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPassangerDetails.Location = new System.Drawing.Point(3, 49);
            this.dataGridViewPassangerDetails.Name = "dataGridViewPassangerDetails";
            this.dataGridViewPassangerDetails.RowHeadersVisible = false;
            this.dataGridViewPassangerDetails.RowHeadersWidth = 25;
            this.tableLayoutPanelInputDetails.SetRowSpan(this.dataGridViewPassangerDetails, 5);
            this.dataGridViewPassangerDetails.Size = new System.Drawing.Size(500, 109);
            this.dataGridViewPassangerDetails.TabIndex = 4;
            // 
            // PassangerName
            // 
            this.PassangerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PassangerName.HeaderText = "NAME";
            this.PassangerName.Name = "PassangerName";
            // 
            // SeatNo
            // 
            this.SeatNo.HeaderText = "SEAT #";
            this.SeatNo.Name = "SeatNo";
            this.SeatNo.Width = 80;
            // 
            // PassangerTicketNo
            // 
            this.PassangerTicketNo.HeaderText = "TICKET NUMBER";
            this.PassangerTicketNo.Name = "PassangerTicketNo";
            this.PassangerTicketNo.Width = 150;
            // 
            // PassangerFfy
            // 
            this.PassangerFfy.HeaderText = "FREQ FLYER NO";
            this.PassangerFfy.Name = "PassangerFfy";
            this.PassangerFfy.Width = 150;
            // 
            // lblPnrNumber
            // 
            this.lblPnrNumber.AutoSize = true;
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.lblPnrNumber, 3);
            this.lblPnrNumber.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPnrNumber.Location = new System.Drawing.Point(3, 8);
            this.lblPnrNumber.Name = "lblPnrNumber";
            this.lblPnrNumber.Size = new System.Drawing.Size(120, 15);
            this.lblPnrNumber.TabIndex = 7;
            this.lblPnrNumber.Text = "PNR NUMBER";
            // 
            // lblFlightNo
            // 
            this.lblFlightNo.AutoSize = true;
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.lblFlightNo, 3);
            this.lblFlightNo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFlightNo.Location = new System.Drawing.Point(129, 169);
            this.lblFlightNo.Name = "lblFlightNo";
            this.lblFlightNo.Size = new System.Drawing.Size(120, 15);
            this.lblFlightNo.TabIndex = 21;
            this.lblFlightNo.Text = "FLIGHT NO";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.lblClass, 3);
            this.lblClass.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblClass.Location = new System.Drawing.Point(255, 169);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(120, 15);
            this.lblClass.TabIndex = 22;
            this.lblClass.Text = "CLASS";
            // 
            // lblAircraftNo
            // 
            this.lblAircraftNo.AutoSize = true;
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.lblAircraftNo, 3);
            this.lblAircraftNo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAircraftNo.Location = new System.Drawing.Point(381, 169);
            this.lblAircraftNo.Name = "lblAircraftNo";
            this.lblAircraftNo.Size = new System.Drawing.Size(122, 15);
            this.lblAircraftNo.TabIndex = 23;
            this.lblAircraftNo.Text = "AIRCRAFT NO:";
            // 
            // lblDeptAirport
            // 
            this.lblDeptAirport.AutoSize = true;
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.lblDeptAirport, 6);
            this.lblDeptAirport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDeptAirport.Location = new System.Drawing.Point(3, 215);
            this.lblDeptAirport.Name = "lblDeptAirport";
            this.lblDeptAirport.Size = new System.Drawing.Size(246, 15);
            this.lblDeptAirport.TabIndex = 24;
            this.lblDeptAirport.Text = "DEPARTURE: AIRPORT TERMINAL";
            // 
            // lblDeptDateTime
            // 
            this.lblDeptDateTime.AutoSize = true;
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.lblDeptDateTime, 3);
            this.lblDeptDateTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDeptDateTime.Location = new System.Drawing.Point(255, 215);
            this.lblDeptDateTime.Name = "lblDeptDateTime";
            this.lblDeptDateTime.Size = new System.Drawing.Size(120, 15);
            this.lblDeptDateTime.TabIndex = 26;
            this.lblDeptDateTime.Text = "DATE N TIME";
            // 
            // lblArrAirPort
            // 
            this.lblArrAirPort.AutoSize = true;
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.lblArrAirPort, 6);
            this.lblArrAirPort.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblArrAirPort.Location = new System.Drawing.Point(3, 261);
            this.lblArrAirPort.Name = "lblArrAirPort";
            this.lblArrAirPort.Size = new System.Drawing.Size(246, 15);
            this.lblArrAirPort.TabIndex = 27;
            this.lblArrAirPort.Text = "ARRIVAL: AIRPORT TERMINAL";
            // 
            // lblArrDateTime
            // 
            this.lblArrDateTime.AutoSize = true;
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.lblArrDateTime, 3);
            this.lblArrDateTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblArrDateTime.Location = new System.Drawing.Point(255, 261);
            this.lblArrDateTime.Name = "lblArrDateTime";
            this.lblArrDateTime.Size = new System.Drawing.Size(120, 15);
            this.lblArrDateTime.TabIndex = 29;
            this.lblArrDateTime.Text = "DATE N TIME";
            // 
            // lblFlightDetails
            // 
            this.lblFlightDetails.AutoSize = true;
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.lblFlightDetails, 3);
            this.lblFlightDetails.Location = new System.Drawing.Point(3, 184);
            this.lblFlightDetails.Name = "lblFlightDetails";
            this.lblFlightDetails.Size = new System.Drawing.Size(115, 15);
            this.lblFlightDetails.TabIndex = 30;
            this.lblFlightDetails.Text = "FLIGHT DETAILS";
            // 
            // comboBoxFlightStatus
            // 
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.comboBoxFlightStatus, 3);
            this.comboBoxFlightStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxFlightStatus.FormattingEnabled = true;
            this.comboBoxFlightStatus.Items.AddRange(new object[] {
            "CONFIRMED",
            "NOT CONFIRMED"});
            this.comboBoxFlightStatus.Location = new System.Drawing.Point(3, 325);
            this.comboBoxFlightStatus.Name = "comboBoxFlightStatus";
            this.comboBoxFlightStatus.Size = new System.Drawing.Size(120, 23);
            this.comboBoxFlightStatus.TabIndex = 16;
            // 
            // txtBoxAirlineRef
            // 
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.txtBoxAirlineRef, 3);
            this.txtBoxAirlineRef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxAirlineRef.Location = new System.Drawing.Point(129, 325);
            this.txtBoxAirlineRef.Name = "txtBoxAirlineRef";
            this.txtBoxAirlineRef.Size = new System.Drawing.Size(120, 21);
            this.txtBoxAirlineRef.TabIndex = 17;
            // 
            // txtBoxMeal
            // 
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.txtBoxMeal, 2);
            this.txtBoxMeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxMeal.Location = new System.Drawing.Point(255, 325);
            this.txtBoxMeal.Name = "txtBoxMeal";
            this.txtBoxMeal.Size = new System.Drawing.Size(78, 21);
            this.txtBoxMeal.TabIndex = 18;
            // 
            // numericUpDownStops
            // 
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.numericUpDownStops, 2);
            this.numericUpDownStops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownStops.Location = new System.Drawing.Point(423, 325);
            this.numericUpDownStops.Name = "numericUpDownStops";
            this.numericUpDownStops.Size = new System.Drawing.Size(80, 21);
            this.numericUpDownStops.TabIndex = 20;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.lblStatus, 3);
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Location = new System.Drawing.Point(3, 307);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(120, 15);
            this.lblStatus.TabIndex = 37;
            this.lblStatus.Text = "STATUS";
            // 
            // lblAirLineRef
            // 
            this.lblAirLineRef.AutoSize = true;
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.lblAirLineRef, 3);
            this.lblAirLineRef.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAirLineRef.Location = new System.Drawing.Point(129, 307);
            this.lblAirLineRef.Name = "lblAirLineRef";
            this.lblAirLineRef.Size = new System.Drawing.Size(120, 15);
            this.lblAirLineRef.TabIndex = 38;
            this.lblAirLineRef.Text = "AIRLINE REF #";
            // 
            // lblMeal
            // 
            this.lblMeal.AutoSize = true;
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.lblMeal, 2);
            this.lblMeal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMeal.Location = new System.Drawing.Point(255, 307);
            this.lblMeal.Name = "lblMeal";
            this.lblMeal.Size = new System.Drawing.Size(78, 15);
            this.lblMeal.TabIndex = 39;
            this.lblMeal.Text = "MEAL";
            // 
            // labelBaggage
            // 
            this.labelBaggage.AutoSize = true;
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.labelBaggage, 2);
            this.labelBaggage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelBaggage.Location = new System.Drawing.Point(339, 307);
            this.labelBaggage.Name = "labelBaggage";
            this.labelBaggage.Size = new System.Drawing.Size(78, 15);
            this.labelBaggage.TabIndex = 40;
            this.labelBaggage.Text = "BAGGAGE";
            // 
            // lblStops
            // 
            this.lblStops.AutoSize = true;
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.lblStops, 2);
            this.lblStops.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStops.Location = new System.Drawing.Point(423, 307);
            this.lblStops.Name = "lblStops";
            this.lblStops.Size = new System.Drawing.Size(80, 15);
            this.lblStops.TabIndex = 41;
            this.lblStops.Text = "STOPS";
            // 
            // txtBoxFare
            // 
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.txtBoxFare, 3);
            this.txtBoxFare.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBoxFare.Location = new System.Drawing.Point(3, 509);
            this.txtBoxFare.Name = "txtBoxFare";
            this.txtBoxFare.Size = new System.Drawing.Size(120, 21);
            this.txtBoxFare.TabIndex = 21;
            this.txtBoxFare.TextChanged += new System.EventHandler(this.AmountTextChanged);
            // 
            // txtBoxGst
            // 
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.txtBoxGst, 3);
            this.txtBoxGst.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBoxGst.Location = new System.Drawing.Point(129, 509);
            this.txtBoxGst.Name = "txtBoxGst";
            this.txtBoxGst.Size = new System.Drawing.Size(120, 21);
            this.txtBoxGst.TabIndex = 22;
            this.txtBoxGst.TextChanged += new System.EventHandler(this.AmountTextChanged);
            // 
            // txtBoxSurcharge
            // 
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.txtBoxSurcharge, 3);
            this.txtBoxSurcharge.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBoxSurcharge.Location = new System.Drawing.Point(255, 509);
            this.txtBoxSurcharge.Name = "txtBoxSurcharge";
            this.txtBoxSurcharge.Size = new System.Drawing.Size(120, 21);
            this.txtBoxSurcharge.TabIndex = 23;
            this.txtBoxSurcharge.TextChanged += new System.EventHandler(this.AmountTextChanged);
            // 
            // txtBoxTotalPrice
            // 
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.txtBoxTotalPrice, 3);
            this.txtBoxTotalPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBoxTotalPrice.Location = new System.Drawing.Point(381, 509);
            this.txtBoxTotalPrice.Name = "txtBoxTotalPrice";
            this.txtBoxTotalPrice.Size = new System.Drawing.Size(122, 21);
            this.txtBoxTotalPrice.TabIndex = 24;
            // 
            // checkBoxConnectingFlight
            // 
            this.checkBoxConnectingFlight.AutoSize = true;
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.checkBoxConnectingFlight, 5);
            this.checkBoxConnectingFlight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxConnectingFlight.Location = new System.Drawing.Point(3, 463);
            this.checkBoxConnectingFlight.Name = "checkBoxConnectingFlight";
            this.checkBoxConnectingFlight.Size = new System.Drawing.Size(204, 17);
            this.checkBoxConnectingFlight.TabIndex = 25;
            this.checkBoxConnectingFlight.Text = "ADD CONNECTING FLIGHT";
            this.checkBoxConnectingFlight.UseVisualStyleBackColor = true;
            // 
            // lblFare
            // 
            this.lblFare.AutoSize = true;
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.lblFare, 3);
            this.lblFare.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFare.Location = new System.Drawing.Point(3, 491);
            this.lblFare.Name = "lblFare";
            this.lblFare.Size = new System.Drawing.Size(120, 15);
            this.lblFare.TabIndex = 48;
            this.lblFare.Text = "FARE";
            // 
            // lblGst
            // 
            this.lblGst.AutoSize = true;
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.lblGst, 3);
            this.lblGst.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblGst.Location = new System.Drawing.Point(129, 491);
            this.lblGst.Name = "lblGst";
            this.lblGst.Size = new System.Drawing.Size(120, 15);
            this.lblGst.TabIndex = 49;
            this.lblGst.Text = "GST";
            // 
            // lblSurcharge
            // 
            this.lblSurcharge.AutoSize = true;
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.lblSurcharge, 3);
            this.lblSurcharge.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSurcharge.Location = new System.Drawing.Point(255, 491);
            this.lblSurcharge.Name = "lblSurcharge";
            this.lblSurcharge.Size = new System.Drawing.Size(120, 15);
            this.lblSurcharge.TabIndex = 50;
            this.lblSurcharge.Text = "SURCHARGE";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.lblTotalPrice, 3);
            this.lblTotalPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalPrice.Location = new System.Drawing.Point(381, 491);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(122, 15);
            this.lblTotalPrice.TabIndex = 51;
            this.lblTotalPrice.Text = "TOTAL";
            // 
            // txtBoxBaggageLimit
            // 
            this.tableLayoutPanelInputDetails.SetColumnSpan(this.txtBoxBaggageLimit, 2);
            this.txtBoxBaggageLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxBaggageLimit.Location = new System.Drawing.Point(339, 325);
            this.txtBoxBaggageLimit.Name = "txtBoxBaggageLimit";
            this.txtBoxBaggageLimit.Size = new System.Drawing.Size(78, 21);
            this.txtBoxBaggageLimit.TabIndex = 19;
            // 
            // FrmVouchersWorkingFlightPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 587);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVouchersWorkingFlightPage";
            this.Text = "FLIGHT INFORMATION";
            this.Load += new System.EventHandler(this.FrmVouchersWorkingFlightPage_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanelInformation.ResumeLayout(false);
            this.groupBoxCurrentStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrentStatus)).EndInit();
            this.groupBoxRequirement.ResumeLayout(false);
            this.groupBoxRequirement.PerformLayout();
            this.tableLayoutPanelInputDetails.ResumeLayout(false);
            this.tableLayoutPanelInputDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPassangerCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassangerDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStops)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInformation;
        private System.Windows.Forms.GroupBox groupBoxCurrentStatus;
        private System.Windows.Forms.DataGridView dataGridViewCurrentStatus;
        private System.Windows.Forms.GroupBox groupBoxRequirement;
        private System.Windows.Forms.TextBox txtBoxRequirement;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInputDetails;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox txtBoxPnr;
        private System.Windows.Forms.DateTimePicker dateTimePickerIssueDate;
        private System.Windows.Forms.NumericUpDown numericUpDownPassangerCount;
        private System.Windows.Forms.DataGridView dataGridViewPassangerDetails;
        private System.Windows.Forms.Label lblPnrNumber;
        private System.Windows.Forms.Label lblPersonCount;
        private System.Windows.Forms.Label lblBookingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassangerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeatNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassangerTicketNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassangerFfy;
        private System.Windows.Forms.TextBox txtBoxDeptAirport;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeptTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeptDate;
        private System.Windows.Forms.TextBox txtBoxDeptTerminal;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrDate;
        private System.Windows.Forms.TextBox txtBoxArrAirPort;
        private System.Windows.Forms.TextBox txtBoxArrTerminal;
        private System.Windows.Forms.TextBox txtBoxAircraftNo;
        private System.Windows.Forms.TextBox txtBoxFlightClass;
        private System.Windows.Forms.TextBox txtBoxFlightNo;
        private System.Windows.Forms.Label lblFlightNo;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblAircraftNo;
        private System.Windows.Forms.Label lblDeptAirport;
        private System.Windows.Forms.Label lblDeptDateTime;
        private System.Windows.Forms.Label lblArrAirPort;
        private System.Windows.Forms.Label lblArrDateTime;
        private System.Windows.Forms.Label lblFlightDetails;
        private System.Windows.Forms.ComboBox comboBoxFlightStatus;
        private System.Windows.Forms.TextBox txtBoxAirlineRef;
        private System.Windows.Forms.TextBox txtBoxMeal;
        private System.Windows.Forms.NumericUpDown numericUpDownStops;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAirLineRef;
        private System.Windows.Forms.Label lblMeal;
        private System.Windows.Forms.Label labelBaggage;
        private System.Windows.Forms.Label lblStops;
        private System.Windows.Forms.TextBox txtBoxFare;
        private System.Windows.Forms.TextBox txtBoxGst;
        private System.Windows.Forms.TextBox txtBoxSurcharge;
        private System.Windows.Forms.TextBox txtBoxTotalPrice;
        private System.Windows.Forms.CheckBox checkBoxConnectingFlight;
        private System.Windows.Forms.Label lblFare;
        private System.Windows.Forms.Label lblGst;
        private System.Windows.Forms.Label lblSurcharge;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtBoxBaggageLimit;
    }
}