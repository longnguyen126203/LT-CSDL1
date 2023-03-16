namespace BaiTapThietKeForm
{
    partial class frmBai4
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblNhapSoCanTim = new System.Windows.Forms.Label();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.btnTimSo = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(66, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(177, 199);
            this.listBox1.TabIndex = 0;
            // 
            // lblNhapSoCanTim
            // 
            this.lblNhapSoCanTim.AutoSize = true;
            this.lblNhapSoCanTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapSoCanTim.Location = new System.Drawing.Point(430, 80);
            this.lblNhapSoCanTim.Name = "lblNhapSoCanTim";
            this.lblNhapSoCanTim.Size = new System.Drawing.Size(114, 17);
            this.lblNhapSoCanTim.TabIndex = 1;
            this.lblNhapSoCanTim.Text = "Nhập số cần tìm:";
            this.lblNhapSoCanTim.Click += new System.EventHandler(this.lblNhapSoCanTim_Click);
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(546, 80);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(100, 20);
            this.txtSo.TabIndex = 2;
            // 
            // btnTimSo
            // 
            this.btnTimSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimSo.Location = new System.Drawing.Point(546, 121);
            this.btnTimSo.Name = "btnTimSo";
            this.btnTimSo.Size = new System.Drawing.Size(100, 25);
            this.btnTimSo.TabIndex = 3;
            this.btnTimSo.Text = "Tìm số";
            this.btnTimSo.UseVisualStyleBackColor = true;
            this.btnTimSo.Click += new System.EventHandler(this.btnTimSo_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(496, 220);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(76, 20);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Kết quả:";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.ForeColor = System.Drawing.Color.Red;
            this.lblKetQua.Location = new System.Drawing.Point(570, 220);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(14, 20);
            this.lblKetQua.TabIndex = 4;
            this.lblKetQua.Text = ".";
            // 
            // frmBai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnTimSo);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.lblNhapSoCanTim);
            this.Controls.Add(this.listBox1);
            this.Name = "frmBai4";
            this.Text = "Tìm số trong danh sách";
            this.Load += new System.EventHandler(this.frmBai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblNhapSoCanTim;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Button btnTimSo;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblKetQua;
    }
}