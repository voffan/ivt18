﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gallery
{
    public partial class ReportForm : Form
    {
        public Context C { get; set; }
        public int id = 0;
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            object Nothing = System.Reflection.Missing.Value;
            var app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = false;
            Microsoft.Office.Interop.Excel.Workbook workBook = app.Workbooks.Add(Nothing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workBook.Sheets[1];
            worksheet.Name = "WorkSheet";

            worksheet.Cells[1, 1] = "Отчет от ";
            worksheet.Cells[1, 2] = dateTimePicker1.Value + " - " + dateTimePicker2.Value;

            for (int i = 1; i <= reportDataGrid.RowCount; i++)
            {
                for (int j = 1; j < reportDataGrid.ColumnCount + 1; j++)
                {
                    worksheet.Cells[2, j] = reportDataGrid.Columns[j - 1].HeaderText;
                    worksheet.Cells[i + 2, j] = reportDataGrid.Rows[i - 1].Cells[j - 1].Value;
                }
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                worksheet.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing);
                workBook.Close(false, Type.Missing, Type.Missing);
                app.Quit();
            }

        }

        private void reportDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var results = ReportLogic.loadData(dateTimePicker1.Value, dateTimePicker2.Value, C);

            reportDataGrid.DataSource = results;
        }
    }
}
