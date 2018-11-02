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
            this.tableLayoutPanelOptionButton.SuspendLayout();
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
            this.tableLayoutPanelOptionButton.ColumnCount = 3;
            this.tableLayoutPanelOptionButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelOptionButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelOptionButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelOptionButton.Controls.Add(this.BtnExit, 2, 0);
            this.tableLayoutPanelOptionButton.Controls.Add(this.BtnUpdateFlightInfo, 1, 0);
            this.tableLayoutPanelOptionButton.Controls.Add(this.BtnUpdateHotelInfo, 0, 0);
            this.tableLayoutPanelOptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelOptionButton.Location = new System.Drawing.Point(12, 37);
            this.tableLayoutPanelOptionButton.Name = "tableLayoutPanelOptionButton";
            this.tableLayoutPanelOptionButton.RowCount = 1;
            this.tableLayoutPanelOptionButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelOptionButton.Size = new System.Drawing.Size(778, 80);
            this.tableLayoutPanelOptionButton.TabIndex = 3;
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnExit.Location = new System.Drawing.Point(521, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(254, 74);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnUpdateFlightInfo
            // 
            this.BtnUpdateFlightInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUpdateFlightInfo.Location = new System.Drawing.Point(262, 3);
            this.BtnUpdateFlightInfo.Name = "BtnUpdateFlightInfo";
            this.BtnUpdateFlightInfo.Size = new System.Drawing.Size(253, 74);
            this.BtnUpdateFlightInfo.TabIndex = 1;
            this.BtnUpdateFlightInfo.Text = "FLIGHT INFO";
            this.BtnUpdateFlightInfo.UseVisualStyleBackColor = true;
            this.BtnUpdateFlightInfo.Click += new System.EventHandler(this.BtnUpdateFlightInfo_Click);
            // 
            // BtnUpdateHotelInfo
            // 
            this.BtnUpdateHotelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUpdateHotelInfo.Location = new System.Drawing.Point(3, 3);
            this.BtnUpdateHotelInfo.Name = "BtnUpdateHotelInfo";
            this.BtnUpdateHotelInfo.Size = new System.Drawing.Size(253, 74);
            this.BtnUpdateHotelInfo.TabIndex = 2;
            this.BtnUpdateHotelInfo.Text = "HOTEL INFO";
            this.BtnUpdateHotelInfo.UseVisualStyleBackColor = true;
            this.BtnUpdateHotelInfo.Click += new System.EventHandler(this.BtnUpdateHotelInfo_Click);
            // 
            // FrmVouchersWorkingOptionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 129);
            this.Controls.Add(this.tableLayoutPanelOptionButton);
            this.Controls.Add(this.lblQueryInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVouchersWorkingOptionPage";
            this.Text = "VOUCHER WORKING";
            this.Load += new System.EventHandler(this.FrmVouchersWorkingOptionPage_Load);
            this.tableLayoutPanelOptionButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQueryInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOptionButton;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnUpdateFlightInfo;
        private System.Windows.Forms.Button BtnUpdateHotelInfo;
    }
}