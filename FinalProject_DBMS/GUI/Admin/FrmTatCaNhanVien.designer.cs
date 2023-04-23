
namespace GUI.Admin
{
    partial class FrmTatCaNhanVien
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
            this.dgvInfoEmployee = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pnlinforBN = new System.Windows.Forms.Panel();
            this.txtidpeo = new System.Windows.Forms.TextBox();
            this.txtidkhoa = new System.Windows.Forms.TextBox();
            this.txtfirst = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.txtGioitinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblCmnd = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBirthDay = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoEmployee)).BeginInit();
            this.pnlinforBN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInfoEmployee
            // 
            this.dgvInfoEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoEmployee.Location = new System.Drawing.Point(20, 61);
            this.dgvInfoEmployee.Name = "dgvInfoEmployee";
            this.dgvInfoEmployee.RowHeadersWidth = 51;
            this.dgvInfoEmployee.RowTemplate.Height = 24;
            this.dgvInfoEmployee.Size = new System.Drawing.Size(612, 588);
            this.dgvInfoEmployee.TabIndex = 1;
            this.dgvInfoEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInfoEmployee_CellContentClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1134, 617);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 32);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(978, 617);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 32);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(807, 617);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 32);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(649, 617);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 32);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pnlinforBN
            // 
            this.pnlinforBN.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlinforBN.Controls.Add(this.txtidpeo);
            this.pnlinforBN.Controls.Add(this.txtidkhoa);
            this.pnlinforBN.Controls.Add(this.txtfirst);
            this.pnlinforBN.Controls.Add(this.txtLastname);
            this.pnlinforBN.Controls.Add(this.txtCard);
            this.pnlinforBN.Controls.Add(this.txtsdt);
            this.pnlinforBN.Controls.Add(this.txtaddress);
            this.pnlinforBN.Controls.Add(this.txtBirthday);
            this.pnlinforBN.Controls.Add(this.txtGioitinh);
            this.pnlinforBN.Controls.Add(this.label2);
            this.pnlinforBN.Controls.Add(this.lblJob);
            this.pnlinforBN.Controls.Add(this.lblCmnd);
            this.pnlinforBN.Controls.Add(this.lblPhone);
            this.pnlinforBN.Controls.Add(this.lblAddress);
            this.pnlinforBN.Controls.Add(this.lblBirthDay);
            this.pnlinforBN.Controls.Add(this.lblSex);
            this.pnlinforBN.Controls.Add(this.lblLastName);
            this.pnlinforBN.Controls.Add(this.lblFirstName);
            this.pnlinforBN.Controls.Add(this.lblThongTin);
            this.pnlinforBN.Location = new System.Drawing.Point(638, 61);
            this.pnlinforBN.Name = "pnlinforBN";
            this.pnlinforBN.Size = new System.Drawing.Size(606, 550);
            this.pnlinforBN.TabIndex = 13;
            // 
            // txtidpeo
            // 
            this.txtidpeo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidpeo.Location = new System.Drawing.Point(169, 491);
            this.txtidpeo.Name = "txtidpeo";
            this.txtidpeo.ReadOnly = true;
            this.txtidpeo.Size = new System.Drawing.Size(388, 30);
            this.txtidpeo.TabIndex = 36;
            // 
            // txtidkhoa
            // 
            this.txtidkhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidkhoa.Location = new System.Drawing.Point(169, 435);
            this.txtidkhoa.Name = "txtidkhoa";
            this.txtidkhoa.Size = new System.Drawing.Size(388, 30);
            this.txtidkhoa.TabIndex = 35;
            // 
            // txtfirst
            // 
            this.txtfirst.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirst.Location = new System.Drawing.Point(169, 54);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(388, 30);
            this.txtfirst.TabIndex = 34;
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(169, 104);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(388, 30);
            this.txtLastname.TabIndex = 33;
            // 
            // txtCard
            // 
            this.txtCard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCard.Location = new System.Drawing.Point(169, 376);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(388, 30);
            this.txtCard.TabIndex = 29;
            // 
            // txtsdt
            // 
            this.txtsdt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdt.Location = new System.Drawing.Point(169, 321);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(388, 30);
            this.txtsdt.TabIndex = 28;
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(169, 263);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(388, 30);
            this.txtaddress.TabIndex = 27;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthday.Location = new System.Drawing.Point(169, 206);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(388, 30);
            this.txtBirthday.TabIndex = 26;
            // 
            // txtGioitinh
            // 
            this.txtGioitinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioitinh.Location = new System.Drawing.Point(169, 159);
            this.txtGioitinh.Name = "txtGioitinh";
            this.txtGioitinh.Size = new System.Drawing.Size(388, 30);
            this.txtGioitinh.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID People";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.Location = new System.Drawing.Point(18, 438);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(52, 22);
            this.lblJob.TabIndex = 8;
            this.lblJob.Text = "Khoa";
            // 
            // lblCmnd
            // 
            this.lblCmnd.AutoSize = true;
            this.lblCmnd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmnd.Location = new System.Drawing.Point(18, 379);
            this.lblCmnd.Name = "lblCmnd";
            this.lblCmnd.Size = new System.Drawing.Size(127, 22);
            this.lblCmnd.TabIndex = 7;
            this.lblCmnd.Text = "CMND/CCCD";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(18, 324);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(114, 22);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Số điện thoại";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(18, 266);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(77, 22);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Địa Chỉ ";
            // 
            // lblBirthDay
            // 
            this.lblBirthDay.AutoSize = true;
            this.lblBirthDay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDay.Location = new System.Drawing.Point(18, 209);
            this.lblBirthDay.Name = "lblBirthDay";
            this.lblBirthDay.Size = new System.Drawing.Size(96, 22);
            this.lblBirthDay.TabIndex = 4;
            this.lblBirthDay.Text = "Ngày Sinh ";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(18, 162);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(86, 22);
            this.lblSex.TabIndex = 3;
            this.lblSex.Text = "Giới tính ";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(18, 107);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(99, 22);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name ";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(18, 57);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(103, 22);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name ";
            // 
            // lblThongTin
            // 
            this.lblThongTin.AutoSize = true;
            this.lblThongTin.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTin.Location = new System.Drawing.Point(223, 11);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(174, 23);
            this.lblThongTin.TabIndex = 0;
            this.lblThongTin.Text = "Thông tin nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 26);
            this.label1.TabIndex = 22;
            this.label1.Text = "Danh sách nhân viên";
            // 
            // FrmTatCaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1268, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.pnlinforBN);
            this.Controls.Add(this.dgvInfoEmployee);
            this.Name = "FrmTatCaNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.FrmTatCaNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoEmployee)).EndInit();
            this.pnlinforBN.ResumeLayout(false);
            this.pnlinforBN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInfoEmployee;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel pnlinforBN;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblCmnd;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBirthDay;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.TextBox txtGioitinh;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private System.Windows.Forms.TextBox txtidkhoa;
        private System.Windows.Forms.TextBox txtfirst;
        private System.Windows.Forms.TextBox txtidpeo;
    }
}