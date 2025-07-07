using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDombo_ConditionExcelPainter
{
    public partial class FormSearch : Form
    {
        private readonly DataGridView dgvMain;
        public FormSearch(DataGridView dgvMain)
        {
            InitializeComponent();
            this.dgvMain = dgvMain;
        }

        private void FormSearch_Shown(object sender, EventArgs e)
        {
            if (dgvMain.CurrentCell == null || dgvMain.CurrentCell.Value == null)
                tbxSearch.Text = string.Empty; // 선택된 셀이 없거나 값이 없으면 텍스트박스를 비움
            else
                tbxSearch.Text = dgvMain.CurrentCell.Value.ToString(); // 선택된 셀의 텍스트를 텍스트박스에 설정
        }
        private void btnAllSearch_Click(object sender, EventArgs e)
        {
            string searchText = tbxSearch.Text.Trim(); // 검색할 텍스트 가져오기
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("검색어를 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvAllSearchResult.Rows.Clear(); // 모든 검색 결과 초기화
            // 모든 셀 검색
            for (int nRowIdx = 0; nRowIdx < dgvMain.Rows.Count; nRowIdx++)
            {
                DataGridViewRow row = dgvMain.Rows[nRowIdx];
                for (int nColIdx = 0; nColIdx < dgvMain.Columns.Count; nColIdx++)
                {
                    DataGridViewCell cell = row.Cells[nColIdx];
                    if (cell.Value == null)
                        continue;

                    if (cell.Value.ToString().Contains(searchText))
                    {
                        string headerText = dgvMain.Columns[cell.ColumnIndex].HeaderText; // 열 이름
                        string rowIdx = (row.Index + 1).ToString(); // 행 번호
                        string cellValue = cell.Value.ToString();
                        dgvAllSearchResult.Rows.Add(headerText, rowIdx, cellValue);
                    }
                }
            }
        }

        private void FormSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();   // 리소스 정리
        }

        private void dgvAllSearchResult_SelectionChanged(object sender, EventArgs e)
        {
            dgvMain.SuspendLayout();
            try
            {
                if (dgvAllSearchResult.SelectedRows.Count == 0)
                    return;

                // 선택된 행 가져오기
                DataGridViewRow selectedRow = dgvAllSearchResult.SelectedRows[0];
                // 열 이름, 행 번호 가져오기
                string columnName = selectedRow.Cells[0].Value?.ToString(); // 열 이름
                string rowIndexStr = selectedRow.Cells[1].Value?.ToString(); // 행 번호
                if (string.IsNullOrEmpty(columnName) || string.IsNullOrEmpty(rowIndexStr))
                    return;

                if (!int.TryParse(rowIndexStr, out int rowIndex))
                    return;

                dgvMain.CurrentCell = dgvMain.Rows[rowIndex - 1].Cells[columnName];
                dgvMain.FirstDisplayedScrollingRowIndex = rowIndex - 1; // 스크롤 이동
            }
            finally
            {
                dgvMain.ResumeLayout();
            }
        }
    }
}
