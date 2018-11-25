namespace TourQueryManager
{
    partial class FrmFinalizeQueryPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFinalizeQueryPage));
            this.comboBoxAssignedTo = new System.Windows.Forms.ComboBox();
            this.lblAssignedTo = new System.Windows.Forms.Label();
            this.txtBoxSpclInstrsn = new System.Windows.Forms.TextBox();
            this.lblSpclInstrn = new System.Windows.Forms.Label();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.txtBoxTotalCost = new System.Windows.Forms.TextBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxAssignedTo
            // 
            this.comboBoxAssignedTo.FormattingEnabled = true;
            this.comboBoxAssignedTo.Location = new System.Drawing.Point(98, 5);
            this.comboBoxAssignedTo.Name = "comboBoxAssignedTo";
            this.comboBoxAssignedTo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAssignedTo.TabIndex = 0;
            // 
            // lblAssignedTo
            // 
            this.lblAssignedTo.AutoSize = true;
            this.lblAssignedTo.Location = new System.Drawing.Point(12, 9);
            this.lblAssignedTo.Name = "lblAssignedTo";
            this.lblAssignedTo.Size = new System.Drawing.Size(80, 13);
            this.lblAssignedTo.TabIndex = 1;
            this.lblAssignedTo.Text = "ASSIGNED TO";
            // 
            // txtBoxSpclInstrsn
            // 
            this.txtBoxSpclInstrsn.Location = new System.Drawing.Point(15, 58);
            this.txtBoxSpclInstrsn.Multiline = true;
            this.txtBoxSpclInstrsn.Name = "txtBoxSpclInstrsn";
            this.txtBoxSpclInstrsn.Size = new System.Drawing.Size(647, 167);
            this.txtBoxSpclInstrsn.TabIndex = 27;
            // 
            // lblSpclInstrn
            // 
            this.lblSpclInstrn.AutoSize = true;
            this.lblSpclInstrn.Location = new System.Drawing.Point(12, 42);
            this.lblSpclInstrn.Name = "lblSpclInstrn";
            this.lblSpclInstrn.Size = new System.Drawing.Size(128, 13);
            this.lblSpclInstrn.TabIndex = 26;
            this.lblSpclInstrn.Text = "SPECIAL INSTRUCTION";
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(554, 231);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(108, 23);
            this.ButtonUpdate.TabIndex = 28;
            this.ButtonUpdate.Text = "UPDATE";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(440, 231);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(108, 23);
            this.ButtonCancel.TabIndex = 29;
            this.ButtonCancel.Text = "CANCEL";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // txtBoxTotalCost
            // 
            this.txtBoxTotalCost.Location = new System.Drawing.Point(541, 5);
            this.txtBoxTotalCost.Name = "txtBoxTotalCost";
            this.txtBoxTotalCost.Size = new System.Drawing.Size(121, 20);
            this.txtBoxTotalCost.TabIndex = 31;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(461, 9);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(74, 13);
            this.lblTotalCost.TabIndex = 30;
            this.lblTotalCost.Text = "TOTAL COST";
            // 
            // FrmFinalizeQueryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 270);
            this.Controls.Add(this.txtBoxTotalCost);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.txtBoxSpclInstrsn);
            this.Controls.Add(this.lblSpclInstrn);
            this.Controls.Add(this.lblAssignedTo);
            this.Controls.Add(this.comboBoxAssignedTo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFinalizeQueryPage";
            this.Text = "FINALIZE QUERY";
            this.Load += new System.EventHandler(this.FrmFinalizeQueryPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAssignedTo;
        private System.Windows.Forms.Label lblAssignedTo;
        private System.Windows.Forms.TextBox txtBoxSpclInstrsn;
        private System.Windows.Forms.Label lblSpclInstrn;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.TextBox txtBoxTotalCost;
        private System.Windows.Forms.Label lblTotalCost;
    }
}