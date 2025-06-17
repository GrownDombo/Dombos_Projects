using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDombo_CustomControl
{
    public partial class CheckBoxComboBox : ComboBox
    {
        private readonly CheckBoxComboBoxDropdown dropdownPanel;
        private readonly ToolStripDropDown dropDown;
        public CheckBox[] GetItems => dropdownPanel.GetItems;
        private string sText;
        public CheckBoxComboBox()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            this.sText = string.Empty;

            // 기본 설정
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.DropDownHeight = 1; // 기본 드롭다운 숨기기
            this.DropDownStyle = ComboBoxStyle.DropDownList;

            dropdownPanel = new CheckBoxComboBoxDropdown();
            dropdownPanel.CheckedChanged += DropdownPanel_CheckedChanged; // 이벤트 핸들러 추가
            ToolStripControlHost host = new ToolStripControlHost(dropdownPanel)
            {
                Padding = Padding.Empty,
                Margin = Padding.Empty,
                AutoSize = true
            };
            dropDown = new ToolStripDropDown
            {
                AutoClose = true,
                Padding = Padding.Empty
            };
            dropDown.Closing += dropdown_Closing;
            dropDown.Items.Add(host);
        }
        private void DropdownPanel_CheckedChanged(object sender, EventArgs e)
        {
            UpdateText();
        }
        private void dropdown_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            if (e.CloseReason == ToolStripDropDownCloseReason.ItemClicked)
                e.Cancel = true;
            UpdateText();
        }
        private void UpdateText()
        {
            CheckBox[] checkBoxes = dropdownPanel.GetItems;
            List<string> selectedItems = new List<string>();
            for (int i = 0; i < checkBoxes.Length; i++)
            {
                if (checkBoxes[i].Checked)
                    selectedItems.Add(checkBoxes[i].Text);
            }
            this.sText = string.Join(", ", selectedItems);
            Invalidate();
        }
        public void AddItem(string item, bool isChecked = false)
        {
            dropdownPanel.AddItem(item, isChecked);
            UpdateText();
        }
        public void AddItemRange(string[] items)
        {
            dropdownPanel.AddItemRange(items);
            UpdateText();
        }
        public void ItemClear()
        {
            dropdownPanel.ItemClear();
            UpdateText();
        }

        protected async override void OnClick(EventArgs e)
        {
            this.SuspendLayout();
            await Task.Delay(10);
            dropDown.Show(this, new Point(0, this.Height));
            dropdownPanel.Focus(); // 포커스를 패널로 줘서 외부 클릭 감지 유도
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            this.SuspendLayout();
            e.DrawBackground(); // 배경 그리기 추가
            using (SolidBrush brush = new SolidBrush(e.ForeColor))
                e.Graphics.DrawString(sText, e.Font, brush, e.Bounds);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
