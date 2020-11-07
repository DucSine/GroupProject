namespace GroupProject.GUI
{
    partial class frm_BillImport
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
            this.dgv_BillImport = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_UnitIP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dt_DayIP = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_TotalamountIP = new System.Windows.Forms.TextBox();
            this.txt_AmountIP = new System.Windows.Forms.TextBox();
            this.btn_XoaIP = new System.Windows.Forms.Button();
            this.btn_SuaIP = new System.Windows.Forms.Button();
            this.btn_ThemIP = new System.Windows.Forms.Button();
            this.txt_CostIP = new System.Windows.Forms.TextBox();
            this.txt_ItemsIP = new System.Windows.Forms.TextBox();
            this.txt_IDIP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BillImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_BillImport
            // 
            this.dgv_BillImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BillImport.Location = new System.Drawing.Point(0, 0);
            this.dgv_BillImport.Name = "dgv_BillImport";
            this.dgv_BillImport.Size = new System.Drawing.Size(519, 382);
            this.dgv_BillImport.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(421, 380);
            this.dataGridView2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_BillImport);
            this.panel2.Location = new System.Drawing.Point(278, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(519, 380);
            this.panel2.TabIndex = 1;
            // 
            // txt_UnitIP
            // 
            this.txt_UnitIP.Location = new System.Drawing.Point(109, 298);
            this.txt_UnitIP.Name = "txt_UnitIP";
            this.txt_UnitIP.Size = new System.Drawing.Size(135, 20);
            this.txt_UnitIP.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Đơn vị";
            // 
            // dt_DayIP
            // 
            this.dt_DayIP.CustomFormat = "dd/MM/yyyy";
            this.dt_DayIP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_DayIP.Location = new System.Drawing.Point(109, 159);
            this.dt_DayIP.Name = "dt_DayIP";
            this.dt_DayIP.Size = new System.Drawing.Size(135, 20);
            this.dt_DayIP.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Ngày nhập";
            // 
            // txt_TotalamountIP
            // 
            this.txt_TotalamountIP.Location = new System.Drawing.Point(109, 341);
            this.txt_TotalamountIP.Name = "txt_TotalamountIP";
            this.txt_TotalamountIP.Size = new System.Drawing.Size(135, 20);
            this.txt_TotalamountIP.TabIndex = 11;
            // 
            // txt_AmountIP
            // 
            this.txt_AmountIP.Location = new System.Drawing.Point(109, 256);
            this.txt_AmountIP.Name = "txt_AmountIP";
            this.txt_AmountIP.Size = new System.Drawing.Size(135, 20);
            this.txt_AmountIP.TabIndex = 10;
            // 
            // btn_XoaIP
            // 
            this.btn_XoaIP.Location = new System.Drawing.Point(368, 12);
            this.btn_XoaIP.Name = "btn_XoaIP";
            this.btn_XoaIP.Size = new System.Drawing.Size(75, 23);
            this.btn_XoaIP.TabIndex = 2;
            this.btn_XoaIP.Text = "Xóa";
            this.btn_XoaIP.UseVisualStyleBackColor = true;
            // 
            // btn_SuaIP
            // 
            this.btn_SuaIP.Location = new System.Drawing.Point(197, 12);
            this.btn_SuaIP.Name = "btn_SuaIP";
            this.btn_SuaIP.Size = new System.Drawing.Size(75, 23);
            this.btn_SuaIP.TabIndex = 1;
            this.btn_SuaIP.Text = "Sửa";
            this.btn_SuaIP.UseVisualStyleBackColor = true;
            // 
            // btn_ThemIP
            // 
            this.btn_ThemIP.Location = new System.Drawing.Point(24, 12);
            this.btn_ThemIP.Name = "btn_ThemIP";
            this.btn_ThemIP.Size = new System.Drawing.Size(75, 23);
            this.btn_ThemIP.TabIndex = 0;
            this.btn_ThemIP.Text = "Thêm";
            this.btn_ThemIP.UseVisualStyleBackColor = true;
            // 
            // txt_CostIP
            // 
            this.txt_CostIP.Location = new System.Drawing.Point(109, 210);
            this.txt_CostIP.Name = "txt_CostIP";
            this.txt_CostIP.Size = new System.Drawing.Size(135, 20);
            this.txt_CostIP.TabIndex = 9;
            // 
            // txt_ItemsIP
            // 
            this.txt_ItemsIP.Location = new System.Drawing.Point(109, 109);
            this.txt_ItemsIP.Name = "txt_ItemsIP";
            this.txt_ItemsIP.Size = new System.Drawing.Size(135, 20);
            this.txt_ItemsIP.TabIndex = 8;
            // 
            // txt_IDIP
            // 
            this.txt_IDIP.Location = new System.Drawing.Point(109, 65);
            this.txt_IDIP.Name = "txt_IDIP";
            this.txt_IDIP.Size = new System.Drawing.Size(135, 20);
            this.txt_IDIP.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tổng tiền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Đơn giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Số lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tên Hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "ID";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Location = new System.Drawing.Point(380, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(420, 380);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_XoaIP);
            this.panel5.Controls.Add(this.btn_SuaIP);
            this.panel5.Controls.Add(this.btn_ThemIP);
            this.panel5.Location = new System.Drawing.Point(300, 11);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(488, 46);
            this.panel5.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_UnitIP);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.dt_DayIP);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txt_TotalamountIP);
            this.panel3.Controls.Add(this.txt_AmountIP);
            this.panel3.Controls.Add(this.txt_CostIP);
            this.panel3.Controls.Add(this.txt_ItemsIP);
            this.panel3.Controls.Add(this.txt_IDIP);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 427);
            this.panel3.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 448);
            this.panel1.TabIndex = 1;
            // 
            // frm_BillImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frm_BillImport";
            this.Text = "Bill Import";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BillImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_BillImport;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_UnitIP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dt_DayIP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_TotalamountIP;
        private System.Windows.Forms.TextBox txt_AmountIP;
        private System.Windows.Forms.Button btn_XoaIP;
        private System.Windows.Forms.Button btn_SuaIP;
        private System.Windows.Forms.Button btn_ThemIP;
        private System.Windows.Forms.TextBox txt_CostIP;
        private System.Windows.Forms.TextBox txt_ItemsIP;
        private System.Windows.Forms.TextBox txt_IDIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
    }
}