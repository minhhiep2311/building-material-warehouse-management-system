﻿using System;
using System.Linq;
using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Utils;

namespace BTL_LTTQ_QLKhoVLXD.Services
{
    internal class ReceiptService
    {
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

        private static int CreateNewExportReceipt(ExportReceipt receipt)
        {
            var query = "INSERT INTO exportReceipt(date, totalPrice, vat, idWarehouse, reason) " +
                "OUTPUT INSERTED.ID " +
                $"VALUES('{DateTime.Now}', " +
                $"{receipt.TotalPrice}, " +
                $"{receipt.Vat}, " +
                $"{receipt.Warehouse.Id}, " +
                $"'{receipt.Reason}')";

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
    }
}
