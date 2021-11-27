using System;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Forms.TaskManager;
using BTL_LTTQ_QLKhoVLXD.Properties;
using BTL_LTTQ_QLKhoVLXD.Services;
using BTL_LTTQ_QLKhoVLXD.Utils;
using FormMode = BTL_LTTQ_QLKhoVLXD.Utils.Enum.FormMode;

namespace BTL_LTTQ_QLKhoVLXD.Forms.Material
{
    public partial class fMaterial : Form
    {
        private readonly fTaskManager _parentForm;
        private readonly Models.Material _material;
        private readonly FormMode _mode;
        private readonly bool _startEdit;
        public fMaterial(fTaskManager form, FormMode mode = FormMode.Create, Models.Material material = null, bool startEdit = false)
        {
            InitializeComponent();
            _mode = mode;
            _material = material;
            _parentForm = form;
            _startEdit = startEdit;
        }

        #region Events
        private void fMaterial_Load(object sender, EventArgs e)
        {
            BindData();
            ConfigureAccessibility();
        }

        private void chkEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEdit.Checked)
            {
                txtName.ReadOnly = false;
                txtExportUnitPrice.ReadOnly = false;
                txtImportUnitPrice.ReadOnly = false;
                txtSpecialization.ReadOnly = false;
            }
            else
            {
                txtName.ReadOnly = true;
                txtExportUnitPrice.ReadOnly = true;
                txtImportUnitPrice.ReadOnly = true;
                txtSpecialization.ReadOnly = true;
            }
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
        private void BindData()
        {
            if (_mode == FormMode.Create)
                return;

            txtName.Text = _material.Name;
            txtImportUnitPrice.Text = Helper.Converter.ToString(_material.ImportUnitPrice);
            txtExportUnitPrice.Text = Helper.Converter.ToString(_material.ExportUnitPrice);
            txtSpecialization.Text = _material.Specialization;
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
                    Text = Resources.Form_Text_AddNewMaterial;
                    break;
                case FormMode.Read:
                    txtName.ReadOnly = true;
                    txtExportUnitPrice.ReadOnly = true;
                    txtImportUnitPrice.ReadOnly = true;
                    txtSpecialization.ReadOnly = true;
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
            var importUnitPrice = txtImportUnitPrice.Text;
            var exportUnitPrice = txtExportUnitPrice.Text;
            var specialization = txtSpecialization.Text;

            var newMaterial = new Models.Material(name, Convert.ToDouble(importUnitPrice), Convert.ToDouble(exportUnitPrice), specialization);

            if (CreateMaterial(ref newMaterial))
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_AddEmployeeSuccessfully,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                _parentForm.LoadData_Material();
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
        private static bool CreateMaterial(ref Models.Material newMaterial)
        {
            newMaterial.Id = MaterialService.CreateMaterial(newMaterial);
            return newMaterial.Id != -1;
        }

        private void TryChangeInformation()
        {
            var name = txtName.Text;
            var importUnitPrice = txtImportUnitPrice.Text;
            var exportUnitPrice = txtExportUnitPrice.Text;
            var specialization = txtSpecialization.Text;

            var newMaterial = new Models.Material(name, Convert.ToDouble(importUnitPrice), Convert.ToDouble(exportUnitPrice), specialization);

            if (_material.Equals(newMaterial))
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

            if (ChangeInformation(newMaterial))
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

            _parentForm.LoadData_Material();
            Close();
        }
        private bool ValidInput()
        {
            if (txtName.Text != "" && txtImportUnitPrice.Text != "" && txtExportUnitPrice.Text != "")
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
                string.Format(Resources.MessageBox_Message_ConfirmChangeEmployeeInfo, _material.Name),
                Resources.MessageBox_Caption_Notification,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            ) == DialogResult.Yes;
        }

        private static bool ChangeInformation(Models.Material newMaterial)
        {
            return MaterialService.ChangeMaterialInformation(newMaterial);
        }
        #endregion


    }
}
