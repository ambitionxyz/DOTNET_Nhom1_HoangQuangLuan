
namespace appquanlydanhba
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Gridnhom = new System.Windows.Forms.DataGridView();
            this.Gridsinhvien = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnthemnhom = new System.Windows.Forms.ToolStripButton();
            this.btnxoanhom = new System.Windows.Forms.ToolStripButton();
            this.btnthemlienlac = new System.Windows.Forms.ToolStripButton();
            this.btnxoalienlac = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txttimkiem = new System.Windows.Forms.ToolStripTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tenSinhVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhVienViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tenNhomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Gridnhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridsinhvien)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Gridnhom
            // 
            this.Gridnhom.AutoGenerateColumns = false;
            this.Gridnhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridnhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenNhomDataGridViewTextBoxColumn});
            this.Gridnhom.DataSource = this.nhomViewModelBindingSource;
            this.Gridnhom.Location = new System.Drawing.Point(13, 41);
            this.Gridnhom.Name = "Gridnhom";
            this.Gridnhom.RowHeadersWidth = 51;
            this.Gridnhom.RowTemplate.Height = 24;
            this.Gridnhom.Size = new System.Drawing.Size(240, 341);
            this.Gridnhom.TabIndex = 0;
            this.Gridnhom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gridnhom_CellClick);
            // 
            // Gridsinhvien
            // 
            this.Gridsinhvien.AutoGenerateColumns = false;
            this.Gridsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridsinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenSinhVienDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn});
            this.Gridsinhvien.DataSource = this.sinhVienViewModelBindingSource;
            this.Gridsinhvien.Location = new System.Drawing.Point(259, 41);
            this.Gridsinhvien.Name = "Gridsinhvien";
            this.Gridsinhvien.RowHeadersWidth = 51;
            this.Gridsinhvien.RowTemplate.Height = 24;
            this.Gridsinhvien.Size = new System.Drawing.Size(492, 182);
            this.Gridsinhvien.TabIndex = 1;
            this.Gridsinhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gridsinhvien_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnthemnhom,
            this.btnxoanhom,
            this.btnthemlienlac,
            this.btnxoalienlac,
            this.toolStripLabel1,
            this.txttimkiem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnthemnhom
            // 
            this.btnthemnhom.Image = ((System.Drawing.Image)(resources.GetObject("btnthemnhom.Image")));
            this.btnthemnhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthemnhom.Name = "btnthemnhom";
            this.btnthemnhom.Size = new System.Drawing.Size(112, 24);
            this.btnthemnhom.Text = "Thêm nhóm";
            this.btnthemnhom.Click += new System.EventHandler(this.btnthemnhom_Click);
            // 
            // btnxoanhom
            // 
            this.btnxoanhom.Image = ((System.Drawing.Image)(resources.GetObject("btnxoanhom.Image")));
            this.btnxoanhom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnxoanhom.Name = "btnxoanhom";
            this.btnxoanhom.Size = new System.Drawing.Size(101, 24);
            this.btnxoanhom.Text = "Xóa nhóm";
            this.btnxoanhom.Click += new System.EventHandler(this.btnxoanhom_Click);
            // 
            // btnthemlienlac
            // 
            this.btnthemlienlac.Image = ((System.Drawing.Image)(resources.GetObject("btnthemlienlac.Image")));
            this.btnthemlienlac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthemlienlac.Name = "btnthemlienlac";
            this.btnthemlienlac.Size = new System.Drawing.Size(118, 24);
            this.btnthemlienlac.Text = "thêm liên lạc";
            this.btnthemlienlac.Click += new System.EventHandler(this.btnthemlienlac_Click);
            // 
            // btnxoalienlac
            // 
            this.btnxoalienlac.Image = ((System.Drawing.Image)(resources.GetObject("btnxoalienlac.Image")));
            this.btnxoalienlac.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnxoalienlac.Name = "btnxoalienlac";
            this.btnxoalienlac.Size = new System.Drawing.Size(108, 24);
            this.btnxoalienlac.Text = "xóa liên lạc";
            this.btnxoalienlac.Click += new System.EventHandler(this.btnxoalienlac_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(116, 24);
            this.toolStripLabel1.Text = "Nhập tư cần tìm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(100, 27);
            this.txttimkiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên gọi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "SĐT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa chỉ";
            // 
            // tenSinhVienDataGridViewTextBoxColumn
            // 
            this.tenSinhVienDataGridViewTextBoxColumn.DataPropertyName = "TenSinhVien";
            this.tenSinhVienDataGridViewTextBoxColumn.HeaderText = "Tên Gọi";
            this.tenSinhVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenSinhVienDataGridViewTextBoxColumn.Name = "tenSinhVienDataGridViewTextBoxColumn";
            this.tenSinhVienDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.Width = 125;
            // 
            // sinhVienViewModelBindingSource
            // 
            this.sinhVienViewModelBindingSource.DataSource = typeof(appquanlydanhba.ViewModel.SinhVienViewModel);
            // 
            // tenNhomDataGridViewTextBoxColumn
            // 
            this.tenNhomDataGridViewTextBoxColumn.DataPropertyName = "TenNhom";
            this.tenNhomDataGridViewTextBoxColumn.HeaderText = "Tên Nhóm";
            this.tenNhomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenNhomDataGridViewTextBoxColumn.Name = "tenNhomDataGridViewTextBoxColumn";
            this.tenNhomDataGridViewTextBoxColumn.Width = 125;
            // 
            // nhomViewModelBindingSource
            // 
            this.nhomViewModelBindingSource.DataSource = typeof(appquanlydanhba.ViewModel.NhomViewModel);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(413, 240);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(191, 22);
            this.txtten.TabIndex = 7;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(413, 274);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(191, 22);
            this.txtdiachi.TabIndex = 7;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(413, 314);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(191, 22);
            this.txtemail.TabIndex = 7;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(413, 353);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(191, 22);
            this.txtsdt.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Gridsinhvien);
            this.Controls.Add(this.Gridnhom);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Gridnhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridsinhvien)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Gridnhom;
        private System.Windows.Forms.DataGridView Gridsinhvien;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnthemnhom;
        private System.Windows.Forms.ToolStripButton btnxoanhom;
        private System.Windows.Forms.ToolStripButton btnthemlienlac;
        private System.Windows.Forms.ToolStripButton btnxoalienlac;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txttimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource nhomViewModelBindingSource;
        private System.Windows.Forms.BindingSource sinhVienViewModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSinhVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtsdt;
    }
}

