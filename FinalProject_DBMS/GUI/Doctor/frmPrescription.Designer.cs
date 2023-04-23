namespace GUI.Doctor
{
    partial class frmPrescription
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDonThuoc = new System.Windows.Forms.TextBox();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboTenThuoc = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtNhomThuoc = new System.Windows.Forms.TextBox();
            this.txtHSD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHinhDang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoTon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvLayThuoc = new System.Windows.Forms.DataGridView();
            this.medicinesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.medicinesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 56);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(429, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "TẠO ĐƠN THUỐC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã đơn thuốc";
            // 
            // txtMaDonThuoc
            // 
            this.txtMaDonThuoc.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDonThuoc.Location = new System.Drawing.Point(262, 20);
            this.txtMaDonThuoc.Name = "txtMaDonThuoc";
            this.txtMaDonThuoc.Size = new System.Drawing.Size(160, 40);
            this.txtMaDonThuoc.TabIndex = 2;
            // 
            // txtMota
            // 
            this.txtMota.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMota.Location = new System.Drawing.Point(262, 93);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(780, 96);
            this.txtMota.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mô tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(36, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên thuốc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Medium", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(36, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số lượng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMota);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtMaDonThuoc);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1125, 229);
            this.panel2.TabIndex = 9;
            // 
            // comboTenThuoc
            // 
            this.comboTenThuoc.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTenThuoc.FormattingEnabled = true;
            this.comboTenThuoc.Location = new System.Drawing.Point(262, 96);
            this.comboTenThuoc.Name = "comboTenThuoc";
            this.comboTenThuoc.Size = new System.Drawing.Size(265, 41);
            this.comboTenThuoc.TabIndex = 9;
            this.comboTenThuoc.SelectedIndexChanged += new System.EventHandler(this.comboTenThuoc_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSoLuong);
            this.panel3.Controls.Add(this.comboTenThuoc);
            this.panel3.Controls.Add(this.txtNhomThuoc);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtHSD);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtHinhDang);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtSoTon);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtGia);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtDonVi);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtMaThuoc);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 285);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1125, 512);
            this.panel3.TabIndex = 10;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(262, 442);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(265, 40);
            this.txtSoLuong.TabIndex = 40;
            // 
            // txtNhomThuoc
            // 
            this.txtNhomThuoc.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhomThuoc.Location = new System.Drawing.Point(262, 174);
            this.txtNhomThuoc.Name = "txtNhomThuoc";
            this.txtNhomThuoc.Size = new System.Drawing.Size(265, 40);
            this.txtNhomThuoc.TabIndex = 39;
            // 
            // txtHSD
            // 
            this.txtHSD.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHSD.Location = new System.Drawing.Point(262, 351);
            this.txtHSD.Name = "txtHSD";
            this.txtHSD.Size = new System.Drawing.Size(265, 40);
            this.txtHSD.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto Medium", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(36, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 33);
            this.label10.TabIndex = 37;
            this.label10.Text = "Nhóm thuốc";
            // 
            // txtHinhDang
            // 
            this.txtHinhDang.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHinhDang.Location = new System.Drawing.Point(816, 174);
            this.txtHinhDang.Name = "txtHinhDang";
            this.txtHinhDang.Size = new System.Drawing.Size(265, 40);
            this.txtHinhDang.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Medium", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(597, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 33);
            this.label9.TabIndex = 34;
            this.label9.Text = "Hình dạng";
            // 
            // txtSoTon
            // 
            this.txtSoTon.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTon.Location = new System.Drawing.Point(816, 351);
            this.txtSoTon.Name = "txtSoTon";
            this.txtSoTon.Size = new System.Drawing.Size(265, 40);
            this.txtSoTon.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Medium", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(597, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 33);
            this.label8.TabIndex = 32;
            this.label8.Text = "Số tồn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Medium", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(36, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 33);
            this.label7.TabIndex = 31;
            this.label7.Text = "Hạn sử dụng";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(816, 261);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(265, 40);
            this.txtGia.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto Medium", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label11.Location = new System.Drawing.Point(597, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 33);
            this.label11.TabIndex = 29;
            this.label11.Text = "Giá";
            // 
            // txtDonVi
            // 
            this.txtDonVi.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonVi.Location = new System.Drawing.Point(262, 261);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(265, 40);
            this.txtDonVi.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto Medium", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label12.Location = new System.Drawing.Point(36, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 33);
            this.label12.TabIndex = 27;
            this.label12.Text = "Đơn vị";
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Enabled = false;
            this.txtMaThuoc.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThuoc.Location = new System.Drawing.Point(816, 97);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Size = new System.Drawing.Size(265, 40);
            this.txtMaThuoc.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Roboto Medium", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label14.Location = new System.Drawing.Point(597, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 33);
            this.label14.TabIndex = 23;
            this.label14.Text = "Mã thuốc";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1125, 57);
            this.panel4.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(412, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "THÔNG TIN THUỐC";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Controls.Add(this.btnUpdate);
            this.panel5.Controls.Add(this.btnRefresh);
            this.panel5.Controls.Add(this.btnAdd);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 797);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1125, 96);
            this.panel5.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDelete.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(466, -2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(172, 95);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseMnemonic = false;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpdate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(245, -2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(169, 95);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseMnemonic = false;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRefresh.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(694, -2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(169, 95);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseMnemonic = false;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdd.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(28, -2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(172, 95);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseMnemonic = false;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSave.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(911, -2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 95);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseMnemonic = false;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvLayThuoc
            // 
            this.dgvLayThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLayThuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLayThuoc.Location = new System.Drawing.Point(0, 893);
            this.dgvLayThuoc.Name = "dgvLayThuoc";
            this.dgvLayThuoc.RowHeadersWidth = 82;
            this.dgvLayThuoc.RowTemplate.Height = 33;
            this.dgvLayThuoc.Size = new System.Drawing.Size(1125, 440);
            this.dgvLayThuoc.TabIndex = 12;
            this.dgvLayThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLayThuoc_CellClick);
            // 
            // frmPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1125, 1335);
            this.Controls.Add(this.dgvLayThuoc);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmPrescription";
            this.Text = "frmPrescription";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmPrescription_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLayThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicinesBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDonThuoc;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHSD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHinhDang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoTon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvLayThuoc;
        private System.Windows.Forms.TextBox txtNhomThuoc;
        private System.Windows.Forms.BindingSource medicinesBindingSource2;
        private System.Windows.Forms.BindingSource medicinesBindingSource3;
        private System.Windows.Forms.ComboBox comboTenThuoc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSoLuong;
    }
}