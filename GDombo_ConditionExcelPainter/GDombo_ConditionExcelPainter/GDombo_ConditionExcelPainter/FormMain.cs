using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using ClosedXML.Excel;
using System.Diagnostics;
using System.Runtime.InteropServices;
namespace GDombo_ConditionExcelPainter
{
    public partial class FormMain : Form
    {
        private string sPath;
        public FormMain()
        {
            InitializeComponent();
            sPath = string.Empty;
        }
        private DataTable LoadFileToDataTable(string fileFullPath)
        {
            string tableName = Path.GetFileNameWithoutExtension(fileFullPath);
            DataTable table = new DataTable(tableName);
            List<string> duplValues = new List<string>();
            using (XLWorkbook workbook = new XLWorkbook(fileFullPath))
            {
                IXLWorksheet worksheet = workbook.Worksheet(1);// 첫 번째 시트를 가져옴
                int firstColIndex = worksheet.FirstColumnUsed().ColumnNumber(); // 첫 번째로 비어있지 않은 열의 번호
                int firstRowIndex = worksheet.FirstRowUsed().RowNumber();       // 첫 번째로 비어있지 않은 행의 번호
                int lastColIndex = worksheet.LastColumnUsed().ColumnNumber();   // 마지막 번째로 비어있지 않은 열의 번호
                int lastRowIndex = worksheet.LastRowUsed().RowNumber();         // 마지막 번째로 비어있지 않은 행의 번호

                for (int col = firstColIndex; col <= lastColIndex; col++)
                    table.Columns.Add(worksheet.Cell(firstRowIndex, col).GetString());
                for (int row = firstRowIndex + 1; row <= lastRowIndex; row++)               // 데이터를 DataTable에 추가
                {
                    DataRow dataRow = table.NewRow();
                    for (int col = firstColIndex; col <= lastColIndex; col++)
                        dataRow[col - firstColIndex] = worksheet.Cell(row, col).GetString();  // 셀 값을 DataTable에 추가
                    table.Rows.Add(dataRow);
                }
            }
            return table;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                sPath = openFileDialog.FileName;
            }

            if (File.Exists(sPath) == false)
                return;
            switch (Path.GetExtension(sPath))
            {
                case ".xlsx":
                case ".xls":
                    break;
                default:
                    MessageBox.Show("지원하지 않는 파일 형식입니다.");
                    return;
            }
            this.Text = $"Condition Excel Painter - {sPath}";
            dgvMain.DataSource = LoadFileToDataTable(sPath);
            using (FormSetConditions formDataDetails = new FormSetConditions(dgvMain))
            {
                formDataDetails.Owner = this;
                formDataDetails.ShowDialog();
            }
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://growndombo.tistory.com/7");
        }
        private void dgvMain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn col in dgvMain.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        private void dgvMain_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string rowIdx = (e.RowIndex + 1).ToString(); // 1부터 시작하는 행 번호
            StringFormat centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            // RowHeader에 행 번호 그리기
            Rectangle headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgvMain.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, dgvMain.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(sPath))
                {
                    MessageBox.Show($"Path Error : {sPath}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string exportFilePath = $"{Path.GetDirectoryName(sPath)}\\{Path.GetFileNameWithoutExtension(sPath)}_Painted{Path.GetExtension(sPath)}";

                using (XLWorkbook workbook = new XLWorkbook())
                {
                    IXLWorksheet worksheet = workbook.Worksheets.Add("ExportedData");
                    // DataGridView 헤더를 Excel로 복사
                    for (int col = 0; col < dgvMain.Columns.Count; col++)
                    {
                        worksheet.Cell(1, col + 1).Value = dgvMain.Columns[col].HeaderText; // 헤더
                        worksheet.Cell(1, col + 1).Style.Font.Bold = true;
                    }

                    // DataGridView 데이터를 Excel로 복사
                    for (int rowIdx = 0; rowIdx < dgvMain.Rows.Count; rowIdx++)
                    {
                        DataGridViewRow row = dgvMain.Rows[rowIdx];
                        for (int colIdx = 0; colIdx < dgvMain.Columns.Count; colIdx++)
                        {
                            DataGridViewCell cell = row.Cells[colIdx];
                            IXLCell excelCell = worksheet.Cell(rowIdx + 2, colIdx + 1);

                            // 값 설정
                            if (cell.Value != null)
                            {
                                string value = cell.Value.ToString();
                                if (double.TryParse(value, out double dRst))
                                    excelCell.Value = dRst;
                                else
                                    excelCell.Value = value;
                            }

                            if (row.DefaultCellStyle.BackColor != System.Drawing.Color.Empty)// Row 배경색 설정
                                excelCell.Style.Fill.BackgroundColor = XLColor.FromColor(row.DefaultCellStyle.BackColor);
                            if (row.DefaultCellStyle.ForeColor != System.Drawing.Color.Empty)// Row 글씨 색 설정 
                                excelCell.Style.Font.FontColor = XLColor.FromColor(row.DefaultCellStyle.ForeColor);

                            if (cell.Style.BackColor != System.Drawing.Color.Empty)// Cell 배경색 설정
                                excelCell.Style.Fill.BackgroundColor = XLColor.FromColor(cell.Style.BackColor);
                            if (cell.Style.ForeColor != System.Drawing.Color.Empty)// Cell 글씨 색 설정
                                excelCell.Style.Font.FontColor = XLColor.FromColor(cell.Style.ForeColor);

                        }
                    }

                    //열너비늘리는거해바
                    worksheet.Columns().AdjustToContents();

                    IXLRange usedRange = worksheet.RangeUsed();
                    usedRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    usedRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                    // Excel 파일 저장
                    workbook.SaveAs(exportFilePath);
                }
                Process.Start(exportFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"에러 {ex}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private FormSearch formSearch; // FormSearch를 필드로 선언
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F)) // Control + F 키 조합 확인
            {
                if (formSearch == null || formSearch.IsDisposed) // FormSearch가 없거나 이미 Dispose된 경우
                {
                    formSearch = new FormSearch(dgvMain);
                    formSearch.Owner = this; // FormSearch의 소유자를 현재 폼으로 설정
                }

                if (formSearch.Visible) // FormSearch가 보이지 않는 경우
                    formSearch.Focus(); // 이미 열려 있는 경우 포커스 설정
                else
                    formSearch.Show(); // FormSearch 창 열기
                return true; // 키 이벤트 처리 완료
            }
            return base.ProcessCmdKey(ref msg, keyData); // 기본 처리
        }
    }
}
