namespace BaiTapWindowForm
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
            this.lblSoA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTongAB = new System.Windows.Forms.RadioButton();
            this.rdbTong1D9 = new System.Windows.Forms.RadioButton();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.lblKQ = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSoA
            // 
            this.lblSoA.AutoSize = true;
            this.lblSoA.Location = new System.Drawing.Point(77, 39);
            this.lblSoA.Name = "lblSoA";
            this.lblSoA.Size = new System.Drawing.Size(41, 13);
            this.lblSoA.TabIndex = 0;
            this.lblSoA.Text = "Số a = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số b =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số n =";
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(136, 39);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(144, 20);
            this.txtSoA.TabIndex = 1;
            this.txtSoA.Text = "0";
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(136, 71);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(144, 20);
            this.txtSoB.TabIndex = 1;
            this.txtSoB.Text = "0";
            // 
            // txtSoN
            // 
            this.txtSoN.Location = new System.Drawing.Point(136, 104);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(144, 20);
            this.txtSoN.TabIndex = 1;
            this.txtSoN.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTong1D9);
            this.groupBox1.Controls.Add(this.rdbTongAB);
            this.groupBox1.Location = new System.Drawing.Point(80, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán";
            // 
            // rdbTongAB
            // 
            this.rdbTongAB.AutoSize = true;
            this.rdbTongAB.Checked = true;
            this.rdbTongAB.Location = new System.Drawing.Point(44, 19);
            this.rdbTongAB.Name = "rdbTongAB";
            this.rdbTongAB.Size = new System.Drawing.Size(114, 17);
            this.rdbTongAB.TabIndex = 3;
            this.rdbTongAB.TabStop = true;
            this.rdbTongAB.Text = "Tính tổng của a, b";
            this.rdbTongAB.UseVisualStyleBackColor = true;
            // 
            // rdbTong1D9
            // 
            this.rdbTong1D9.AutoSize = true;
            this.rdbTong1D9.Location = new System.Drawing.Point(44, 58);
            this.rdbTong1D9.Name = "rdbTong1D9";
            this.rdbTong1D9.Size = new System.Drawing.Size(124, 17);
            this.rdbTong1D9.TabIndex = 3;
            this.rdbTong1D9.Text = "Tính tổng từ 1 đến n";
            this.rdbTong1D9.UseVisualStyleBackColor = true;
            // 
            // btnKetQua
            // 
            this.btnKetQua.Location = new System.Drawing.Point(145, 265);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(75, 23);
            this.btnKetQua.TabIndex = 3;
            this.btnKetQua.Text = "Xem kết quả";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.Location = new System.Drawing.Point(77, 340);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(95, 20);
            this.lblKQ.TabIndex = 4;
            this.lblKQ.Text = "Kết quả là:";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(192, 345);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(10, 13);
            this.lblKetQua.TabIndex = 4;
            this.lblKetQua.Text = ".";
            this.lblKetQua.Click += new System.EventHandler(this.lblKetQua_Click);
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSoA);
            this.Name = "frmBai3";
            this.Text = "Bài 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTong1D9;
        private System.Windows.Forms.RadioButton rdbTongAB;
        private System.Windows.Forms.Button btnKetQua;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Label lblKetQua;
    }
}