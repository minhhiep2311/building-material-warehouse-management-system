using BTL_LTTQ_QLKhoVLXD.Controls.Button;
using BTL_LTTQ_QLKhoVLXD.Controls.GroupBox;

namespace BTL_LTTQ_QLKhoVLXD.Forms.Customer
{
    partial class fCustomer
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
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.grbPhone = new System.Windows.Forms.GroupBox();
            this.btnModifyPhone = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.lvwPhone = new System.Windows.Forms.ListView();
            this.btnRemovePhone = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnAddPhone = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.chkEdit = new System.Windows.Forms.CheckBox();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnCancel = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnSave = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.grbInfo.SuspendLayout();
            this.grbPhone.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.txtAddress);
            this.grbInfo.Controls.Add(this.txtName);
            this.grbInfo.Controls.Add(this.lblName);
            this.grbInfo.Controls.Add(this.lblAddress);
            this.grbInfo.ForeColor = System.Drawing.Color.White;
            this.grbInfo.Location = new System.Drawing.Point(12, 26);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(841, 114);
            this.grbInfo.TabIndex = 6;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Thông tin khách hàng";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtAddress.Location = new System.Drawing.Point(147, 67);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(680, 26);
            this.txtAddress.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtName.Location = new System.Drawing.Point(147, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(680, 26);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên khách hàng";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 67);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 17);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // grbPhone
            // 
            this.grbPhone.Controls.Add(this.btnModifyPhone);
            this.grbPhone.Controls.Add(this.lvwPhone);
            this.grbPhone.Controls.Add(this.btnRemovePhone);
            this.grbPhone.Controls.Add(this.btnAddPhone);
            this.grbPhone.ForeColor = System.Drawing.Color.White;
            this.grbPhone.Location = new System.Drawing.Point(12, 161);
            this.grbPhone.Name = "grbPhone";
            this.grbPhone.Size = new System.Drawing.Size(841, 114);
            this.grbPhone.TabIndex = 21;
            this.grbPhone.TabStop = false;
            this.grbPhone.Text = "Số điện thoại";
            // 
            // btnModifyPhone
            // 
            this.btnModifyPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnModifyPhone.Enabled = false;
            this.btnModifyPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnModifyPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnModifyPhone.Location = new System.Drawing.Point(673, 53);
            this.btnModifyPhone.Name = "btnModifyPhone";
            this.btnModifyPhone.Size = new System.Drawing.Size(145, 26);
            this.btnModifyPhone.TabIndex = 9;
            this.btnModifyPhone.Text = "Chỉnh sửa";
            this.btnModifyPhone.UseVisualStyleBackColor = false;
            this.btnModifyPhone.Click += new System.EventHandler(this.btnModifyPhone_Click);
            // 
            // lvwPhone
            // 
            this.lvwPhone.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvwPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.lvwPhone.FullRowSelect = true;
            this.lvwPhone.GridLines = true;
            this.lvwPhone.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvwPhone.HideSelection = false;
            this.lvwPhone.LabelEdit = true;
            this.lvwPhone.Location = new System.Drawing.Point(3, 18);
            this.lvwPhone.Name = "lvwPhone";
            this.lvwPhone.Size = new System.Drawing.Size(653, 93);
            this.lvwPhone.TabIndex = 7;
            this.lvwPhone.UseCompatibleStateImageBehavior = false;
            this.lvwPhone.View = System.Windows.Forms.View.Details;
            // 
            // btnRemovePhone
            // 
            this.btnRemovePhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnRemovePhone.Enabled = false;
            this.btnRemovePhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRemovePhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnRemovePhone.Location = new System.Drawing.Point(673, 82);
            this.btnRemovePhone.Name = "btnRemovePhone";
            this.btnRemovePhone.Size = new System.Drawing.Size(145, 26);
            this.btnRemovePhone.TabIndex = 10;
            this.btnRemovePhone.Text = "Xóa";
            this.btnRemovePhone.UseVisualStyleBackColor = false;
            this.btnRemovePhone.Click += new System.EventHandler(this.btnRemovePhone_Click);
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnAddPhone.Enabled = false;
            this.btnAddPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnAddPhone.Location = new System.Drawing.Point(673, 21);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(145, 26);
            this.btnAddPhone.TabIndex = 8;
            this.btnAddPhone.Text = "Thêm";
            this.btnAddPhone.UseVisualStyleBackColor = false;
            this.btnAddPhone.Click += new System.EventHandler(this.btnAddPhone_Click);
            // 
            // chkEdit
            // 
            this.chkEdit.AutoSize = true;
            this.chkEdit.ForeColor = System.Drawing.Color.White;
            this.chkEdit.Location = new System.Drawing.Point(12, 296);
            this.chkEdit.Name = "chkEdit";
            this.chkEdit.Size = new System.Drawing.Size(152, 21);
            this.chkEdit.TabIndex = 22;
            this.chkEdit.Text = "Chỉnh sửa thông tin";
            this.chkEdit.UseVisualStyleBackColor = true;
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnCancel);
            this.pnlButton.Controls.Add(this.btnSave);
            this.pnlButton.Location = new System.Drawing.Point(204, 327);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(464, 58);
            this.pnlButton.TabIndex = 23;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnCancel.Location = new System.Drawing.Point(291, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 45);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnSave.Location = new System.Drawing.Point(22, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 45);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Lưu thay đổi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // fCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(863, 393);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.chkEdit);
            this.Controls.Add(this.grbPhone);
            this.Controls.Add(this.grbInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin khách hàng";
            this.Load += new System.EventHandler(this.fCustomer_Load);
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            this.grbPhone.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.GroupBox grbPhone;
        private BmwButton btnModifyPhone;
        private System.Windows.Forms.ListView lvwPhone;
        private BmwButton btnRemovePhone;
        private BmwButton btnAddPhone;
        private System.Windows.Forms.CheckBox chkEdit;
        private System.Windows.Forms.Panel pnlButton;
        private BmwButton btnCancel;
        private BmwButton btnSave;
    }
}