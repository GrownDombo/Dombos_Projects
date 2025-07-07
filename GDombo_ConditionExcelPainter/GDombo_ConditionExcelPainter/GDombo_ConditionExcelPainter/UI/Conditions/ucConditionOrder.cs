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
    public partial class ucConditionOrder : UserControl, ICondtions
    {
        public string[] SelectedCols => null;
        [Category("Action")]
        [Description("Put Level between 0~10")]
        public int Level
        {
            get { return ucConditonCommon.Level; }
            set { ucConditonCommon.Level = value; }
        }
        [Category("Action")]
        [Description("Put Type of Painting Color")]
        public eConditionType ConditionType
        {
            get { return ucConditonCommon.ConditionType; }
            set { ucConditonCommon.ConditionType = value; }
        }
        [Category("Action")]
        [Description("Put Color to Paint")]
        public Color SelectColor
        {
            get { return ucConditonCommon.SelectColor; }
            set { ucConditonCommon.SelectColor = SelectColor; }
        }
        [Category("Action")]
        [Description("Put Goods Count")]
        public int nLimitPeopleCnt
        {
            get { return (int)numcLimitPeopleCnt.Value; }
            set
            {
                if (value > numcLimitPeopleCnt.Maximum)
                    value = (int)numcLimitPeopleCnt.Maximum;
                numcLimitPeopleCnt.Value = value;
            }
        }

        public void CondtionResult(DataTable dataTable, ref cConditionCalculator conditionCalculator)
        {
            string[] SelectedCols = cbxcomSelectCols.GetItems.Where(CheckBox => CheckBox.Checked).Select(CheckBox => CheckBox.Text).ToArray();
            if (SelectedCols.Length == 0)
                return;
            string sPrimaryColName = conditionCalculator.sPrimaryColName;
            string sOptionColName = conditionCalculator.sOptionColName;

            HashSet<string> duplicationCheck = new HashSet<string>();
            int nPeopleCnt = 0;
            int nLimitPeopleCnt = (int)numcLimitPeopleCnt.Value;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow dataRow = dataTable.Rows[i];
                string groupKey = string.Join("|", SelectedCols.Select(col => dataRow[col].ToString()));
                if (duplicationCheck.Contains(groupKey))
                    continue;
                duplicationCheck.Add(groupKey);

                string sPrimaryValue = dataRow[sPrimaryColName].ToString();
                if (conditionCalculator.LevelCheck(sPrimaryValue, Level) == false)
                    continue;
                if (++nPeopleCnt > nLimitPeopleCnt)
                    break;
                conditionCalculator.AddCondtions(sPrimaryValue, this);
            }
        }
        public ucConditionOrder()
        {
            InitializeComponent();
        }
        public ucConditionOrder(string[] sColNames) : this()
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
