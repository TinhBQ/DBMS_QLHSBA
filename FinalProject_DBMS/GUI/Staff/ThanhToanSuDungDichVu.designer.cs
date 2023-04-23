namespace GUI.Staff
{
    partial class ThanhToanSuDungDichVu
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
            this.dataGridView_usingService = new System.Windows.Forms.DataGridView();
            this.serviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_totayPay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_usingService)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_usingService
            // 
            this.dataGridView_usingService.AllowUserToAddRows = false;
            this.dataGridView_usingService.AllowUserToDeleteRows = false;
            this.dataGridView_usingService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_usingService.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView_usingService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_usingService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceID,
            this.serviceName,
            this.unitPrice,
            this.quantity,
            this.payTotal,
            this.createdAt});
            this.dataGridView_usingService.Location = new System.Drawing.Point(16, 60);
            this.dataGridView_usingService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_usingService.Name = "dataGridView_usingService";
            this.dataGridView_usingService.ReadOnly = true;
            this.dataGridView_usingService.RowHeadersWidth = 51;
            this.dataGridView_usingService.Size = new System.Drawing.Size(840, 290);
            this.dataGridView_usingService.TabIndex = 6;
            // 
            // serviceID
            // 
            this.serviceID.HeaderText = "ID dịch vụ";
            this.serviceID.MinimumWidth = 6;
            this.serviceID.Name = "serviceID";
            this.serviceID.ReadOnly = true;
            // 
            // serviceName
            // 
            this.serviceName.HeaderText = "Tên dịch vụ";
            this.serviceName.MinimumWidth = 6;
            this.serviceName.Name = "serviceName";
            this.serviceName.ReadOnly = true;
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
            // createdAt
            // 
            this.createdAt.HeaderText = "Ngày sử dụng";
            this.createdAt.MinimumWidth = 6;
            this.createdAt.Name = "createdAt";
            this.createdAt.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thanh toán dịch vụ";
            // 
            // lb_totayPay
            // 
            this.lb_totayPay.AutoSize = true;
            this.lb_totayPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totayPay.ForeColor = System.Drawing.Color.Red;
            this.lb_totayPay.Location = new System.Drawing.Point(225, 369);
            this.lb_totayPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_totayPay.Name = "lb_totayPay";
            this.lb_totayPay.Size = new System.Drawing.Size(95, 29);
            this.lb_totayPay.TabIndex = 9;
            this.lb_totayPay.Text = "money";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 369);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tổng hóa đơn:";
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(885, 60);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(137, 290);
            this.btnPay.TabIndex = 7;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // ThanhToanSuDungDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1037, 418);
            this.Controls.Add(this.dataGridView_usingService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_totayPay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPay);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ThanhToanSuDungDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán dịch vụ";
            this.Load += new System.EventHandler(this.payUsingService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_usingService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_usingService;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn payTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_totayPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPay;
    }
}