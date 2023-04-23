namespace GUI.Staff
{
    partial class TiepNhanBenhNhan
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
            this.dataGridViewInfoPatient = new System.Windows.Forms.DataGridView();
            this.IDbenhnhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDpatient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCardID = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.btnFinding = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUsingService = new System.Windows.Forms.Button();
            this.btnPay_service = new System.Windows.Forms.Button();
            this.btnPay_medicine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfoPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInfoPatient
            // 
            this.dataGridViewInfoPatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInfoPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfoPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDbenhnhan,
            this.firstName,
            this.lastName,
            this.sex,
            this.birthDay,
            this.address,
            this.phone,
            this.cardID});
            this.dataGridViewInfoPatient.Location = new System.Drawing.Point(23, 507);
            this.dataGridViewInfoPatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewInfoPatient.Name = "dataGridViewInfoPatient";
            this.dataGridViewInfoPatient.RowHeadersWidth = 51;
            this.dataGridViewInfoPatient.Size = new System.Drawing.Size(1489, 302);
            this.dataGridViewInfoPatient.TabIndex = 0;
            this.dataGridViewInfoPatient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInfoPatient_CellClick);
            // 
            // IDbenhnhan
            // 
            this.IDbenhnhan.HeaderText = "ID Bệnh nhân";
            this.IDbenhnhan.MinimumWidth = 6;
            this.IDbenhnhan.Name = "IDbenhnhan";
            this.IDbenhnhan.ReadOnly = true;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "Họ";
            this.firstName.MinimumWidth = 6;
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Tên";
            this.lastName.MinimumWidth = 6;
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // sex
            // 
            this.sex.HeaderText = "Giới tính";
            this.sex.MinimumWidth = 6;
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            // 
            // birthDay
            // 
            this.birthDay.HeaderText = "Ngày sinh";
            this.birthDay.MinimumWidth = 6;
            this.birthDay.Name = "birthDay";
            this.birthDay.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Địa chỉ";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.HeaderText = "Số điện thoại";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // cardID
            // 
            this.cardID.HeaderText = "CMND";
            this.cardID.MinimumWidth = 6;
            this.cardID.Name = "cardID";
            this.cardID.ReadOnly = true;
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(1053, 64);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(459, 183);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Hồ sơ bệnh án";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tiếp nhận bệnh nhân";
            // 
            // txtIDpatient
            // 
            this.txtIDpatient.Location = new System.Drawing.Point(172, 68);
            this.txtIDpatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDpatient.Name = "txtIDpatient";
            this.txtIDpatient.ReadOnly = true;
            this.txtIDpatient.Size = new System.Drawing.Size(295, 22);
            this.txtIDpatient.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID bệnh nhân";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Họ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 282);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngày sinh";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(172, 127);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(295, 22);
            this.txtFirstName.TabIndex = 13;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(172, 178);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(295, 22);
            this.txtLastName.TabIndex = 14;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(667, 64);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(348, 22);
            this.txtAddress.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(508, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(508, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Số điện thoại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(508, 178);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "CMND";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(508, 228);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Công việc";
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cmbSex.Location = new System.Drawing.Point(172, 228);
            this.cmbSex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(295, 24);
            this.cmbSex.TabIndex = 23;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(172, 282);
            this.dtpBirthday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(295, 22);
            this.dtpBirthday.TabIndex = 24;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(667, 128);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(348, 22);
            this.txtPhone.TabIndex = 26;
            // 
            // txtCardID
            // 
            this.txtCardID.Location = new System.Drawing.Point(667, 174);
            this.txtCardID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.Size = new System.Drawing.Size(348, 22);
            this.txtCardID.TabIndex = 27;
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(667, 223);
            this.txtJob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(348, 22);
            this.txtJob.TabIndex = 28;
            // 
            // btnFinding
            // 
            this.btnFinding.Location = new System.Drawing.Point(23, 336);
            this.btnFinding.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFinding.Name = "btnFinding";
            this.btnFinding.Size = new System.Drawing.Size(195, 75);
            this.btnFinding.TabIndex = 32;
            this.btnFinding.Text = "Tìm kiếm";
            this.btnFinding.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(261, 336);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(207, 146);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExam
            // 
            this.btnExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExam.Location = new System.Drawing.Point(1053, 396);
            this.btnExam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(459, 86);
            this.btnExam.TabIndex = 34;
            this.btnExam.Text = "Khám";
            this.btnExam.UseVisualStyleBackColor = true;
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(23, 420);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(195, 63);
            this.btnRefresh.TabIndex = 35;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUsingService
            // 
            this.btnUsingService.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsingService.Location = new System.Drawing.Point(512, 396);
            this.btnUsingService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUsingService.Name = "btnUsingService";
            this.btnUsingService.Size = new System.Drawing.Size(504, 86);
            this.btnUsingService.TabIndex = 36;
            this.btnUsingService.Text = "Sử dụng dịch vụ";
            this.btnUsingService.UseVisualStyleBackColor = true;
            this.btnUsingService.Click += new System.EventHandler(this.btnUsingService_Click);
            // 
            // btnPay_service
            // 
            this.btnPay_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay_service.Location = new System.Drawing.Point(512, 271);
            this.btnPay_service.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPay_service.Name = "btnPay_service";
            this.btnPay_service.Size = new System.Drawing.Size(504, 102);
            this.btnPay_service.TabIndex = 37;
            this.btnPay_service.Text = "Thanh toán dịch vụ";
            this.btnPay_service.UseVisualStyleBackColor = true;
            this.btnPay_service.Click += new System.EventHandler(this.btnPay_service_Click);
            // 
            // btnPay_medicine
            // 
            this.btnPay_medicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay_medicine.Location = new System.Drawing.Point(1053, 272);
            this.btnPay_medicine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPay_medicine.Name = "btnPay_medicine";
            this.btnPay_medicine.Size = new System.Drawing.Size(459, 101);
            this.btnPay_medicine.TabIndex = 38;
            this.btnPay_medicine.Text = "Thanh toán đơn thuốc";
            this.btnPay_medicine.UseVisualStyleBackColor = true;
            this.btnPay_medicine.Click += new System.EventHandler(this.btnPay_medicine_Click);
            // 
            // TiepNhanBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1551, 823);
            this.Controls.Add(this.btnPay_medicine);
            this.Controls.Add(this.btnPay_service);
            this.Controls.Add(this.btnUsingService);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnExam);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnFinding);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.txtCardID);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDpatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.dataGridViewInfoPatient);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TiepNhanBenhNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinBenhNhan";
            this.Load += new System.EventHandler(this.TiepNhanBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfoPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInfoPatient;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDpatient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCardID;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Button btnFinding;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDbenhnhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardID;
        private System.Windows.Forms.Button btnUsingService;
        private System.Windows.Forms.Button btnPay_service;
        private System.Windows.Forms.Button btnPay_medicine;
    }
}