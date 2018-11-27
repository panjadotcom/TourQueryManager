namespace TourQueryManager
{
    partial class FrmPaymentUpdatePage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaymentUpdatePage));
            this.dataGridViewCurrentStatus = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelPaymentForm = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalTourCost = new System.Windows.Forms.Label();
            this.txtBoxTotalTourCost = new System.Windows.Forms.TextBox();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.txtBoxTotalPayment = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.txtBoxNote = new System.Windows.Forms.TextBox();
            this.txtBoxTransactionId = new System.Windows.Forms.TextBox();
            this.txtBoxTransactionAmount = new System.Windows.Forms.TextBox();
            this.lblTransactionId = new System.Windows.Forms.Label();
            this.lblTransacionAmount = new System.Windows.Forms.Label();
            this.lblTransactionMode = new System.Windows.Forms.Label();
            this.lblTransactionTime = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.comboBoxTransactionMode = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTransactionTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrentStatus)).BeginInit();
            this.tableLayoutPanelPaymentForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCurrentStatus
            // 
            this.dataGridViewCurrentStatus.AllowUserToAddRows = false;
            this.dataGridViewCurrentStatus.AllowUserToDeleteRows = false;
            this.dataGridViewCurrentStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanelPaymentForm.SetColumnSpan(this.dataGridViewCurrentStatus, 10);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCurrentStatus.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCurrentStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCurrentStatus.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCurrentStatus.MultiSelect = false;
            this.dataGridViewCurrentStatus.Name = "dataGridViewCurrentStatus";
            this.dataGridViewCurrentStatus.ReadOnly = true;
            this.dataGridViewCurrentStatus.RowHeadersVisible = false;
            this.tableLayoutPanelPaymentForm.SetRowSpan(this.dataGridViewCurrentStatus, 4);
            this.dataGridViewCurrentStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCurrentStatus.Size = new System.Drawing.Size(794, 114);
            this.dataGridViewCurrentStatus.TabIndex = 7;
            this.dataGridViewCurrentStatus.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCurrentStatus_CellDoubleClick);
            // 
            // tableLayoutPanelPaymentForm
            // 
            this.tableLayoutPanelPaymentForm.ColumnCount = 10;
            this.tableLayoutPanelPaymentForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelPaymentForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelPaymentForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelPaymentForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelPaymentForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelPaymentForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelPaymentForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelPaymentForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelPaymentForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelPaymentForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelPaymentForm.Controls.Add(this.lblTotalTourCost, 0, 4);
            this.tableLayoutPanelPaymentForm.Controls.Add(this.txtBoxTotalTourCost, 0, 5);
            this.tableLayoutPanelPaymentForm.Controls.Add(this.lblTotalPayment, 3, 4);
            this.tableLayoutPanelPaymentForm.Controls.Add(this.txtBoxTotalPayment, 3, 5);
            this.tableLayoutPanelPaymentForm.Controls.Add(this.BtnDelete, 4, 14);
            this.tableLayoutPanelPaymentForm.Controls.Add(this.ButtonCancel, 8, 14);
            this.tableLayoutPanelPaymentForm.Controls.Add(this.dataGridViewCurrentStatus, 0, 0);
            this.tableLayoutPanelPaymentForm.Controls.Add(this.ButtonUpdate, 6, 14);
            this.tableLayoutPanelPaymentForm.Controls.Add(this.txtBoxNote, 0, 12);
            this.tableLayoutPanelPaymentForm.Controls.Add(this.txtBoxTransactionId, 6, 9);
            this.tableLayoutPanelPaymentForm.Controls.Add(this.txtBoxTransactionAmount, 6, 7);
            this.tableLayoutPanelPaymentForm.Controls.Add(this.lblTransactionId, 6, 8);
            this.tableLayoutPanelPaymentForm.Controls.Add(this.lblTransacionAmount, 6, 6);
            this.tableLayoutPanelPaymentForm.Controls.Add(this.lblTransactionMode, 6, 4);
            this.tableLayoutPanelPaymentForm.Controls.Add(this.lblTransactionTime, 6, 10);
            this.tableLayoutPanelPaymentForm.Controls.Add(this.lblNote, 0, 11);
            this.tableLayoutPanelPaymentForm.Controls.Add(this.comboBoxTransactionMode, 6, 5);
            this.tableLayoutPanelPaymentForm.Controls.Add(this.dateTimePickerTransactionDate, 6, 11);
            this.tableLayoutPanelPaymentForm.Controls.Add(this.dateTimePickerTransactionTime, 8, 11);
            this.tableLayoutPanelPaymentForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPaymentForm.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelPaymentForm.Name = "tableLayoutPanelPaymentForm";
            this.tableLayoutPanelPaymentForm.RowCount = 15;
            this.tableLayoutPanelPaymentForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanelPaymentForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanelPaymentForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanelPaymentForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanelPaymentForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanelPaymentForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanelPaymentForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanelPaymentForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanelPaymentForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanelPaymentForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanelPaymentForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanelPaymentForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanelPaymentForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanelPaymentForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanelPaymentForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanelPaymentForm.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanelPaymentForm.TabIndex = 33;
            // 
            // lblTotalTourCost
            // 
            this.lblTotalTourCost.AutoSize = true;
            this.tableLayoutPanelPaymentForm.SetColumnSpan(this.lblTotalTourCost, 2);
            this.lblTotalTourCost.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalTourCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTourCost.Location = new System.Drawing.Point(3, 134);
            this.lblTotalTourCost.Name = "lblTotalTourCost";
            this.lblTotalTourCost.Size = new System.Drawing.Size(154, 16);
            this.lblTotalTourCost.TabIndex = 13;
            this.lblTotalTourCost.Text = "TOTAL TOUR COST";
            // 
            // txtBoxTotalTourCost
            // 
            this.tableLayoutPanelPaymentForm.SetColumnSpan(this.txtBoxTotalTourCost, 2);
            this.txtBoxTotalTourCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxTotalTourCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTotalTourCost.Location = new System.Drawing.Point(3, 153);
            this.txtBoxTotalTourCost.Name = "txtBoxTotalTourCost";
            this.txtBoxTotalTourCost.ReadOnly = true;
            this.txtBoxTotalTourCost.Size = new System.Drawing.Size(154, 26);
            this.txtBoxTotalTourCost.TabIndex = 10;
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            this.tableLayoutPanelPaymentForm.SetColumnSpan(this.lblTotalPayment, 2);
            this.lblTotalPayment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayment.Location = new System.Drawing.Point(243, 134);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(154, 16);
            this.lblTotalPayment.TabIndex = 14;
            this.lblTotalPayment.Text = "TOTAL PAYMENT";
            // 
            // txtBoxTotalPayment
            // 
            this.tableLayoutPanelPaymentForm.SetColumnSpan(this.txtBoxTotalPayment, 2);
            this.txtBoxTotalPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTotalPayment.Location = new System.Drawing.Point(243, 153);
            this.txtBoxTotalPayment.Name = "txtBoxTotalPayment";
            this.txtBoxTotalPayment.ReadOnly = true;
            this.txtBoxTotalPayment.Size = new System.Drawing.Size(154, 26);
            this.txtBoxTotalPayment.TabIndex = 11;
            // 
            // BtnDelete
            // 
            this.tableLayoutPanelPaymentForm.SetColumnSpan(this.BtnDelete, 2);
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.Location = new System.Drawing.Point(323, 423);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(154, 24);
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.Text = "DELETE";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // ButtonCancel
            // 
            this.tableLayoutPanelPaymentForm.SetColumnSpan(this.ButtonCancel, 2);
            this.ButtonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonCancel.Location = new System.Drawing.Point(643, 423);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(154, 24);
            this.ButtonCancel.TabIndex = 9;
            this.ButtonCancel.Text = "EXIT";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonUpdate
            // 
            this.tableLayoutPanelPaymentForm.SetColumnSpan(this.ButtonUpdate, 2);
            this.ButtonUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonUpdate.Location = new System.Drawing.Point(483, 423);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(154, 24);
            this.ButtonUpdate.TabIndex = 6;
            this.ButtonUpdate.Text = "UPDATE";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // txtBoxNote
            // 
            this.tableLayoutPanelPaymentForm.SetColumnSpan(this.txtBoxNote, 10);
            this.txtBoxNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxNote.Location = new System.Drawing.Point(3, 363);
            this.txtBoxNote.Multiline = true;
            this.txtBoxNote.Name = "txtBoxNote";
            this.tableLayoutPanelPaymentForm.SetRowSpan(this.txtBoxNote, 2);
            this.txtBoxNote.Size = new System.Drawing.Size(794, 54);
            this.txtBoxNote.TabIndex = 5;
            // 
            // txtBoxTransactionId
            // 
            this.tableLayoutPanelPaymentForm.SetColumnSpan(this.txtBoxTransactionId, 3);
            this.txtBoxTransactionId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxTransactionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTransactionId.Location = new System.Drawing.Point(483, 273);
            this.txtBoxTransactionId.Name = "txtBoxTransactionId";
            this.txtBoxTransactionId.Size = new System.Drawing.Size(234, 26);
            this.txtBoxTransactionId.TabIndex = 2;
            // 
            // txtBoxTransactionAmount
            // 
            this.tableLayoutPanelPaymentForm.SetColumnSpan(this.txtBoxTransactionAmount, 3);
            this.txtBoxTransactionAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxTransactionAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTransactionAmount.Location = new System.Drawing.Point(483, 213);
            this.txtBoxTransactionAmount.Name = "txtBoxTransactionAmount";
            this.txtBoxTransactionAmount.Size = new System.Drawing.Size(234, 26);
            this.txtBoxTransactionAmount.TabIndex = 1;
            // 
            // lblTransactionId
            // 
            this.lblTransactionId.AutoSize = true;
            this.tableLayoutPanelPaymentForm.SetColumnSpan(this.lblTransactionId, 3);
            this.lblTransactionId.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTransactionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionId.Location = new System.Drawing.Point(483, 254);
            this.lblTransactionId.Name = "lblTransactionId";
            this.lblTransactionId.Size = new System.Drawing.Size(234, 16);
            this.lblTransactionId.TabIndex = 17;
            this.lblTransactionId.Text = "TRANSACTION ID";
            // 
            // lblTransacionAmount
            // 
            this.lblTransacionAmount.AutoSize = true;
            this.tableLayoutPanelPaymentForm.SetColumnSpan(this.lblTransacionAmount, 3);
            this.lblTransacionAmount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTransacionAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransacionAmount.Location = new System.Drawing.Point(483, 194);
            this.lblTransacionAmount.Name = "lblTransacionAmount";
            this.lblTransacionAmount.Size = new System.Drawing.Size(234, 16);
            this.lblTransacionAmount.TabIndex = 16;
            this.lblTransacionAmount.Text = "TRANSACTION AMOUNT";
            // 
            // lblTransactionMode
            // 
            this.lblTransactionMode.AutoSize = true;
            this.tableLayoutPanelPaymentForm.SetColumnSpan(this.lblTransactionMode, 3);
            this.lblTransactionMode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTransactionMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionMode.Location = new System.Drawing.Point(483, 134);
            this.lblTransactionMode.Name = "lblTransactionMode";
            this.lblTransactionMode.Size = new System.Drawing.Size(234, 16);
            this.lblTransactionMode.TabIndex = 15;
            this.lblTransactionMode.Text = "TRANSACTION MODE";
            // 
            // lblTransactionTime
            // 
            this.lblTransactionTime.AutoSize = true;
            this.tableLayoutPanelPaymentForm.SetColumnSpan(this.lblTransactionTime, 3);
            this.lblTransactionTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTransactionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionTime.Location = new System.Drawing.Point(483, 314);
            this.lblTransactionTime.Name = "lblTransactionTime";
            this.lblTransactionTime.Size = new System.Drawing.Size(234, 16);
            this.lblTransactionTime.TabIndex = 18;
            this.lblTransactionTime.Text = "TIME OF TRANSACTION";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.tableLayoutPanelPaymentForm.SetColumnSpan(this.lblNote, 2);
            this.lblNote.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(3, 344);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(154, 16);
            this.lblNote.TabIndex = 12;
            this.lblNote.Text = "NOTE:";
            // 
            // comboBoxTransactionMode
            // 
            this.tableLayoutPanelPaymentForm.SetColumnSpan(this.comboBoxTransactionMode, 3);
            this.comboBoxTransactionMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxTransactionMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTransactionMode.FormattingEnabled = true;
            this.comboBoxTransactionMode.Items.AddRange(new object[] {
            "SELECT MODE",
            "CASH",
            "CHEQUE",
            "PAYTM",
            "UPI",
            "BANK TRANSFER",
            "OTHER"});
            this.comboBoxTransactionMode.Location = new System.Drawing.Point(483, 153);
            this.comboBoxTransactionMode.Name = "comboBoxTransactionMode";
            this.comboBoxTransactionMode.Size = new System.Drawing.Size(234, 24);
            this.comboBoxTransactionMode.TabIndex = 0;
            // 
            // dateTimePickerTransactionDate
            // 
            this.tableLayoutPanelPaymentForm.SetColumnSpan(this.dateTimePickerTransactionDate, 2);
            this.dateTimePickerTransactionDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerTransactionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTransactionDate.Location = new System.Drawing.Point(483, 333);
            this.dateTimePickerTransactionDate.Name = "dateTimePickerTransactionDate";
            this.dateTimePickerTransactionDate.Size = new System.Drawing.Size(154, 22);
            this.dateTimePickerTransactionDate.TabIndex = 3;
            // 
            // dateTimePickerTransactionTime
            // 
            this.dateTimePickerTransactionTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerTransactionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTransactionTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTransactionTime.Location = new System.Drawing.Point(643, 333);
            this.dateTimePickerTransactionTime.Name = "dateTimePickerTransactionTime";
            this.dateTimePickerTransactionTime.ShowUpDown = true;
            this.dateTimePickerTransactionTime.Size = new System.Drawing.Size(74, 22);
            this.dateTimePickerTransactionTime.TabIndex = 4;
            // 
            // FrmPaymentUpdatePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanelPaymentForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPaymentUpdatePage";
            this.Text = "UPDATE PAYMENT";
            this.Load += new System.EventHandler(this.FrmPaymentUpdatePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrentStatus)).EndInit();
            this.tableLayoutPanelPaymentForm.ResumeLayout(false);
            this.tableLayoutPanelPaymentForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewCurrentStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPaymentForm;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox txtBoxNote;
        private System.Windows.Forms.TextBox txtBoxTransactionId;
        private System.Windows.Forms.TextBox txtBoxTransactionAmount;
        private System.Windows.Forms.Label lblTransactionId;
        private System.Windows.Forms.Label lblTransacionAmount;
        private System.Windows.Forms.Label lblTransactionMode;
        private System.Windows.Forms.Label lblTransactionTime;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.ComboBox comboBoxTransactionMode;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransactionDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransactionTime;
        private System.Windows.Forms.Label lblTotalPayment;
        private System.Windows.Forms.TextBox txtBoxTotalPayment;
        private System.Windows.Forms.TextBox txtBoxTotalTourCost;
        private System.Windows.Forms.Label lblTotalTourCost;
    }
}