
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
            this.tpgStatistic = new System.Windows.Forms.TabPage();
            this.tpgCustomer = new System.Windows.Forms.TabPage();
            this.tpgSupplier = new System.Windows.Forms.TabPage();
            this.tpgEmployee = new System.Windows.Forms.TabPage();
            this.tpgUserSetting = new System.Windows.Forms.TabPage();
            this.panel3.SuspendLayout();
            this.tctlControl.SuspendLayout();
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
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(292, 20);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(71, 17);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "Chức vụ:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(12, 20);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(96, 17);
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
            this.tpgSell.Size = new System.Drawing.Size(989, 607);
            this.tpgSell.TabIndex = 1;
            this.tpgSell.Text = "Bán hàng";
            this.tpgSell.UseVisualStyleBackColor = true;
            // 
            // tpgReceipt
            // 
            this.tpgReceipt.Location = new System.Drawing.Point(174, 4);
            this.tpgReceipt.Margin = new System.Windows.Forms.Padding(0);
            this.tpgReceipt.Name = "tpgReceipt";
            this.tpgReceipt.Size = new System.Drawing.Size(989, 607);
            this.tpgReceipt.TabIndex = 2;
            this.tpgReceipt.Text = "Hóa đơn";
            this.tpgReceipt.UseVisualStyleBackColor = true;
            // 
            // tpgMaterial
            // 
            this.tpgMaterial.Location = new System.Drawing.Point(174, 4);
            this.tpgMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpgMaterial.Name = "tpgMaterial";
            this.tpgMaterial.Size = new System.Drawing.Size(989, 607);
            this.tpgMaterial.TabIndex = 3;
            this.tpgMaterial.Text = "Vật liệu";
            this.tpgMaterial.UseVisualStyleBackColor = true;
            // 
            // tpgStatistic
            // 
            this.tpgStatistic.Location = new System.Drawing.Point(174, 4);
            this.tpgStatistic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpgStatistic.Name = "tpgStatistic";
            this.tpgStatistic.Size = new System.Drawing.Size(989, 607);
            this.tpgStatistic.TabIndex = 4;
            this.tpgStatistic.Text = "Thống kê";
            this.tpgStatistic.UseVisualStyleBackColor = true;
            // 
            // tpgCustomer
            // 
            this.tpgCustomer.Location = new System.Drawing.Point(174, 4);
            this.tpgCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpgCustomer.Name = "tpgCustomer";
            this.tpgCustomer.Size = new System.Drawing.Size(989, 607);
            this.tpgCustomer.TabIndex = 5;
            this.tpgCustomer.Text = "Khách hàng";
            this.tpgCustomer.UseVisualStyleBackColor = true;
            // 
            // tpgSupplier
            // 
            this.tpgSupplier.Location = new System.Drawing.Point(174, 4);
            this.tpgSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpgSupplier.Name = "tpgSupplier";
            this.tpgSupplier.Size = new System.Drawing.Size(989, 607);
            this.tpgSupplier.TabIndex = 6;
            this.tpgSupplier.Text = "Nhà cung cấp";
            this.tpgSupplier.UseVisualStyleBackColor = true;
            // 
            // tpgEmployee
            // 
            this.tpgEmployee.Location = new System.Drawing.Point(174, 4);
            this.tpgEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpgEmployee.Name = "tpgEmployee";
            this.tpgEmployee.Size = new System.Drawing.Size(989, 607);
            this.tpgEmployee.TabIndex = 7;
            this.tpgEmployee.Text = "Nhân viên";
            this.tpgEmployee.UseVisualStyleBackColor = true;
            // 
            // tpgUserSetting
            // 
            this.tpgUserSetting.Location = new System.Drawing.Point(174, 4);
            this.tpgUserSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpgUserSetting.Name = "tpgUserSetting";
            this.tpgUserSetting.Size = new System.Drawing.Size(989, 607);
            this.tpgUserSetting.TabIndex = 8;
            this.tpgUserSetting.Text = "Quản lý người dùng";
            this.tpgUserSetting.UseVisualStyleBackColor = true;
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tctlControl.ResumeLayout(false);
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
    }
}