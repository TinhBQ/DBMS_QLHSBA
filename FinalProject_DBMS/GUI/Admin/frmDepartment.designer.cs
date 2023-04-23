namespace GUI.Admin
{
    partial class frmDepartment
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.reload_btn = new System.Windows.Forms.Button();
            this.luu_btn = new System.Windows.Forms.Button();
            this.Sua_btn = new System.Windows.Forms.Button();
            this.xoa_btn = new System.Windows.Forms.Button();
            this.them_btn = new System.Windows.Forms.Button();
            this.dgvDepartment = new System.Windows.Forms.DataGridView();
            this.findDep_txt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.createAt_txt = new System.Windows.Forms.TextBox();
            this.updateAt_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_dep_txt = new System.Windows.Forms.TextBox();
            this.ID_dep_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ID_Thuốc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.reload_btn);
            this.panel2.Controls.Add(this.luu_btn);
            this.panel2.Controls.Add(this.Sua_btn);
            this.panel2.Controls.Add(this.xoa_btn);
            this.panel2.Controls.Add(this.them_btn);
            this.panel2.Controls.Add(this.dgvDepartment);
            this.panel2.Controls.Add(this.findDep_txt);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(25, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1248, 551);
            this.panel2.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(455, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tìm kiếm theo tên:";
            // 
            // reload_btn
            // 
            this.reload_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reload_btn.Location = new System.Drawing.Point(1082, 25);
            this.reload_btn.Name = "reload_btn";
            this.reload_btn.Size = new System.Drawing.Size(121, 35);
            this.reload_btn.TabIndex = 10;
            this.reload_btn.Text = "Reload";
            this.reload_btn.UseVisualStyleBackColor = true;
            // 
            // luu_btn
            // 
            this.luu_btn.BackColor = System.Drawing.Color.Pink;
            this.luu_btn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luu_btn.Location = new System.Drawing.Point(259, 468);
            this.luu_btn.Name = "luu_btn";
            this.luu_btn.Size = new System.Drawing.Size(187, 52);
            this.luu_btn.TabIndex = 9;
            this.luu_btn.Text = "Lưu";
            this.luu_btn.UseVisualStyleBackColor = false;
            // 
            // Sua_btn
            // 
            this.Sua_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.Sua_btn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sua_btn.Location = new System.Drawing.Point(48, 468);
            this.Sua_btn.Name = "Sua_btn";
            this.Sua_btn.Size = new System.Drawing.Size(187, 52);
            this.Sua_btn.TabIndex = 8;
            this.Sua_btn.Text = "Sửa";
            this.Sua_btn.UseVisualStyleBackColor = false;
            this.Sua_btn.Click += new System.EventHandler(this.Sua_btn_Click);
            // 
            // xoa_btn
            // 
            this.xoa_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.xoa_btn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa_btn.Location = new System.Drawing.Point(259, 411);
            this.xoa_btn.Name = "xoa_btn";
            this.xoa_btn.Size = new System.Drawing.Size(187, 52);
            this.xoa_btn.TabIndex = 7;
            this.xoa_btn.Text = "Xóa";
            this.xoa_btn.UseVisualStyleBackColor = false;
            this.xoa_btn.Click += new System.EventHandler(this.xoa_btn_Click);
            // 
            // them_btn
            // 
            this.them_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.them_btn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them_btn.Location = new System.Drawing.Point(48, 411);
            this.them_btn.Name = "them_btn";
            this.them_btn.Size = new System.Drawing.Size(187, 52);
            this.them_btn.TabIndex = 6;
            this.them_btn.Text = "Thêm ";
            this.them_btn.UseVisualStyleBackColor = false;
            this.them_btn.Click += new System.EventHandler(this.them_btn_Click);
            // 
            // dgvDepartment
            // 
            this.dgvDepartment.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartment.Location = new System.Drawing.Point(505, 84);
            this.dgvDepartment.Name = "dgvDepartment";
            this.dgvDepartment.RowHeadersWidth = 62;
            this.dgvDepartment.RowTemplate.Height = 28;
            this.dgvDepartment.Size = new System.Drawing.Size(723, 435);
            this.dgvDepartment.TabIndex = 5;
            this.dgvDepartment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartment_CellClick);
            // 
            // findDep_txt
            // 
            this.findDep_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findDep_txt.Location = new System.Drawing.Point(661, 27);
            this.findDep_txt.Name = "findDep_txt";
            this.findDep_txt.Size = new System.Drawing.Size(345, 31);
            this.findDep_txt.TabIndex = 4;
            this.findDep_txt.TextChanged += new System.EventHandler(this.findDep_txt_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Menu;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.createAt_txt);
            this.panel3.Controls.Add(this.updateAt_txt);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.name_dep_txt);
            this.panel3.Controls.Add(this.ID_dep_txt);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.ID_Thuốc);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(19, 84);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel3.Size = new System.Drawing.Size(455, 296);
            this.panel3.TabIndex = 1;
            // 
            // createAt_txt
            // 
            this.createAt_txt.Enabled = false;
            this.createAt_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAt_txt.Location = new System.Drawing.Point(167, 173);
            this.createAt_txt.Name = "createAt_txt";
            this.createAt_txt.Size = new System.Drawing.Size(259, 27);
            this.createAt_txt.TabIndex = 14;
            // 
            // updateAt_txt
            // 
            this.updateAt_txt.Enabled = false;
            this.updateAt_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAt_txt.Location = new System.Drawing.Point(167, 228);
            this.updateAt_txt.Name = "updateAt_txt";
            this.updateAt_txt.Size = new System.Drawing.Size(259, 27);
            this.updateAt_txt.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Created At";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Updated At";
            // 
            // name_dep_txt
            // 
            this.name_dep_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_dep_txt.Location = new System.Drawing.Point(167, 120);
            this.name_dep_txt.Name = "name_dep_txt";
            this.name_dep_txt.Size = new System.Drawing.Size(259, 27);
            this.name_dep_txt.TabIndex = 10;
            // 
            // ID_dep_txt
            // 
            this.ID_dep_txt.Enabled = false;
            this.ID_dep_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_dep_txt.Location = new System.Drawing.Point(167, 67);
            this.ID_dep_txt.Name = "ID_dep_txt";
            this.ID_dep_txt.Size = new System.Drawing.Size(259, 27);
            this.ID_dep_txt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên phòng ban";
            // 
            // ID_Thuốc
            // 
            this.ID_Thuốc.AutoSize = true;
            this.ID_Thuốc.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Thuốc.Location = new System.Drawing.Point(13, 71);
            this.ID_Thuốc.Name = "ID_Thuốc";
            this.ID_Thuốc.Size = new System.Drawing.Size(104, 18);
            this.ID_Thuốc.TabIndex = 1;
            this.ID_Thuốc.Text = "Mã phòng ban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "THÔNG TIN PHÒNG BAN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin phòng ban";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(397, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(430, 48);
            this.label6.TabIndex = 6;
            this.label6.Text = "QUẢN LÝ PHÒNG BAN";
            // 
            // frmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1283, 630);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Name = "frmDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDepartmemt";
            this.Load += new System.EventHandler(this.frmDepartment_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button luu_btn;
        private System.Windows.Forms.Button Sua_btn;
        private System.Windows.Forms.Button xoa_btn;
        private System.Windows.Forms.Button them_btn;
        private System.Windows.Forms.DataGridView dgvDepartment;
        private System.Windows.Forms.TextBox findDep_txt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox name_dep_txt;
        private System.Windows.Forms.TextBox ID_dep_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ID_Thuốc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button reload_btn;
        private System.Windows.Forms.TextBox createAt_txt;
        private System.Windows.Forms.TextBox updateAt_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

