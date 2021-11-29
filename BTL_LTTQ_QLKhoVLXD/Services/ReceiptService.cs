using System;
using System.Collections.Generic;
using System.Linq;
using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Utils;

namespace BTL_LTTQ_QLKhoVLXD.Services
{
    internal class ReceiptService
    {
        #region Select

        public static List<ImportReceipt> GetImportReceipts()
        {
            const string query =
                "SELECT iR.id, date, totalPrice, w.name, e.name AS employeeName, s.name AS supplierName " +
                "FROM importReceipt AS iR " +
                "JOIN warehouse w ON iR.idWarehouse = w.id " +
                "JOIN employee_importReceipt eiR ON iR.id = eiR.idImportReceipt " +
                "JOIN employee e ON eiR.idEmployee = e.id " +
                "JOIN supplier_receipt sr ON iR.id = sr.idImportReceipt " +
                "JOIN supplier s ON sr.idSupplier = s.id ";

            var result = DatabaseProvider.Instance.ExecuteQuery(query);
            var receipts = Helper.Mapper.MapArrayOfObject(result, ImportReceipt.FromData);
            return receipts;
        }

        public static List<ExportReceipt> GetExportReceipts()
        {
            const string query =
                "SELECT iR.id, date, totalPrice, w.name, e.name AS customerName, s.name AS supplierName, vat, reason " +
                "FROM exportReceipt AS iR " +
                "JOIN warehouse w ON iR.idWarehouse = w.id " +
                "JOIN employee_exportReceipt eiR ON iR.id = eiR.idExportReceipt " +
                "JOIN employee e ON eiR.idEmployee = e.id " +
                "JOIN customer_receipt sr ON iR.id = sr.idExportReceipt " +
                "JOIN customer s ON sr.idCustomer = s.id ";

            var result = DatabaseProvider.Instance.ExecuteQuery(query);
            var receipts = Helper.Mapper.MapArrayOfObject(result, ExportReceipt.FromData);
            return receipts;
        }

        public static List<Material> GetMaterialsFromImportReceipt(ImportReceipt receipt)
        {
            var query =
                "SELECT e.idImportReceipt AS id, e.numerous, e.unitPrice, m.name, m.specialization, u.name AS unitName " +
                "FROM importReceiptDetails AS e " +
                "JOIN material m ON e.idMaterial = m.id " +
                "JOIN unit u ON m.idUnit = u.id " +
                $"WHERE idImportReceipt = {receipt.Id}";

            var result = DatabaseProvider.Instance.ExecuteQuery(query);
            var materials = Helper.Mapper.MapArrayOfObject(result, Material.FromExportReceipt);
            return materials;
        }

        public static List<Material> GetMaterialsFromExportReceipt(ExportReceipt receipt)
        {
            var query =
                "SELECT e.idExportReceipt AS id, e.numerous, e.unitPrice, m.name, m.specialization, u.name AS unitName " +
                "FROM exportReceiptDetails AS e " +
                "JOIN material m ON e.idMaterial = m.id " +
                "JOIN unit u ON m.idUnit = u.id " +
                $"WHERE idExportReceipt = {receipt.Id}";

            var result = DatabaseProvider.Instance.ExecuteQuery(query);
            var materials = Helper.Mapper.MapArrayOfObject(result, Material.FromExportReceipt);
            return materials;
        }
        #endregion

        #region Insert

        public static int CreateImportReceipt(ImportReceipt receipt)
        {
            var receiptId = CreateNewImportReceipt(receipt);
            if (receiptId == -1)
                return -1;

            receipt.Id = receiptId;
            return CreateImportReceiptDetails(receipt) &&
                LinkImportReceiptToSupplier(receipt) &&
                LinkImportReceiptToEmployee(receipt) ? receiptId : -1;
        }

        public static int CreateExportReceipt(ExportReceipt receipt)
        {
            var receiptId = CreateNewExportReceipt(receipt);
            if (receiptId == -1)
                return -1;

            receipt.Id = receiptId;
            return CreateExportReceiptDetails(receipt) &&
                LinkExportReceiptToCustomer(receipt) &&
                LinkExportReceiptToEmployee(receipt) ? receiptId : -1;
        }

        #endregion

        #region Private methods

        private static int CreateNewImportReceipt(Receipt receipt)
        {
            var query = "INSERT INTO importReceipt(date, totalPrice, idWarehouse) " +
                "OUTPUT INSERTED.ID " +
                $"VALUES('{receipt.DateTime}', " +
                $"{receipt.TotalPrice}, " +
                $"{receipt.Warehouse.Id})";

            try
            {
                var receiptId = Convert.ToInt32(DatabaseProvider.Instance.ExecuteScalar(query));
                return receiptId;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        private static bool CreateImportReceiptDetails(ImportReceipt receipt)
        {
            var values = receipt.Materials
               .Select(x => $"({receipt.Id}, {x.Id}, {x.Numerous}, {x.ExportUnitPrice})");
            var query = "INSERT INTO importReceiptDetails(idImportReceipt, idMaterial, numerous, unitPrice) " +
                $"VALUES {string.Join(", ", values)}";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);
            return rowAffected >= receipt.Materials.Count;
        }

        private static bool LinkImportReceiptToSupplier(ImportReceipt receipt)
        {
            var query = "INSERT INTO supplier_receipt(idImportReceipt, idSupplier) " +
                $"VALUES({receipt.Id}, {receipt.Supplier.Id})";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);
            return rowAffected >= 1;
        }

        private static bool LinkImportReceiptToEmployee(ImportReceipt receipt)
        {
            var query = "INSERT INTO employee_importReceipt(idEmployee, idImportReceipt) " +
                $"VALUES({receipt.Employee.Id}, {receipt.Id})";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);
            return rowAffected >= 1;
        }

        private static int CreateNewExportReceipt(ExportReceipt receipt)
        {
            var query = "INSERT INTO exportReceipt(date, totalPrice, vat, idWarehouse, reason) " +
                "OUTPUT INSERTED.ID " +
                $"VALUES('{receipt.DateTime}', " +
                $"{receipt.TotalPrice}, " +
                $"{receipt.Vat}, " +
                $"{receipt.Warehouse.Id}, " +
                $"N'{receipt.Reason}')";

            try
            {
                var receiptId = Convert.ToInt32(DatabaseProvider.Instance.ExecuteScalar(query));
                return receiptId;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        private static bool CreateExportReceiptDetails(ExportReceipt receipt)
        {
            var values = receipt.Materials
               .Select(x => $"({receipt.Id}, {x.Id}, {x.Numerous}, {x.ExportUnitPrice})");
            var query = "INSERT INTO exportReceiptDetails(idExportReceipt, idMaterial, numerous, unitPrice) " +
                $"VALUES {string.Join(", ", values)}";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);
            return rowAffected >= receipt.Materials.Count;
        }

        private static bool LinkExportReceiptToCustomer(ExportReceipt receipt)
        {
            var query = "INSERT INTO customer_receipt(idExportReceipt, idCustomer) " +
                $"VALUES({receipt.Id}, {receipt.Customer.Id})";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);
            return rowAffected >= 1;
        }

        private static bool LinkExportReceiptToEmployee(ExportReceipt receipt)
        {
            var query = "INSERT INTO employee_exportReceipt(idEmployee, idExportReceipt) " +
                $"VALUES({receipt.Employee.Id}, {receipt.Id})";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);
            return rowAffected >= 1;
        }

        #endregion
    }
}
