using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_LTTQ_QLKhoVLXD
{
    public partial class fTaskManager : Form
    {
        private void tpgMaterial_Enter(object sender, EventArgs e)
        {
            LoadMaterialData();
        }

        private void ConfigMaterialTable()
        {
            dgvMaterial.Columns[0].HeaderText = "Mã";
            dgvMaterial.Columns[1].HeaderText = "Tên vật liệu";
            dgvMaterial.Columns[2].HeaderText = "Đơn giá nhập";
            dgvMaterial.Columns[3].HeaderText = "Đơn giá xuất";
            dgvMaterial.Columns[4].HeaderText = "Đơn vị tính";
            dgvMaterial.Columns[5].HeaderText = "Quy cách";

            dgvMaterial.Columns[0].Width = 40;
            dgvMaterial.Columns[1].Width = 200;
            dgvMaterial.Columns[2].Width = 150;
            dgvMaterial.Columns[3].Width = 150;
            dgvMaterial.Columns[4].Width = 120;
            dgvMaterial.Columns[5].Width = 150;
        }

        private void LoadMaterialData()
        {
            //DataTable table = new DataTable();
            string query =
                "SELECT m.id, m.name, importUnitPrice, exportUnitPrice, u.Name as unitName, specialization " +
                "FROM material as m " +
                "JOIN unit as u ON m.idUnit=u.id";

            dgvMaterial.DataSource = DatabaseProvider.Instance.ExecuteQuery(query);

            //SqlDataAdapter adapter = new SqlDataAdapter(query, DatabaseProvider.Connection);
            //adapter.Fill(table);
            //dgvMaterial.DataSource = table;

            ConfigMaterialTable();
        }
    }
}
