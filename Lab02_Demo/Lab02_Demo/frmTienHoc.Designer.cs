
namespace Lab02_Demo
{
    partial class frmTrungTam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrungTam));
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaHV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkTinHocA = new System.Windows.Forms.CheckBox();
            this.chkTinHocB = new System.Windows.Forms.CheckBox();
            this.chkTiengAnhA = new System.Windows.Forms.CheckBox();
            this.chkTiengAnhB = new System.Windows.Forms.CheckBox();
            this.lblTHA = new System.Windows.Forms.Label();
            this.lblTHB = new System.Windows.Forms.Label();
            this.lblTAA = new System.Windows.Forms.Label();
            this.lblTAB = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtpNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "TÍNH TIỀN HỌC TRUNG TÂM";
            // 
            // cboMaHV
            // 
            this.cboMaHV.FormattingEnabled = true;
            this.cboMaHV.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004",
            "005"});
            this.cboMaHV.Location = new System.Drawing.Point(106, 60);
            this.cboMaHV.Name = "cboMaHV";
            this.cboMaHV.Size = new System.Drawing.Size(121, 21);
            this.cboMaHV.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Học Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới Tính";
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNam.Location = new System.Drawing.Point(304, 63);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(52, 19);
            this.rdNam.TabIndex = 1;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNu.Location = new System.Drawing.Point(362, 63);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(41, 19);
            this.rdNu.TabIndex = 2;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Họ Tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(106, 98);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(312, 20);
            this.txtHoTen.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày Đăng Ký";
            // 
            // chkTinHocA
            // 
            this.chkTinHocA.AutoSize = true;
            this.chkTinHocA.Location = new System.Drawing.Point(67, 179);
            this.chkTinHocA.Name = "chkTinHocA";
            this.chkTinHocA.Size = new System.Drawing.Size(72, 17);
            this.chkTinHocA.TabIndex = 5;
            this.chkTinHocA.Text = "Tin học A";
            this.chkTinHocA.UseVisualStyleBackColor = true;
            // 
            // chkTinHocB
            // 
            this.chkTinHocB.AutoSize = true;
            this.chkTinHocB.Location = new System.Drawing.Point(67, 220);
            this.chkTinHocB.Name = "chkTinHocB";
            this.chkTinHocB.Size = new System.Drawing.Size(72, 17);
            this.chkTinHocB.TabIndex = 6;
            this.chkTinHocB.Text = "Tin học B";
            this.chkTinHocB.UseVisualStyleBackColor = true;
            // 
            // chkTiengAnhA
            // 
            this.chkTiengAnhA.AutoSize = true;
            this.chkTiengAnhA.Location = new System.Drawing.Point(67, 257);
            this.chkTiengAnhA.Name = "chkTiengAnhA";
            this.chkTiengAnhA.Size = new System.Drawing.Size(85, 17);
            this.chkTiengAnhA.TabIndex = 7;
            this.chkTiengAnhA.Text = "Tiếng Anh A";
            this.chkTiengAnhA.UseVisualStyleBackColor = true;
            // 
            // chkTiengAnhB
            // 
            this.chkTiengAnhB.AutoSize = true;
            this.chkTiengAnhB.Location = new System.Drawing.Point(67, 297);
            this.chkTiengAnhB.Name = "chkTiengAnhB";
            this.chkTiengAnhB.Size = new System.Drawing.Size(85, 17);
            this.chkTiengAnhB.TabIndex = 8;
            this.chkTiengAnhB.Text = "Tiếng Anh B";
            this.chkTiengAnhB.UseVisualStyleBackColor = true;
            // 
            // lblTHA
            // 
            this.lblTHA.AutoSize = true;
            this.lblTHA.Location = new System.Drawing.Point(277, 183);
            this.lblTHA.Name = "lblTHA";
            this.lblTHA.Size = new System.Drawing.Size(74, 13);
            this.lblTHA.TabIndex = 2;
            this.lblTHA.Text = "300.000 đồng";
            // 
            // lblTHB
            // 
            this.lblTHB.AutoSize = true;
            this.lblTHB.Location = new System.Drawing.Point(277, 220);
            this.lblTHB.Name = "lblTHB";
            this.lblTHB.Size = new System.Drawing.Size(74, 13);
            this.lblTHB.TabIndex = 2;
            this.lblTHB.Text = "500.000 đồng";
            // 
            // lblTAA
            // 
            this.lblTAA.AutoSize = true;
            this.lblTAA.Location = new System.Drawing.Point(277, 257);
            this.lblTAA.Name = "lblTAA";
            this.lblTAA.Size = new System.Drawing.Size(74, 13);
            this.lblTAA.TabIndex = 2;
            this.lblTAA.Text = "400.000 đồng";
            // 
            // lblTAB
            // 
            this.lblTAB.AutoSize = true;
            this.lblTAB.Location = new System.Drawing.Point(277, 298);
            this.lblTAB.Name = "lblTAB";
            this.lblTAB.Size = new System.Drawing.Size(74, 13);
            this.lblTAB.TabIndex = 2;
            this.lblTAB.Text = "600.000 đồng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(227, 318);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(124, 31);
            this.txtTongTien.TabIndex = 11;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.ForeColor = System.Drawing.Color.Blue;
            this.btnTinhTien.Location = new System.Drawing.Point(37, 367);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(102, 38);
            this.btnTinhTien.TabIndex = 11;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Crimson;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(145, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(178, 50);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Blue;
            this.btnExit.Location = new System.Drawing.Point(329, 365);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 38);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtpNgayDangKy
            // 
            this.dtpNgayDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDangKy.Location = new System.Drawing.Point(106, 124);
            this.dtpNgayDangKy.Name = "dtpNgayDangKy";
            this.dtpNgayDangKy.Size = new System.Drawing.Size(312, 21);
            this.dtpNgayDangKy.TabIndex = 4;
            // 
            // frmTrungTam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 415);
            this.Controls.Add(this.dtpNgayDangKy);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTAB);
            this.Controls.Add(this.lblTAA);
            this.Controls.Add(this.lblTHB);
            this.Controls.Add(this.lblTHA);
            this.Controls.Add(this.chkTiengAnhB);
            this.Controls.Add(this.chkTiengAnhA);
            this.Controls.Add(this.chkTinHocB);
            this.Controls.Add(this.chkTinHocA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMaHV);
            this.Controls.Add(this.label1);
            this.Name = "frmTrungTam";
            this.Text = "Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaHV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkTinHocA;
        private System.Windows.Forms.CheckBox chkTinHocB;
        private System.Windows.Forms.CheckBox chkTiengAnhA;
        private System.Windows.Forms.CheckBox chkTiengAnhB;
        private System.Windows.Forms.Label lblTHA;
        private System.Windows.Forms.Label lblTHB;
        private System.Windows.Forms.Label lblTAA;
        private System.Windows.Forms.Label lblTAB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dtpNgayDangKy;
    }
}

