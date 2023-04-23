
namespace GUI.Admin
{
    partial class FrmPatients
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lbldsBenhNhan = new System.Windows.Forms.Label();
            this.pnlinforBN = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtlydo = new System.Windows.Forms.TextBox();
            this.txtbhyt = new System.Windows.Forms.TextBox();
            this.txtjob = new System.Windows.Forms.TextBox();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.txtGioitinh = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblreason = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblCmnd = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBirthDay = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.dgvInfoPatien = new System.Windows.Forms.DataGridView();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLHSBADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.pnlinforBN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoPatien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSBADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.lbldsBenhNhan);
            this.panel1.Controls.Add(this.pnlinforBN);
            this.panel1.Controls.Add(this.dgvInfoPatien);
            this.panel1.Location = new System.Drawing.Point(7, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1529, 721);
            this.panel1.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1351, 686);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 32);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(1209, 686);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 32);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(1070, 686);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 32);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(936, 686);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 32);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbldsBenhNhan
            // 
            this.lbldsBenhNhan.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldsBenhNhan.Location = new System.Drawing.Point(12, 33);
            this.lbldsBenhNhan.Name = "lbldsBenhNhan";
            this.lbldsBenhNhan.Size = new System.Drawing.Size(373, 37);
            this.lbldsBenhNhan.TabIndex = 2;
            this.lbldsBenhNhan.Text = "Danh sách bệnh nhân :";
            // 
            // pnlinforBN
            // 
            this.pnlinforBN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlinforBN.Controls.Add(this.label1);
            this.pnlinforBN.Controls.Add(this.txtId);
            this.pnlinforBN.Controls.Add(this.txtlydo);
            this.pnlinforBN.Controls.Add(this.txtbhyt);
            this.pnlinforBN.Controls.Add(this.txtjob);
            this.pnlinforBN.Controls.Add(this.txtCard);
            this.pnlinforBN.Controls.Add(this.txtphone);
            this.pnlinforBN.Controls.Add(this.txtaddress);
            this.pnlinforBN.Controls.Add(this.txtBirthday);
            this.pnlinforBN.Controls.Add(this.txtGioitinh);
            this.pnlinforBN.Controls.Add(this.txtLastname);
            this.pnlinforBN.Controls.Add(this.txtFirstName);
            this.pnlinforBN.Controls.Add(this.lblreason);
            this.pnlinforBN.Controls.Add(this.lblHealth);
            this.pnlinforBN.Controls.Add(this.lblJob);
            this.pnlinforBN.Controls.Add(this.lblCmnd);
            this.pnlinforBN.Controls.Add(this.lblPhone);
            this.pnlinforBN.Controls.Add(this.lblAddress);
            this.pnlinforBN.Controls.Add(this.lblBirthDay);
            this.pnlinforBN.Controls.Add(this.lblSex);
            this.pnlinforBN.Controls.Add(this.lblLastName);
            this.pnlinforBN.Controls.Add(this.lblFirstName);
            this.pnlinforBN.Controls.Add(this.lblThongTin);
            this.pnlinforBN.Location = new System.Drawing.Point(914, 73);
            this.pnlinforBN.Name = "pnlinforBN";
            this.pnlinforBN.Size = new System.Drawing.Size(606, 607);
            this.pnlinforBN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 580);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(156, 577);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(391, 30);
            this.txtId.TabIndex = 21;
            // 
            // txtlydo
            // 
            this.txtlydo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlydo.Location = new System.Drawing.Point(156, 529);
            this.txtlydo.Name = "txtlydo";
            this.txtlydo.Size = new System.Drawing.Size(391, 30);
            this.txtlydo.TabIndex = 20;
            // 
            // txtbhyt
            // 
            this.txtbhyt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbhyt.Location = new System.Drawing.Point(156, 471);
            this.txtbhyt.Name = "txtbhyt";
            this.txtbhyt.Size = new System.Drawing.Size(391, 30);
            this.txtbhyt.TabIndex = 19;
            // 
            // txtjob
            // 
            this.txtjob.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjob.Location = new System.Drawing.Point(156, 418);
            this.txtjob.Name = "txtjob";
            this.txtjob.Size = new System.Drawing.Size(391, 30);
            this.txtjob.TabIndex = 18;
            // 
            // txtCard
            // 
            this.txtCard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCard.Location = new System.Drawing.Point(156, 359);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(391, 30);
            this.txtCard.TabIndex = 17;
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Location = new System.Drawing.Point(156, 304);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(391, 30);
            this.txtphone.TabIndex = 16;
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(156, 246);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(391, 30);
            this.txtaddress.TabIndex = 15;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthday.Location = new System.Drawing.Point(156, 189);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(391, 30);
            this.txtBirthday.TabIndex = 14;
            // 
            // txtGioitinh
            // 
            this.txtGioitinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioitinh.Location = new System.Drawing.Point(156, 142);
            this.txtGioitinh.Name = "txtGioitinh";
            this.txtGioitinh.Size = new System.Drawing.Size(391, 30);
            this.txtGioitinh.TabIndex = 13;
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(156, 87);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(391, 30);
            this.txtLastname.TabIndex = 12;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(156, 37);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(391, 30);
            this.txtFirstName.TabIndex = 11;
            // 
            // lblreason
            // 
            this.lblreason.AutoSize = true;
            this.lblreason.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreason.Location = new System.Drawing.Point(18, 532);
            this.lblreason.Name = "lblreason";
            this.lblreason.Size = new System.Drawing.Size(129, 22);
            this.lblreason.TabIndex = 10;
            this.lblreason.Text = "Lý do vào viện";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.Location = new System.Drawing.Point(18, 474);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(63, 22);
            this.lblHealth.TabIndex = 9;
            this.lblHealth.Text = "BHYT";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.Location = new System.Drawing.Point(18, 421);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(90, 22);
            this.lblJob.TabIndex = 8;
            this.lblJob.Text = "Công việc";
            // 
            // lblCmnd
            // 
            this.lblCmnd.AutoSize = true;
            this.lblCmnd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmnd.Location = new System.Drawing.Point(18, 362);
            this.lblCmnd.Name = "lblCmnd";
            this.lblCmnd.Size = new System.Drawing.Size(127, 22);
            this.lblCmnd.TabIndex = 7;
            this.lblCmnd.Text = "CMND/CCCD";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(18, 307);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(114, 22);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Số điện thoại";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(18, 249);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(77, 22);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Địa Chỉ ";
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.AutoSize = true;
            this.lblBirthDay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDay.Location = new System.Drawing.Point(18, 192);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(96, 22);
            this.lblBirthDay.TabIndex = 4;
            this.lblBirthDay.Text = "Ngày Sinh ";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(18, 145);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(86, 22);
            this.lblSex.TabIndex = 3;
            this.lblSex.Text = "Giới tính ";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(18, 90);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(99, 22);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name ";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(18, 40);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(103, 22);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name ";
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.Location = new System.Drawing.Point(199, 9);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(180, 23);
            this.lblThongTin.TabIndex = 0;
            this.lblThongTin.Text = "Thông tin bệnh nhân";
            // 
            // dgvInfoPatien
            // 
            this.dgvInfoPatien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoPatien.Location = new System.Drawing.Point(17, 73);
            this.dgvInfoPatien.Name = "dgvInfoPatien";
            this.dgvInfoPatien.RowHeadersWidth = 51;
            this.dgvInfoPatien.RowTemplate.Height = 24;
            this.dgvInfoPatien.Size = new System.Drawing.Size(891, 645);
            this.dgvInfoPatien.TabIndex = 0;
            this.dgvInfoPatien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfoPatien_CellContentClick);
            // 
            // FrmPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1543, 750);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPatients";
            this.Load += new System.EventHandler(this.FrmPatients_Load);
            this.panel1.ResumeLayout(false);
            this.pnlinforBN.ResumeLayout(false);
            this.pnlinforBN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoPatien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHSBADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lbldsBenhNhan;
        private System.Windows.Forms.Panel pnlinforBN;
        private System.Windows.Forms.TextBox txtlydo;
        private System.Windows.Forms.TextBox txtbhyt;
        private System.Windows.Forms.TextBox txtjob;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.TextBox txtGioitinh;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblreason;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblCmnd;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBirthDay;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.DataGridView dgvInfoPatien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private System.Windows.Forms.BindingSource qLHSBADataSetBindingSource;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
    }
}