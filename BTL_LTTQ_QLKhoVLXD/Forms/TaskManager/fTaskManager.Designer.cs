
namespace BTL_LTTQ_QLKhoVLXD
{
    partial class fTaskManager
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.tctlControl = new System.Windows.Forms.TabControl();
            this.tpgBuy = new System.Windows.Forms.TabPage();
            this.tpgSell = new System.Windows.Forms.TabPage();
            this.tpgReceipt = new System.Windows.Forms.TabPage();
            this.tpgMaterial = new System.Windows.Forms.TabPage();
            this.dgvMaterial = new System.Windows.Forms.DataGridView();
            this.tpgStatistic = new System.Windows.Forms.TabPage();
            this.tpgCustomer = new System.Windows.Forms.TabPage();
            this.tpgSupplier = new System.Windows.Forms.TabPage();
            this.tpgEmployee = new System.Windows.Forms.TabPage();
            this.tpgUserSetting = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateAccount_userSetting = new System.Windows.Forms.Button();
            this.btnChangePassword_userSetting = new System.Windows.Forms.Button();
            this.btnResetPassword_userSetting = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.tctlControl.SuspendLayout();
            this.tpgMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).BeginInit();
            this.tpgUserSetting.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPosition);
            this.panel3.Controls.Add(this.lblUser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 607);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1163, 57);
            this.panel3.TabIndex = 3;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(423, 20);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(63, 17);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "Chức vụ:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(12, 20);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(85, 17);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Người dùng:";
            // 
            // tctlControl
            // 
            this.tctlControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tctlControl.Controls.Add(this.tpgBuy);
            this.tctlControl.Controls.Add(this.tpgSell);
            this.tctlControl.Controls.Add(this.tpgReceipt);
            this.tctlControl.Controls.Add(this.tpgMaterial);
            this.tctlControl.Controls.Add(this.tpgStatistic);
            this.tctlControl.Controls.Add(this.tpgCustomer);
            this.tctlControl.Controls.Add(this.tpgSupplier);
            this.tctlControl.Controls.Add(this.tpgEmployee);
            this.tctlControl.Controls.Add(this.tpgUserSetting);
            this.tctlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctlControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tctlControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.tctlControl.ItemSize = new System.Drawing.Size(55, 170);
            this.tctlControl.Location = new System.Drawing.Point(0, 0);
            this.tctlControl.Margin = new System.Windows.Forms.Padding(0);
            this.tctlControl.Multiline = true;
            this.tctlControl.Name = "tctlControl";
            this.tctlControl.Padding = new System.Drawing.Point(0, 0);
            this.tctlControl.SelectedIndex = 0;
            this.tctlControl.Size = new System.Drawing.Size(1163, 607);
            this.tctlControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tctlControl.TabIndex = 0;
            this.tctlControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tctlControl_DrawItem);
            // 
            // tpgBuy
            // 
            this.tpgBuy.Location = new System.Drawing.Point(174, 4);
            this.tpgBuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpgBuy.Name = "tpgBuy";
            this.tpgBuy.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpgBuy.Size = new System.Drawing.Size(985, 599);
            this.tpgBuy.TabIndex = 0;
            this.tpgBuy.Text = "Mua hàng";
            this.tpgBuy.UseVisualStyleBackColor = true;
            // 
            // tpgSell
            // 
            this.tpgSell.Location = new System.Drawing.Point(174, 4);
            this.tpgSell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpgSell.Name = "tpgSell";
            this.tpgSell.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpgSell.Size = new System.Drawing.Size(985, 599);
            this.tpgSell.TabIndex = 1;
            this.tpgSell.Text = "Bán hàng";
            this.tpgSell.UseVisualStyleBackColor = true;
            // 
            // tpgReceipt
            // 
            this.tpgReceipt.Location = new System.Drawing.Point(174, 4);
            this.tpgReceipt.Margin = new System.Windows.Forms.Padding(0);
            this.tpgReceipt.Name = "tpgReceipt";
            this.tpgReceipt.Size = new System.Drawing.Size(985, 599);
            this.tpgReceipt.TabIndex = 2;
            this.tpgReceipt.Text = "Hóa đơn";
            this.tpgReceipt.UseVisualStyleBackColor = true;
            // 
            // tpgMaterial
            // 
            this.tpgMaterial.Controls.Add(this.dgvMaterial);
            this.tpgMaterial.Location = new System.Drawing.Point(174, 4);
            this.tpgMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpgMaterial.Name = "tpgMaterial";
            this.tpgMaterial.Size = new System.Drawing.Size(985, 599);
            this.tpgMaterial.TabIndex = 3;
            this.tpgMaterial.Text = "Vật liệu";
            this.tpgMaterial.UseVisualStyleBackColor = true;
            this.tpgMaterial.Enter += new System.EventHandler(this.tpgMaterial_Enter);
            // 
            // dgvMaterial
            // 
            this.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterial.Location = new System.Drawing.Point(0, 0);
            this.dgvMaterial.Name = "dgvMaterial";
            this.dgvMaterial.RowHeadersWidth = 51;
            this.dgvMaterial.RowTemplate.Height = 24;
            this.dgvMaterial.Size = new System.Drawing.Size(985, 599);
            this.dgvMaterial.TabIndex = 0;
            // 
            // tpgStatistic
            // 
            this.tpgStatistic.Location = new System.Drawing.Point(174, 4);
            this.tpgStatistic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpgStatistic.Name = "tpgStatistic";
            this.tpgStatistic.Size = new System.Drawing.Size(985, 599);
            this.tpgStatistic.TabIndex = 4;
            this.tpgStatistic.Text = "Thống kê";
            this.tpgStatistic.UseVisualStyleBackColor = true;
            // 
            // tpgCustomer
            // 
            this.tpgCustomer.Location = new System.Drawing.Point(174, 4);
            this.tpgCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpgCustomer.Name = "tpgCustomer";
            this.tpgCustomer.Size = new System.Drawing.Size(985, 599);
            this.tpgCustomer.TabIndex = 5;
            this.tpgCustomer.Text = "Khách hàng";
            this.tpgCustomer.UseVisualStyleBackColor = true;
            // 
            // tpgSupplier
            // 
            this.tpgSupplier.Location = new System.Drawing.Point(174, 4);
            this.tpgSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpgSupplier.Name = "tpgSupplier";
            this.tpgSupplier.Size = new System.Drawing.Size(985, 599);
            this.tpgSupplier.TabIndex = 6;
            this.tpgSupplier.Text = "Nhà cung cấp";
            this.tpgSupplier.UseVisualStyleBackColor = true;
            // 
            // tpgEmployee
            // 
            this.tpgEmployee.Location = new System.Drawing.Point(174, 4);
            this.tpgEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpgEmployee.Name = "tpgEmployee";
            this.tpgEmployee.Size = new System.Drawing.Size(985, 599);
            this.tpgEmployee.TabIndex = 7;
            this.tpgEmployee.Text = "Nhân viên";
            this.tpgEmployee.UseVisualStyleBackColor = true;
            // 
            // tpgUserSetting
            // 
            this.tpgUserSetting.Controls.Add(this.flowLayoutPanel1);
            this.tpgUserSetting.Location = new System.Drawing.Point(174, 4);
            this.tpgUserSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpgUserSetting.Name = "tpgUserSetting";
            this.tpgUserSetting.Size = new System.Drawing.Size(985, 599);
            this.tpgUserSetting.TabIndex = 8;
            this.tpgUserSetting.Text = "Quản lý người dùng";
            this.tpgUserSetting.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCreateAccount_userSetting);
            this.flowLayoutPanel1.Controls.Add(this.btnChangePassword_userSetting);
            this.flowLayoutPanel1.Controls.Add(this.btnResetPassword_userSetting);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(989, 603);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnCreateAccount_userSetting
            // 
            this.btnCreateAccount_userSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreateAccount_userSetting.Image = global::BTL_LTTQ_QLKhoVLXD.Properties.Resources.user_add;
            this.btnCreateAccount_userSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateAccount_userSetting.Location = new System.Drawing.Point(40, 40);
            this.btnCreateAccount_userSetting.Margin = new System.Windows.Forms.Padding(20);
            this.btnCreateAccount_userSetting.Name = "btnCreateAccount_userSetting";
            this.btnCreateAccount_userSetting.Size = new System.Drawing.Size(206, 91);
            this.btnCreateAccount_userSetting.TabIndex = 0;
            this.btnCreateAccount_userSetting.Text = "Tạo tài khoản";
            this.btnCreateAccount_userSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateAccount_userSetting.UseVisualStyleBackColor = true;
            this.btnCreateAccount_userSetting.Click += new System.EventHandler(this.btnCreateAccount_userSetting_Click);
            // 
            // btnChangePassword_userSetting
            // 
            this.btnChangePassword_userSetting.Image = global::BTL_LTTQ_QLKhoVLXD.Properties.Resources._lock;
            this.btnChangePassword_userSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangePassword_userSetting.Location = new System.Drawing.Point(286, 40);
            this.btnChangePassword_userSetting.Margin = new System.Windows.Forms.Padding(20);
            this.btnChangePassword_userSetting.Name = "btnChangePassword_userSetting";
            this.btnChangePassword_userSetting.Size = new System.Drawing.Size(206, 91);
            this.btnChangePassword_userSetting.TabIndex = 1;
            this.btnChangePassword_userSetting.Text = "Đổi mật khẩu";
            this.btnChangePassword_userSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePassword_userSetting.UseVisualStyleBackColor = true;
            this.btnChangePassword_userSetting.Click += new System.EventHandler(this.btnChangePassword_userSetting_Click);
            // 
            // btnResetPassword_userSetting
            // 
            this.btnResetPassword_userSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnResetPassword_userSetting.Image = global::BTL_LTTQ_QLKhoVLXD.Properties.Resources.unlock;
            this.btnResetPassword_userSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetPassword_userSetting.Location = new System.Drawing.Point(532, 40);
            this.btnResetPassword_userSetting.Margin = new System.Windows.Forms.Padding(20);
            this.btnResetPassword_userSetting.Name = "btnResetPassword_userSetting";
            this.btnResetPassword_userSetting.Size = new System.Drawing.Size(206, 91);
            this.btnResetPassword_userSetting.TabIndex = 2;
            this.btnResetPassword_userSetting.Text = "Đặt lại mật khẩu";
            this.btnResetPassword_userSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetPassword_userSetting.UseVisualStyleBackColor = true;
            this.btnResetPassword_userSetting.Click += new System.EventHandler(this.btnResetPassword_userSetting_Click);
            // 
            // fTaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 664);
            this.Controls.Add(this.tctlControl);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(700, 711);
            this.Name = "fTaskManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Kho Vật Liệu Xây Dựng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTaskManager_FormClosing);
            this.Load += new System.EventHandler(this.fTaskManager_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tctlControl.ResumeLayout(false);
            this.tpgMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).EndInit();
            this.tpgUserSetting.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TabControl tctlControl;
        private System.Windows.Forms.TabPage tpgBuy;
        private System.Windows.Forms.TabPage tpgSell;
        private System.Windows.Forms.TabPage tpgReceipt;
        private System.Windows.Forms.TabPage tpgMaterial;
        private System.Windows.Forms.TabPage tpgStatistic;
        private System.Windows.Forms.TabPage tpgCustomer;
        private System.Windows.Forms.TabPage tpgSupplier;
        private System.Windows.Forms.TabPage tpgEmployee;
        private System.Windows.Forms.TabPage tpgUserSetting;
        private System.Windows.Forms.DataGridView dgvMaterial;
        private System.Windows.Forms.Button btnChangePassword_userSetting;
        private System.Windows.Forms.Button btnCreateAccount_userSetting;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnResetPassword_userSetting;
    }
}