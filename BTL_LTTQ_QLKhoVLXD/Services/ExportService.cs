using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Properties;
using BTL_LTTQ_QLKhoVLXD.Utils;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using XlConstants = Microsoft.Office.Interop.Excel.Constants;

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

        #region Export Receipt

        public static void Export(ImportReceipt receipt)
        {
            var (exApp, exBook, exSheet) = InitExcelFile();

            PrintCompany(exSheet);

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
            exSheet.Range["C6:D6"].Merge(true);
            header.Font.Size = 14;
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
                exSheet.Range[$"F{i}"].Value = $"'{Helper.Converter.ToString(material.ImportUnitPrice)}";
                exSheet.Range[$"G{i}"].Value = $"'{Helper.Converter.ToString(material.ImportUnitPrice * material.Numerous)}";

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
            exSheet.Range[$"G{i}"].Value = $"'{Helper.Converter.ToString(receipt.TotalPrice)}";
            exSheet.Range[$"G{i}"].HorizontalAlignment = XlHAlign.xlHAlignRight;

            var border = exSheet.Range[$"A8:G{i}"].Borders;
            SetBorder(border);

            var employeeExcel = (Range)exSheet.Cells[i + 3, 5];
            employeeExcel.Font.Size = 12;
            employeeExcel.Font.Bold = true;
            employeeExcel.Font.Color = Color.Blue;
            employeeExcel.Value = $"Nhân viên: {receipt.Employee.Name}";

            exSheet.Name = "Phiếu nhập kho";

            RequestToSave(exApp, exBook);
        }

        public static void Export(ExportReceipt receipt)
        {
            var (exApp, exBook, exSheet) = InitExcelFile();

            PrintCompany(exSheet);

            var supplierExcel = (Range)exSheet.Cells[2, 1];
            supplierExcel.Font.Size = 12;
            supplierExcel.Font.Bold = true;
            supplierExcel.Font.Color = Color.Blue;
            supplierExcel.Value = $"Nhà cung cấp: {receipt.Customer.Name}";

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
            exSheet.Range["C6:D6"].Merge(true);
            header.Font.Size = 14;
            header.Font.Bold = true;
            header.Font.Color = Color.Red;
            header.Value = "HÓA ĐƠN XUẤT HÀNG";

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
                exSheet.Range[$"F{i}"].Value = $"'{Helper.Converter.ToString(material.ImportUnitPrice)}";
                exSheet.Range[$"G{i}"].Value = $"'{Helper.Converter.ToString(material.ImportUnitPrice * material.Numerous)}";

                exSheet.Range[$"C{i}"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                exSheet.Range[$"D{i}"].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                exSheet.Range[$"F{i}"].HorizontalAlignment = XlHAlign.xlHAlignRight;
                exSheet.Range[$"G{i}"].HorizontalAlignment = XlHAlign.xlHAlignRight;
            }

            var vat = (Range)exSheet.Cells[i, 1];
            exSheet.Range[$"A{i}:F{i}"].Merge(true);
            vat.HorizontalAlignment = XlHAlign.xlHAlignRight;
            vat.Value = $"Thuế: {receipt.VatPercent}%";
            exSheet.Range[$"G{i}"].Value = $"'{Helper.Converter.ToString(receipt.Vat)}";
            exSheet.Range[$"G{i}"].HorizontalAlignment = XlHAlign.xlHAlignRight;
            i++;

            var totalReceipt = (Range)exSheet.Cells[i, 1];
            exSheet.Range[$"A{i}:F{i}"].Merge(true);
            totalReceipt.Font.Bold = true;
            totalReceipt.HorizontalAlignment = XlHAlign.xlHAlignRight;
            totalReceipt.Value = "Tổng tiền";
            exSheet.Range[$"G{i}"].Value = $"'{Helper.Converter.ToString(receipt.TotalPrice)}";
            exSheet.Range[$"G{i}"].HorizontalAlignment = XlHAlign.xlHAlignRight;

            if (!string.IsNullOrEmpty(receipt.Reason))
            {
                i++;
                var reason = (Range)exSheet.Cells[i, 1];
                exSheet.Range[$"A{i}:G{i}"].Merge(true);
                reason.Value = $"Lý do: {receipt.Reason}";
            }

            var border = exSheet.Range[$"A8:G{i}"].Borders;
            SetBorder(border);

            var employeeExcel = (Range)exSheet.Cells[i + 3, 5];
            employeeExcel.Font.Size = 12;
            employeeExcel.Font.Bold = true;
            employeeExcel.Font.Color = Color.Blue;
            employeeExcel.Value = $"Nhân viên: {receipt.Employee.Name}";

            exSheet.Name = "Phiếu xuất kho";

            RequestToSave(exApp, exBook);
        }

        #endregion

        #region Export Customer

        public static void Export(List<Customer> customers)
        {
            var (exApp, exBook, exSheet) = InitExcelFile();

            var header = (Range)exSheet.Cells[2, 2];
            exSheet.Range["B2:E2"].Merge(true);
            header.Font.Size = 13;
            header.Font.Bold = true;
            header.Value = "DANH SÁCH KHÁCH HÀNG";

            var time = (Range)exSheet.Cells[4, 2];
            time.Font.Size = 12;
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

            var border = exSheet.Range[$"A6:D{i - 1}"].Borders;
            SetBorder(border);

            exSheet.Name = "Khách hàng";

            RequestToSave(exApp, exBook);
        }

        #endregion

        #region Export Supplier

        public static void Export(List<Supplier> suppliers)
        {
            var (exApp, exBook, exSheet) = InitExcelFile();

            var header = (Range)exSheet.Cells[2, 2];
            exSheet.Range["B2:E2"].Merge(true);
            header.Font.Size = 13;
            header.Font.Bold = true;
            header.Value = "DANH SÁCH NHÀ CUNG CẤP";

            var time = (Range)exSheet.Cells[4, 2];
            time.Font.Size = 12;
            time.Value = "Thời gian tạo danh sách: " + DateTime.Now;

            exSheet.Range["A6:D6"].Font.Bold = true;
            exSheet.Range["A6:D6"].HorizontalAlignment = XlHAlign.xlHAlignCenter;

            exSheet.Range["A6"].Value = "STT";
            exSheet.Range["B6"].Value = "Tên nhà cung cấp";
            exSheet.Range["C6"].Value = "Địa chỉ";
            exSheet.Range["D6"].Value = "Số điện thoại";

            exSheet.Range["A6"].ColumnWidth = 5;
            exSheet.Range["B6"].ColumnWidth = 60;
            exSheet.Range["C6"].ColumnWidth = 100;
            exSheet.Range["D6"].ColumnWidth = 15;

            var i = 7;
            for (var j = 0; j < suppliers.Count; i++, j++)
            {
                var supplier = suppliers[j];
                exSheet.Range[$"A{i}"].Value = j + 1;
                exSheet.Range[$"B{i}"].Value = supplier.Name;
                exSheet.Range[$"C{i}"].Value = supplier.Address;

                switch (supplier.PhoneNumber.Count)
                {
                    case 0:
                        break;
                    case 1:
                        exSheet.Range[$"D{i}"].Value = $"'{supplier.PhoneNumber[0]}";
                        break;
                    default:
                        {
                            var startRow = i;
                            for (var k = 0; k < supplier.PhoneNumber.Count; k++)
                            {
                                exSheet.Range[$"D{i}"].Value = $"'{supplier.PhoneNumber[k]}";
                                if (k < supplier.PhoneNumber.Count - 1)
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

            var border = exSheet.Range[$"A6:D{i - 1}"].Borders;
            SetBorder(border);

            exSheet.Name = "Nhà cung cấp";

            RequestToSave(exApp, exBook);
        }

        #endregion

        #region Export Material

        public static void Export(List<Material> materials)
        {
            var (exApp, exBook, exSheet) = InitExcelFile();

            PrintCompany(exSheet);

            var header = (Range)exSheet.Cells[2, 2];
            exSheet.Range["B2:E2"].Merge(true);
            header.Font.Size = 14;
            header.Font.Bold = true;
            header.Font.Color = Color.Red;
            header.Value = "DANH SÁCH VẬT LIỆU";

            exSheet.Range["A6:G6"].Font.Bold = true;
            exSheet.Range["A6:G6"].HorizontalAlignment = XlHAlign.xlHAlignCenter;

            exSheet.Range["A6"].Value = "ID";
            exSheet.Range["B6"].Value = "Tên vật liệu";
            exSheet.Range["C6"].Value = "Đơn vị";
            exSheet.Range["D6"].Value = "Quy cách";
            exSheet.Range["E6"].Value = "Số lượng";
            exSheet.Range["F6"].Value = "Đơn giá nhập";
            exSheet.Range["G6"].Value = "Đơn giá xuất";

            exSheet.Range["A6"].ColumnWidth = 5;
            exSheet.Range["B6"].ColumnWidth = 40;
            exSheet.Range["C6"].ColumnWidth = 15;
            exSheet.Range["D6"].ColumnWidth = 10;
            exSheet.Range["E6"].ColumnWidth = 12;
            exSheet.Range["F6"].ColumnWidth = 15;
            exSheet.Range["G6"].ColumnWidth = 15;

            var i = 7;
            for (var j = 0; j < materials.Count; i++, j++)
            {
                var material = materials[j];
                exSheet.Range[$"A{i}"].Value = material.Id;
                exSheet.Range[$"B{i}"].Value = material.Name;
                exSheet.Range[$"C{i}"].Value = material.Unit;
                exSheet.Range[$"D{i}"].Value = material.Specialization;
                exSheet.Range[$"E{i}"].Value = material.Numerous;
                exSheet.Range[$"F{i}"].Value = material.ImportUnitPrice;
                exSheet.Range[$"G{i}"].Value = material.ExportUnitPrice;

            }

            var border = exSheet.Range[$"A6:G{i - 1}"].Borders;
            SetBorder(border);

            exSheet.Name = "Vật liệu";

            RequestToSave(exApp, exBook);
        }

        #endregion

        #region Private Methods

        private static void SetBorder(Borders border)
        {
            border.LineStyle = XlLineStyle.xlContinuous;
            border.ColorIndex = XlConstants.xlAutomatic;
            border.TintAndShade = 0;
            border.Weight = XlBorderWeight.xlThin;
        }

        private static Tuple<Application, Workbook, Worksheet> InitExcelFile()
        {
            var exApp = new Application();
            var exBook = exApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            var exSheet = (Worksheet)exBook.Worksheets[1];

            return new Tuple<Application, Workbook, Worksheet>(exApp, exBook, exSheet);
        }

        private static void PrintCompany(_Worksheet exSheet)
        {
            var companyExcel = (Range)exSheet.Cells[1, 1];
            companyExcel.Font.Size = 13;
            companyExcel.Font.Bold = true;
            companyExcel.Font.Color = Color.Blue;
            companyExcel.Value = "VẬT LIỆU XÂY DỰNG AN HIỆP - CÔNG TY TNHH THƯƠNG MẠI VÀ DỊCH VỤ AN HIỆP";
        }

        private static void RequestToSave(_Application exApp, _Workbook exBook)
        {
            exBook.Activate();
            if (DlgSave.ShowDialog() == DialogResult.OK)
                exBook.SaveAs(DlgSave.FileName);
            exApp.Quit();
        }

        #endregion
    }
}
