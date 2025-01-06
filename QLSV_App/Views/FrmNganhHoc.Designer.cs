namespace QLSV_App
{
    partial class FrmNganhHoc
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
            this.components = new System.ComponentModel.Container();
            this.dtgvNganhHoc = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaNganhHoc = new System.Windows.Forms.TextBox();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSet = new QLSV_App.QLSVDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaNganhHoc = new System.Windows.Forms.Label();
            this.lblTenNganhHoc = new System.Windows.Forms.Label();
            this.txtTenNganhHoc = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.khoaTableAdapter = new QLSV_App.QLSVDataSetTableAdapters.KhoaTableAdapter();
            this.qLSVDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNganhHoc)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvNganhHoc
            // 
            this.dtgvNganhHoc.BackgroundColor = System.Drawing.Color.White;
            this.dtgvNganhHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNganhHoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvNganhHoc.Location = new System.Drawing.Point(0, 211);
            this.dtgvNganhHoc.Name = "dtgvNganhHoc";
            this.dtgvNganhHoc.Size = new System.Drawing.Size(377, 222);
            this.dtgvNganhHoc.TabIndex = 2;
            this.dtgvNganhHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNganhHoc_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMaNganhHoc);
            this.panel2.Controls.Add(this.cboKhoa);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblMaNganhHoc);
            this.panel2.Controls.Add(this.lblTenNganhHoc);
            this.panel2.Controls.Add(this.txtTenNganhHoc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 154);
            this.panel2.TabIndex = 0;
            // 
            // txtMaNganhHoc
            // 
            this.txtMaNganhHoc.Location = new System.Drawing.Point(124, 66);
            this.txtMaNganhHoc.Name = "txtMaNganhHoc";
            this.txtMaNganhHoc.Size = new System.Drawing.Size(215, 20);
            this.txtMaNganhHoc.TabIndex = 2;
            // 
            // cboKhoa
            // 
            this.cboKhoa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.khoaBindingSource, "TenKhoa", true));
            this.cboKhoa.DataSource = this.khoaBindingSource;
            this.cboKhoa.DisplayMember = "TenKhoa";
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(124, 22);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(215, 21);
            this.cboKhoa.TabIndex = 1;
            this.cboKhoa.SelectedIndexChanged += new System.EventHandler(this.cboKhoa_SelectedIndexChanged);
            this.cboKhoa.Click += new System.EventHandler(this.cboKhoa_Click);
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            this.khoaBindingSource.DataSource = this.qLSVDataSet;
            // 
            // qLSVDataSet
            // 
            this.qLSVDataSet.DataSetName = "QLSVDataSet";
            this.qLSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Khoa";
            // 
            // lblMaNganhHoc
            // 
            this.lblMaNganhHoc.AutoSize = true;
            this.lblMaNganhHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNganhHoc.Location = new System.Drawing.Point(16, 66);
            this.lblMaNganhHoc.Name = "lblMaNganhHoc";
            this.lblMaNganhHoc.Size = new System.Drawing.Size(102, 18);
            this.lblMaNganhHoc.TabIndex = 4;
            this.lblMaNganhHoc.Text = "Mã ngành học";
            // 
            // lblTenNganhHoc
            // 
            this.lblTenNganhHoc.AutoSize = true;
            this.lblTenNganhHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNganhHoc.Location = new System.Drawing.Point(16, 108);
            this.lblTenNganhHoc.Name = "lblTenNganhHoc";
            this.lblTenNganhHoc.Size = new System.Drawing.Size(106, 18);
            this.lblTenNganhHoc.TabIndex = 9;
            this.lblTenNganhHoc.Text = "Tên ngành học";
            // 
            // txtTenNganhHoc
            // 
            this.txtTenNganhHoc.Location = new System.Drawing.Point(124, 109);
            this.txtTenNganhHoc.Name = "txtTenNganhHoc";
            this.txtTenNganhHoc.Size = new System.Drawing.Size(215, 20);
            this.txtTenNganhHoc.TabIndex = 3;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(247, 160);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(118, 44);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(123, 160);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(118, 44);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(-1, 160);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 44);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // khoaTableAdapter
            // 
            this.khoaTableAdapter.ClearBeforeFill = true;
            // 
            // qLSVDataSetBindingSource
            // 
            this.qLSVDataSetBindingSource.DataSource = this.qLSVDataSet;
            this.qLSVDataSetBindingSource.Position = 0;
            // 
            // FrmNganhHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(377, 433);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtgvNganhHoc);
            this.Name = "FrmNganhHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NganhHoc";
            this.Load += new System.EventHandler(this.FrmNganhHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNganhHoc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvNganhHoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMaNganhHoc;
        private System.Windows.Forms.Label lblTenNganhHoc;
        private System.Windows.Forms.TextBox txtTenNganhHoc;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private QLSVDataSet qLSVDataSet;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private QLSVDataSetTableAdapters.KhoaTableAdapter khoaTableAdapter;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.TextBox txtMaNganhHoc;
        private System.Windows.Forms.BindingSource qLSVDataSetBindingSource;
    }
}