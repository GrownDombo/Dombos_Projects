namespace GDombo_ConditionExcelPainter
{
    partial class ucConditionOrder
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
            this.lbExplain2 = new System.Windows.Forms.Label();
            this.numcLimitPeopleCnt = new System.Windows.Forms.NumericUpDown();
            this.lbExplain1 = new System.Windows.Forms.Label();
            this.cbxcomSelectCols = new GDombo_CustomControl.CheckBoxComboBox();
            this.ucConditonCommon = new GDombo_ConditionExcelPainter.ucConditionCommon();
            ((System.ComponentModel.ISupportInitialize)(this.numcLimitPeopleCnt)).BeginInit();
            this.SuspendLayout();
            // 
            // lbExplain2
            // 
            this.lbExplain2.AutoSize = true;
            this.lbExplain2.Location = new System.Drawing.Point(334, 10);
            this.lbExplain2.Name = "lbExplain2";
            this.lbExplain2.Size = new System.Drawing.Size(17, 12);
            this.lbExplain2.TabIndex = 1;
            this.lbExplain2.Text = "명";
            this.lbExplain2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numcLimitPeopleCnt
            // 
            this.numcLimitPeopleCnt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numcLimitPeopleCnt.Location = new System.Drawing.Point(287, 5);
            this.numcLimitPeopleCnt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numcLimitPeopleCnt.Name = "numcLimitPeopleCnt";
            this.numcLimitPeopleCnt.Size = new System.Drawing.Size(44, 21);
            this.numcLimitPeopleCnt.TabIndex = 2;
            this.numcLimitPeopleCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numcLimitPeopleCnt.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lbExplain1
            // 
            this.lbExplain1.AutoSize = true;
            this.lbExplain1.Location = new System.Drawing.Point(95, 10);
            this.lbExplain1.Name = "lbExplain1";
            this.lbExplain1.Size = new System.Drawing.Size(189, 12);
            this.lbExplain1.TabIndex = 3;
            this.lbExplain1.Text = "을 기준으로 중복을 제외한 선착순";
            this.lbExplain1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxcomSelectCols
            // 
            this.cbxcomSelectCols.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxcomSelectCols.DropDownHeight = 1;
            this.cbxcomSelectCols.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxcomSelectCols.FormattingEnabled = true;
            this.cbxcomSelectCols.IntegralHeight = false;
            this.cbxcomSelectCols.Location = new System.Drawing.Point(3, 4);
            this.cbxcomSelectCols.Name = "cbxcomSelectCols";
            this.cbxcomSelectCols.Size = new System.Drawing.Size(90, 22);
            this.cbxcomSelectCols.TabIndex = 6;
            // 
            // ucConditonCommon
            // 
            this.ucConditonCommon.ConditionType = GDombo_ConditionExcelPainter.eConditionType.Font;
            this.ucConditonCommon.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucConditonCommon.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucConditonCommon.Level = 0;
            this.ucConditonCommon.Location = new System.Drawing.Point(385, 0);
            this.ucConditonCommon.Name = "ucConditonCommon";
            this.ucConditonCommon.SelectColor = System.Drawing.Color.Red;
            this.ucConditonCommon.Size = new System.Drawing.Size(215, 30);
            this.ucConditonCommon.TabIndex = 0;
            this.ucConditonCommon.DeleteButtonClick += new System.EventHandler(this.ucConditonCommon_DeleteButtonClick);
            // 
            // ucConditionOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxcomSelectCols);
            this.Controls.Add(this.numcLimitPeopleCnt);
            this.Controls.Add(this.lbExplain2);
            this.Controls.Add(this.ucConditonCommon);
            this.Controls.Add(this.lbExplain1);
            this.Name = "ucConditionOrder";
            this.Size = new System.Drawing.Size(600, 30);
            ((System.ComponentModel.ISupportInitialize)(this.numcLimitPeopleCnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucConditionCommon ucConditonCommon;
        private System.Windows.Forms.Label lbExplain2;
        private System.Windows.Forms.NumericUpDown numcLimitPeopleCnt;
        private System.Windows.Forms.Label lbExplain1;
        private GDombo_CustomControl.CheckBoxComboBox cbxcomSelectCols;
    }
}
