
using BTL_LTTQ_QLKhoVLXD.Controls;
using BTL_LTTQ_QLKhoVLXD.Controls.Button;

namespace BTL_LTTQ_QLKhoVLXD.Forms.CreateAccount
{
    partial class fCreateAccount
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
            this.pnlName = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnCreate = new BmwButton();
            this.btnCancel = new BmwButton();
            this.pnlName.SuspendLayout();
            this.pnlAccount.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlName
            // 
            this.pnlName.Controls.Add(this.txtName);
            this.pnlName.Controls.Add(this.lblName);
            this.pnlName.Location = new System.Drawing.Point(12, 12);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(494, 38);
            this.pnlName.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtName.Location = new System.Drawing.Point(129, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(335, 26);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ tên:";
            // 
            // pnlAccount
            // 
            this.pnlAccount.Controls.Add(this.txtAccount);
            this.pnlAccount.Controls.Add(this.lblAccount);
            this.pnlAccount.Location = new System.Drawing.Point(12, 56);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(494, 37);
            this.pnlAccount.TabIndex = 0;
            // 
            // txtAccount
            // 
            this.txtAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtAccount.Location = new System.Drawing.Point(129, 3);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(335, 26);
            this.txtAccount.TabIndex = 1;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(3, 9);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(109, 17);
            this.lblAccount.TabIndex = 0;
            this.lblAccount.Text = "Tên đăng nhập:";
            // 
            // pnlPassword
            // 
            this.pnlPassword.Controls.Add(this.chkShowPassword);
            this.pnlPassword.Controls.Add(this.txtPassword);
            this.pnlPassword.Controls.Add(this.lblPassword);
            this.pnlPassword.Location = new System.Drawing.Point(12, 99);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(494, 71);
            this.pnlPassword.TabIndex = 1;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(129, 40);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(140, 21);
            this.chkShowPassword.TabIndex = 2;
            this.chkShowPassword.Text = "Hiển thị mật khẩu";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtPassword.Location = new System.Drawing.Point(129, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(335, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(3, 9);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 17);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Mật khẩu:";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnCreate.Location = new System.Drawing.Point(93, 184);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(129, 39);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Tạo tài khoản";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnCancel.Location = new System.Drawing.Point(263, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 39);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(517, 241);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.pnlAccount);
            this.Controls.Add(this.pnlName);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "fCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateAccount";
            this.Load += new System.EventHandler(this.fCreateAccount_Load);
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            this.pnlAccount.ResumeLayout(false);
            this.pnlAccount.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlAccount;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private BmwButton btnCreate;
        private BmwButton btnCancel;
    }
}