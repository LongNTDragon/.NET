
namespace QL_Karaoke
{
    partial class Form_DatPhong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPhieu_DP = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbKH = new System.Windows.Forms.GroupBox();
            this.txtLoaiKH = new System.Windows.Forms.TextBox();
            this.btnCreateMaKH = new System.Windows.Forms.Button();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.txtDTLuy = new System.Windows.Forms.TextBox();
            this.lblDTLuy = new System.Windows.Forms.Label();
            this.dtBirthday_DP = new System.Windows.Forms.DateTimePicker();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtAddress_DP = new System.Windows.Forms.TextBox();
            this.txtPhone_DP = new System.Windows.Forms.TextBox();
            this.txtCusName_DP = new System.Windows.Forms.TextBox();
            this.txtCCCD_DP = new System.Windows.Forms.TextBox();
            this.lblTenKhachHang_DP = new System.Windows.Forms.Label();
            this.lblBirthday_DP = new System.Windows.Forms.Label();
            this.lblCCCD_DP = new System.Windows.Forms.Label();
            this.lblLoaiKH_DP = new System.Windows.Forms.Label();
            this.lblDiaChi_DP = new System.Windows.Forms.Label();
            this.lblSĐT_DP = new System.Windows.Forms.Label();
            this.grbPhong = new System.Windows.Forms.GroupBox();
            this.lblTTPhong = new System.Windows.Forms.Label();
            this.lblPhong_DP = new System.Windows.Forms.Label();
            this.lblLoaiPhong_DP = new System.Windows.Forms.Label();
            this.btnDat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtLoaiPhong_DP = new System.Windows.Forms.TextBox();
            this.txtTTPhong_DP = new System.Windows.Forms.TextBox();
            this.txtPhong_DP = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grbKH.SuspendLayout();
            this.grbPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPhieu_DP);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 73);
            this.panel1.TabIndex = 3;
            // 
            // lblPhieu_DP
            // 
            this.lblPhieu_DP.AutoSize = true;
            this.lblPhieu_DP.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieu_DP.ForeColor = System.Drawing.Color.White;
            this.lblPhieu_DP.Location = new System.Drawing.Point(434, 16);
            this.lblPhieu_DP.Name = "lblPhieu_DP";
            this.lblPhieu_DP.Size = new System.Drawing.Size(327, 37);
            this.lblPhieu_DP.TabIndex = 0;
            this.lblPhieu_DP.Text = "PHIẾU ĐẶT PHÒNG";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // grbKH
            // 
            this.grbKH.BackColor = System.Drawing.SystemColors.Control;
            this.grbKH.Controls.Add(this.txtLoaiKH);
            this.grbKH.Controls.Add(this.btnCreateMaKH);
            this.grbKH.Controls.Add(this.txtMaKH);
            this.grbKH.Controls.Add(this.lblMaKH);
            this.grbKH.Controls.Add(this.txtDTLuy);
            this.grbKH.Controls.Add(this.lblDTLuy);
            this.grbKH.Controls.Add(this.dtBirthday_DP);
            this.grbKH.Controls.Add(this.btnFind);
            this.grbKH.Controls.Add(this.txtAddress_DP);
            this.grbKH.Controls.Add(this.txtPhone_DP);
            this.grbKH.Controls.Add(this.txtCusName_DP);
            this.grbKH.Controls.Add(this.txtCCCD_DP);
            this.grbKH.Controls.Add(this.lblTenKhachHang_DP);
            this.grbKH.Controls.Add(this.lblBirthday_DP);
            this.grbKH.Controls.Add(this.lblCCCD_DP);
            this.grbKH.Controls.Add(this.lblLoaiKH_DP);
            this.grbKH.Controls.Add(this.lblDiaChi_DP);
            this.grbKH.Controls.Add(this.lblSĐT_DP);
            this.grbKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbKH.Location = new System.Drawing.Point(14, 90);
            this.grbKH.Name = "grbKH";
            this.grbKH.Size = new System.Drawing.Size(1116, 274);
            this.grbKH.TabIndex = 6;
            this.grbKH.TabStop = false;
            this.grbKH.Text = "Thông tin khách hàng";
            // 
            // txtLoaiKH
            // 
            this.txtLoaiKH.Location = new System.Drawing.Point(198, 212);
            this.txtLoaiKH.Name = "txtLoaiKH";
            this.txtLoaiKH.ReadOnly = true;
            this.txtLoaiKH.Size = new System.Drawing.Size(350, 35);
            this.txtLoaiKH.TabIndex = 46;
            this.txtLoaiKH.Visible = false;
            // 
            // btnCreateMaKH
            // 
            this.btnCreateMaKH.BackColor = System.Drawing.Color.White;
            this.btnCreateMaKH.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCreateMaKH.FlatAppearance.BorderSize = 0;
            this.btnCreateMaKH.Location = new System.Drawing.Point(1004, 36);
            this.btnCreateMaKH.Name = "btnCreateMaKH";
            this.btnCreateMaKH.Size = new System.Drawing.Size(105, 44);
            this.btnCreateMaKH.TabIndex = 45;
            this.btnCreateMaKH.Text = "Tạo";
            this.btnCreateMaKH.UseVisualStyleBackColor = false;
            this.btnCreateMaKH.Click += new System.EventHandler(this.btnCreateMaKH_Click);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(742, 39);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(229, 35);
            this.txtMaKH.TabIndex = 44;
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(573, 47);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(90, 27);
            this.lblMaKH.TabIndex = 43;
            this.lblMaKH.Text = "Mã KH:";
            // 
            // txtDTLuy
            // 
            this.txtDTLuy.Location = new System.Drawing.Point(742, 211);
            this.txtDTLuy.Name = "txtDTLuy";
            this.txtDTLuy.ReadOnly = true;
            this.txtDTLuy.Size = new System.Drawing.Size(234, 35);
            this.txtDTLuy.TabIndex = 42;
            this.txtDTLuy.Text = "0";
            this.txtDTLuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDTLuy.Visible = false;
            // 
            // lblDTLuy
            // 
            this.lblDTLuy.AutoSize = true;
            this.lblDTLuy.Location = new System.Drawing.Point(573, 219);
            this.lblDTLuy.Name = "lblDTLuy";
            this.lblDTLuy.Size = new System.Drawing.Size(148, 27);
            this.lblDTLuy.TabIndex = 41;
            this.lblDTLuy.Text = "Điểm tích lũy:";
            this.lblDTLuy.Visible = false;
            // 
            // dtBirthday_DP
            // 
            this.dtBirthday_DP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirthday_DP.Location = new System.Drawing.Point(742, 153);
            this.dtBirthday_DP.Name = "dtBirthday_DP";
            this.dtBirthday_DP.Size = new System.Drawing.Size(234, 35);
            this.dtBirthday_DP.TabIndex = 39;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.White;
            this.btnFind.Enabled = false;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.Location = new System.Drawing.Point(443, 36);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(105, 44);
            this.btnFind.TabIndex = 38;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtAddress_DP
            // 
            this.txtAddress_DP.Location = new System.Drawing.Point(742, 96);
            this.txtAddress_DP.Name = "txtAddress_DP";
            this.txtAddress_DP.Size = new System.Drawing.Size(363, 35);
            this.txtAddress_DP.TabIndex = 37;
            // 
            // txtPhone_DP
            // 
            this.txtPhone_DP.Location = new System.Drawing.Point(198, 155);
            this.txtPhone_DP.Name = "txtPhone_DP";
            this.txtPhone_DP.Size = new System.Drawing.Size(350, 35);
            this.txtPhone_DP.TabIndex = 36;
            this.txtPhone_DP.TextChanged += new System.EventHandler(this.txtPhone_DP_TextChanged);
            // 
            // txtCusName_DP
            // 
            this.txtCusName_DP.Location = new System.Drawing.Point(198, 96);
            this.txtCusName_DP.Name = "txtCusName_DP";
            this.txtCusName_DP.Size = new System.Drawing.Size(350, 35);
            this.txtCusName_DP.TabIndex = 35;
            // 
            // txtCCCD_DP
            // 
            this.txtCCCD_DP.Location = new System.Drawing.Point(198, 39);
            this.txtCCCD_DP.Name = "txtCCCD_DP";
            this.txtCCCD_DP.Size = new System.Drawing.Size(218, 35);
            this.txtCCCD_DP.TabIndex = 34;
            this.txtCCCD_DP.TextChanged += new System.EventHandler(this.txtCCCD_DP_TextChanged);
            // 
            // lblTenKhachHang_DP
            // 
            this.lblTenKhachHang_DP.AutoSize = true;
            this.lblTenKhachHang_DP.Location = new System.Drawing.Point(12, 103);
            this.lblTenKhachHang_DP.Name = "lblTenKhachHang_DP";
            this.lblTenKhachHang_DP.Size = new System.Drawing.Size(171, 27);
            this.lblTenKhachHang_DP.TabIndex = 33;
            this.lblTenKhachHang_DP.Text = "Tên khách hàng:";
            // 
            // lblBirthday_DP
            // 
            this.lblBirthday_DP.AutoSize = true;
            this.lblBirthday_DP.Location = new System.Drawing.Point(573, 159);
            this.lblBirthday_DP.Name = "lblBirthday_DP";
            this.lblBirthday_DP.Size = new System.Drawing.Size(114, 27);
            this.lblBirthday_DP.TabIndex = 32;
            this.lblBirthday_DP.Text = "Ngày sinh:";
            // 
            // lblCCCD_DP
            // 
            this.lblCCCD_DP.AutoSize = true;
            this.lblCCCD_DP.Location = new System.Drawing.Point(12, 47);
            this.lblCCCD_DP.Name = "lblCCCD_DP";
            this.lblCCCD_DP.Size = new System.Drawing.Size(83, 27);
            this.lblCCCD_DP.TabIndex = 31;
            this.lblCCCD_DP.Text = "CCCD:";
            // 
            // lblLoaiKH_DP
            // 
            this.lblLoaiKH_DP.AutoSize = true;
            this.lblLoaiKH_DP.Location = new System.Drawing.Point(12, 218);
            this.lblLoaiKH_DP.Name = "lblLoaiKH_DP";
            this.lblLoaiKH_DP.Size = new System.Drawing.Size(96, 27);
            this.lblLoaiKH_DP.TabIndex = 29;
            this.lblLoaiKH_DP.Text = "Loại KH";
            this.lblLoaiKH_DP.Visible = false;
            // 
            // lblDiaChi_DP
            // 
            this.lblDiaChi_DP.AutoSize = true;
            this.lblDiaChi_DP.Location = new System.Drawing.Point(573, 103);
            this.lblDiaChi_DP.Name = "lblDiaChi_DP";
            this.lblDiaChi_DP.Size = new System.Drawing.Size(87, 27);
            this.lblDiaChi_DP.TabIndex = 28;
            this.lblDiaChi_DP.Text = "Địa chỉ:";
            // 
            // lblSĐT_DP
            // 
            this.lblSĐT_DP.AutoSize = true;
            this.lblSĐT_DP.Location = new System.Drawing.Point(12, 163);
            this.lblSĐT_DP.Name = "lblSĐT_DP";
            this.lblSĐT_DP.Size = new System.Drawing.Size(143, 27);
            this.lblSĐT_DP.TabIndex = 27;
            this.lblSĐT_DP.Text = "Số điện thoại:";
            // 
            // grbPhong
            // 
            this.grbPhong.BackColor = System.Drawing.SystemColors.Control;
            this.grbPhong.Controls.Add(this.txtPhong_DP);
            this.grbPhong.Controls.Add(this.txtTTPhong_DP);
            this.grbPhong.Controls.Add(this.txtLoaiPhong_DP);
            this.grbPhong.Controls.Add(this.lblTTPhong);
            this.grbPhong.Controls.Add(this.lblPhong_DP);
            this.grbPhong.Controls.Add(this.lblLoaiPhong_DP);
            this.grbPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPhong.Location = new System.Drawing.Point(14, 364);
            this.grbPhong.Name = "grbPhong";
            this.grbPhong.Size = new System.Drawing.Size(1116, 165);
            this.grbPhong.TabIndex = 7;
            this.grbPhong.TabStop = false;
            this.grbPhong.Text = "Phòng";
            // 
            // lblTTPhong
            // 
            this.lblTTPhong.AutoSize = true;
            this.lblTTPhong.Location = new System.Drawing.Point(562, 46);
            this.lblTTPhong.Name = "lblTTPhong";
            this.lblTTPhong.Size = new System.Drawing.Size(182, 27);
            this.lblTTPhong.TabIndex = 22;
            this.lblTTPhong.Text = "Tình trạng phòng:";
            // 
            // lblPhong_DP
            // 
            this.lblPhong_DP.AutoSize = true;
            this.lblPhong_DP.Location = new System.Drawing.Point(13, 115);
            this.lblPhong_DP.Name = "lblPhong_DP";
            this.lblPhong_DP.Size = new System.Drawing.Size(79, 27);
            this.lblPhong_DP.TabIndex = 19;
            this.lblPhong_DP.Text = "Phòng:";
            // 
            // lblLoaiPhong_DP
            // 
            this.lblLoaiPhong_DP.AutoSize = true;
            this.lblLoaiPhong_DP.Location = new System.Drawing.Point(13, 46);
            this.lblLoaiPhong_DP.Name = "lblLoaiPhong_DP";
            this.lblLoaiPhong_DP.Size = new System.Drawing.Size(127, 27);
            this.lblLoaiPhong_DP.TabIndex = 18;
            this.lblLoaiPhong_DP.Text = "Loại phòng:";
            // 
            // btnDat
            // 
            this.btnDat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDat.FlatAppearance.BorderSize = 0;
            this.btnDat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDat.Location = new System.Drawing.Point(790, 551);
            this.btnDat.Name = "btnDat";
            this.btnDat.Size = new System.Drawing.Size(157, 51);
            this.btnDat.TabIndex = 8;
            this.btnDat.Text = "Đặt";
            this.btnDat.UseVisualStyleBackColor = false;
            this.btnDat.Click += new System.EventHandler(this.btnDat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Firebrick;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHuy.Location = new System.Drawing.Point(973, 551);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(157, 51);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtLoaiPhong_DP
            // 
            this.txtLoaiPhong_DP.Location = new System.Drawing.Point(198, 43);
            this.txtLoaiPhong_DP.Name = "txtLoaiPhong_DP";
            this.txtLoaiPhong_DP.ReadOnly = true;
            this.txtLoaiPhong_DP.Size = new System.Drawing.Size(350, 35);
            this.txtLoaiPhong_DP.TabIndex = 37;
            // 
            // txtTTPhong_DP
            // 
            this.txtTTPhong_DP.Location = new System.Drawing.Point(750, 43);
            this.txtTTPhong_DP.Name = "txtTTPhong_DP";
            this.txtTTPhong_DP.ReadOnly = true;
            this.txtTTPhong_DP.Size = new System.Drawing.Size(350, 35);
            this.txtTTPhong_DP.TabIndex = 38;
            this.txtTTPhong_DP.Text = "Đã đặt";
            this.txtTTPhong_DP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPhong_DP
            // 
            this.txtPhong_DP.Location = new System.Drawing.Point(198, 107);
            this.txtPhong_DP.Name = "txtPhong_DP";
            this.txtPhong_DP.ReadOnly = true;
            this.txtPhong_DP.Size = new System.Drawing.Size(350, 35);
            this.txtPhong_DP.TabIndex = 39;
            // 
            // Form_DatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1148, 614);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDat);
            this.Controls.Add(this.grbPhong);
            this.Controls.Add(this.grbKH);
            this.Controls.Add(this.panel1);
            this.Name = "Form_DatPhong";
            this.Text = "Form_DatPhong";
            this.Load += new System.EventHandler(this.Form_DatPhong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grbKH.ResumeLayout(false);
            this.grbKH.PerformLayout();
            this.grbPhong.ResumeLayout(false);
            this.grbPhong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPhieu_DP;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDat;
        private System.Windows.Forms.GroupBox grbPhong;
        private System.Windows.Forms.Label lblTTPhong;
        private System.Windows.Forms.Label lblPhong_DP;
        private System.Windows.Forms.Label lblLoaiPhong_DP;
        private System.Windows.Forms.GroupBox grbKH;
        private System.Windows.Forms.TextBox txtDTLuy;
        private System.Windows.Forms.Label lblDTLuy;
        private System.Windows.Forms.DateTimePicker dtBirthday_DP;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtAddress_DP;
        private System.Windows.Forms.TextBox txtPhone_DP;
        private System.Windows.Forms.TextBox txtCusName_DP;
        private System.Windows.Forms.TextBox txtCCCD_DP;
        private System.Windows.Forms.Label lblTenKhachHang_DP;
        private System.Windows.Forms.Label lblBirthday_DP;
        private System.Windows.Forms.Label lblCCCD_DP;
        private System.Windows.Forms.Label lblLoaiKH_DP;
        private System.Windows.Forms.Label lblDiaChi_DP;
        private System.Windows.Forms.Label lblSĐT_DP;
        private System.Windows.Forms.Button btnCreateMaKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.TextBox txtLoaiKH;
        private System.Windows.Forms.TextBox txtPhong_DP;
        private System.Windows.Forms.TextBox txtTTPhong_DP;
        private System.Windows.Forms.TextBox txtLoaiPhong_DP;
    }
}