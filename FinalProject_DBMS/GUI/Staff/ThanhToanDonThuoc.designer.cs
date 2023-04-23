namespace GUI.Staff
{
    partial class ThanhToanDonThuoc
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
            this.dataGridView_listMedicine = new System.Windows.Forms.DataGridView();
            this.medicineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_totayPay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.IDexam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_listMedicine
            // 
            this.dataGridView_listMedicine.AllowUserToAddRows = false;
            this.dataGridView_listMedicine.AllowUserToDeleteRows = false;
            this.dataGridView_listMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_listMedicine.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView_listMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_listMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicineID,
            this.medicineName,
            this.unitPrice,
            this.quantity,
            this.payTotal});
            this.dataGridView_listMedicine.Location = new System.Drawing.Point(521, 66);
            this.dataGridView_listMedicine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_listMedicine.Name = "dataGridView_listMedicine";
            this.dataGridView_listMedicine.ReadOnly = true;
            this.dataGridView_listMedicine.RowHeadersWidth = 51;
            this.dataGridView_listMedicine.Size = new System.Drawing.Size(819, 337);
            this.dataGridView_listMedicine.TabIndex = 11;
            // 
            // medicineID
            // 
            this.medicineID.HeaderText = "ID thuốc";
            this.medicineID.MinimumWidth = 6;
            this.medicineID.Name = "medicineID";
            this.medicineID.ReadOnly = true;
            // 
            // medicineName
            // 
            this.medicineName.HeaderText = "Tên thuốc";
            this.medicineName.MinimumWidth = 6;
            this.medicineName.Name = "medicineName";
            this.medicineName.ReadOnly = true;
            // 
            // unitPrice
            // 
            this.unitPrice.HeaderText = "Đơn giá";
            this.unitPrice.MinimumWidth = 6;
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Số lượng";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // payTotal
            // 
            this.payTotal.HeaderText = "Tổng giá";
            this.payTotal.MinimumWidth = 6;
            this.payTotal.Name = "payTotal";
            this.payTotal.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Thanh toán đơn thuốc";
            // 
            // lb_totayPay
            // 
            this.lb_totayPay.AutoSize = true;
            this.lb_totayPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totayPay.ForeColor = System.Drawing.Color.Red;
            this.lb_totayPay.Location = new System.Drawing.Point(228, 433);
            this.lb_totayPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_totayPay.Name = "lb_totayPay";
            this.lb_totayPay.Size = new System.Drawing.Size(95, 29);
            this.lb_totayPay.TabIndex = 14;
            this.lb_totayPay.Text = "money";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 433);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tổng hóa đơn:";
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(995, 411);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(345, 60);
            this.btnPay.TabIndex = 12;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDexam,
            this.doctor,
            this.date});
            this.dataGridViewHistory.Location = new System.Drawing.Point(16, 66);
            this.dataGridViewHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.RowHeadersWidth = 51;
            this.dataGridViewHistory.Size = new System.Drawing.Size(479, 337);
            this.dataGridViewHistory.TabIndex = 68;
            this.dataGridViewHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHistory_CellContentClick);
            // 
            // IDexam
            // 
            this.IDexam.HeaderText = "ID đơn khám";
            this.IDexam.MinimumWidth = 6;
            this.IDexam.Name = "IDexam";
            this.IDexam.ReadOnly = true;
            // 
            // doctor
            // 
            this.doctor.HeaderText = "Bác sĩ khám";
            this.doctor.MinimumWidth = 6;
            this.doctor.Name = "doctor";
            this.doctor.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Ngày khám";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // ThanhToanDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1356, 486);
            this.Controls.Add(this.dataGridViewHistory);
            this.Controls.Add(this.dataGridView_listMedicine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_totayPay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPay);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ThanhToanDonThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThanhToanDonThuoc";
            this.Load += new System.EventHandler(this.ThanhToanDonThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_listMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_listMedicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_totayPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn payTotal;
        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDexam;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}