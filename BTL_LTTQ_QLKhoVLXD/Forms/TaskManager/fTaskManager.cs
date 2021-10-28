using System;
using System.Drawing;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Forms.ChangeInformation;
using BTL_LTTQ_QLKhoVLXD.Forms.CreateAccount;
using BTL_LTTQ_QLKhoVLXD.Forms.ResetPassword;
using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Properties;
using BTL_LTTQ_QLKhoVLXD.Services;
using BTL_LTTQ_QLKhoVLXD.Utils;
using SortOrder = System.Data.SqlClient.SortOrder;

namespace BTL_LTTQ_QLKhoVLXD.Forms.TaskManager
{
    public partial class fTaskManager : Form
    {
        private User _user;
        public User User
        {
            get => _user;
            set
            {
                _user = value;
                DisplayUserInfo();
            }
        }

        public fTaskManager(User user)
        {
            InitializeComponent();
            User = user;
        }

        #region Form
        #region Form Events

        private void fTaskManager_Load(object sender, EventArgs e)
        {
            DisplayComponentsAccordsPermission();
            Init_Employee();
        }

        private void tctlControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            // No draw selected border
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(
                    e.Graphics,
                    e.Font,
                    e.Bounds,
                    e.Index,
                    e.State ^ DrawItemState.Selected,
                    e.ForeColor,
                    Color.YellowGreen
                );

            e.DrawBackground();

            // Draw Text
            var g = e.Graphics;
            var text = tctlControl.TabPages[e.Index].Text;
            var textSize = g.MeasureString(text, tctlControl.Font);

            var x = e.Bounds.Left + 10;
            var y = e.Bounds.Top + (e.Bounds.Height - textSize.Height) / 2;

            g.DrawString(text, tctlControl.Font, Brushes.Black, x, y);
        }
        private void fTaskManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show(
                    Resources.MessageBox_Message_ConfirmExit,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                ) == DialogResult.No;
        }

        #endregion

        #region Form Methods
        private void DisplayComponentsAccordsPermission()
        {
            if (!PermissionConstant.CreateAccount.Contains(User.Position.Id))
                btnCreateAccount_userSetting.Visible = false;
            if (!PermissionConstant.ResetPassword.Contains(User.Position.Id))
                btnResetPassword_userSetting.Visible = false;
        }

        private void DisplayUserInfo()
        {
            lblUser.Text = string.Format(Resources.TaskManager_Label_User, User.Name);
            lblPosition.Text = string.Format(Resources.TaskManager_Label_Position, User.Position);
        }

        #endregion
        #endregion

        #region Material
        #region Material Events

        private void tpgMaterial_Enter(object sender, EventArgs e)
        {
            LoadMaterialData();
        }

        #endregion

        #region Material Methods

        private void LoadMaterialData()
        {
            dgvMaterial_material.DataSource = MaterialService.GetAll();
            ConfigMaterialTable();
        }

        private void ConfigMaterialTable()
        {
            dgvMaterial_material.Columns[0].Width = 40;
            dgvMaterial_material.Columns[1].Width = 200;
            dgvMaterial_material.Columns[2].Width = 150;
            dgvMaterial_material.Columns[3].Width = 150;
            dgvMaterial_material.Columns[4].Width = 120;
            dgvMaterial_material.Columns[5].Width = 150;
        }

        #endregion
        #endregion

        #region Employee
        #region Employee Events

        private void tpgEmployee_Enter(object sender, EventArgs e)
        {
            LoadData_Employee();
        }

        private void lvwEmployee_employee_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (lvwEmployee_employee.SelectedItems.Count <= 0)
                return;

            var item = lvwEmployee_employee.SelectedItems[0];
        }

        private void lvwEmployee_employee_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            var sorter = (Helper.ItemComparer)lvwEmployee_employee.ListViewItemSorter;
            if (sorter == null)
            {
                sorter = new Helper.ItemComparer(e.Column)
                {
                    Order = SortOrder.Ascending
                };
                lvwEmployee_employee.ListViewItemSorter = sorter;
            }

            if (e.Column == sorter.Column)
                sorter.Order = 1 - sorter.Order;
            else
            {
                sorter.Column = e.Column;
                sorter.Order = SortOrder.Ascending;
            }

            lvwEmployee_employee.Sort();
            DrawArrow_Employee(e.Column, sorter.Order);
        }

        private void txtName_employee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_employee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_employee_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdoAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoMale_employee_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoFemale_employee_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Employee Methods

        private void Init_Employee()
        {
            lvwEmployee_employee.Columns.Add("Họ tên", -2, HorizontalAlignment.Left);
            lvwEmployee_employee.Columns.Add("Địa chỉ", -2, HorizontalAlignment.Left);
            lvwEmployee_employee.Columns.Add("Giới tính", 80, HorizontalAlignment.Left);
            lvwEmployee_employee.Columns.Add("Vị trí", -2, HorizontalAlignment.Left);
        }

        private void LoadData_Employee()
        {
            lvwEmployee_employee.Items.Clear();
            var employeeList = EmployeeService.GetAllEmployees();
            employeeList.ForEach(employee =>
                {
                    var row = new ListViewItem(employee.Name);
                    row.SubItems.Add(employee.Address);
                    row.SubItems.Add(employee.IsMale ? "Nam" : "Nữ");
                    row.SubItems.Add(employee.Position.Name);
                    lvwEmployee_employee.Items.Add(row);
                }
            );
        }

        private void DrawArrow_Employee(int colIdx, SortOrder order)
        {
            var upArrow = $"{Helper.Character.UpArrow}    ";
            var downArrow = $"{Helper.Character.DownArrow}    ";

            foreach (ColumnHeader column in lvwEmployee_employee.Columns)
            {
                if (column.Text.Contains(upArrow))
                    column.Text = column.Text.Replace(upArrow, string.Empty);
                else if (column.Text.Contains(downArrow))
                    column.Text = column.Text.Replace(downArrow, string.Empty);
            }

            lvwEmployee_employee.Columns[colIdx].Text =
                lvwEmployee_employee.Columns[colIdx].Text.Insert(0,
                    order == SortOrder.Ascending
                        ? downArrow
                        : upArrow
                );
        }

        #endregion
        #endregion

        #region UserSettings
        #region UserSettings Events

        private void btnCreateAccount_userSetting_Click(object sender, EventArgs e)
        {
            new fCreateAccount().ShowDialog();
        }

        private void btnChangeInformation_userSetting_Click(object sender, EventArgs e)
        {
            new fChangeInformation(this).ShowDialog();
        }
        private void btnResetPassword_userSetting_Click(object sender, EventArgs e)
        {
            new fResetPassword(User).ShowDialog();
        }

        #endregion

        #endregion
    }
}
