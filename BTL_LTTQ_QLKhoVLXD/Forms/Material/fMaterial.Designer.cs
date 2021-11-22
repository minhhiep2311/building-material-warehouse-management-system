
namespace BTL_LTTQ_QLKhoVLXD.Forms.Material
{
    partial class fMaterial
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
            this.txtExportUnitPrice = new System.Windows.Forms.TextBox();
            this.lblExportUnitPrice = new System.Windows.Forms.Label();
            this.txtImportUnitPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblImportUnitPrice = new System.Windows.Forms.Label();
            this.chkEdit = new System.Windows.Forms.CheckBox();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnCancel = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnSave = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.txtSpecialization = new System.Windows.Forms.TextBox();
            this.grbInfo.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.txtSpecialization);
            this.grbInfo.Controls.Add(this.lblSpecialization);
            this.grbInfo.Controls.Add(this.txtExportUnitPrice);
            this.grbInfo.Controls.Add(this.lblExportUnitPrice);
            this.grbInfo.Controls.Add(this.txtImportUnitPrice);
            this.grbInfo.Controls.Add(this.txtName);
            this.grbInfo.Controls.Add(this.lblName);
            this.grbInfo.Controls.Add(this.lblImportUnitPrice);
            this.grbInfo.ForeColor = System.Drawing.Color.White;
            this.grbInfo.Location = new System.Drawing.Point(12, 23);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(659, 214);
            this.grbInfo.TabIndex = 6;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Thông tin vật liệu";
            // 
            // txtExportUnitPrice
            // 
            this.txtExportUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExportUnitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtExportUnitPrice.Location = new System.Drawing.Point(104, 119);
            this.txtExportUnitPrice.Name = "txtExportUnitPrice";
            this.txtExportUnitPrice.Size = new System.Drawing.Size(543, 26);
            this.txtExportUnitPrice.TabIndex = 6;
            // 
            // lblExportUnitPrice
            // 
            this.lblExportUnitPrice.AutoSize = true;
            this.lblExportUnitPrice.Location = new System.Drawing.Point(6, 119);
            this.lblExportUnitPrice.Name = "lblExportUnitPrice";
            this.lblExportUnitPrice.Size = new System.Drawing.Size(58, 17);
            this.lblExportUnitPrice.TabIndex = 5;
            this.lblExportUnitPrice.Text = "Giá bán";
            // 
            // txtImportUnitPrice
            // 
            this.txtImportUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImportUnitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtImportUnitPrice.Location = new System.Drawing.Point(104, 67);
            this.txtImportUnitPrice.Name = "txtImportUnitPrice";
            this.txtImportUnitPrice.Size = new System.Drawing.Size(543, 26);
            this.txtImportUnitPrice.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtName.Location = new System.Drawing.Point(104, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(543, 26);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên vật liệu";
            // 
            // lblImportUnitPrice
            // 
            this.lblImportUnitPrice.AutoSize = true;
            this.lblImportUnitPrice.Location = new System.Drawing.Point(6, 76);
            this.lblImportUnitPrice.Name = "lblImportUnitPrice";
            this.lblImportUnitPrice.Size = new System.Drawing.Size(66, 17);
            this.lblImportUnitPrice.TabIndex = 1;
            this.lblImportUnitPrice.Text = "Giá nhập";
            // 
            // chkEdit
            // 
            this.chkEdit.AutoSize = true;
            this.chkEdit.ForeColor = System.Drawing.Color.White;
            this.chkEdit.Location = new System.Drawing.Point(12, 261);
            this.chkEdit.Name = "chkEdit";
            this.chkEdit.Size = new System.Drawing.Size(152, 21);
            this.chkEdit.TabIndex = 20;
            this.chkEdit.Text = "Chỉnh sửa thông tin";
            this.chkEdit.UseVisualStyleBackColor = true;
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnCancel);
            this.pnlButton.Controls.Add(this.btnSave);
            this.pnlButton.Location = new System.Drawing.Point(99, 309);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(464, 58);
            this.pnlButton.TabIndex = 21;
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
            // lblSpecialization
            // 
            this.lblSpecialization.AutoSize = true;
            this.lblSpecialization.Location = new System.Drawing.Point(6, 169);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(68, 17);
            this.lblSpecialization.TabIndex = 7;
            this.lblSpecialization.Text = "Quy cách";
            // 
            // txtSpecialization
            // 
            this.txtSpecialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtSpecialization.Location = new System.Drawing.Point(104, 163);
            this.txtSpecialization.Name = "txtSpecialization";
            this.txtSpecialization.Size = new System.Drawing.Size(543, 26);
            this.txtSpecialization.TabIndex = 8;
            // 
            // fMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(678, 378);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.chkEdit);
            this.Controls.Add(this.grbInfo);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "fMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin vật liệu";
            this.Load += new System.EventHandler(this.fMaterial_Load);
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.TextBox txtImportUnitPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblImportUnitPrice;
        private System.Windows.Forms.TextBox txtExportUnitPrice;
        private System.Windows.Forms.Label lblExportUnitPrice;
        private System.Windows.Forms.CheckBox chkEdit;
        private System.Windows.Forms.Panel pnlButton;
        private Controls.Button.BmwButton btnCancel;
        private Controls.Button.BmwButton btnSave;
        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.Label lblSpecialization;
    }
}