namespace QL_Karaoke
{
    partial class Form_HoaDon
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
            this.lblTenQuan = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSĐT_HD = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lstCTPhong = new System.Windows.Forms.ListView();
            this.columnPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLPhong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTimeIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTimeOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.lstCTMHang = new System.Windows.Forms.ListView();
            this.columnHangDv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDVT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.columnGGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSumMoney = new System.Windows.Forms.Label();
            this.txtSumMoney = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTenQuan
            // 
            this.lblTenQuan.AutoSize = true;
            this.lblTenQuan.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenQuan.ForeColor = System.Drawing.Color.LightCoral;
            this.lblTenQuan.Location = new System.Drawing.Point(40, 13);
            this.lblTenQuan.Name = "lblTenQuan";
            this.lblTenQuan.Size = new System.Drawing.Size(379, 65);
            this.lblTenQuan.TabIndex = 0;
            this.lblTenQuan.Text = "CBR Karaoke";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTenQuan);
            this.panel1.Location = new System.Drawing.Point(221, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 78);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSĐT_HD);
            this.panel2.Controls.Add(this.lblDiaChi);
            this.panel2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 79);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 70);
            this.panel2.TabIndex = 2;
            // 
            // lblSĐT_HD
            // 
            this.lblSĐT_HD.AutoSize = true;
            this.lblSĐT_HD.Location = new System.Drawing.Point(375, 39);
            this.lblSĐT_HD.Name = "lblSĐT_HD";
            this.lblSĐT_HD.Size = new System.Drawing.Size(149, 21);
            this.lblSĐT_HD.TabIndex = 1;
            this.lblSĐT_HD.Text = "SĐT: 0397299xxx";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(184, 8);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(513, 21);
            this.lblDiaChi.TabIndex = 0;
            this.lblDiaChi.Text = "Địa Chỉ: 50XY Cửu Long, phường 20, quận Tân Bình, TP.HCM";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.lstCTPhong);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.lstCTMHang);
            this.panel3.Controls.Add(this.lblHoaDon);
            this.panel3.Location = new System.Drawing.Point(12, 149);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(899, 464);
            this.panel3.TabIndex = 3;
            // 
            // lstCTPhong
            // 
            this.lstCTPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPhong,
            this.columnLPhong,
            this.columnGia,
            this.columnTimeIn,
            this.columnTimeOut,
            this.columnGGia,
            this.columnTTien});
            this.lstCTPhong.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCTPhong.FullRowSelect = true;
            this.lstCTPhong.GridLines = true;
            this.lstCTPhong.HideSelection = false;
            this.lstCTPhong.Location = new System.Drawing.Point(16, 301);
            this.lstCTPhong.Name = "lstCTPhong";
            this.lstCTPhong.Size = new System.Drawing.Size(868, 95);
            this.lstCTPhong.TabIndex = 5;
            this.lstCTPhong.UseCompatibleStateImageBehavior = false;
            this.lstCTPhong.View = System.Windows.Forms.View.Details;
            // 
            // columnPhong
            // 
            this.columnPhong.Text = "Phòng";
            this.columnPhong.Width = 65;
            // 
            // columnLPhong
            // 
            this.columnLPhong.Text = "Loại phòng";
            this.columnLPhong.Width = 130;
            // 
            // columnGia
            // 
            this.columnGia.Text = "Giá";
            this.columnGia.Width = 65;
            // 
            // columnTimeIn
            // 
            this.columnTimeIn.Text = "Giờ vào";
            this.columnTimeIn.Width = 75;
            // 
            // columnTimeOut
            // 
            this.columnTimeOut.Text = "Giờ ra";
            this.columnTimeOut.Width = 75;
            // 
            // columnTTien
            // 
            this.columnTTien.Text = "Thành tiền";
            this.columnTTien.Width = 85;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtSumMoney);
            this.panel5.Controls.Add(this.lblSumMoney);
            this.panel5.Location = new System.Drawing.Point(464, 403);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(435, 57);
            this.panel5.TabIndex = 4;
            // 
            // lstCTMHang
            // 
            this.lstCTMHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHangDv,
            this.columnDG,
            this.columnSL,
            this.columnDVT,
            this.columnTT});
            this.lstCTMHang.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCTMHang.GridLines = true;
            this.lstCTMHang.HideSelection = false;
            this.lstCTMHang.Location = new System.Drawing.Point(16, 70);
            this.lstCTMHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstCTMHang.Name = "lstCTMHang";
            this.lstCTMHang.Size = new System.Drawing.Size(868, 224);
            this.lstCTMHang.TabIndex = 3;
            this.lstCTMHang.UseCompatibleStateImageBehavior = false;
            this.lstCTMHang.View = System.Windows.Forms.View.Details;
            // 
            // columnHangDv
            // 
            this.columnHangDv.Text = "Tên hàng/DV";
            this.columnHangDv.Width = 165;
            // 
            // columnDG
            // 
            this.columnDG.Text = "Đơn giá ";
            this.columnDG.Width = 100;
            // 
            // columnSL
            // 
            this.columnSL.Text = "SL";
            this.columnSL.Width = 85;
            // 
            // columnDVT
            // 
            this.columnDVT.Text = "ĐVT";
            this.columnDVT.Width = 85;
            // 
            // columnTT
            // 
            this.columnTT.Text = "Thành tiền";
            this.columnTT.Width = 140;
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDon.Location = new System.Drawing.Point(362, 17);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(153, 40);
            this.lblHoaDon.TabIndex = 0;
            this.lblHoaDon.Text = "HÓA ĐƠN";
            // 
            // columnGGia
            // 
            this.columnGGia.Text = "Giảm giá(%)";
            this.columnGGia.Width = 80;
            // 
            // lblSumMoney
            // 
            this.lblSumMoney.AutoSize = true;
            this.lblSumMoney.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumMoney.Location = new System.Drawing.Point(14, 14);
            this.lblSumMoney.Name = "lblSumMoney";
            this.lblSumMoney.Size = new System.Drawing.Size(117, 26);
            this.lblSumMoney.TabIndex = 0;
            this.lblSumMoney.Text = "Tổng tiền:";
            // 
            // txtSumMoney
            // 
            this.txtSumMoney.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumMoney.Location = new System.Drawing.Point(182, 11);
            this.txtSumMoney.Name = "txtSumMoney";
            this.txtSumMoney.Size = new System.Drawing.Size(238, 35);
            this.txtSumMoney.TabIndex = 1;
            this.txtSumMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 626);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_HoaDon";
            this.Load += new System.EventHandler(this.Form_HoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTenQuan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSĐT_HD;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lstCTMHang;
        private System.Windows.Forms.ColumnHeader columnHangDv;
        private System.Windows.Forms.ColumnHeader columnDG;
        private System.Windows.Forms.ColumnHeader columnSL;
        private System.Windows.Forms.ColumnHeader columnDVT;
        private System.Windows.Forms.ColumnHeader columnTT;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView lstCTPhong;
        private System.Windows.Forms.ColumnHeader columnPhong;
        private System.Windows.Forms.ColumnHeader columnLPhong;
        private System.Windows.Forms.ColumnHeader columnGia;
        private System.Windows.Forms.ColumnHeader columnTimeIn;
        private System.Windows.Forms.ColumnHeader columnTimeOut;
        private System.Windows.Forms.ColumnHeader columnTTien;
        private System.Windows.Forms.ColumnHeader columnGGia;
        private System.Windows.Forms.TextBox txtSumMoney;
        private System.Windows.Forms.Label lblSumMoney;
    }
}