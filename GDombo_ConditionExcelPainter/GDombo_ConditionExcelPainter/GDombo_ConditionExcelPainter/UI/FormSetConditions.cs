using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDombo_ConditionExcelPainter
{
    public partial class FormSetConditions : Form
    {
        private readonly DataGridView dataGridView;

        private string[] arrCols;
        private string[] arrOptions;
        public FormSetConditions(DataGridView dataGridView)
        {
            InitializeComponent();
            // 소스 전체에서 필요할때 사용할수 있도록 캐싱
            this.dataGridView = dataGridView;
            /////////////////////////////////////////////////////
        }
        private void FormSetConditions_Load(object sender, EventArgs e)
        {
            DataTable dataTable = dataGridView.DataSource as DataTable;
            List<string> lPrimaryCandidates = new List<string>();

            int colIdx = 0;
            int dateColIdx = -1; // 날짜 형식의 Col을 찾음
            int nameIdx = -1;  // 이름 형식의 Col을 찾음
            int optionColIdx = -1; // 상품옵션 컬럼을 찾음
            int cntColIdx = -1; // 상품수량 컬럼을 찾음

            arrCols = new string[dataTable.Columns.Count];
            foreach (DataColumn column in dataTable.Columns)
            {
                string sColumnName = arrCols[colIdx++] = column.ColumnName;
                cbxOrderBy.Items.Add(sColumnName);
                cbxOrderBy2.Items.Add(sColumnName);
                cbxGoodsOptionCol.Items.Add(sColumnName);
                cbxBuyCntCol.Items.Add(sColumnName);
                HashSet<string> uniqueValues = new HashSet<string>();
                bool hasNull = false;
                bool DateCol = true;

                foreach (DataRow row in dataTable.Rows)
                {
                    string value = row[column].ToString();
                    if (string.IsNullOrEmpty(value))
                    {
                        hasNull = true;
                        DateCol = false; // Null 이어도 찾은 컬럼은아님
                        break;
                    }
                    uniqueValues.Add(value);
                    if (!DateTime.TryParse(value, out _))
                    {
                        DateCol = false;
                    }
                }
                if (!hasNull && uniqueValues.Count == dataTable.Rows.Count)
                {
                    lPrimaryCandidates.Add(sColumnName);
                }
                if (optionColIdx == -1 && sColumnName.Contains("옵션"))
                {
                    optionColIdx = colIdx - 1;
                }
                else if (cntColIdx == -1 && sColumnName.Contains("수량"))
                {
                    cntColIdx = colIdx - 1;
                }
                else if (dateColIdx == -1 && DateCol)
                {
                    dateColIdx = colIdx - 1;
                }
                else if (nameIdx == -1 && sColumnName.Contains("주문자"))
                {
                    nameIdx = colIdx - 1;
                }
            }
            int nLength = lPrimaryCandidates.Count();
            if (nLength <= 0)
            {
                MessageBox.Show("데이터 잘못됨 엑셀 파일 확인 필요함 - 기본키 잘못됨");
                this.DialogResult = DialogResult.Abort;
                return;
            }

            for (int i = 0; i < nLength; i++)
                cbxPrimaryKey.Items.Add(lPrimaryCandidates[i]);

            cbxPrimaryKey.SelectedIndex = 0;
            cbxOrderBy.SelectedIndex = dateColIdx < 0 ? 0 : dateColIdx;
            cbxOrderBy2.SelectedIndex = nameIdx < 0 ? 0 : nameIdx;
            cbxGoodsOptionCol.SelectedIndex = optionColIdx < 0 ? 0 : optionColIdx;
            cbxBuyCntCol.SelectedIndex = cntColIdx < 0 ? 0 : cntColIdx;

            foreach (eConditions cond in Enum.GetValues(typeof(eConditions)))
            {
                cbxAddCondition.Items.Add(cond.GetDescription());
            }
            cbxAddCondition.SelectedIndex = 0;

            // 이부분 인터페이스로 뺄수 있면 빼자
            foreach (Control control in vflpCondition.Controls)
            {
                if (control is ucConditionOrder conditionOrder)
                {
                    conditionOrder.SetOptionRange(arrCols);
                }
                else if (control is ucConditionQuantity conditionCount)
                {
                    conditionCount.SetOptionRange(arrCols);
                }
                else if (control is ucConditionDuplicate conditionDuplicate)
                {
                    conditionDuplicate.SetOptionRange(arrCols);
                }
            }
        }
        private void cbxSelectOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = dataGridView.DataSource as DataTable;
                vflpOptionCnt.SuspendLayout();
                vflpOptionCnt.Controls.Clear();

                HashSet<string> uniqueValues = new HashSet<string>();
                string selectedColumn = cbxGoodsOptionCol.SelectedItem.ToString();
                List<ucSetOptionCount> lucSetOptionCnts = new List<ucSetOptionCount>();
                foreach (DataRow row in dataTable.Rows)
                {
                    string value = row[selectedColumn].ToString();
                    if (string.IsNullOrEmpty(value) ||
                        uniqueValues.Contains(value))
                        continue;
                    uniqueValues.Add(value);
                    lucSetOptionCnts.Add(new ucSetOptionCount() { OptionName = value });
                }
                arrOptions = uniqueValues.ToArray();
                vflpOptionCnt.Controls.AddRange(lucSetOptionCnts.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                vflpOptionCnt.ResumeLayout();
            }
        }
        private void btnAddCondtion_Click(object sender, EventArgs e)
        {
            vflpCondition.SuspendLayout(); // 레이아웃 일시 중지
            try
            {
                int maxLevel = vflpCondition.Controls.OfType<ICondtions>().Max(c => c.Level) + 1;
                ICondtions condtions;
                switch (cbxAddCondition.SelectedIndex)
                {
                    case (int)eConditions.Order:
                        condtions = new ucConditionOrder(arrCols);
                        break;
                    case (int)eConditions.Duplicate:
                        condtions = new ucConditionDuplicate(arrCols);
                        break;
                    case (int)eConditions.Quantity:
                        condtions = new ucConditionQuantity(arrCols);
                        break;
                    case (int)eConditions.OptionBuyOrder:
                        condtions = new ucConditionOptionBuyOrder(arrOptions);
                        break;
                    default:
                        return;
                }
                condtions.Level = maxLevel;
                vflpCondition.Controls.Add(condtions as Control);
            }
            finally
            {
                vflpCondition.ResumeLayout(false); // 레이아웃 다시 시작
                vflpCondition.PerformLayout(); // 레이아웃 강제 업데이트서 
            }
        }
        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. 정렬 설정 
                string sOrderBy = cbxOrderBy.SelectedItem.ToString();
                string sOrderBy2 = cbxOrderBy2.SelectedItem.ToString();
                DataTable dataTable = dataGridView.DataSource as DataTable;
                dataTable.DefaultView.Sort = $"{sOrderBy} ASC, {sOrderBy2} ASC"; // ASC 또는 DESC
                dataTable = dataTable.DefaultView.ToTable();

                // 2. 기본키 설정
                string sPrimaryKey = cbxPrimaryKey.SelectedItem.ToString();
                DataColumn dcPrimaryKey = dataTable.Columns[sPrimaryKey];
                dataTable.PrimaryKey = new DataColumn[] { dcPrimaryKey };

                // 3. 상품옵션 설정
                string sBuyCntColName = cbxBuyCntCol.SelectedItem.ToString();
                string sOptionColName = cbxGoodsOptionCol.SelectedItem.ToString();
                Dictionary<string, int> dicGoodsQuntity = new Dictionary<string, int>();
                foreach (Control control in vflpOptionCnt.Controls)
                {
                    if (control is ucSetOptionCount setOptionCnt)
                    {
                        if (string.IsNullOrEmpty(setOptionCnt.OptionName))
                            continue;
                        dicGoodsQuntity.Add(setOptionCnt.OptionName, setOptionCnt.OptionCount);
                    }
                }

                // 5. 조건 계산
                cConditionCalculator conditionCalculator = new cConditionCalculator(sPrimaryKey, sBuyCntColName, sOptionColName, dicGoodsQuntity);
                ILookup<int, ICondtions> lookups = vflpCondition.Controls.OfType<ICondtions>().ToLookup(c => c.Level);
                foreach (IGrouping<int, ICondtions> group in lookups)
                {
                    int level = group.Key;
                    foreach (ICondtions condtions in group)
                    {
                        condtions.CondtionResult(dataTable, ref conditionCalculator);
                    }
                }

                // 4. 조건 적용 전 테이블 업데이트
                dataGridView.DataSource = dataTable;

                // 6. 조건 계산 후 테이블 업데이트
                conditionCalculator.PaintDataGridView(dataGridView);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
