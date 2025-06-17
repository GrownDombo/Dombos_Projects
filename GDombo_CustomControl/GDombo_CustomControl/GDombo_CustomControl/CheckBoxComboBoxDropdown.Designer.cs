namespace GDombo_CustomControl
{
    partial class CheckBoxComboBoxDropdown
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.vflpMain = new VerticalFlowLayoutPanel();
            this.SuspendLayout();
            // 
            // vflpMain
            // 
            this.vflpMain.AutoScroll = true;
            this.vflpMain.AutoSize = true;
            this.vflpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vflpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vflpMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.vflpMain.Location = new System.Drawing.Point(0, 0);
            this.vflpMain.Name = "vflpMain";
            this.vflpMain.Size = new System.Drawing.Size(148, 28);
            this.vflpMain.TabIndex = 0;
            this.vflpMain.WrapContents = false;
            // 
            // CheckBoxComboBoxDropdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.vflpMain);
            this.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MinimumSize = new System.Drawing.Size(150, 30);
            this.Name = "CheckBoxComboBoxDropdown";
            this.Size = new System.Drawing.Size(148, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VerticalFlowLayoutPanel vflpMain;
    }
}
