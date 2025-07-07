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
    public partial class ucConditionOptionBuyOrder : UserControl, ICondtions
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
            string[] SelectedCols = cbxcomSelectOptions.GetItems.Where(CheckBox => CheckBox.Checked).Select(CheckBox => CheckBox.Text).ToArray();
            if (SelectedCols.Length == 0)
                return;
            string sPrimaryColName = conditionCalculator.sPrimaryColName;
            string sOptionColName = conditionCalculator.sOptionColName;

            int nPeopleCnt = 0;
            int nLimitPeopleCnt = (int)numcLimitPeopleCnt.Value;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow dataRow = dataTable.Rows[i];
                string sOptionValue = dataRow[sOptionColName].ToString();
                if (SelectedCols.Contains(sOptionValue))
                {
                    string sPrimaryValue = dataRow[sPrimaryColName].ToString();
                    if (conditionCalculator.LevelCheck(sPrimaryValue, Level) == false)
                        continue;
                    if (++nPeopleCnt > nLimitPeopleCnt)
                        break;
                    conditionCalculator.AddCondtions(sPrimaryValue, this);
                }
            }
        }
        public ucConditionOptionBuyOrder()
        {
            InitializeComponent();
        }
        public ucConditionOptionBuyOrder(string[] sOptions) : this()
        {
            cbxcomSelectOptions.ItemClear();
            cbxcomSelectOptions.AddItemRange(sOptions);
        }

        private void ConditionCommon_DeleteButtonClick(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
    }
}
