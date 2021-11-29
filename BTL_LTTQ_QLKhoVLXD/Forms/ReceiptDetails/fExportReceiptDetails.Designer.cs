
namespace BTL_LTTQ_QLKhoVLXD.Forms.ReceiptDetails
{
    partial class fExportReceiptDetails
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.pnlInfor = new System.Windows.Forms.Panel();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.txtWarehouse = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.grbMaterial = new BTL_LTTQ_QLKhoVLXD.Controls.GroupBox.BmwGroupBox();
            this.lvwMaterial = new BTL_LTTQ_QLKhoVLXD.Controls.ListView.BmwListView();
            this.btnExport = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.btnExit = new BTL_LTTQ_QLKhoVLXD.Controls.Button.BmwButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlInfor.SuspendLayout();
            this.grbMaterial.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtId.Location = new System.Drawing.Point(181, 10);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(581, 26);
            this.txtId.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(10, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(83, 17);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Mã hóa đơn";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(10, 50);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(152, 17);
            this.lblEmployee.TabIndex = 6;
            this.lblEmployee.Text = "Nhân viên tạo hóa đơn";
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.Location = new System.Drawing.Point(10, 118);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(33, 17);
            this.lblWarehouse.TabIndex = 7;
            this.lblWarehouse.Text = "Kho";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(10, 254);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(68, 17);
            this.lblTotalPrice.TabIndex = 8;
            this.lblTotalPrice.Text = "Tổng tiền";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(10, 186);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(64, 17);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Ngày lập";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(10, 84);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(84, 17);
            this.lblCustomer.TabIndex = 10;
            this.lblCustomer.Text = "Khách hàng";
            // 
            // pnlInfor
            // 
            this.pnlInfor.Controls.Add(this.txtTotalPrice);
            this.pnlInfor.Controls.Add(this.txtReason);
            this.pnlInfor.Controls.Add(this.txtDate);
            this.pnlInfor.Controls.Add(this.txtVat);
            this.pnlInfor.Controls.Add(this.txtWarehouse);
            this.pnlInfor.Controls.Add(this.txtCustomer);
            this.pnlInfor.Controls.Add(this.txtEmployee);
            this.pnlInfor.Controls.Add(this.lblId);
            this.pnlInfor.Controls.Add(this.lblEmployee);
            this.pnlInfor.Controls.Add(this.lblReason);
            this.pnlInfor.Controls.Add(this.lblWarehouse);
            this.pnlInfor.Controls.Add(this.txtId);
            this.pnlInfor.Controls.Add(this.lblTotalPrice);
            this.pnlInfor.Controls.Add(this.lblVat);
            this.pnlInfor.Controls.Add(this.lblDate);
            this.pnlInfor.Controls.Add(this.lblCustomer);
            this.pnlInfor.Location = new System.Drawing.Point(8, 12);
            this.pnlInfor.Name = "pnlInfor";
            this.pnlInfor.Size = new System.Drawing.Size(780, 291);
            this.pnlInfor.TabIndex = 15;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtTotalPrice.Location = new System.Drawing.Point(181, 248);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(581, 26);
            this.txtTotalPrice.TabIndex = 21;
            // 
            // txtReason
            // 
            this.txtReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtReason.Location = new System.Drawing.Point(181, 214);
            this.txtReason.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReason.Name = "txtReason";
            this.txtReason.ReadOnly = true;
            this.txtReason.Size = new System.Drawing.Size(581, 26);
            this.txtReason.TabIndex = 20;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtDate.Location = new System.Drawing.Point(181, 180);
            this.txtDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(581, 26);
            this.txtDate.TabIndex = 19;
            // 
            // txtVat
            // 
            this.txtVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtVat.Location = new System.Drawing.Point(181, 146);
            this.txtVat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVat.Name = "txtVat";
            this.txtVat.ReadOnly = true;
            this.txtVat.Size = new System.Drawing.Size(581, 26);
            this.txtVat.TabIndex = 17;
            // 
            // txtWarehouse
            // 
            this.txtWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWarehouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtWarehouse.Location = new System.Drawing.Point(181, 112);
            this.txtWarehouse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWarehouse.Name = "txtWarehouse";
            this.txtWarehouse.ReadOnly = true;
            this.txtWarehouse.Size = new System.Drawing.Size(581, 26);
            this.txtWarehouse.TabIndex = 16;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtCustomer.Location = new System.Drawing.Point(181, 78);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(581, 26);
            this.txtCustomer.TabIndex = 15;
            // 
            // txtEmployee
            // 
            this.txtEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.txtEmployee.Location = new System.Drawing.Point(181, 44);
            this.txtEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.ReadOnly = true;
            this.txtEmployee.Size = new System.Drawing.Size(581, 26);
            this.txtEmployee.TabIndex = 14;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(10, 220);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(43, 17);
            this.lblReason.TabIndex = 13;
            this.lblReason.Text = "Lý do";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Location = new System.Drawing.Point(10, 152);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(35, 17);
            this.lblVat.TabIndex = 11;
            this.lblVat.Text = "VAT";
            // 
            // grbMaterial
            // 
            this.grbMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.grbMaterial.Controls.Add(this.lvwMaterial);
            this.grbMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grbMaterial.ForeColor = System.Drawing.Color.White;
            this.grbMaterial.Location = new System.Drawing.Point(8, 309);
            this.grbMaterial.Name = "grbMaterial";
            this.grbMaterial.Size = new System.Drawing.Size(780, 232);
            this.grbMaterial.TabIndex = 16;
            this.grbMaterial.TabStop = false;
            this.grbMaterial.Text = "Danh sách vật liệu";
            // 
            // lvwMaterial
            // 
            this.lvwMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.lvwMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lvwMaterial.ForeColor = System.Drawing.Color.White;
            this.lvwMaterial.FullRowSelect = true;
            this.lvwMaterial.GridLines = true;
            this.lvwMaterial.HideSelection = false;
            this.lvwMaterial.Location = new System.Drawing.Point(3, 22);
            this.lvwMaterial.Name = "lvwMaterial";
            this.lvwMaterial.OwnerDraw = true;
            this.lvwMaterial.Size = new System.Drawing.Size(774, 207);
            this.lvwMaterial.Sortable = true;
            this.lvwMaterial.SortableColumns = null;
            this.lvwMaterial.TabIndex = 0;
            this.lvwMaterial.UseCompatibleStateImageBehavior = false;
            this.lvwMaterial.View = System.Windows.Forms.View.Details;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.White;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnExport.Location = new System.Drawing.Point(25, 3);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(180, 39);
            this.btnExport.TabIndex = 17;
            this.btnExport.Text = "Xuất hóa đơn";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.btnExit.Location = new System.Drawing.Point(315, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 39);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(137, 547);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 59);
            this.panel1.TabIndex = 19;
            // 
            // fExportReceiptDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbMaterial);
            this.Controls.Add(this.pnlInfor);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "fExportReceiptDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết hóa đơn xuất";
            this.Load += new System.EventHandler(this.fExportReceiptDetails_Load);
            this.pnlInfor.ResumeLayout(false);
            this.pnlInfor.PerformLayout();
            this.grbMaterial.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Panel pnlInfor;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtWarehouse;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtEmployee;
        private Controls.GroupBox.BmwGroupBox grbMaterial;
        private Controls.ListView.BmwListView lvwMaterial;
        private Controls.Button.BmwButton btnExport;
        private Controls.Button.BmwButton btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Label lblVat;
    }
}