using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Forms.TaskManager;
using BTL_LTTQ_QLKhoVLXD.Properties;
using BTL_LTTQ_QLKhoVLXD.Services;
using BTL_LTTQ_QLKhoVLXD.Utils;
using FormMode = BTL_LTTQ_QLKhoVLXD.Utils.Enum.FormMode;

namespace BTL_LTTQ_QLKhoVLXD.Forms.WareHouse
{
    public partial class fWareHouse : Form
    {
        private readonly fTaskManager _parentForm;
        private readonly Models.Supplier _supplier;
        private readonly FormMode _mode;
        private readonly bool _startEdit;

        public fWareHouse(fTaskManager form)
        {
            InitializeComponent();
            _parentForm = form;
        }

        #region Events
        private void fWareHouse_Load(object sender, EventArgs e)
        {
            BindData();
            //ConfigureAccessibility();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (_mode == FormMode.Create)
            //    TryCreate();
            //else
            //    TryChangeInformation();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Methods
        private void BindData()
        {
            if (_mode == FormMode.Create)
                return;

            //txtName.Text = _wareHouse.Name;
            //txtArea.Text = _wareHouse.Area;
        }

        //private void ConfigureAccessibility()
        //{
        //    chkEdit.Visible = _mode == FormMode.Write;
        //    switch (_mode)
        //    {
        //        case FormMode.Write:
        //            if (_startEdit)
        //                chkEdit.Checked = true;
        //            return;
        //        case FormMode.Create:
        //            chkEdit.Checked = true;
        //            btnSave.Text = Resources.Form_ButtonSave;
        //            Text = Resources.Form_Text_AddNewSupplier;
        //            break;
        //        case FormMode.Read:
        //            txtName.ReadOnly = true;
        //            txtArea.ReadOnly = true;
        //            return;

        //        default:
        //            throw new ArgumentOutOfRangeException();
        //    }
        //}

        //private void TryCreate()
        //{
        //    if (!ValidInput())
        //        return;

        //    var name = txtName.Text;
        //    var name = txtArea.Text;
        //    var newWareHouse = new Models.WareHouse(name, area);

        //    if (CreateSupplier(ref newSupplier) &&
        //        AddNewPhoneNumbers(phoneNumbers, newSupplier))
        //    {
        //        MessageBox.Show(
        //            Resources.MessageBox_Message_AddEmployeeSuccessfully,
        //            Resources.MessageBox_Caption_Notification,
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Information
        //        );
        //        _parentForm.LoadData_Supplier();
        //    }
        //    else
        //        MessageBox.Show(
        //            Resources.MessageBox_Message_SystemError,
        //            Resources.MessageBox_Caption_Notification,
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Error
        //        );

        //    Close();
        //}

        #endregion
    }
}
