﻿using BTL_LTTQ_QLKhoVLXD.Forms.TaskManager;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Properties;
using BTL_LTTQ_QLKhoVLXD.Utils;
using BTL_LTTQ_QLKhoVLXD.Services;
using System.Collections.Generic;

namespace BTL_LTTQ_QLKhoVLXD.Forms.AddSupplier
{

    public partial class fSupplier : Form
    {
        private readonly fTaskManager _parentForm;
        private readonly Supplier _supplier;
        private readonly Mode _mode;
        private readonly bool _startEdit;

        public enum Mode
        {
            Read,
            Write,
            Create
        }

        public fSupplier(fTaskManager form, Mode mode = Mode.Create, Supplier supplier = null, bool startEdit = false)
        {
            InitializeComponent();
            _mode = mode;
            _supplier = supplier ;
            _parentForm = form;
            _startEdit = startEdit;
        }


        #region Events
        private void fAddSupplier_Load(object sender, EventArgs e)
        {
            InitControls();
            BindData();
            ConfigureAccessibility();
        }
        private void fSupplier_FormClosing(object sender, FormClosingEventArgs e)
        {
            _parentForm.LoadData_Supplier();
        }

        private void chkEdit_CheckedChanged(object sender, EventArgs e)
        {
            if(chkEdit.Checked)
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
            if (_mode == Mode.Create)
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
            if (_mode == Mode.Create)
                return;

            txtName.Text = _supplier.Name;
            txtAddress.Text = _supplier.Address;
            _supplier.PhoneNumber.ForEach(phone => lvwPhone.Items.Add(new ListViewItem(phone)));
        }

        private void ConfigureAccessibility()
        {
            chkEdit.Visible = _mode == Mode.Write;
            switch (_mode)
            {
                case Mode.Write:
                    if (_startEdit)
                        chkEdit.Checked = true;
                    return;
                case Mode.Create:
                    chkEdit.Checked = true;
                    btnSave.Text = Resources.Form_ButtonSave;
                    Text = Resources.Form_Text_AddNewSupplier;
                    break;
                case Mode.Read:
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
            var newSupplier = new Supplier(name, address, phoneNumbers);

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
                MessageBox.Show(
                    Resources.MessageBox_Message_SystemError,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

            _parentForm.LoadData_Supplier();
            Close();
        }

        private static bool CreateSupplier(ref Supplier newSupplier)
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

            var newSupplier = new Supplier(id, name, address, phoneNumbers);

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

            Close();
        }

        private bool ValidInput()
        {
            if (txtName.Text == "" ||
                txtAddress.Text == "")
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_EnterFullPersonalInfo,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }

            return true;
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

        private static bool ChangeInformation(Supplier newSupplier)
        {
             return SupplierService.ChangeSupplierInformation(newSupplier);
        }

        private bool ChangePhoneNumber(Supplier newSupplier)
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

        private bool AddNewPhoneNumbers(List<string> shouldAdd, Supplier supplier = null)
        {
            return SupplierService.AddNewPhoneNumbers(supplier ?? _supplier, shouldAdd);
        }

        #endregion


    }
}