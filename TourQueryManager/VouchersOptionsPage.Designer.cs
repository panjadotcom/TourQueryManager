namespace TourQueryManager
{
    partial class FrmVouchersOptionsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVouchersOptionsPage));
            this.tableLayoutPanelButtonsHolder = new System.Windows.Forms.TableLayoutPanel();
            this.BtnPrintBoth = new System.Windows.Forms.Button();
            this.BtnPrintFlightTickets = new System.Windows.Forms.Button();
            this.BtnPrintHotelVouchers = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.lblQueryInfo = new System.Windows.Forms.Label();
            this.saveFileDialogItinerary = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanelButtonsHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelButtonsHolder
            // 
            this.tableLayoutPanelButtonsHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelButtonsHolder.ColumnCount = 4;
            this.tableLayoutPanelButtonsHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelButtonsHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelButtonsHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelButtonsHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelButtonsHolder.Controls.Add(this.BtnPrintBoth, 2, 0);
            this.tableLayoutPanelButtonsHolder.Controls.Add(this.BtnPrintFlightTickets, 1, 0);
            this.tableLayoutPanelButtonsHolder.Controls.Add(this.BtnPrintHotelVouchers, 0, 0);
            this.tableLayoutPanelButtonsHolder.Controls.Add(this.BtnExit, 3, 0);
            this.tableLayoutPanelButtonsHolder.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanelButtonsHolder.Location = new System.Drawing.Point(12, 37);
            this.tableLayoutPanelButtonsHolder.Name = "tableLayoutPanelButtonsHolder";
            this.tableLayoutPanelButtonsHolder.RowCount = 1;
            this.tableLayoutPanelButtonsHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtonsHolder.Size = new System.Drawing.Size(903, 130);
            this.tableLayoutPanelButtonsHolder.TabIndex = 0;
            // 
            // BtnPrintBoth
            // 
            this.BtnPrintBoth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPrintBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintBoth.Location = new System.Drawing.Point(453, 3);
            this.BtnPrintBoth.Name = "BtnPrintBoth";
            this.BtnPrintBoth.Size = new System.Drawing.Size(219, 124);
            this.BtnPrintBoth.TabIndex = 2;
            this.BtnPrintBoth.Text = "PRINT BOTH";
            this.BtnPrintBoth.UseVisualStyleBackColor = true;
            this.BtnPrintBoth.Click += new System.EventHandler(this.BtnPrintVouchersAndTickets_Click);
            // 
            // BtnPrintFlightTickets
            // 
            this.BtnPrintFlightTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPrintFlightTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintFlightTickets.Location = new System.Drawing.Point(228, 3);
            this.BtnPrintFlightTickets.Name = "BtnPrintFlightTickets";
            this.BtnPrintFlightTickets.Size = new System.Drawing.Size(219, 124);
            this.BtnPrintFlightTickets.TabIndex = 1;
            this.BtnPrintFlightTickets.Text = "FLIGHT TICKET";
            this.BtnPrintFlightTickets.UseVisualStyleBackColor = true;
            this.BtnPrintFlightTickets.Click += new System.EventHandler(this.BtnPrintVouchersAndTickets_Click);
            // 
            // BtnPrintHotelVouchers
            // 
            this.BtnPrintHotelVouchers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnPrintHotelVouchers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintHotelVouchers.Location = new System.Drawing.Point(3, 3);
            this.BtnPrintHotelVouchers.Name = "BtnPrintHotelVouchers";
            this.BtnPrintHotelVouchers.Size = new System.Drawing.Size(219, 124);
            this.BtnPrintHotelVouchers.TabIndex = 0;
            this.BtnPrintHotelVouchers.Text = "HOTEL VOUCHER";
            this.BtnPrintHotelVouchers.UseVisualStyleBackColor = true;
            this.BtnPrintHotelVouchers.Click += new System.EventHandler(this.BtnPrintVouchersAndTickets_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(678, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(222, 124);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblQueryInfo
            // 
            this.lblQueryInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQueryInfo.AutoSize = true;
            this.lblQueryInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueryInfo.Location = new System.Drawing.Point(9, 9);
            this.lblQueryInfo.Name = "lblQueryInfo";
            this.lblQueryInfo.Size = new System.Drawing.Size(403, 25);
            this.lblQueryInfo.TabIndex = 1;
            this.lblQueryInfo.Text = "PRINT VOUCHERS AND TICKETS FOR";
            // 
            // saveFileDialogItinerary
            // 
            this.saveFileDialogItinerary.DefaultExt = "pdf";
            // 
            // FrmVouchersOptionsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 179);
            this.Controls.Add(this.lblQueryInfo);
            this.Controls.Add(this.tableLayoutPanelButtonsHolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVouchersOptionsPage";
            this.Text = "GENERATE VOUCHERS FOR";
            this.Load += new System.EventHandler(this.FrmVouchersOptionsPage_Load);
            this.tableLayoutPanelButtonsHolder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtonsHolder;
        private System.Windows.Forms.Button BtnPrintBoth;
        private System.Windows.Forms.Button BtnPrintFlightTickets;
        private System.Windows.Forms.Button BtnPrintHotelVouchers;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label lblQueryInfo;
        private System.Windows.Forms.SaveFileDialog saveFileDialogItinerary;
    }
}