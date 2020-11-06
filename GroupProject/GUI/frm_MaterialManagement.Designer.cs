namespace GroupProject.GUI
{
    partial class frm_MaterialManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_boxKindOfMaterial = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_AddMaterial = new System.Windows.Forms.Button();
            this.gv_Material = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Material)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_AddMaterial);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cb_boxKindOfMaterial);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 392);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại Nguyên Liệu:";
            // 
            // cb_boxKindOfMaterial
            // 
            this.cb_boxKindOfMaterial.FormattingEnabled = true;
            this.cb_boxKindOfMaterial.Location = new System.Drawing.Point(238, 21);
            this.cb_boxKindOfMaterial.Name = "cb_boxKindOfMaterial";
            this.cb_boxKindOfMaterial.Size = new System.Drawing.Size(359, 21);
            this.cb_boxKindOfMaterial.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gv_Material);
            this.panel2.Location = new System.Drawing.Point(24, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 261);
            this.panel2.TabIndex = 5;
            // 
            // btn_AddMaterial
            // 
            this.btn_AddMaterial.Location = new System.Drawing.Point(694, 340);
            this.btn_AddMaterial.Name = "btn_AddMaterial";
            this.btn_AddMaterial.Size = new System.Drawing.Size(93, 33);
            this.btn_AddMaterial.TabIndex = 6;
            this.btn_AddMaterial.Text = "Nhập hàng";
            this.btn_AddMaterial.UseVisualStyleBackColor = true;
            // 
            // gv_Material
            // 
            this.gv_Material.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Material.Location = new System.Drawing.Point(0, 4);
            this.gv_Material.Name = "gv_Material";
            this.gv_Material.Size = new System.Drawing.Size(760, 257);
            this.gv_Material.TabIndex = 0;
            // 
            // frm_MaterialManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 417);
            this.Controls.Add(this.panel1);
            this.Name = "frm_MaterialManagement";
            this.Text = "frm_MaterialManagement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Material)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_AddMaterial;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gv_Material;
        private System.Windows.Forms.ComboBox cb_boxKindOfMaterial;
        private System.Windows.Forms.Label label2;
    }
}