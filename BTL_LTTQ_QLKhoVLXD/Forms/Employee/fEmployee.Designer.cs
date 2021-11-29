using BTL_LTTQ_QLKhoVLXD.Controls.Button;
using BTL_LTTQ_QLKhoVLXD.Controls.ComboBox;
using BTL_LTTQ_QLKhoVLXD.Controls.GroupBox;
using BTL_LTTQ_QLKhoVLXD.Controls.ListView;

namespace BTL_LTTQ_QLKhoVLXD.Forms.Employee
{
    partial class fEmployee
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
            this.grbInfo = new BTL_LTTQ_QLKhoVLXD.Controls.GroupBox.BmwGroupBox();
            this.pnlPosition = new System.Windows.Forms.Panel();
            this.lblPosition = new System.Windows.Forms.Label();
            this.cboPosition = new BTL_LTTQ_QLKhoVLXD.Controls.ComboBox.BmwComboBox();
            this.pnlAddress = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.pnlGender = new System.Windows.Forms.Panel();
            this.lblGender = new System.Windows.Forms.Label();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.lblDob = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.grbPhone = new System.Windows.Forms.GroupBox();
            this.btnModifyPhone = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.lvwPhone = new System.Windows.Forms.ListView();
            this.btnRemovePhone = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnAddPhone = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnCancel = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnSave = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.chkEdit = new System.Windows.Forms.CheckBox();
            this.grbInfo.SuspendLayout();
            this.pnlPosition.SuspendLayout();
            this.pnlAddress.SuspendLayout();
            this.pnlGender.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbPhone.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInfo
            // 
            this.grbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.grbInfo.Controls.Add(this.pnlPosition);
            this.grbInfo.Controls.Add(this.pnlAddress);
            this.grbInfo.Controls.Add(this.pnlGender);
            this.grbInfo.Controls.Add(this.panel2);
            this.grbInfo.Controls.Add(this.panel1);
            this.grbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grbInfo.ForeColor = System.Drawing.Color.White;
            this.grbInfo.Location = new System.Drawing.Point(12, 12);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(505, 213);
            this.grbInfo.TabIndex = 0;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Thông tin cá nhân";
            // 
            // pnlPosition
            // 
            this.pnlPosition.Controls.Add(this.lblPosition);
            this.pnlPosition.Controls.Add(this.cboPosition);
            this.pnlPosition.Location = new System.Drawing.Point(3, 174);
            this.pnlPosition.Name = "pnlPosition";
            this.pnlPosition.Size = new System.Drawing.Size(496, 32);
            this.pnlPosition.TabIndex = 13;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(3, 8);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(70, 20);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "Chức vụ";
            // 
            // cboPosition
            // 
            this.cboPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.cboPosition.Location = new System.Drawing.Point(102, 3);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(390, 26);
            this.cboPosition.TabIndex = 6;
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
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtAddress.Location = new System.Drawing.Point(102, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(390, 24);
            this.txtAddress.TabIndex = 5;
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
            this.rdoFemale.Location = new System.Drawing.Point(228, 0);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(51, 24);
            this.rdoFemale.TabIndex = 4;
            this.rdoFemale.Text = "Nữ";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Enabled = false;
            this.rdoMale.Location = new System.Drawing.Point(102, 3);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(65, 24);
            this.rdoMale.TabIndex = 3;
            this.rdoMale.Text = "Nam";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpDob);
            this.panel2.Controls.Add(this.lblDob);
            this.panel2.Location = new System.Drawing.Point(3, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 39);
            this.panel2.TabIndex = 2;
            // 
            // dtpDob
            // 
            this.dtpDob.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.dtpDob.CustomFormat = "                                  dd-MM-yyyy";
            this.dtpDob.Enabled = false;
            this.dtpDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDob.Location = new System.Drawing.Point(102, 6);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(390, 25);
            this.dtpDob.TabIndex = 2;
            this.dtpDob.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
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
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtName.Location = new System.Drawing.Point(102, 7);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(391, 24);
            this.txtName.TabIndex = 1;
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
            // grbPhone
            // 
            this.grbPhone.Controls.Add(this.btnModifyPhone);
            this.grbPhone.Controls.Add(this.lvwPhone);
            this.grbPhone.Controls.Add(this.btnRemovePhone);
            this.grbPhone.Controls.Add(this.btnAddPhone);
            this.grbPhone.ForeColor = System.Drawing.Color.White;
            this.grbPhone.Location = new System.Drawing.Point(523, 12);
            this.grbPhone.Name = "grbPhone";
            this.grbPhone.Size = new System.Drawing.Size(505, 129);
            this.grbPhone.TabIndex = 12;
            this.grbPhone.TabStop = false;
            this.grbPhone.Text = "Số điện thoại";
            // 
            // btnModifyPhone
            // 
            this.btnModifyPhone.BackColor = System.Drawing.Color.White;
            this.btnModifyPhone.Enabled = false;
            this.btnModifyPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnModifyPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnModifyPhone.Location = new System.Drawing.Point(351, 55);
            this.btnModifyPhone.Name = "btnModifyPhone";
            this.btnModifyPhone.Size = new System.Drawing.Size(145, 30);
            this.btnModifyPhone.TabIndex = 9;
            this.btnModifyPhone.Text = "Chỉnh sửa";
            this.btnModifyPhone.UseVisualStyleBackColor = false;
            this.btnModifyPhone.Click += new System.EventHandler(this.btnModifyPhone_Click);
            // 
            // lvwPhone
            // 
            this.lvwPhone.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvwPhone.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvwPhone.HideSelection = false;
            this.lvwPhone.LabelEdit = true;
            this.lvwPhone.Location = new System.Drawing.Point(3, 18);
            this.lvwPhone.Name = "lvwPhone";
            this.lvwPhone.Size = new System.Drawing.Size(339, 108);
            this.lvwPhone.TabIndex = 7;
            this.lvwPhone.UseCompatibleStateImageBehavior = false;
            this.lvwPhone.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwPhone_MouseDoubleClick);
            // 
            // btnRemovePhone
            // 
            this.btnRemovePhone.BackColor = System.Drawing.Color.White;
            this.btnRemovePhone.Enabled = false;
            this.btnRemovePhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRemovePhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnRemovePhone.Location = new System.Drawing.Point(351, 91);
            this.btnRemovePhone.Name = "btnRemovePhone";
            this.btnRemovePhone.Size = new System.Drawing.Size(145, 30);
            this.btnRemovePhone.TabIndex = 10;
            this.btnRemovePhone.Text = "Xóa";
            this.btnRemovePhone.UseVisualStyleBackColor = false;
            this.btnRemovePhone.Click += new System.EventHandler(this.btnRemovePhone_Click);
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.BackColor = System.Drawing.Color.White;
            this.btnAddPhone.Enabled = false;
            this.btnAddPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnAddPhone.Location = new System.Drawing.Point(351, 19);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(145, 30);
            this.btnAddPhone.TabIndex = 8;
            this.btnAddPhone.Text = "Thêm";
            this.btnAddPhone.UseVisualStyleBackColor = false;
            this.btnAddPhone.Click += new System.EventHandler(this.btnAddPhone_Click);
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnCancel);
            this.pnlButton.Controls.Add(this.btnSave);
            this.pnlButton.Location = new System.Drawing.Point(523, 185);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(506, 40);
            this.pnlButton.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnCancel.Location = new System.Drawing.Point(285, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 38);
            this.btnCancel.TabIndex = 13;
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
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(54, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 38);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Lưu thay đổi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkEdit
            // 
            this.chkEdit.AutoSize = true;
            this.chkEdit.Location = new System.Drawing.Point(526, 150);
            this.chkEdit.Name = "chkEdit";
            this.chkEdit.Size = new System.Drawing.Size(152, 21);
            this.chkEdit.TabIndex = 11;
            this.chkEdit.Text = "Chỉnh sửa thông tin";
            this.chkEdit.UseVisualStyleBackColor = true;
            this.chkEdit.CheckedChanged += new System.EventHandler(this.chkEdit_CheckedChanged);
            // 
            // fEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1043, 253);
            this.Controls.Add(this.chkEdit);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.grbPhone);
            this.Controls.Add(this.grbInfo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fEmployee_FormClosing);
            this.Load += new System.EventHandler(this.fEmployee_Load);
            this.grbInfo.ResumeLayout(false);
            this.pnlPosition.ResumeLayout(false);
            this.pnlPosition.PerformLayout();
            this.pnlAddress.ResumeLayout(false);
            this.pnlAddress.PerformLayout();
            this.pnlGender.ResumeLayout(false);
            this.pnlGender.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbPhone.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Panel pnlGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grbPhone;
        private BmwButton btnModifyPhone;
        private System.Windows.Forms.ListView lvwPhone;
        private BmwButton btnRemovePhone;
        private BmwButton btnAddPhone;
        private System.Windows.Forms.Panel pnlButton;
        private BmwButton btnCancel;
        private BmwButton btnSave;
        private System.Windows.Forms.CheckBox chkEdit;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.Panel pnlPosition;
        private System.Windows.Forms.Label lblPosition;
        private BmwComboBox cboPosition;
        private BmwGroupBox grbInfo;
    }
}