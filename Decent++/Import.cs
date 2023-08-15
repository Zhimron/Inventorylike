using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;


namespace Decent__
{
    public partial class Import : UserControl
    {
        public Import()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;//license for use
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Create Excel Application and Workbook
                Application excelApp = new Application();
                Workbook excelWorkbook = excelApp.Workbooks.Open(filePath);
                Worksheet excelWorksheet = excelWorkbook.Sheets[1]; // Assuming the data is on the first sheet

                // Get the used range of the worksheet
                Range usedRange = excelWorksheet.UsedRange;
                if (usedRange.Columns.Count > 5)
                {
                    MessageBox.Show("The imported file has more than 6 columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Loop through the rows and add data to the DataGridView
                for (int row = 2; row <= usedRange.Rows.Count; row++) // Start from row 2 to skip the header
                {
                    dgv1.Rows.Add(usedRange.Cells[row, 1].Value, usedRange.Cells[row, 2].Value, usedRange.Cells[row, 3].Value, usedRange.Cells[row, 4].Value, usedRange.Cells[row, 5].Value, usedRange.Cells[row, 6].Value);
                    // Add more cells as needed
                }

                // Close and release Excel objects
                excelWorkbook.Close();
                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorkbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                // Clean up
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }

        }
    }
}
