
using BTL_LTTQ_QLKhoVLXD.Controls;
using BTL_LTTQ_QLKhoVLXD.Controls.Button;
using BTL_LTTQ_QLKhoVLXD.Controls.ListView;

namespace BTL_LTTQ_QLKhoVLXD.Forms.ChangeInformation
{
    partial class fChangeInformation
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
            this.btnSave = new BmwButton();
            this.btnCancel = new BmwButton();
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.pnlAddress = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.pnlGender = new System.Windows.Forms.Panel();
            this.lblGender = new System.Windows.Forms.Label();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.lblDob = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnModifyPhone = new BmwButton();
            this.lvwPhone = new BmwListView();
            this.btnRemovePhone = new BmwButton();
            this.btnAddPhone = new BmwButton();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnChangePassword = new BmwButton();
            this.grbInfo.SuspendLayout();
            this.pnlAddress.SuspendLayout();
            this.pnlGender.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(193, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 38);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu thay đổi";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(368, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 38);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.pnlAddress);
            this.grbInfo.Controls.Add(this.pnlGender);
            this.grbInfo.Controls.Add(this.panel2);
            this.grbInfo.Controls.Add(this.panel1);
            this.grbInfo.ForeColor = System.Drawing.Color.White;
            this.grbInfo.Location = new System.Drawing.Point(12, 12);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(505, 177);
            this.grbInfo.TabIndex = 10;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Thông tin cá nhân";
            // 
            // pnlAddress
            // 
            this.pnlAddress.Controls.Add(this.txtAddress);
            this.pnlAddress.Controls.Add(this.lblAddress);
            this.pnlAddress.Location = new System.Drawing.Point(3, 136);
            this.pnlAddress.Name = "pnlAddress";
            this.pnlAddress.Size = new System.Drawing.Size(496, 32);
            this.pnlAddress.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtAddress.Location = new System.Drawing.Point(79, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(413, 26);
            this.txtAddress.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(3, 8);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 17);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // pnlGender
            // 
            this.pnlGender.Controls.Add(this.lblGender);
            this.pnlGender.Controls.Add(this.rdoFemale);
            this.pnlGender.Controls.Add(this.rdoMale);
            this.pnlGender.Location = new System.Drawing.Point(3, 106);
            this.pnlGender.Name = "pnlGender";
            this.pnlGender.Size = new System.Drawing.Size(496, 23);
            this.pnlGender.TabIndex = 12;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(3, 3);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 17);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Giới tính";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Enabled = false;
            this.rdoFemale.Location = new System.Drawing.Point(174, 1);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(47, 21);
            this.rdoFemale.TabIndex = 10;
            this.rdoFemale.Text = "Nữ";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Enabled = false;
            this.rdoMale.Location = new System.Drawing.Point(79, 1);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(58, 21);
            this.rdoMale.TabIndex = 9;
            this.rdoMale.Text = "Nam";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDob);
            this.panel2.Controls.Add(this.lblDob);
            this.panel2.Location = new System.Drawing.Point(3, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 39);
            this.panel2.TabIndex = 0;
            // 
            // txtDob
            // 
            this.txtDob.Enabled = false;
            this.txtDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtDob.Location = new System.Drawing.Point(80, 8);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(413, 26);
            this.txtDob.TabIndex = 3;
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(3, 12);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(71, 17);
            this.lblDob.TabIndex = 1;
            this.lblDob.Text = "Ngày sinh";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 38);
            this.panel1.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtName.Location = new System.Drawing.Point(78, 7);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(415, 26);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ và tên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnModifyPhone);
            this.groupBox1.Controls.Add(this.lvwPhone);
            this.groupBox1.Controls.Add(this.btnRemovePhone);
            this.groupBox1.Controls.Add(this.btnAddPhone);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(524, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 114);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Số điện thoại";
            // 
            // btnModifyPhone
            // 
            this.btnModifyPhone.Location = new System.Drawing.Point(351, 53);
            this.btnModifyPhone.Name = "btnModifyPhone";
            this.btnModifyPhone.Size = new System.Drawing.Size(145, 26);
            this.btnModifyPhone.TabIndex = 14;
            this.btnModifyPhone.Text = "Chỉnh sửa";
            this.btnModifyPhone.Click += new System.EventHandler(this.btnModifyPhone_Click);
            // 
            // lvwPhone
            // 
            this.lvwPhone.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvwPhone.LabelEdit = true;
            this.lvwPhone.Location = new System.Drawing.Point(6, 21);
            this.lvwPhone.Name = "lvwPhone";
            this.lvwPhone.Size = new System.Drawing.Size(339, 88);
            this.lvwPhone.TabIndex = 12;
            this.lvwPhone.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lvwPhone_AfterLabelEdit);
            this.lvwPhone.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lvwPhone_BeforeLabelEdit);
            this.lvwPhone.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwPhone_MouseDoubleClick);
            // 
            // btnRemovePhone
            // 
            this.btnRemovePhone.Location = new System.Drawing.Point(351, 83);
            this.btnRemovePhone.Name = "btnRemovePhone";
            this.btnRemovePhone.Size = new System.Drawing.Size(145, 26);
            this.btnRemovePhone.TabIndex = 13;
            this.btnRemovePhone.Text = "Xóa";
            this.btnRemovePhone.Click += new System.EventHandler(this.btnRemovePhone_Click);
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.Location = new System.Drawing.Point(351, 21);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(145, 26);
            this.btnAddPhone.TabIndex = 5;
            this.btnAddPhone.Text = "Thêm";
            this.btnAddPhone.Click += new System.EventHandler(this.btnAddPhone_Click);
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnChangePassword);
            this.pnlButton.Controls.Add(this.btnCancel);
            this.pnlButton.Controls.Add(this.btnSave);
            this.pnlButton.Location = new System.Drawing.Point(523, 132);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(506, 57);
            this.pnlButton.TabIndex = 12;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(19, 10);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(129, 38);
            this.btnChangePassword.TabIndex = 8;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // fChangeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1041, 197);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fChangeInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chỉnh sửa thông tin";
            this.Load += new System.EventHandler(this.fChangeInformation_Load);
            this.grbInfo.ResumeLayout(false);
            this.pnlAddress.ResumeLayout(false);
            this.pnlAddress.PerformLayout();
            this.pnlGender.ResumeLayout(false);
            this.pnlGender.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private BmwButton btnSave;
        private BmwButton btnCancel;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDob;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Panel pnlGender;
        private System.Windows.Forms.Panel pnlAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private BmwListView lvwPhone;
        private BmwButton btnRemovePhone;
        private BmwButton btnAddPhone;
        private System.Windows.Forms.Panel pnlButton;
        private BmwButton btnModifyPhone;
        private BmwButton btnChangePassword;
    }
}