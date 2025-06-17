using System;
using System.Drawing;
using System.Windows.Forms;

namespace GDombo_CustomControl
{
    internal partial class ColorComboBoxDropdown : UserControl
    {
        internal event EventHandler<ColorSelectedEventArgs> ColorSelected;
        internal ColorComboBoxDropdown()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }
        private void btnMoreColor_Click(object sender, EventArgs e)
        {
            if (colDigMoreCol.ShowDialog() == DialogResult.OK)
                ColorSelected?.Invoke(this, new ColorSelectedEventArgs(colDigMoreCol.Color));
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorSelected?.Invoke(this, new ColorSelectedEventArgs(((Button)sender).BackColor));
        }
    }
    internal class ColorSelectedEventArgs : EventArgs
    {
        internal readonly Color color;
        internal ColorSelectedEventArgs(Color color)
        {
            this.color = color;
        }
    }
}
