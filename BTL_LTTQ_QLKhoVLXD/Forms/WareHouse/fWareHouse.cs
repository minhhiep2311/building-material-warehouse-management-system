using System;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Forms.TaskManager;

namespace BTL_LTTQ_QLKhoVLXD.Forms.WareHouse
{
    public partial class fWareHouse : Form
    {
        private readonly fTaskManager _parentForm;       

        public fWareHouse(fTaskManager form)
        {
            InitializeComponent();
            _parentForm = form;
        }

        #region Events

        private void btnSave_Click(object sender, EventArgs e)
        {
            TryCreate();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Behaviors


        private void TryCreate()
        {
            /*if (!ValidInput())
                return;

            var name = txtName.Text;
            var area = Convert.ToDouble( txtArea.Text);
            var newWareHouse = new Models.Warehouse(-1,name, area);
*/
            /*if (CreateSupplier(ref newSupplier) &&
                AddNewPhoneNumbers(phoneNumbers, newSupplier))
            {
                MessageBox.Show(
                    Resources.MessageBox_Message_AddEmployeeSuccessfully,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                _parentForm.LoadData_Supplier();
            }
            else
                MessageBox.Show(
                    Resources.MessageBox_Message_SystemError,
                    Resources.MessageBox_Caption_Notification,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
*/
            Close();
        }

        #endregion
    }
}
