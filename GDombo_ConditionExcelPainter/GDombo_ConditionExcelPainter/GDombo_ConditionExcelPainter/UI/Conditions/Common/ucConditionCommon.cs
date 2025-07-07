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
    public partial class ucConditionCommon : UserControl, ICondtionsCommon
    {
        [Category("Action")]
        [Description("Put Level between 0~10")]
        public int Level
        {
            get { return (int)numcLevel.Value; }
            set
            {
                if (value > numcLevel.Maximum)
                    value = (int)numcLevel.Maximum;
                numcLevel.Value = value;
            }
        }
        [Category("Action")]
        [Description("Put Type of Painting Color")]
        public eConditionType ConditionType
        {
            get { return (eConditionType)Enum.Parse(typeof(eConditionType), btnFontOrFill.Text); }
            set { btnFontOrFill.Text = value.ToString(); }
        }
        [Category("Action")]
        [Description("Put Color to Paint")]
        public Color SelectColor
        {
            get { return colorComboBox1.SelectedColor; }
            set { colorComboBox1.SelectedColor = value; }
        }
        [Category("Action")]
        [Description("Occurs when the Delete button is clicked.")]
        public event EventHandler DeleteButtonClick;
        public ucConditionCommon()
        {
            InitializeComponent();
            btnFontOrFill.Text = eConditionType.Font.ToString();
            ttConditionCommon.SetToolTip(numcLevel, "조건 Level을 0~10 사이로 입력하세요.");
            ttConditionCommon.SetToolTip(btnFontOrFill, "글자색 변경 or 셀 배경색 변경.");
            ttConditionCommon.SetToolTip(btnDelete, "해당조건 제거.");
        }
        private void btnFontOrFill_Click(object sender, EventArgs e)
        {
            if (btnFontOrFill.Text == eConditionType.Font.ToString())
                btnFontOrFill.Text = eConditionType.Fill.ToString();
            else
                btnFontOrFill.Text = eConditionType.Font.ToString();

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteButtonClick?.Invoke(this, e);
        }
    }
}
