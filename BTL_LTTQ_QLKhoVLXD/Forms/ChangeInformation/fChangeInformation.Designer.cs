using BTL_LTTQ_QLKhoVLXD.Controls.Button;
using BTL_LTTQ_QLKhoVLXD.Controls.GroupBox;
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
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnChangePassword = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnCancel = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnSave = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.grbPhone = new BTL_LTTQ_QLKhoVLXD.Controls.GroupBox.BmwGroupBox();
            this.btnModifyPhone = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.lvwPhone = new BTL_LTTQ_QLKhoVLXD.Controls.ListView.BmwListView();
            this.btnRemovePhone = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnAddPhone = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.grbInfo = new BTL_LTTQ_QLKhoVLXD.Controls.GroupBox.BmwGroupBox();
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
            this.pnlButton.SuspendLayout();
            this.grbPhone.SuspendLayout();
            this.grbInfo.SuspendLayout();
            this.pnlAddress.SuspendLayout();
            this.pnlGender.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnChangePassword);
            this.pnlButton.Controls.Add(this.btnCancel);
            this.pnlButton.Controls.Add(this.btnSave);
            this.pnlButton.Location = new System.Drawing.Point(194, 214);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(685, 57);
            this.pnlButton.TabIndex = 12;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.White;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnChangePassword.Location = new System.Drawing.Point(19, 10);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(168, 38);
            this.btnChangePassword.TabIndex = 8;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnCancel.Location = new System.Drawing.Point(502, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(168, 38);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnSave.Location = new System.Drawing.Point(255, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 38);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu thay đổi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grbPhone
            // 
            this.grbPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.grbPhone.Controls.Add(this.btnModifyPhone);
            this.grbPhone.Controls.Add(this.lvwPhone);
            this.grbPhone.Controls.Add(this.btnRemovePhone);
            this.grbPhone.Controls.Add(this.btnAddPhone);
            this.grbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grbPhone.ForeColor = System.Drawing.Color.White;
            this.grbPhone.Location = new System.Drawing.Point(524, 12);
            this.grbPhone.Name = "grbPhone";
            this.grbPhone.Size = new System.Drawing.Size(505, 177);
            this.grbPhone.TabIndex = 11;
            this.grbPhone.TabStop = false;
            this.grbPhone.Text = "Số điện thoại";
            // 
            // btnModifyPhone
            // 
            this.btnModifyPhone.BackColor = System.Drawing.Color.White;
            this.btnModifyPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnModifyPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnModifyPhone.Location = new System.Drawing.Point(351, 62);
            this.btnModifyPhone.Name = "btnModifyPhone";
            this.btnModifyPhone.Size = new System.Drawing.Size(145, 30);
            this.btnModifyPhone.TabIndex = 14;
            this.btnModifyPhone.Text = "Chỉnh sửa";
            this.btnModifyPhone.UseVisualStyleBackColor = false;
            this.btnModifyPhone.Click += new System.EventHandler(this.btnModifyPhone_Click);
            // 
            // lvwPhone
            // 
            this.lvwPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.lvwPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lvwPhone.ForeColor = System.Drawing.Color.White;
            this.lvwPhone.FullRowSelect = true;
            this.lvwPhone.GridLines = true;
            this.lvwPhone.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvwPhone.HideSelection = false;
            this.lvwPhone.LabelEdit = true;
            this.lvwPhone.Location = new System.Drawing.Point(6, 22);
            this.lvwPhone.Name = "lvwPhone";
            this.lvwPhone.OwnerDraw = true;
            this.lvwPhone.Size = new System.Drawing.Size(342, 142);
            this.lvwPhone.Sortable = true;
            this.lvwPhone.SortableColumns = null;
            this.lvwPhone.TabIndex = 12;
            this.lvwPhone.UseCompatibleStateImageBehavior = false;
            this.lvwPhone.View = System.Windows.Forms.View.Details;
            this.lvwPhone.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lvwPhone_AfterLabelEdit);
            this.lvwPhone.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lvwPhone_BeforeLabelEdit);
            this.lvwPhone.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwPhone_MouseDoubleClick);
            // 
            // btnRemovePhone
            // 
            this.btnRemovePhone.BackColor = System.Drawing.Color.White;
            this.btnRemovePhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRemovePhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnRemovePhone.Location = new System.Drawing.Point(351, 104);
            this.btnRemovePhone.Name = "btnRemovePhone";
            this.btnRemovePhone.Size = new System.Drawing.Size(145, 30);
            this.btnRemovePhone.TabIndex = 13;
            this.btnRemovePhone.Text = "Xóa";
            this.btnRemovePhone.UseVisualStyleBackColor = false;
            this.btnRemovePhone.Click += new System.EventHandler(this.btnRemovePhone_Click);
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.BackColor = System.Drawing.Color.White;
            this.btnAddPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnAddPhone.Location = new System.Drawing.Point(351, 22);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(145, 30);
            this.btnAddPhone.TabIndex = 5;
            this.btnAddPhone.Text = "Thêm";
            this.btnAddPhone.UseVisualStyleBackColor = false;
            this.btnAddPhone.Click += new System.EventHandler(this.btnAddPhone_Click);
            // 
            // grbInfo
            // 
            this.grbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.grbInfo.Controls.Add(this.pnlAddress);
            this.grbInfo.Controls.Add(this.pnlGender);
            this.grbInfo.Controls.Add(this.panel2);
            this.grbInfo.Controls.Add(this.panel1);
            this.grbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
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
            this.txtAddress.Location = new System.Drawing.Point(106, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(386, 26);
            this.txtAddress.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(3, 8);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 20);
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
            this.lblGender.Size = new System.Drawing.Size(71, 20);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Giới tính";
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Enabled = false;
            this.rdoFemale.Location = new System.Drawing.Point(215, 1);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(51, 24);
            this.rdoFemale.TabIndex = 10;
            this.rdoFemale.Text = "Nữ";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Enabled = false;
            this.rdoMale.Location = new System.Drawing.Point(106, 1);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(65, 24);
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
            this.txtDob.Location = new System.Drawing.Point(106, 8);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(387, 26);
            this.txtDob.TabIndex = 3;
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(3, 12);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(83, 20);
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
            this.txtName.Location = new System.Drawing.Point(106, 7);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(387, 26);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ và tên";
            // 
            // fChangeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1041, 283);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.grbPhone);
            this.Controls.Add(this.grbInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fChangeInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chỉnh sửa thông tin";
            this.Load += new System.EventHandler(this.fChangeInformation_Load);
            this.pnlButton.ResumeLayout(false);
            this.grbPhone.ResumeLayout(false);
            this.grbInfo.ResumeLayout(false);
            this.pnlAddress.ResumeLayout(false);
            this.pnlAddress.PerformLayout();
            this.pnlGender.ResumeLayout(false);
            this.pnlGender.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private BmwButton btnSave;
        private BmwButton btnCancel;
        private BmwGroupBox grbInfo;
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
        private BmwGroupBox grbPhone;
        private BmwListView lvwPhone;
        private BmwButton btnRemovePhone;
        private BmwButton btnAddPhone;
        private System.Windows.Forms.Panel pnlButton;
        private BmwButton btnModifyPhone;
        private BmwButton btnChangePassword;
    }
}