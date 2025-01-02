namespace QLSV_App
{
    partial class Khoa
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
            this.dtgvKhoa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvKhoa
            // 
            this.dtgvKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKhoa.Location = new System.Drawing.Point(93, 225);
            this.dtgvKhoa.Name = "dtgvKhoa";
            this.dtgvKhoa.Size = new System.Drawing.Size(720, 150);
            this.dtgvKhoa.TabIndex = 0;
            // 
            // Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 576);
            this.Controls.Add(this.dtgvKhoa);
            this.Name = "Khoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khoa";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvKhoa;
    }
}