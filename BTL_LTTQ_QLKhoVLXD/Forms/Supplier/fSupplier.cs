using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Properties;
using BTL_LTTQ_QLKhoVLXD.Services;
using BTL_LTTQ_QLKhoVLXD.Utils;
using FormMode = BTL_LTTQ_QLKhoVLXD.Utils.Enum.FormMode;

namespace BTL_LTTQ_QLKhoVLXD.Forms.Supplier
{

    public partial class fSupplier : Form
    {
        private readonly Action _afterClosed;
        private readonly Models.Supplier _supplier;
        private readonly FormMode _mode;
        private readonly bool _startEdit;

        public fSupplier(
            Action afterClosed = null,
            FormMode mode = FormMode.Create,
            Models.Supplier supplier = null,
            bool startEdit = false)
        {
            InitializeComponent();
            _afterClosed = afterClosed;
            _mode = mode;
            _supplier = supplier;
            _startEdit = startEdit;
        }

        #region Events

        private void fAddSupplier_Load(object sender, EventArgs e)
        {
            InitControls();
            BindData();
            ConfigureAccessibility();
        }

        private void chkEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEdit.Checked)
            {
                txtName.ReadOnly = false;
                txtAddress.ReadOnly = false;
                btnAddPhone.Enabled = true;
                btnModifyPhone.Enabled = true;
                btnRemovePhone.Enabled = true;
            }
            else
            {
                txtName.ReadOnly = true;
                txtAddress.ReadOnly = true;
                btnAddPhone.Enabled = false;
                btnModifyPhone.Enabled = false;
                btnRemovePhone.Enabled = false;
            }
        }
        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            lvwPhone.SelectedItems.Clear();
            var item = lvwPhone.Items.Add("");
            item.BeginEdit();
        }

        private void btnModifyPhone_Click(object sender, EventArgs e)
        {
            if (lvwPhone.SelectedItems.Count <= 0)
                return;

            var selectItem = lvwPhone.SelectedItems[0];
            lvwPhone.SelectedItems.Clear();
            selectItem.BeginEdit();
        }

        private void btnRemovePhone_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvwPhone.SelectedItems)
                lvwPhone.Items.Remove(item);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_mode == FormMode.Create)
                TryCreate();
            else
                TryChangeInformation();
        }

        #endregion

        #region Methods
        private void InitControls()
        {
            lvwPhone.Columns.Add("SDT", -2, HorizontalAlignment.Left);
        }

        private void BindData()
        {
            if (_mode == FormMode.Create)
                return;

            txtName.Text = _supplier.Name;
            txtAddress.Text = _supplier.Address;
            _supplier.PhoneNumber.ForEach(phone => lvwPhone.Items.Add(new ListViewItem(phone)));
        }

        private void ConfigureAccessibility()
        {
            chkEdit.Visible = _mode == FormMode.Write;
            switch (_mode)
            {
                case FormMode.Write:
                    if (_startEdit)
                        chkEdit.Checked = true;
                    return;
                case FormMode.Create:
                    chkEdit.Checked = true;
                    btnSave.Text = Resources.Form_ButtonSave;
                    Text = Resources.Form_Text_AddNewSupplier;
                    break;
                case FormMode.Read:
                    txtName.ReadOnly = true;
                    txtAddress.ReadOnly = true;
                    btnAddPhone.Visible = false;
                    btnModifyPhone.Visible = false;
                    btnRemovePhone.Visible = false;
                    btnSave.Visible = false;
                    btnCancel.Visible = false;
                    return;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void TryCreate()
        {
            if (!ValidInput())
                return;

            var name = txtName.Text;
            var address = txtAddress.Text;
            var phoneNumbers = lvwPhone.Items
               .Cast<ListViewItem>()
               .Select(item => item.Text)
               .ToList();
            var newSupplier = new Models.Supplier(name, address, phoneNumbers);

            if (CreateSupplier(ref newSupplier) &&
                AddNewPhoneNumbers(phoneNumbers, newSupplier))
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_AddEmployeeSuccessfully,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_SystemError,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            _afterClosed();
            Close();
        }

        private static bool CreateSupplier(ref Models.Supplier newSupplier)
        {
            newSupplier.Id = SupplierService.CreateSupplier(newSupplier);
            return newSupplier.Id != -1;
        }

        private void TryChangeInformation()
        {
            var id = _supplier.Id;
            var name = txtName.Text;
            var address = txtAddress.Text;
            var phoneNumbers = lvwPhone.Items
               .Cast<ListViewItem>()
               .Select(item => item.Text)
               .ToList();

            var newSupplier = new Models.Supplier(id, name, address, phoneNumbers);

            if (_supplier.Equals(newSupplier))
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_ChangeInfoNoChange,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                Close();
                return;
            }

            if (!ValidInput() || !ConfirmChange())
                return;

            if (ChangeInformation(newSupplier) &&
                ChangePhoneNumber(newSupplier))
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_ChangeSuccessfully,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
                MessageBox.Show(
                    Resources.MessageBox_Message_SystemError,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

            _afterClosed();
            Close();
        }

        private bool ValidInput()
        {
            if (txtName.Text != "" && txtAddress.Text != "")
                return true;

            MessageBox.Show(
                Resources.MessageBox_Message_EnterFulllInfo,
                Resources.MessageBox_Caption_Notification,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            return false;
        }

        private bool ConfirmChange()
        {
            return MessageBox.Show(
                string.Format(Resources.MessageBox_Message_ConfirmChangeEmployeeInfo, _supplier.Name),
                Resources.MessageBox_Caption_Notification,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            ) == DialogResult.Yes;
        }

        private static bool ChangeInformation(Models.Supplier newSupplier)
        {
            return SupplierService.ChangeSupplierInformation(newSupplier);
        }

        private bool ChangePhoneNumber(Models.Supplier newSupplier)
        {
            var (shouldDelete, shouldAdd) = Helper.List
               .Difference(
                    _supplier.PhoneNumber,
                    newSupplier.PhoneNumber
                );

            return DeletePhoneNumbers(shouldDelete) && AddNewPhoneNumbers(shouldAdd);
        }

        private static bool DeletePhoneNumbers(List<string> shouldDelete)
        {
            return SupplierService.DeletePhoneNumbers(shouldDelete);
        }

        private bool AddNewPhoneNumbers(List<string> shouldAdd, Models.Supplier supplier = null)
        {
            return SupplierService.AddNewPhoneNumbers(supplier ?? _supplier, shouldAdd);
        }

        #endregion
    }
}
