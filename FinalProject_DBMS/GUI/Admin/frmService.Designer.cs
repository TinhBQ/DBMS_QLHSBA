namespace GUI.Admin
{
    partial class frmService
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
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpate = new System.Windows.Forms.Button();
            this.btnDetele = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDVName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDVID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDV
            // 
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Location = new System.Drawing.Point(25, 297);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.RowHeadersVisible = false;
            this.dgvDV.RowHeadersWidth = 82;
            this.dgvDV.RowTemplate.Height = 33;
            this.dgvDV.Size = new System.Drawing.Size(528, 281);
            this.dgvDV.TabIndex = 20;
            this.dgvDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDV_CellClick);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnExit.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(396, 704);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 46);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRefresh.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(25, 704);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(158, 46);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpate
            // 
            this.btnUpate.AutoSize = true;
            this.btnUpate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpate.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpate.ForeColor = System.Drawing.Color.White;
            this.btnUpate.Location = new System.Drawing.Point(396, 618);
            this.btnUpate.Name = "btnUpate";
            this.btnUpate.Size = new System.Drawing.Size(150, 46);
            this.btnUpate.TabIndex = 17;
            this.btnUpate.Text = "Update";
            this.btnUpate.UseVisualStyleBackColor = false;
            this.btnUpate.Click += new System.EventHandler(this.btnUpate_Click);
            // 
            // btnDetele
            // 
            this.btnDetele.AutoSize = true;
            this.btnDetele.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDetele.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetele.ForeColor = System.Drawing.Color.White;
            this.btnDetele.Location = new System.Drawing.Point(215, 618);
            this.btnDetele.Name = "btnDetele";
            this.btnDetele.Size = new System.Drawing.Size(158, 46);
            this.btnDetele.TabIndex = 16;
            this.btnDetele.Text = "Detele";
            this.btnDetele.UseVisualStyleBackColor = false;
            this.btnDetele.Click += new System.EventHandler(this.btnDetele_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdd.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(25, 618);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(158, 46);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDVName
            // 
            this.txtDVName.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDVName.Location = new System.Drawing.Point(311, 153);
            this.txtDVName.Name = "txtDVName";
            this.txtDVName.Size = new System.Drawing.Size(242, 40);
            this.txtDVName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(25, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên dịch vụ";
            // 
            // txtDVID
            // 
            this.txtDVID.Enabled = false;
            this.txtDVID.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDVID.Location = new System.Drawing.Point(311, 92);
            this.txtDVID.Name = "txtDVID";
            this.txtDVID.Size = new System.Drawing.Size(242, 40);
            this.txtDVID.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(25, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã dịch vụ";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(311, 219);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(242, 40);
            this.txtGia.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(25, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 33);
            this.label3.TabIndex = 21;
            this.label3.Text = "Giá dịch vụ";
            // 
            // txtTK
            // 
            this.txtTK.Font = new System.Drawing.Font("Roboto", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Location = new System.Drawing.Point(311, 29);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(242, 40);
            this.txtTK.TabIndex = 24;
            this.txtTK.TextChanged += new System.EventHandler(this.txtTK_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(25, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 33);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tìm kiếm";
            // 
            // frmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 790);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDV);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpate);
            this.Controls.Add(this.btnDetele);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDVName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDVID);
            this.Controls.Add(this.label1);
            this.Name = "frmService";
            this.Text = "frmService";
            this.Load += new System.EventHandler(this.frmService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpate;
        private System.Windows.Forms.Button btnDetele;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDVName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDVID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label label4;
    }
}