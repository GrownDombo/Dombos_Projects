using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GDombo_ConditionExcelPainter
{
    public class cConditionCalculator
    {
        // 조건 검색에 쓰이는 데이터
        public readonly string sPrimaryColName;
        public readonly string sBuyCntColName;
        public readonly string sOptionColName;
        
        public readonly ReadOnlyDictionary<string, int> dicGoodsQuntity;

        // 조건 검색 적용된 레벨 Key : PrimaryKey값, Value: ICondtionsCommon
        private readonly List<KeyValuePair<string, ICondtions>> ZeroLevelConditions;
        private readonly Dictionary<string, ICondtions> HighLevelConditions;

        public cConditionCalculator(string sPrimaryColName, string sBuyCntColName, string sOptionColName, Dictionary<string, int> dicGoodsQuntity)
        {
            this.sPrimaryColName = sPrimaryColName;
            this.sBuyCntColName = sBuyCntColName;
            this.sOptionColName = sOptionColName;
            this.dicGoodsQuntity = new ReadOnlyDictionary<string, int>(dicGoodsQuntity);

            ZeroLevelConditions = new List<KeyValuePair<string, ICondtions>>(); // Level이 0이면
            HighLevelConditions = new Dictionary<string, ICondtions>();
        }

        public bool LevelCheck(string sPrimaryKey, int nLevel)
        {
            if (HighLevelConditions.ContainsKey(sPrimaryKey))
            {
                ICondtions thisCondtion = HighLevelConditions[sPrimaryKey];
                if (thisCondtion.Level < nLevel)
                {
                    return false;
                }
            }
            return true;
        }
        public void AddCondtions(string sPrimaryKey, ICondtions condtions)
        {
            if (condtions.Level == 0)
                ZeroLevelConditions.Add(new KeyValuePair<string, ICondtions>(sPrimaryKey, condtions));
            else
                HighLevelConditions[sPrimaryKey] = condtions;
        }
        public void PaintDataGridView(DataGridView dgv)
        {
            IEnumerable<KeyValuePair<string, ICondtions>> mergedConditions = ZeroLevelConditions.Concat(HighLevelConditions);

            DataTable dataTable = dgv.DataSource as DataTable;

            foreach (KeyValuePair<string, ICondtions> kvp in mergedConditions)
            {
                string sPrimaryValue = kvp.Key;
                ICondtions condtions = kvp.Value;
                int nRowIdx = dataTable.Rows.IndexOf(dataTable.Rows.Find(sPrimaryValue));
                if (nRowIdx < 0)
                {
                    MessageBox.Show($"Row Index not found for {sPrimaryValue} in {sPrimaryValue} column", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

                if (condtions.SelectedCols == null)
                {
                    if (condtions.ConditionType == eConditionType.Font)// 글씨 색 변경
                        dgv.Rows[nRowIdx].DefaultCellStyle.ForeColor = condtions.SelectColor;
                    else // 배경색 변경
                        dgv.Rows[nRowIdx].DefaultCellStyle.BackColor = condtions.SelectColor;
                }
                else
                {
                    for (int nColIdx = 0; nColIdx < condtions.SelectedCols.Length; nColIdx++)
                    {
                        string sColName = condtions.SelectedCols[nColIdx];
                        if (condtions.ConditionType == eConditionType.Font) // 글씨 색 변경
                            dgv.Rows[nRowIdx].Cells[sColName].Style.ForeColor = condtions.SelectColor;
                        else // 배경색 변경
                            dgv.Rows[nRowIdx].Cells[sColName].Style.BackColor = condtions.SelectColor;
                    }
                }

            }
        }
    }
}
