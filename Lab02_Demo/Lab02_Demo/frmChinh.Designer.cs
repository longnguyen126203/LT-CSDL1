namespace Lab02_Demo
{
    partial class frmChinh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nguyễnHoàngBảoLongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmividu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.víDụ2BàiTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nguyễnHoàngBảoLongToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nguyễnHoàngBảoLongToolStripMenuItem
            // 
            this.nguyễnHoàngBảoLongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmividu1,
            this.víDụ2BàiTậpToolStripMenuItem});
            this.nguyễnHoàngBảoLongToolStripMenuItem.Name = "nguyễnHoàngBảoLongToolStripMenuItem";
            this.nguyễnHoàngBảoLongToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.nguyễnHoàngBảoLongToolStripMenuItem.Text = "Nguyễn Hoàng Bảo Long";
            // 
            // tsmividu1
            // 
            this.tsmividu1.Name = "tsmividu1";
            this.tsmividu1.Size = new System.Drawing.Size(180, 22);
            this.tsmividu1.Text = "Ví dụ 1";
            this.tsmividu1.Click += new System.EventHandler(this.tsmividu1_Click);
            // 
            // víDụ2BàiTậpToolStripMenuItem
            // 
            this.víDụ2BàiTậpToolStripMenuItem.Name = "víDụ2BàiTậpToolStripMenuItem";
            this.víDụ2BàiTậpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.víDụ2BàiTậpToolStripMenuItem.Text = "Ví dụ 2 + Bài tập";
            this.víDụ2BàiTậpToolStripMenuItem.Click += new System.EventHandler(this.víDụ2BàiTậpToolStripMenuItem_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChinh";
            this.Text = "Chương trình điều khiển";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nguyễnHoàngBảoLongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmividu1;
        private System.Windows.Forms.ToolStripMenuItem víDụ2BàiTậpToolStripMenuItem;
    }
}