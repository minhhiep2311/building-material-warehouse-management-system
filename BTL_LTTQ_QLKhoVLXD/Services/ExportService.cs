﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Properties;
using BTL_LTTQ_QLKhoVLXD.Utils;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace BTL_LTTQ_QLKhoVLXD.Services
{
    public class ExportService
    {
        private static readonly SaveFileDialog DlgSave = new SaveFileDialog();

        public static void Init()
        {
            DlgSave.Filter = Resources.FileFilter_Excel;
            DlgSave.FilterIndex = 1;
            DlgSave.AddExtension = true;
            DlgSave.DefaultExt = ".xlsx";
        }

        public static void Export(ImportReceipt receipt)
        {
            var exApp = new Application();
            var exBook = exApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            var exSheet = (Worksheet)exBook.Worksheets[1];

            var employeeExcel = (Range)exSheet.Cells[1, 1];
            employeeExcel.Font.Size = 12;
            employeeExcel.Font.Bold = true;
            employeeExcel.Font.Color = Color.Blue;
            employeeExcel.Value = $"Nhân viên: {receipt.Employee.Name}";

            var supplierExcel = (Range)exSheet.Cells[2, 1];
            supplierExcel.Font.Size = 12;
            supplierExcel.Font.Bold = true;
            supplierExcel.Font.Color = Color.Blue;
            supplierExcel.Value = $"Nhà cung cấp: {receipt.Supplier.Name}";

            var idExcel = (Range)exSheet.Cells[3, 1];
            idExcel.Font.Size = 12;
            idExcel.Font.Bold = true;
            idExcel.Font.Color = Color.Blue;
            idExcel.Value = $"Mã hóa đơn: {receipt.Id}";

            var warehouseExcel = (Range)exSheet.Cells[4, 1];
            warehouseExcel.Font.Size = 12;
            warehouseExcel.Font.Bold = true;
            warehouseExcel.Font.Color = Color.Blue;
            warehouseExcel.Value = $"Kho hàng: {receipt.Warehouse.Name}";

            var header = (Range)exSheet.Cells[6, 3];
            exSheet.Range["C6:E6"].Merge(true);
            header.Font.Size = 13;
            header.Font.Bold = true;
            header.Font.Color = Color.Red;
            header.Value = "HÓA ĐƠN NHẬP";

            exSheet.Range["A8:G8"].Font.Bold = true;
            exSheet.Range["A8:G8"].HorizontalAlignment = XlHAlign.xlHAlignCenter;

            exSheet.Range["A8"].Value = "Mã hàng";
            exSheet.Range["B8"].Value = "Tên hàng";
            exSheet.Range["C8"].Value = "Quy cách";
            exSheet.Range["D8"].Value = "Đơn vị";
            exSheet.Range["E8"].Value = "Số lượng";
            exSheet.Range["F8"].Value = "Đơn giá";
            exSheet.Range["G8"].Value = "Tổng tiền";

            exSheet.Range["B8"].ColumnWidth = 40;
            exSheet.Range["C8"].ColumnWidth = 15;
            exSheet.Range["D8"].ColumnWidth = 10;
            exSheet.Range["E8"].ColumnWidth = 12;
            exSheet.Range["F8"].ColumnWidth = 15;
            exSheet.Range["G8"].ColumnWidth = 15;

            var i = 9;
            for (var j = 0; j < receipt.Materials.Count; i++, j++)
            {
                var material = receipt.Materials[j];
                exSheet.Range[$"A{i}"].Value = material.Id.ToString();
                exSheet.Range[$"B{i}"].Value = material.Name;
                exSheet.Range[$"C{i}"].Value = material.Specialization;
                exSheet.Range[$"D{i}"].Value = material.Unit.Name;
                exSheet.Range[$"E{i}"].Value = material.Numerous;
                exSheet.Range[$"F{i}"].Value = $"'{Helper.Format.String(material.ImportUnitPrice)}";
                exSheet.Range[$"G{i}"].Value = $"'{Helper.Format.String(material.ImportUnitPrice * material.Numerous)}";

                exSheet.Range[$"C{i}"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                exSheet.Range[$"D{i}"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                exSheet.Range[$"F{i}"].HorizontalAlignment = XlHAlign.xlHAlignRight;
                exSheet.Range[$"G{i}"].HorizontalAlignment = XlHAlign.xlHAlignRight;
            }

            var totalReceipt = (Range)exSheet.Cells[i, 1];
            exSheet.Range[$"A{i}:F{i}"].Merge(true);
            totalReceipt.Font.Bold = true;
            totalReceipt.HorizontalAlignment = XlHAlign.xlHAlignRight;
            totalReceipt.Value = "Tổng tiền";

            exSheet.Range[$"G{i}"].Value = $"'{Helper.Format.String(receipt.TotalPrice)}";
            exSheet.Range[$"G{i}"].HorizontalAlignment = XlHAlign.xlHAlignRight;

            exSheet.Name = "Phieu_Nhap_Kho";
            exBook.Activate();

            if (DlgSave.ShowDialog() == DialogResult.OK)
                exBook.SaveAs(DlgSave.FileName);

            exApp.Quit();
        }

        public static void Export(List<Customer> customers)
        {
            var exApp = new Application();
            var exBook = exApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            var exSheet = (Worksheet)exBook.Worksheets[1];

            var header = (Range)exSheet.Cells[2, 2];
            exSheet.Range["B2:E2"].Merge(true);
            header.Font.Size = 13;
            header.Font.Bold = true;
            header.Value = "DANH SÁCH KHÁCH HÀNG";

            var time = (Range)exSheet.Cells[4, 2];
            time.Font.Size = 13;
            time.Font.Bold = true;
            time.Value = "Thời gian tạo danh sách: " + DateTime.Now;

            exSheet.Range["A6:G6"].Font.Bold = true;
            exSheet.Range["A6:G6"].HorizontalAlignment = XlHAlign.xlHAlignCenter;

            exSheet.Range["A6"].Value = "STT";
            exSheet.Range["B6"].Value = "Tên khách hàng";
            exSheet.Range["C6"].Value = "Địa chỉ";
            exSheet.Range["D6"].Value = "Số điện thoại";

            exSheet.Range["A6"].ColumnWidth = 5;
            exSheet.Range["B6"].ColumnWidth = 60;
            exSheet.Range["C6"].ColumnWidth = 100;
            exSheet.Range["D6"].ColumnWidth = 15;

            var i = 7;
            for (var j = 0; j < customers.Count; i++, j++)
            {
                var customer = customers[j];
                exSheet.Range[$"A{i}"].Value = j + 1;
                exSheet.Range[$"B{i}"].Value = customer.Name;
                exSheet.Range[$"C{i}"].Value = customer.Address;

                switch (customer.PhoneNumber.Count)
                {
                    case 0:
                        break;
                    case 1:
                        exSheet.Range[$"D{i}"].Value = $"'{customer.PhoneNumber[0]}";
                        break;
                    default:
                        {
                            var startRow = i;
                            for (var k = 0; k < customer.PhoneNumber.Count; k++)
                            {
                                exSheet.Range[$"D{i}"].Value = $"'{customer.PhoneNumber[k]}";
                                if (k < customer.PhoneNumber.Count - 1)
                                {
                                    i++;
                                }
                            }

                            exSheet.Range[$"A{startRow}:A{i}"].Merge();
                            exSheet.Range[$"B{startRow}:B{i}"].Merge();
                            exSheet.Range[$"C{startRow}:C{i}"].Merge();

                            exSheet.Range[$"A{startRow}:A{i}"].VerticalAlignment = XlVAlign.xlVAlignCenter;
                            exSheet.Range[$"B{startRow}:B{i}"].VerticalAlignment = XlVAlign.xlVAlignCenter;
                            exSheet.Range[$"C{startRow}:C{i}"].VerticalAlignment = XlVAlign.xlVAlignCenter;

                            break;
                        }
                }
            }

            exSheet.Name = "Khach_Hang";
            exBook.Activate();

            if (DlgSave.ShowDialog() == DialogResult.OK)
                exBook.SaveAs(DlgSave.FileName);

            exApp.Quit();
        }
    }
}
