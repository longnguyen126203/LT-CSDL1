namespace Lab02_Demo
{
    partial class frmTimKiem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdMaGV = new System.Windows.Forms.RadioButton();
            this.rdHoTen = new System.Windows.Forms.RadioButton();
            this.rdSoDT = new System.Windows.Forms.RadioButton();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdSoDT);
            this.groupBox1.Controls.Add(this.rdHoTen);
            this.groupBox1.Controls.Add(this.rdMaGV);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm theo";
            // 
            // rdMaGV
            // 
            this.rdMaGV.AutoSize = true;
            this.rdMaGV.Checked = true;
            this.rdMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMaGV.Location = new System.Drawing.Point(19, 25);
            this.rdMaGV.Name = "rdMaGV";
            this.rdMaGV.Size = new System.Drawing.Size(69, 21);
            this.rdMaGV.TabIndex = 0;
            this.rdMaGV.TabStop = true;
            this.rdMaGV.Text = "Mã GV";
            this.rdMaGV.UseVisualStyleBackColor = true;
            // 
            // rdHoTen
            // 
            this.rdHoTen.AutoSize = true;
            this.rdHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHoTen.Location = new System.Drawing.Point(135, 25);
            this.rdHoTen.Name = "rdHoTen";
            this.rdHoTen.Size = new System.Drawing.Size(73, 21);
            this.rdHoTen.TabIndex = 0;
            this.rdHoTen.Text = "Họ Tên";
            this.rdHoTen.UseVisualStyleBackColor = true;
            // 
            // rdSoDT
            // 
            this.rdSoDT.AutoSize = true;
            this.rdSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSoDT.Location = new System.Drawing.Point(256, 27);
            this.rdSoDT.Name = "rdSoDT";
            this.rdSoDT.Size = new System.Drawing.Size(116, 21);
            this.rdSoDT.TabIndex = 0;
            this.rdSoDT.Text = "Số Điện Thoại";
            this.rdSoDT.UseVisualStyleBackColor = true;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(12, 125);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(59, 20);
            this.lblTimKiem.TabIndex = 1;
            this.lblTimKiem.Text = "Mã GV";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(147, 125);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(202, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(355, 125);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 158);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTimKiem";
            this.Text = "Tìm Kiếm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdSoDT;
        private System.Windows.Forms.RadioButton rdHoTen;
        private System.Windows.Forms.RadioButton rdMaGV;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnOK;
    }
}