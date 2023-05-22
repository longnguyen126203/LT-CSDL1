namespace Lab07_Advanced_Command
{
    partial class FormDetailsOrders
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
            this.dgvDanhMucMatHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhMucMatHang
            // 
            this.dgvDanhMucMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucMatHang.Location = new System.Drawing.Point(3, 2);
            this.dgvDanhMucMatHang.Name = "dgvDanhMucMatHang";
            this.dgvDanhMucMatHang.Size = new System.Drawing.Size(793, 317);
            this.dgvDanhMucMatHang.TabIndex = 0;
            
            // 
            // FormDetailsOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 319);
            this.Controls.Add(this.dgvDanhMucMatHang);
            this.Name = "FormDetailsOrders";
            this.Text = "FormDetailsOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucMatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhMucMatHang;
    }
}