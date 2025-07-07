namespace GDombo_ConditionExcelPainter
{
    partial class ucConditionQuantity
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
            this.cbxcomSelectCols = new GDombo_CustomControl.CheckBoxComboBox();
            this.lbCondition1 = new System.Windows.Forms.Label();
            this.numcGoodsCnt = new System.Windows.Forms.NumericUpDown();
            this.lbCondition2 = new System.Windows.Forms.Label();
            this.numcLimitPeopleCnt = new System.Windows.Forms.NumericUpDown();
            this.ConditionCommon = new GDombo_ConditionExcelPainter.ucConditionCommon();
            this.lbCondition3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numcGoodsCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numcLimitPeopleCnt)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxcomSelectCols
            // 
            this.cbxcomSelectCols.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxcomSelectCols.DropDownHeight = 1;
            this.cbxcomSelectCols.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxcomSelectCols.FormattingEnabled = true;
            this.cbxcomSelectCols.IntegralHeight = false;
            this.cbxcomSelectCols.Location = new System.Drawing.Point(3, 5);
            this.cbxcomSelectCols.Name = "cbxcomSelectCols";
            this.cbxcomSelectCols.Size = new System.Drawing.Size(90, 22);
            this.cbxcomSelectCols.TabIndex = 5;
            // 
            // lbCondition1
            // 
            this.lbCondition1.AutoSize = true;
            this.lbCondition1.Location = new System.Drawing.Point(96, 10);
            this.lbCondition1.Name = "lbCondition1";
            this.lbCondition1.Size = new System.Drawing.Size(101, 12);
            this.lbCondition1.TabIndex = 6;
            this.lbCondition1.Text = "이 같은 사람들 중";
            // 
            // numcGoodsCnt
            // 
            this.numcGoodsCnt.Location = new System.Drawing.Point(201, 6);
            this.numcGoodsCnt.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numcGoodsCnt.Name = "numcGoodsCnt";
            this.numcGoodsCnt.Size = new System.Drawing.Size(55, 21);
            this.numcGoodsCnt.TabIndex = 7;
            // 
            // lbCondition2
            // 
            this.lbCondition2.AutoSize = true;
            this.lbCondition2.Location = new System.Drawing.Point(257, 10);
            this.lbCondition2.Name = "lbCondition2";
            this.lbCondition2.Size = new System.Drawing.Size(125, 12);
            this.lbCondition2.TabIndex = 8;
            this.lbCondition2.Text = "개 이상 구매자 선착순";
            // 
            // numcLimitPeopleCnt
            // 
            this.numcLimitPeopleCnt.Location = new System.Drawing.Point(383, 6);
            this.numcLimitPeopleCnt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numcLimitPeopleCnt.Name = "numcLimitPeopleCnt";
            this.numcLimitPeopleCnt.Size = new System.Drawing.Size(55, 21);
            this.numcLimitPeopleCnt.TabIndex = 9;
            this.numcLimitPeopleCnt.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ConditionCommon
            // 
            this.ConditionCommon.ConditionType = GDombo_ConditionExcelPainter.eConditionType.Font;
            this.ConditionCommon.Dock = System.Windows.Forms.DockStyle.Right;
            this.ConditionCommon.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConditionCommon.Level = 0;
            this.ConditionCommon.Location = new System.Drawing.Point(485, 0);
            this.ConditionCommon.Name = "ConditionCommon";
            this.ConditionCommon.SelectColor = System.Drawing.Color.Red;
            this.ConditionCommon.Size = new System.Drawing.Size(215, 30);
            this.ConditionCommon.TabIndex = 4;
            this.ConditionCommon.DeleteButtonClick += new System.EventHandler(this.ucConditonCommon_DeleteButtonClick);
            // 
            // lbCondition3
            // 
            this.lbCondition3.AutoSize = true;
            this.lbCondition3.Location = new System.Drawing.Point(441, 10);
            this.lbCondition3.Name = "lbCondition3";
            this.lbCondition3.Size = new System.Drawing.Size(17, 12);
            this.lbCondition3.TabIndex = 10;
            this.lbCondition3.Text = "명";
            // 
            // ucConditionCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbCondition3);
            this.Controls.Add(this.numcLimitPeopleCnt);
            this.Controls.Add(this.lbCondition2);
            this.Controls.Add(this.numcGoodsCnt);
            this.Controls.Add(this.lbCondition1);
            this.Controls.Add(this.cbxcomSelectCols);
            this.Controls.Add(this.ConditionCommon);
            this.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "ucConditionCount";
            this.Size = new System.Drawing.Size(700, 30);
            ((System.ComponentModel.ISupportInitialize)(this.numcGoodsCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numcLimitPeopleCnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ucConditionCommon ConditionCommon;
        private GDombo_CustomControl.CheckBoxComboBox cbxcomSelectCols;
        private System.Windows.Forms.Label lbCondition1;
        private System.Windows.Forms.NumericUpDown numcGoodsCnt;
        private System.Windows.Forms.Label lbCondition2;
        private System.Windows.Forms.NumericUpDown numcLimitPeopleCnt;
        private System.Windows.Forms.Label lbCondition3;
    }
}
