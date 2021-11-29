using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Properties;
using BTL_LTTQ_QLKhoVLXD.Services;
using BTL_LTTQ_QLKhoVLXD.Utils;
using FormMode = BTL_LTTQ_QLKhoVLXD.Utils.Enum.FormMode;

namespace BTL_LTTQ_QLKhoVLXD.Forms.Customer
{
    public partial class fCustomer : Form
    {
        private readonly Action _afterClosed;
        private readonly Models.Customer _customer;
        private readonly FormMode _mode;
        private readonly bool _startEdit;

        public fCustomer(
            Action afterClosed = null,
            FormMode mode = FormMode.Create,
            Models.Customer customer = null,
            bool startEdit = false)
        {
            InitializeComponent();
            _afterClosed = afterClosed;
            _mode = mode;
            _customer = customer;
            _startEdit = startEdit;
        }

        #region Events

        private void fCustomer_Load(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_mode == FormMode.Create)
                TryCreate();
            else
                TryChangeInformation();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
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

            txtName.Text = _customer.Name;
            txtAddress.Text = _customer.Address;
            _customer.PhoneNumber.ForEach(phone => lvwPhone.Items.Add(new ListViewItem(phone)));
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
                    Text = Resources.Form_Text_AddNewCustomer;
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
            var newCustomer = new Models.Customer(name, address, phoneNumbers);

            if (CreateCustomer(ref newCustomer) &&
                AddNewPhoneNumbers(phoneNumbers, newCustomer))
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_AddEmployeeSuccessfully,
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

        private static bool CreateCustomer(ref Models.Customer newCustomer)
        {
            newCustomer.Id = CustomerService.CreateCustomer(newCustomer);
            return newCustomer.Id != -1;
        }

        private void TryChangeInformation()
        {
            var id = _customer.Id;
            var name = txtName.Text;
            var address = txtAddress.Text;
            var phoneNumbers = lvwPhone.Items
               .Cast<ListViewItem>()
               .Select(item => item.Text)
               .ToList();

            var newCustomer = new Models.Customer(id, name, address, phoneNumbers);

            if (_customer.Equals(newCustomer))
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

            if (ChangeInformation(newCustomer) &&
                ChangePhoneNumber(newCustomer))
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
                string.Format(Resources.MessageBox_Message_ConfirmChangeEmployeeInfo, _customer.Name),
                Resources.MessageBox_Caption_Notification,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            ) == DialogResult.Yes;
        }

        private static bool ChangeInformation(Models.Customer newCustomer)
        {
            return CustomerService.ChangeCustomerInformation(newCustomer);
        }

        private bool ChangePhoneNumber(Models.Customer newCustomer)
        {
            var (shouldDelete, shouldAdd) = Helper.List
               .Difference(
                    _customer.PhoneNumber,
                    newCustomer.PhoneNumber
                );

            return DeletePhoneNumbers(shouldDelete) && AddNewPhoneNumbers(shouldAdd);
        }

        private static bool DeletePhoneNumbers(List<string> shouldDelete)
        {
            return CustomerService.DeletePhoneNumbers(shouldDelete);
        }

        private bool AddNewPhoneNumbers(List<string> shouldAdd, Models.Customer customer = null)
        {
            return CustomerService.AddNewPhoneNumbers(customer ?? _customer, shouldAdd);
        }

        #endregion
    }
}
