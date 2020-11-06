namespace GroupProject.GUI
{
    partial class frm_StaffManagement
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
            this.txt_SearchStaff = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gv_Staff = new System.Windows.Forms.DataGridView();
            this.btn_AddStaff = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Staff)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_SearchStaff
            // 
            this.txt_SearchStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchStaff.Location = new System.Drawing.Point(145, 28);
            this.txt_SearchStaff.Name = "txt_SearchStaff";
            this.txt_SearchStaff.Size = new System.Drawing.Size(408, 26);
            this.txt_SearchStaff.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(559, 28);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(138, 26);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Tìm";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gv_Staff);
            this.panel1.Location = new System.Drawing.Point(30, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 307);
            this.panel1.TabIndex = 2;
            // 
            // gv_Staff
            // 
            this.gv_Staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Staff.Location = new System.Drawing.Point(0, 0);
            this.gv_Staff.Name = "gv_Staff";
            this.gv_Staff.Size = new System.Drawing.Size(740, 304);
            this.gv_Staff.TabIndex = 0;
            // 
            // btn_AddStaff
            // 
            this.btn_AddStaff.Location = new System.Drawing.Point(683, 407);
            this.btn_AddStaff.Name = "btn_AddStaff";
            this.btn_AddStaff.Size = new System.Drawing.Size(87, 31);
            this.btn_AddStaff.TabIndex = 3;
            this.btn_AddStaff.Text = "Thêm";
            this.btn_AddStaff.UseVisualStyleBackColor = true;
            // 
            // frm_StaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_AddStaff);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_SearchStaff);
            this.Name = "frm_StaffManagement";
            this.Text = "frm_StaffManagement";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Staff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SearchStaff;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gv_Staff;
        private System.Windows.Forms.Button btn_AddStaff;
    }
}