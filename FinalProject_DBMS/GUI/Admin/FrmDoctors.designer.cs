
namespace GUI.Admin
{
    partial class FrmDoctors
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
            this.dgvInforDoctor = new System.Windows.Forms.DataGridView();
            this.pnlinforBN = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtidkhoa = new System.Windows.Forms.TextBox();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.txtGioitinh = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblCmnd = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBirthDay = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforDoctor)).BeginInit();
            this.pnlinforBN.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInforDoctor
            // 
            this.dgvInforDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInforDoctor.Location = new System.Drawing.Point(12, 74);
            this.dgvInforDoctor.Name = "dgvInforDoctor";
            this.dgvInforDoctor.RowHeadersWidth = 51;
            this.dgvInforDoctor.RowTemplate.Height = 24;
            this.dgvInforDoctor.Size = new System.Drawing.Size(660, 572);
            this.dgvInforDoctor.TabIndex = 1;
            this.dgvInforDoctor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInforDoctor_CellContentClick);
            // 
            // pnlinforBN
            // 
            this.pnlinforBN.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlinforBN.Controls.Add(this.label2);
            this.pnlinforBN.Controls.Add(this.txtid);
            this.pnlinforBN.Controls.Add(this.txtidkhoa);
            this.pnlinforBN.Controls.Add(this.txtCard);
            this.pnlinforBN.Controls.Add(this.txtphone);
            this.pnlinforBN.Controls.Add(this.txtaddress);
            this.pnlinforBN.Controls.Add(this.txtBirthday);
            this.pnlinforBN.Controls.Add(this.txtGioitinh);
            this.pnlinforBN.Controls.Add(this.txtLastname);
            this.pnlinforBN.Controls.Add(this.txtFirstName);
            this.pnlinforBN.Controls.Add(this.lblJob);
            this.pnlinforBN.Controls.Add(this.lblCmnd);
            this.pnlinforBN.Controls.Add(this.lblPhone);
            this.pnlinforBN.Controls.Add(this.lblAddress);
            this.pnlinforBN.Controls.Add(this.lblBirthDay);
            this.pnlinforBN.Controls.Add(this.lblSex);
            this.pnlinforBN.Controls.Add(this.lblLastName);
            this.pnlinforBN.Controls.Add(this.lblFirstName);
            this.pnlinforBN.Controls.Add(this.lblThongTin);
            this.pnlinforBN.Location = new System.Drawing.Point(692, 74);
            this.pnlinforBN.Name = "pnlinforBN";
            this.pnlinforBN.Size = new System.Drawing.Size(606, 520);
            this.pnlinforBN.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID Doctor";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(156, 475);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(391, 30);
            this.txtid.TabIndex = 19;
            // 
            // txtidkhoa
            // 
            this.txtidkhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidkhoa.Location = new System.Drawing.Point(156, 418);
            this.txtidkhoa.Name = "txtidkhoa";
            this.txtidkhoa.Size = new System.Drawing.Size(391, 30);
            this.txtidkhoa.TabIndex = 18;
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
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.Location = new System.Drawing.Point(18, 421);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(77, 22);
            this.lblJob.TabIndex = 8;
            this.lblJob.Text = "ID Khoa";
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
            this.lblThongTin.Location = new System.Drawing.Point(241, 11);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(142, 23);
            this.lblThongTin.TabIndex = 0;
            this.lblThongTin.Text = "Thông tin bác sĩ";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1160, 614);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 32);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(1018, 614);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 32);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(879, 614);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 32);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(745, 614);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 32);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Danh sách bác sĩ";
            // 
            // FrmDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1323, 658);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.pnlinforBN);
            this.Controls.Add(this.dgvInforDoctor);
            this.Name = "FrmDoctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bác sĩ";
            this.Load += new System.EventHandler(this.FrmDoctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforDoctor)).EndInit();
            this.pnlinforBN.ResumeLayout(false);
            this.pnlinforBN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInforDoctor;
        private System.Windows.Forms.Panel pnlinforBN;
        private System.Windows.Forms.TextBox txtidkhoa;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.TextBox txtGioitinh;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblCmnd;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBirthDay;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
    }
}