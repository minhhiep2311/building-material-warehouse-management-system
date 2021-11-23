using System;
using System.Linq;
using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Utils;

namespace BTL_LTTQ_QLKhoVLXD.Services
{
    internal class ReceiptService
    {
        public static bool CreateImportReceipt(ImportReceipt receipt)
        {
            var receiptId = CreateNewImportReceipt(receipt);
            if (receiptId == -1)
                return false;

            receipt.Id = receiptId;
            return CreateImportReceiptDetails(receipt) &&
                LinkImportReceiptToSupplier(receipt) &&
                LinkImportReceiptToEmployee(receipt);
        }

        private static int CreateNewImportReceipt(ImportReceipt receipt)
        {
            var query = "INSERT INTO importReceipt(date, totalPrice, idWarehouse) " +
                "OUTPUT INSERTED.ID " +
                $"VALUES('{DateTime.Now}', " +
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
            return rowAffected == receipt.Materials.Count;
        }

        private static bool LinkImportReceiptToSupplier(ImportReceipt receipt)
        {
            var query = "INSERT INTO supplier_receipt(idImportReceipt, idSupplier) " +
                $"VALUES({receipt.Id}, {receipt.Supplier.Id})";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);
            return rowAffected == 1;
        }

        private static bool LinkImportReceiptToEmployee(ImportReceipt receipt)
        {
            var query = "INSERT INTO employee_importReceipt(idEmployee, idImportReceipt) " +
                $"VALUES({receipt.Employee.Id}, {receipt.Id})";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);
            return rowAffected == 1;
        }
    }
}
