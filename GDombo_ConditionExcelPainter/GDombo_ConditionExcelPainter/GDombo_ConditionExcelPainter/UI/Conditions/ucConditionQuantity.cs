using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GDombo_ConditionExcelPainter
{
    public partial class ucConditionQuantity : UserControl, ICondtions
    {
        public string[] SelectedCols => null;
        [Category("Action")]
        [Description("Put Level between 0~10")]
        public int Level
        {
            get { return ConditionCommon.Level; }
            set { ConditionCommon.Level = value; }
        }
        [Category("Action")]
        [Description("Put Type of Painting Color")]
        public eConditionType ConditionType
        {
            get { return ConditionCommon.ConditionType; }
            set { ConditionCommon.ConditionType = value; }
        }
        [Category("Action")]
        [Description("Put Color to Paint")]
        public Color SelectColor
        {
            get { return ConditionCommon.SelectColor; }
            set { ConditionCommon.SelectColor = value; }
        }
        [Category("Action")]
        [Description("Put Goods Count")]
        public int nGoodsCount
        {
            get { return (int)numcGoodsCnt.Value; }
            set
            {
                if (value > numcGoodsCnt.Maximum)
                    value = (int)numcGoodsCnt.Maximum;
                numcGoodsCnt.Value = value;
            }
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
            string sBuyCntColName = conditionCalculator.sBuyCntColName;
            string sOptionColName = conditionCalculator.sOptionColName;
            ReadOnlyDictionary<string, int> dicGoodsQuntity = conditionCalculator.dicGoodsQuntity;

            // 그룹화 결과를 저장할 Dictionary
            Dictionary<string, GroupResult> groupedResults = new Dictionary<string, GroupResult>();
            
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow dataRow = dataTable.Rows[i];
                string groupKey = string.Join("|", SelectedCols.Select(col => dataRow[col].ToString()));

                int nBuyCntColName = Convert.ToInt32(dataRow[sBuyCntColName]);
                string sGoodsQuntityValue = dataRow[sOptionColName].ToString();
                int nGoodsQuntity = dicGoodsQuntity[sGoodsQuntityValue];

                int TotalGoodsCount = nBuyCntColName * nGoodsQuntity;
                if (groupedResults.ContainsKey(groupKey))
                    groupedResults[groupKey].TotalGoodsCount += TotalGoodsCount;
                else
                    groupedResults[groupKey] = new GroupResult(dataRow[sPrimaryColName].ToString(), TotalGoodsCount);
            }


            int nPeopleCnt = 0;
            int nLimitPeopleCnt = (int)numcLimitPeopleCnt.Value;
            foreach (GroupResult groupResult in groupedResults.Values)
            {
                int nTotalGoodsCount = groupResult.TotalGoodsCount;
                if (nTotalGoodsCount < nGoodsCount)
                    continue;
                DataRow dataRow = dataTable.Rows.Find(groupResult.FirstRowPrimaryValue);
                string sPrimaryValue = dataRow[sPrimaryColName].ToString();
                if (conditionCalculator.LevelCheck(sPrimaryValue, Level) == false)
                    continue;

                if (++nPeopleCnt > nLimitPeopleCnt)
                    break;
                conditionCalculator.AddCondtions(sPrimaryValue, this);
            }
        }
        public ucConditionQuantity()
        {
            InitializeComponent();
        }
        public ucConditionQuantity(string[] sColNames) : this()
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
        private class GroupResult
        {
            public readonly string FirstRowPrimaryValue;
            public int TotalGoodsCount { get; set; }

            public GroupResult(string firstRowPrimaryValue, int totalGoodsCount)
            {
                FirstRowPrimaryValue = firstRowPrimaryValue;
                TotalGoodsCount = totalGoodsCount;
            }
        }
    }
}
