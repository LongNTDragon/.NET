namespace QL_Karaoke
{
    partial class Form_Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDangNhap = new System.Windows.Forms.Label();
            this.btnDangNhap_DN = new System.Windows.Forms.Button();
            this.panelMatKhau = new System.Windows.Forms.Panel();
            this.lblResPassword = new System.Windows.Forms.Label();
            this.txtMatKhau_DN = new System.Windows.Forms.TextBox();
            this.lblMatKhau_DN = new System.Windows.Forms.Label();
            this.panelTaiKhoan = new System.Windows.Forms.Panel();
            this.lblResUserName = new System.Windows.Forms.Label();
            this.txtTenDangNhap_DN = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap_DN = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelMatKhau.SuspendLayout();
            this.panelTaiKhoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDangNhap);
            this.panel1.Controls.Add(this.btnDangNhap_DN);
            this.panel1.Controls.Add(this.panelMatKhau);
            this.panel1.Controls.Add(this.panelTaiKhoan);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 324);
            this.panel1.TabIndex = 0;
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.AutoSize = true;
            this.lblDangNhap.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangNhap.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblDangNhap.Location = new System.Drawing.Point(206, 5);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(227, 46);
            this.lblDangNhap.TabIndex = 5;
            this.lblDangNhap.Text = "Đăng Nhập";
            // 
            // btnDangNhap_DN
            // 
            this.btnDangNhap_DN.Enabled = false;
            this.btnDangNhap_DN.Location = new System.Drawing.Point(504, 268);
            this.btnDangNhap_DN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDangNhap_DN.Name = "btnDangNhap_DN";
            this.btnDangNhap_DN.Size = new System.Drawing.Size(107, 36);
            this.btnDangNhap_DN.TabIndex = 3;
            this.btnDangNhap_DN.Text = "Đăng nhập";
            this.btnDangNhap_DN.UseVisualStyleBackColor = true;
            this.btnDangNhap_DN.Click += new System.EventHandler(this.btnDangNhap_DN_Click);
            // 
            // panelMatKhau
            // 
            this.panelMatKhau.Controls.Add(this.lblResPassword);
            this.panelMatKhau.Controls.Add(this.txtMatKhau_DN);
            this.panelMatKhau.Controls.Add(this.lblMatKhau_DN);
            this.panelMatKhau.Location = new System.Drawing.Point(11, 166);
            this.panelMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMatKhau.Name = "panelMatKhau";
            this.panelMatKhau.Size = new System.Drawing.Size(600, 94);
            this.panelMatKhau.TabIndex = 1;
            // 
            // lblResPassword
            // 
            this.lblResPassword.AutoSize = true;
            this.lblResPassword.ForeColor = System.Drawing.Color.Red;
            this.lblResPassword.Location = new System.Drawing.Point(203, 66);
            this.lblResPassword.Name = "lblResPassword";
            this.lblResPassword.Size = new System.Drawing.Size(218, 20);
            this.lblResPassword.TabIndex = 3;
            this.lblResPassword.Text = "(Mật khẩu chứa ít nhất 4 kí tự)";
            // 
            // txtMatKhau_DN
            // 
            this.txtMatKhau_DN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau_DN.Location = new System.Drawing.Point(202, 28);
            this.txtMatKhau_DN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatKhau_DN.Multiline = true;
            this.txtMatKhau_DN.Name = "txtMatKhau_DN";
            this.txtMatKhau_DN.PasswordChar = '*';
            this.txtMatKhau_DN.Size = new System.Drawing.Size(393, 34);
            this.txtMatKhau_DN.TabIndex = 1;
            this.txtMatKhau_DN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_DN_KeyPress);
            // 
            // lblMatKhau_DN
            // 
            this.lblMatKhau_DN.AutoSize = true;
            this.lblMatKhau_DN.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau_DN.Location = new System.Drawing.Point(65, 32);
            this.lblMatKhau_DN.Name = "lblMatKhau_DN";
            this.lblMatKhau_DN.Size = new System.Drawing.Size(109, 24);
            this.lblMatKhau_DN.TabIndex = 0;
            this.lblMatKhau_DN.Text = "Mật khẩu:";
            // 
            // panelTaiKhoan
            // 
            this.panelTaiKhoan.Controls.Add(this.lblResUserName);
            this.panelTaiKhoan.Controls.Add(this.txtTenDangNhap_DN);
            this.panelTaiKhoan.Controls.Add(this.lblTenDangNhap_DN);
            this.panelTaiKhoan.Location = new System.Drawing.Point(11, 60);
            this.panelTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTaiKhoan.Name = "panelTaiKhoan";
            this.panelTaiKhoan.Size = new System.Drawing.Size(600, 103);
            this.panelTaiKhoan.TabIndex = 0;
            // 
            // lblResUserName
            // 
            this.lblResUserName.AutoSize = true;
            this.lblResUserName.ForeColor = System.Drawing.Color.Red;
            this.lblResUserName.Location = new System.Drawing.Point(203, 70);
            this.lblResUserName.Name = "lblResUserName";
            this.lblResUserName.Size = new System.Drawing.Size(268, 20);
            this.lblResUserName.TabIndex = 2;
            this.lblResUserName.Text = "(Tên đăng nhập bao gồm 10 kí tự số)";
            // 
            // txtTenDangNhap_DN
            // 
            this.txtTenDangNhap_DN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap_DN.Location = new System.Drawing.Point(202, 28);
            this.txtTenDangNhap_DN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenDangNhap_DN.Multiline = true;
            this.txtTenDangNhap_DN.Name = "txtTenDangNhap_DN";
            this.txtTenDangNhap_DN.Size = new System.Drawing.Size(393, 34);
            this.txtTenDangNhap_DN.TabIndex = 1;
            this.txtTenDangNhap_DN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenDangNhap_DN_KeyPress);
            // 
            // lblTenDangNhap_DN
            // 
            this.lblTenDangNhap_DN.AutoSize = true;
            this.lblTenDangNhap_DN.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap_DN.Location = new System.Drawing.Point(14, 31);
            this.lblTenDangNhap_DN.Name = "lblTenDangNhap_DN";
            this.lblTenDangNhap_DN.Size = new System.Drawing.Size(169, 24);
            this.lblTenDangNhap_DN.TabIndex = 0;
            this.lblTenDangNhap_DN.Text = "Tên đăng nhập:";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 365);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMatKhau.ResumeLayout(false);
            this.panelMatKhau.PerformLayout();
            this.panelTaiKhoan.ResumeLayout(false);
            this.panelTaiKhoan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau_DN;
        private System.Windows.Forms.Label lblMatKhau_DN;
        private System.Windows.Forms.Panel panelTaiKhoan;
        private System.Windows.Forms.TextBox txtTenDangNhap_DN;
        private System.Windows.Forms.Label lblTenDangNhap_DN;
        private System.Windows.Forms.Button btnDangNhap_DN;
        private System.Windows.Forms.Label lblDangNhap;
        private System.Windows.Forms.Label lblResPassword;
        private System.Windows.Forms.Label lblResUserName;
    }
}

