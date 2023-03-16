
namespace BaiTapThietKeForm
{
    partial class frmBai3
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
            this.lblTuMoi = new System.Windows.Forms.Label();
            this.txtTuMoi = new System.Windows.Forms.TextBox();
            this.lbNghiaAnh = new System.Windows.Forms.Label();
            this.txtNghiaAnh = new System.Windows.Forms.TextBox();
            this.btnThemTuMoi = new System.Windows.Forms.Button();
            this.lblDSTuMoi = new System.Windows.Forms.Label();
            this.lblNghiaCuaTu = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtHienThiNghia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTuMoi
            // 
            this.lblTuMoi.AutoSize = true;
            this.lblTuMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuMoi.Location = new System.Drawing.Point(52, 37);
            this.lblTuMoi.Name = "lblTuMoi";
            this.lblTuMoi.Size = new System.Drawing.Size(51, 15);
            this.lblTuMoi.TabIndex = 0;
            this.lblTuMoi.Text = "Từ mới: ";
            // 
            // txtTuMoi
            // 
            this.txtTuMoi.Location = new System.Drawing.Point(109, 37);
            this.txtTuMoi.Name = "txtTuMoi";
            this.txtTuMoi.Size = new System.Drawing.Size(212, 20);
            this.txtTuMoi.TabIndex = 0;
            // 
            // lbNghiaAnh
            // 
            this.lbNghiaAnh.AutoSize = true;
            this.lbNghiaAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNghiaAnh.Location = new System.Drawing.Point(14, 68);
            this.lbNghiaAnh.Name = "lbNghiaAnh";
            this.lbNghiaAnh.Size = new System.Drawing.Size(89, 15);
            this.lbNghiaAnh.TabIndex = 0;
            this.lbNghiaAnh.Text = "Nghĩa a của từ:";
            // 
            // txtNghiaAnh
            // 
            this.txtNghiaAnh.Location = new System.Drawing.Point(109, 63);
            this.txtNghiaAnh.Name = "txtNghiaAnh";
            this.txtNghiaAnh.Size = new System.Drawing.Size(212, 20);
            this.txtNghiaAnh.TabIndex = 1;
            this.txtNghiaAnh.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnThemTuMoi
            // 
            this.btnThemTuMoi.BackColor = System.Drawing.SystemColors.Window;
            this.btnThemTuMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTuMoi.ForeColor = System.Drawing.Color.Black;
            this.btnThemTuMoi.Location = new System.Drawing.Point(165, 89);
            this.btnThemTuMoi.Name = "btnThemTuMoi";
            this.btnThemTuMoi.Size = new System.Drawing.Size(100, 26);
            this.btnThemTuMoi.TabIndex = 2;
            this.btnThemTuMoi.Text = "Thêm từ mới";
            this.btnThemTuMoi.UseVisualStyleBackColor = false;
            this.btnThemTuMoi.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDSTuMoi
            // 
            this.lblDSTuMoi.AutoSize = true;
            this.lblDSTuMoi.Location = new System.Drawing.Point(143, 144);
            this.lblDSTuMoi.Name = "lblDSTuMoi";
            this.lblDSTuMoi.Size = new System.Drawing.Size(111, 13);
            this.lblDSTuMoi.TabIndex = 6;
            this.lblDSTuMoi.Text = "DANH SÁCH TỪ MỚI";
            // 
            // lblNghiaCuaTu
            // 
            this.lblNghiaCuaTu.AutoSize = true;
            this.lblNghiaCuaTu.Location = new System.Drawing.Point(482, 144);
            this.lblNghiaCuaTu.Name = "lblNghiaCuaTu";
            this.lblNghiaCuaTu.Size = new System.Drawing.Size(86, 13);
            this.lblNghiaCuaTu.TabIndex = 3;
            this.lblNghiaCuaTu.Text = "NGHĨA CỦA TỪ";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(90, 169);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 164);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtHienThiNghia
            // 
            this.txtHienThiNghia.Location = new System.Drawing.Point(410, 169);
            this.txtHienThiNghia.Multiline = true;
            this.txtHienThiNghia.Name = "txtHienThiNghia";
            this.txtHienThiNghia.Size = new System.Drawing.Size(206, 164);
            this.txtHienThiNghia.TabIndex = 5;
            this.txtHienThiNghia.TextChanged += new System.EventHandler(this.txtHienThiNghia_TextChanged);
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 360);
            this.Controls.Add(this.txtHienThiNghia);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblNghiaCuaTu);
            this.Controls.Add(this.lblDSTuMoi);
            this.Controls.Add(this.btnThemTuMoi);
            this.Controls.Add(this.txtNghiaAnh);
            this.Controls.Add(this.txtTuMoi);
            this.Controls.Add(this.lbNghiaAnh);
            this.Controls.Add(this.lblTuMoi);
            this.Name = "frmBai3";
            this.Text = "Từ điển Anh - Việt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTuMoi;
        private System.Windows.Forms.TextBox txtTuMoi;
        private System.Windows.Forms.Label lbNghiaAnh;
        private System.Windows.Forms.TextBox txtNghiaAnh;
        private System.Windows.Forms.Button btnThemTuMoi;
        private System.Windows.Forms.Label lblDSTuMoi;
        private System.Windows.Forms.Label lblNghiaCuaTu;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtHienThiNghia;
    }
}