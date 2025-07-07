using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDombo_ConditionExcelPainter
{
    public partial class ucSetOptionCount : UserControl
    {
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Gets or sets the text of the option name label.")]
        [Category("Custom")]
        public string OptionName
        {
            get { return lbOptionName.Text; }
            set
            {
                lbOptionName.Text = value;
                // 숫자 추출 및 numOptionCnt에 적용
                if (!string.IsNullOrEmpty(value))
                {
                    // 정규식을 사용하여 숫자 추출
                    Match match = Regex.Match(value, @"\d+");
                    if (match.Success && int.TryParse(match.Value, out int extractedNumber))
                    {
                        // 추출된 숫자를 numOptionCnt에 설정
                        numOptionCnt.Value = Math.Min(numOptionCnt.Maximum, extractedNumber);
                    }
                }
            }
        }
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Gets or sets the text of the option name label.")]
        [Category("Custom")]
        public int OptionCount
        {
            get { return (int)numOptionCnt.Value; }
            set { numOptionCnt.Value = value; }
        }
        public ucSetOptionCount()
        {
            InitializeComponent();
        }
    }
}
