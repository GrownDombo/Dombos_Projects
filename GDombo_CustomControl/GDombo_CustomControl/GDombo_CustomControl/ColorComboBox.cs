using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDombo_CustomControl
{
    public partial class ColorComboBox : ComboBox
    {
        private readonly ColorComboBoxDropdown dropdownPanel;
        private readonly ToolStripDropDown dropDown;
        private Color _selectedColor = Color.Red;
        public Color SelectedColor
        {
            get => _selectedColor;
            set
            {
                _selectedColor = value;
                this.Invalidate(); // 그려줄 수 있도록 다시 그리기
            }
        }
        public ColorComboBox()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.DropDownHeight = 1; // 기본 드롭다운 숨김
            this.DropDownStyle = ComboBoxStyle.DropDownList;

            dropdownPanel = new ColorComboBoxDropdown();
            dropdownPanel.ColorSelected += ColorComboBoxPanel_ColorSelected;
            ToolStripControlHost host = new ToolStripControlHost(dropdownPanel)
            {
                Margin = Padding.Empty,
                Padding = Padding.Empty,
                AutoSize = false,
                Size = dropdownPanel.Size
            };

            dropDown = new ToolStripDropDown
            {
                AutoClose = true,
                Padding = Padding.Empty,
            };
            dropDown.Closing += dropdown_Closing;
            dropDown.Items.Add(host);
        }
        private void ColorComboBoxPanel_ColorSelected(object sender, ColorSelectedEventArgs e)
        {
            SelectedColor = e.color;
            dropDown.Close();
        }
        private void dropdown_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            if (e.CloseReason == ToolStripDropDownCloseReason.ItemClicked)
                e.Cancel = true;
        }
        protected async override void OnClick(EventArgs e)
        {
            this.SuspendLayout();
            await Task.Delay(10);
            dropDown.Show(this.PointToScreen(new Point(0, this.Height)));
            dropdownPanel.Focus(); // 포커스를 패널로 줘서 외부 클릭 감지 유도
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            this.SuspendLayout();
            e.DrawBackground(); // 배경 그리기 추가
            using (Brush brush = new SolidBrush(SelectedColor))
            {
                Rectangle colorRect = new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1);
                e.Graphics.FillRectangle(brush, colorRect);
                e.Graphics.DrawRectangle(Pens.Black, colorRect);
            }
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
