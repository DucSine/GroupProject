namespace GroupProject.GUI
{
    partial class frm_QLNguyenLieu
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
            this.label8 = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.dgv_NguyenLieu = new System.Windows.Forms.DataGridView();
            this.txt_Tìm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenNL = new System.Windows.Forms.TextBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaNL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TonKho = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NguyenLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(224, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 20);
            this.label8.TabIndex = 135;
            this.label8.Text = "QUẢN LÝ NGUYÊN LIỆU";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(478, 77);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(123, 20);
            this.txt_DonGia.TabIndex = 134;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(363, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 133;
            this.label7.Text = "Đơn giá";
            // 
            // dt_NgayNhap
            // 
            this.dt_NgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dt_NgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_NgayNhap.Location = new System.Drawing.Point(478, 124);
            this.dt_NgayNhap.Name = "dt_NgayNhap";
            this.dt_NgayNhap.Size = new System.Drawing.Size(123, 20);
            this.dt_NgayNhap.TabIndex = 132;
            // 
            // dgv_NguyenLieu
            // 
            this.dgv_NguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NguyenLieu.Location = new System.Drawing.Point(5, 310);
            this.dgv_NguyenLieu.Name = "dgv_NguyenLieu";
            this.dgv_NguyenLieu.Size = new System.Drawing.Size(661, 204);
            this.dgv_NguyenLieu.TabIndex = 131;
            // 
            // txt_Tìm
            // 
            this.txt_Tìm.Location = new System.Drawing.Point(515, 284);
            this.txt_Tìm.Name = "txt_Tìm";
            this.txt_Tìm.Size = new System.Drawing.Size(151, 20);
            this.txt_Tìm.TabIndex = 130;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(445, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 129;
            this.label3.Text = "Tìm kiếm";
            // 
            // txt_TenNL
            // 
            this.txt_TenNL.Location = new System.Drawing.Point(145, 124);
            this.txt_TenNL.Name = "txt_TenNL";
            this.txt_TenNL.Size = new System.Drawing.Size(123, 20);
            this.txt_TenNL.TabIndex = 128;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(145, 171);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(123, 20);
            this.txt_SoLuong.TabIndex = 127;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(235, 226);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 126;
            this.btn_Sua.Text = "Cập nhật";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(420, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 125;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(49, 226);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 124;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(363, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 123;
            this.label6.Text = "Ngày nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 122;
            this.label5.Text = "Mã nguyên liệu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 121;
            this.label4.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 120;
            this.label2.Text = "Tên nguyên liệu";
            // 
            // txt_MaNL
            // 
            this.txt_MaNL.Location = new System.Drawing.Point(145, 76);
            this.txt_MaNL.Name = "txt_MaNL";
            this.txt_MaNL.Size = new System.Drawing.Size(123, 20);
            this.txt_MaNL.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 118;
            // 
            // txt_TonKho
            // 
            this.txt_TonKho.Location = new System.Drawing.Point(478, 175);
            this.txt_TonKho.Name = "txt_TonKho";
            this.txt_TonKho.Size = new System.Drawing.Size(123, 20);
            this.txt_TonKho.TabIndex = 137;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(363, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 136;
            this.label9.Text = "Tồn kho";
            // 
            // frm_QLNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(672, 519);
            this.Controls.Add(this.txt_TonKho);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_DonGia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dt_NgayNhap);
            this.Controls.Add(this.dgv_NguyenLieu);
            this.Controls.Add(this.txt_Tìm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TenNL);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MaNL);
            this.Controls.Add(this.label1);
            this.Name = "frm_QLNguyenLieu";
            this.Text = "Quản Lý Nguyên Liệu";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NguyenLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_NgayNhap;
        private System.Windows.Forms.DataGridView dgv_NguyenLieu;
        private System.Windows.Forms.TextBox txt_Tìm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenNL;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaNL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TonKho;
        private System.Windows.Forms.Label label9;
    }
}