namespace TourQueryManager
{
    partial class FrmVouchersWorkingOptionPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVouchersWorkingOptionPage));
            this.lblQueryInfo = new System.Windows.Forms.Label();
            this.tableLayoutPanelOptionButton = new System.Windows.Forms.TableLayoutPanel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnUpdateFlightInfo = new System.Windows.Forms.Button();
            this.BtnUpdateHotelInfo = new System.Windows.Forms.Button();
            this.BtnFinishedVoucherWorking = new System.Windows.Forms.Button();
            this.dataGridViewFlightInformation = new System.Windows.Forms.DataGridView();
            this.dataGridViewHotelInformation = new System.Windows.Forms.DataGridView();
            this.txtBoxQueryDetails = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelOptionButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotelInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQueryInfo
            // 
            this.lblQueryInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQueryInfo.AutoSize = true;
            this.lblQueryInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueryInfo.Location = new System.Drawing.Point(12, 9);
            this.lblQueryInfo.Name = "lblQueryInfo";
            this.lblQueryInfo.Size = new System.Drawing.Size(516, 25);
            this.lblQueryInfo.TabIndex = 2;
            this.lblQueryInfo.Text = "UPDATE HOTEL AND FLIGHT INFORMATION FOR";
            // 
            // tableLayoutPanelOptionButton
            // 
            this.tableLayoutPanelOptionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelOptionButton.ColumnCount = 4;
            this.tableLayoutPanelOptionButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelOptionButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelOptionButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelOptionButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelOptionButton.Controls.Add(this.BtnExit, 3, 2);
            this.tableLayoutPanelOptionButton.Controls.Add(this.BtnUpdateFlightInfo, 1, 2);
            this.tableLayoutPanelOptionButton.Controls.Add(this.BtnUpdateHotelInfo, 0, 2);
            this.tableLayoutPanelOptionButton.Controls.Add(this.BtnFinishedVoucherWorking, 2, 2);
            this.tableLayoutPanelOptionButton.Controls.Add(this.dataGridViewFlightInformation, 2, 1);
            this.tableLayoutPanelOptionButton.Controls.Add(this.dataGridViewHotelInformation, 0, 1);
            this.tableLayoutPanelOptionButton.Controls.Add(this.txtBoxQueryDetails, 0, 0);
            this.tableLayoutPanelOptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelOptionButton.Location = new System.Drawing.Point(12, 37);
            this.tableLayoutPanelOptionButton.Name = "tableLayoutPanelOptionButton";
            this.tableLayoutPanelOptionButton.RowCount = 3;
            this.tableLayoutPanelOptionButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelOptionButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelOptionButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelOptionButton.Size = new System.Drawing.Size(778, 377);
            this.tableLayoutPanelOptionButton.TabIndex = 3;
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnExit.Location = new System.Drawing.Point(585, 303);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(190, 71);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnUpdateFlightInfo
            // 
            this.BtnUpdateFlightInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUpdateFlightInfo.Location = new System.Drawing.Point(197, 303);
            this.BtnUpdateFlightInfo.Name = "BtnUpdateFlightInfo";
            this.BtnUpdateFlightInfo.Size = new System.Drawing.Size(188, 71);
            this.BtnUpdateFlightInfo.TabIndex = 1;
            this.BtnUpdateFlightInfo.Text = "FLIGHT INFO";
            this.BtnUpdateFlightInfo.UseVisualStyleBackColor = true;
            this.BtnUpdateFlightInfo.Click += new System.EventHandler(this.BtnUpdateFlightInfo_Click);
            // 
            // BtnUpdateHotelInfo
            // 
            this.BtnUpdateHotelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUpdateHotelInfo.Location = new System.Drawing.Point(3, 303);
            this.BtnUpdateHotelInfo.Name = "BtnUpdateHotelInfo";
            this.BtnUpdateHotelInfo.Size = new System.Drawing.Size(188, 71);
            this.BtnUpdateHotelInfo.TabIndex = 2;
            this.BtnUpdateHotelInfo.Text = "HOTEL INFO";
            this.BtnUpdateHotelInfo.UseVisualStyleBackColor = true;
            this.BtnUpdateHotelInfo.Click += new System.EventHandler(this.BtnUpdateHotelInfo_Click);
            // 
            // BtnFinishedVoucherWorking
            // 
            this.BtnFinishedVoucherWorking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnFinishedVoucherWorking.Location = new System.Drawing.Point(391, 303);
            this.BtnFinishedVoucherWorking.Name = "BtnFinishedVoucherWorking";
            this.BtnFinishedVoucherWorking.Size = new System.Drawing.Size(188, 71);
            this.BtnFinishedVoucherWorking.TabIndex = 3;
            this.BtnFinishedVoucherWorking.Text = "FINISH WORKING";
            this.BtnFinishedVoucherWorking.UseVisualStyleBackColor = true;
            this.BtnFinishedVoucherWorking.Click += new System.EventHandler(this.BtnFinishedVoucherWorking_Click);
            // 
            // dataGridViewFlightInformation
            // 
            this.dataGridViewFlightInformation.AllowUserToAddRows = false;
            this.dataGridViewFlightInformation.AllowUserToDeleteRows = false;
            this.dataGridViewFlightInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanelOptionButton.SetColumnSpan(this.dataGridViewFlightInformation, 2);
            this.dataGridViewFlightInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFlightInformation.Location = new System.Drawing.Point(391, 153);
            this.dataGridViewFlightInformation.Name = "dataGridViewFlightInformation";
            this.dataGridViewFlightInformation.ReadOnly = true;
            this.dataGridViewFlightInformation.RowHeadersVisible = false;
            this.dataGridViewFlightInformation.Size = new System.Drawing.Size(384, 144);
            this.dataGridViewFlightInformation.TabIndex = 4;
            this.dataGridViewFlightInformation.TabStop = false;
            // 
            // dataGridViewHotelInformation
            // 
            this.dataGridViewHotelInformation.AllowUserToAddRows = false;
            this.dataGridViewHotelInformation.AllowUserToDeleteRows = false;
            this.dataGridViewHotelInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanelOptionButton.SetColumnSpan(this.dataGridViewHotelInformation, 2);
            this.dataGridViewHotelInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHotelInformation.Location = new System.Drawing.Point(3, 153);
            this.dataGridViewHotelInformation.Name = "dataGridViewHotelInformation";
            this.dataGridViewHotelInformation.ReadOnly = true;
            this.dataGridViewHotelInformation.RowHeadersVisible = false;
            this.dataGridViewHotelInformation.Size = new System.Drawing.Size(382, 144);
            this.dataGridViewHotelInformation.TabIndex = 5;
            this.dataGridViewHotelInformation.TabStop = false;
            // 
            // txtBoxQueryDetails
            // 
            this.tableLayoutPanelOptionButton.SetColumnSpan(this.txtBoxQueryDetails, 4);
            this.txtBoxQueryDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxQueryDetails.Location = new System.Drawing.Point(3, 3);
            this.txtBoxQueryDetails.Multiline = true;
            this.txtBoxQueryDetails.Name = "txtBoxQueryDetails";
            this.txtBoxQueryDetails.ReadOnly = true;
            this.txtBoxQueryDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxQueryDetails.Size = new System.Drawing.Size(772, 144);
            this.txtBoxQueryDetails.TabIndex = 6;
            this.txtBoxQueryDetails.TabStop = false;
            // 
            // FrmVouchersWorkingOptionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 426);
            this.Controls.Add(this.tableLayoutPanelOptionButton);
            this.Controls.Add(this.lblQueryInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVouchersWorkingOptionPage";
            this.Text = "VOUCHER WORKING";
            this.Load += new System.EventHandler(this.FrmVouchersWorkingOptionPage_Load);
            this.tableLayoutPanelOptionButton.ResumeLayout(false);
            this.tableLayoutPanelOptionButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotelInformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQueryInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOptionButton;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnUpdateFlightInfo;
        private System.Windows.Forms.Button BtnUpdateHotelInfo;
        private System.Windows.Forms.Button BtnFinishedVoucherWorking;
        private System.Windows.Forms.DataGridView dataGridViewFlightInformation;
        private System.Windows.Forms.DataGridView dataGridViewHotelInformation;
        private System.Windows.Forms.TextBox txtBoxQueryDetails;
    }
}