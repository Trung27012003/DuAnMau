﻿namespace _3_PL.Views
{
    partial class frm_QLSanPham
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.tbx_nambh = new System.Windows.Forms.TextBox();
            this.cmb_loc = new System.Windows.Forms.ComboBox();
            this.tbx_timkiem = new System.Windows.Forms.TextBox();
            this.dgridviews = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_mota = new System.Windows.Forms.TextBox();
            this.cmb_mausac = new System.Windows.Forms.ComboBox();
            this.cmb_tennsx = new System.Windows.Forms.ComboBox();
            this.cmb_dongsp = new System.Windows.Forms.ComboBox();
            this.cmb_tensp = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbx_giaban = new System.Windows.Forms.TextBox();
            this.tbx_gianhap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_soluongton = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgridviews)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mô Tả";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(22, 256);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(266, 52);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(22, 183);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(266, 52);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(22, 106);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(266, 52);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(22, 26);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(266, 52);
            this.btn_lammoi.TabIndex = 0;
            this.btn_lammoi.Text = "Làm Mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // tbx_nambh
            // 
            this.tbx_nambh.Location = new System.Drawing.Point(183, 227);
            this.tbx_nambh.Name = "tbx_nambh";
            this.tbx_nambh.PlaceholderText = "Năm Bảo Hành";
            this.tbx_nambh.Size = new System.Drawing.Size(566, 27);
            this.tbx_nambh.TabIndex = 3;
            // 
            // cmb_loc
            // 
            this.cmb_loc.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmb_loc.FormattingEnabled = true;
            this.cmb_loc.Location = new System.Drawing.Point(877, 23);
            this.cmb_loc.Name = "cmb_loc";
            this.cmb_loc.Size = new System.Drawing.Size(237, 28);
            this.cmb_loc.TabIndex = 2;
            this.cmb_loc.Text = "Lọc";
            // 
            // tbx_timkiem
            // 
            this.tbx_timkiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbx_timkiem.Location = new System.Drawing.Point(3, 23);
            this.tbx_timkiem.Name = "tbx_timkiem";
            this.tbx_timkiem.PlaceholderText = "Tìm kiếm theo tên";
            this.tbx_timkiem.Size = new System.Drawing.Size(709, 27);
            this.tbx_timkiem.TabIndex = 1;
            this.tbx_timkiem.TextChanged += new System.EventHandler(this.tbx_timkiem_TextChanged);
            // 
            // dgridviews
            // 
            this.dgridviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridviews.Location = new System.Drawing.Point(6, 58);
            this.dgridviews.Name = "dgridviews";
            this.dgridviews.RowHeadersWidth = 51;
            this.dgridviews.RowTemplate.Height = 29;
            this.dgridviews.Size = new System.Drawing.Size(1102, 199);
            this.dgridviews.TabIndex = 0;
            this.dgridviews.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridviews_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Năm Bảo Hành";
            // 
            // tbx_mota
            // 
            this.tbx_mota.Location = new System.Drawing.Point(183, 279);
            this.tbx_mota.Name = "tbx_mota";
            this.tbx_mota.PlaceholderText = "Mô Tả";
            this.tbx_mota.Size = new System.Drawing.Size(566, 27);
            this.tbx_mota.TabIndex = 7;
            // 
            // cmb_mausac
            // 
            this.cmb_mausac.FormattingEnabled = true;
            this.cmb_mausac.Location = new System.Drawing.Point(183, 65);
            this.cmb_mausac.Name = "cmb_mausac";
            this.cmb_mausac.Size = new System.Drawing.Size(566, 28);
            this.cmb_mausac.TabIndex = 8;
            // 
            // cmb_tennsx
            // 
            this.cmb_tennsx.FormattingEnabled = true;
            this.cmb_tennsx.Location = new System.Drawing.Point(183, 173);
            this.cmb_tennsx.Name = "cmb_tennsx";
            this.cmb_tennsx.Size = new System.Drawing.Size(566, 28);
            this.cmb_tennsx.TabIndex = 9;
            // 
            // cmb_dongsp
            // 
            this.cmb_dongsp.FormattingEnabled = true;
            this.cmb_dongsp.Location = new System.Drawing.Point(183, 119);
            this.cmb_dongsp.Name = "cmb_dongsp";
            this.cmb_dongsp.Size = new System.Drawing.Size(566, 28);
            this.cmb_dongsp.TabIndex = 10;
            // 
            // cmb_tensp
            // 
            this.cmb_tensp.FormattingEnabled = true;
            this.cmb_tensp.Location = new System.Drawing.Point(183, 10);
            this.cmb_tensp.Name = "cmb_tensp";
            this.cmb_tensp.Size = new System.Drawing.Size(566, 28);
            this.cmb_tensp.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_loc);
            this.groupBox1.Controls.Add(this.tbx_timkiem);
            this.groupBox1.Controls.Add(this.dgridviews);
            this.groupBox1.Location = new System.Drawing.Point(12, 435);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1117, 293);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Views";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hãng Sản Xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Dòng Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Màu Sản Phẩm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbx_giaban);
            this.groupBox3.Controls.Add(this.tbx_gianhap);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbx_soluongton);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbx_nambh);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbx_mota);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cmb_mausac);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cmb_tennsx);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmb_dongsp);
            this.groupBox3.Controls.Add(this.cmb_tensp);
            this.groupBox3.Location = new System.Drawing.Point(12, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(793, 438);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Text";
            // 
            // tbx_giaban
            // 
            this.tbx_giaban.Location = new System.Drawing.Point(427, 383);
            this.tbx_giaban.Name = "tbx_giaban";
            this.tbx_giaban.Size = new System.Drawing.Size(125, 27);
            this.tbx_giaban.TabIndex = 23;
            // 
            // tbx_gianhap
            // 
            this.tbx_gianhap.Location = new System.Drawing.Point(180, 387);
            this.tbx_gianhap.Name = "tbx_gianhap";
            this.tbx_gianhap.Size = new System.Drawing.Size(125, 27);
            this.tbx_gianhap.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Giá bán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Giá nhập";
            // 
            // tbx_soluongton
            // 
            this.tbx_soluongton.Location = new System.Drawing.Point(183, 336);
            this.tbx_soluongton.Name = "tbx_soluongton";
            this.tbx_soluongton.PlaceholderText = "Số lượng tồn";
            this.tbx_soluongton.Size = new System.Drawing.Size(561, 27);
            this.tbx_soluongton.TabIndex = 19;
            this.tbx_soluongton.TextChanged += new System.EventHandler(this.tbx_soluongton_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Số lượng tồn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.btn_lammoi);
            this.groupBox2.Location = new System.Drawing.Point(811, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 349);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control";
            // 
            // frm_QLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 728);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frm_QLSanPham";
            this.Text = "frm_QLSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dgridviews)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.TextBox tbx_nambh;
        private System.Windows.Forms.ComboBox cmb_loc;
        private System.Windows.Forms.TextBox tbx_timkiem;
        private System.Windows.Forms.DataGridView dgridviews;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_mota;
        private System.Windows.Forms.ComboBox cmb_mausac;
        private System.Windows.Forms.ComboBox cmb_tennsx;
        private System.Windows.Forms.ComboBox cmb_dongsp;
        private System.Windows.Forms.ComboBox cmb_tensp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbx_giaban;
        private System.Windows.Forms.TextBox tbx_gianhap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_soluongton;
        private System.Windows.Forms.Label label7;
    }
}