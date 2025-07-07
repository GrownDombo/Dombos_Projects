namespace GDombo_ConditionExcelPainter
{
    partial class ucSetOptionCount
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
            this.lbOptionName = new System.Windows.Forms.Label();
            this.numOptionCnt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numOptionCnt)).BeginInit();
            this.SuspendLayout();
            // 
            // lbOptionName
            // 
            this.lbOptionName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOptionName.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbOptionName.Location = new System.Drawing.Point(0, 1);
            this.lbOptionName.Name = "lbOptionName";
            this.lbOptionName.Size = new System.Drawing.Size(249, 22);
            this.lbOptionName.TabIndex = 0;
            this.lbOptionName.Text = "OptionName";
            this.lbOptionName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numOptionCnt
            // 
            this.numOptionCnt.Dock = System.Windows.Forms.DockStyle.Right;
            this.numOptionCnt.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numOptionCnt.Location = new System.Drawing.Point(249, 0);
            this.numOptionCnt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numOptionCnt.Name = "numOptionCnt";
            this.numOptionCnt.Size = new System.Drawing.Size(51, 25);
            this.numOptionCnt.TabIndex = 1;
            this.numOptionCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numOptionCnt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ucSetOptionCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.lbOptionName);
            this.Controls.Add(this.numOptionCnt);
            this.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucSetOptionCount";
            this.Size = new System.Drawing.Size(300, 25);
            ((System.ComponentModel.ISupportInitialize)(this.numOptionCnt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbOptionName;
        private System.Windows.Forms.NumericUpDown numOptionCnt;
    }
}
