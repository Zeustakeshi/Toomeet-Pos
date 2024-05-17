using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.UI.UC;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using Toomeet_Pos.BLL.Interfaces;
using Microsoft.Office.Interop.Excel;

namespace Toomeet_Pos.BLL
{



    public class ExcelService : IExcelService
    {
        public void ImportExcelFile(string path, CustomDataGridView dataGridView)
        {
            throw new NotImplementedException();
           
        }

   

        public void ExportExcelFile(string path, string title, CustomDataGridView dataGridView)
        {

            Excel.Application application = new Excel.Application();

            Excel.Workbook workbook =  application.Application.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            // TILE
            Excel.Range titleRange = worksheet.get_Range("D2", "H2");
            titleRange.Merge();
            titleRange.Value = title;
            titleRange.Font.Size = 20;
            titleRange.Font.Bold = true;
            titleRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            titleRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
           

            // HEADER TEXT
            for (int i = 0; i < dataGridView.ColumnCount; ++i)
            {
                worksheet.Cells[4, i + 1] = dataGridView.Columns[i].HeaderText;
            }

            Excel.Range headerRange = worksheet.get_Range("A4", (Excel.Range)worksheet.Cells[4, dataGridView.ColumnCount]);
            headerRange.Font.Bold = true;
            headerRange.Interior.Color = Excel.XlRgbColor.rgbForestGreen; // Màu nền nổi bật
            headerRange.Font.Name = "Arial"; // Đổi font chữ
            headerRange.Font.Size = 16; // Đổi cỡ chữ
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; // Canh giữa

            // CONTENT

            for (int i = 0; i < dataGridView.RowCount; ++i)
            {
                for (int j = 0; j < dataGridView.ColumnCount; ++j)
                {
                    worksheet.Cells[i + 5, j + 1] = dataGridView.Rows[i].Cells[j].Value;

                }
            }

            worksheet.Columns.AutoFit();
            workbook.SaveAs(path);
            workbook.Close();
            application.Quit();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(application);

        }



    }
}
