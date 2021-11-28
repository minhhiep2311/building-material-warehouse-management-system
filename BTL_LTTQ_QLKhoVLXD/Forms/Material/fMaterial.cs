using System;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Forms.TaskManager;
using BTL_LTTQ_QLKhoVLXD.Forms.Unit;
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

        public fMaterial(
            fTaskManager form,
            FormMode mode = FormMode.Create,
            Models.Material material = null)
        {
            InitializeComponent();
            _mode = mode;
            _material = material;
            _parentForm = form;
        }

        #region Events
        private void fMaterial_Load(object sender, EventArgs e)
        {
            BindData();
            ConfigureAccessibility();
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            new fUnit(this).ShowDialog();
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
            {
                LoadUnits();
                return;
            }

            txtName.Text = _material.Name;
            txtImportUnitPrice.Text = Helper.Converter.ToString(_material.ImportUnitPrice);
            txtExportUnitPrice.Text = Helper.Converter.ToString(_material.ExportUnitPrice);
            txtSpecialization.Text = _material.Specialization;
            cboUnit.Text = _material.Unit.Name;
        }

        private void ConfigureAccessibility()
        {
            switch (_mode)
            {
                case FormMode.Create:
                    btnSave.Text = Resources.Form_ButtonSave;
                    Text = Resources.Form_Text_AddNewMaterial;
                    return;
                case FormMode.Write:
                case FormMode.Read:
                    txtName.ReadOnly = true;
                    txtSpecialization.ReadOnly = true;
                    cboUnit.Enabled = false;
                    btnAddUnit.Enabled = false;
                    return;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void LoadUnits()
        {
            var units = UnitService.GetAllUnits();
            cboUnit.DataSource = units;
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
            var importUnitPrice = Convert.ToDouble(txtImportUnitPrice.Text);
            var exportUnitPrice = Convert.ToDouble(txtExportUnitPrice.Text);

            var newMaterial = new Models.Material(
                _material.Id, 
                _material.Name, 
                importUnitPrice, 
                exportUnitPrice);

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
