using System;
using System.Windows.Forms;

namespace GDombo_CustomControl
{
    public partial class VerticalFlowLayoutPanel : FlowLayoutPanel
    {
        private readonly int MARGIN;
        public VerticalFlowLayoutPanel()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            MARGIN = SystemInformation.VerticalScrollBarWidth + 10;
            this.FlowDirection = FlowDirection.TopDown;
            this.WrapContents = false;
            this.AutoScroll = true;
        }
        protected override void OnControlAdded(ControlEventArgs e)
        {
            this.SuspendLayout();
            e.Control.Width = this.Size.Width - MARGIN;
            base.OnControlAdded(e);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            this.SuspendLayout();
            foreach (Control control in this.Controls)
                control.Width = this.Size.Width - MARGIN;
            base.OnSizeChanged(e);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
