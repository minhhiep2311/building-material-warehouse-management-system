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
            this.grbInfo = new BTL_LTTQ_QLKhoVLXD.Controls.GroupBox.BmwGroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnCreate = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnCancel = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.grbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInfo
            // 
            this.grbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.grbInfo.Controls.Add(this.textBox1);
            this.grbInfo.Controls.Add(this.label1);
            this.grbInfo.Controls.Add(this.txtPhone);
            this.grbInfo.Controls.Add(this.lblPhone);
            this.grbInfo.Controls.Add(this.txtAddress);
            this.grbInfo.Controls.Add(this.txtName);
            this.grbInfo.Controls.Add(this.lblName);
            this.grbInfo.Controls.Add(this.lblAddress);
            this.grbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grbInfo.ForeColor = System.Drawing.Color.White;
            this.grbInfo.Location = new System.Drawing.Point(9, 10);
            this.grbInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbInfo.Size = new System.Drawing.Size(349, 154);
            this.grbInfo.TabIndex = 4;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Thông tin khách hàng";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.textBox1.Location = new System.Drawing.Point(104, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 23);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã khách hàng";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtPhone.Location = new System.Drawing.Point(104, 113);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(235, 23);
            this.txtPhone.TabIndex = 10;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(4, 118);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(91, 17);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Số điện thoại";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtAddress.Location = new System.Drawing.Point(104, 83);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(235, 23);
            this.txtAddress.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtName.Location = new System.Drawing.Point(104, 51);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(235, 23);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(4, 56);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên khách hàng";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(4, 88);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 17);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.White;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnCreate.Location = new System.Drawing.Point(40, 168);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(97, 48);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Thêm khách hàng";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnCancel.Location = new System.Drawing.Point(232, 168);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 48);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // fCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(368, 230);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.grbInfo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fCustomer";
            this.Text = "Thêm khách hàng";
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BmwGroupBox grbInfo;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private BmwButton btnCreate;
        private BmwButton btnCancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}