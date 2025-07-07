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
    public partial class ucConditionDuplicate : UserControl, ICondtions
    {
        private string[] selectedCols;
        public string[] SelectedCols => selectedCols;

        [Category("Action")]
        [Description("Put Level between 0~10")]
        public int Level
        {
            get { return ucConditionCommon.Level; }
            set { ucConditionCommon.Level = value; }
        }
        [Category("Action")]
        [Description("Put Type of Painting Color")]
        public eConditionType ConditionType
        {
            get { return ucConditionCommon.ConditionType; }
            set { ucConditionCommon.ConditionType = value; }
        }
        [Category("Action")]
        [Description("Put Color to Paint")]
        public Color SelectColor
        {
            get { return ucConditionCommon.SelectColor; }
            set { ucConditionCommon.SelectColor = SelectColor; }
        }
        public void CondtionResult(DataTable dataTable, ref cConditionCalculator conditionCalculator)
        {
            string sPrimaryColName = conditionCalculator.sPrimaryColName;

            selectedCols = cbxcomSelectCols.GetItems.Where(CheckBox => CheckBox.Checked).Select(CheckBox => CheckBox.Text).ToArray();
            Dictionary<string, List<DataRow>> groupedResults = new Dictionary<string, List<DataRow>>();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow dataRow = dataTable.Rows[i];
                string groupKey = string.Join("|", selectedCols.Select(col => dataRow[col].ToString()));
                if (groupedResults.ContainsKey(groupKey))
                    groupedResults[groupKey].Add(dataRow);
                else
                    groupedResults[groupKey] = new List<DataRow> { dataRow };
            }
            foreach (List<DataRow> rows in groupedResults.Values)
            {
                if (rows.Count <= 1)
                    continue; // 중복이 아니면 패스
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow row = rows[i];
                    string sPrimaryValue = row[sPrimaryColName].ToString();
                    if (conditionCalculator.LevelCheck(sPrimaryValue, Level) == false)
                        continue;
                    conditionCalculator.AddCondtions(sPrimaryValue, this);
                }
            }
        }
        public ucConditionDuplicate()
        {
            InitializeComponent();
        }
        public ucConditionDuplicate(string[] sColNames) : this()
        {
            SetOptionRange(sColNames);
        }
        public void SetOptionRange(string[] sColNames)
        {
            cbxcomSelectCols.ItemClear();
            cbxcomSelectCols.AddItemRange(sColNames);
            CheckBox checkBox = cbxcomSelectCols.GetItems.FirstOrDefault(CheckBox => CheckBox.Text.Contains("주소"));
            if (checkBox != null)
                checkBox.Checked = true;
        }
        private void ucConditonCommon_DeleteButtonClick(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
    }
}
