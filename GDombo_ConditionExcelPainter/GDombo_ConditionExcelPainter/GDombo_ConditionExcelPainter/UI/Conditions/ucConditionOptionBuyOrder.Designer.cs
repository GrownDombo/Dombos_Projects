namespace GDombo_ConditionExcelPainter
{
    partial class ucConditionOptionBuyOrder
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
            this.ConditionCommon = new GDombo_ConditionExcelPainter.ucConditionCommon();
            this.cbxcomSelectOptions = new GDombo_CustomControl.CheckBoxComboBox();
            this.lbCondtion1 = new System.Windows.Forms.Label();
            this.lbCondition3 = new System.Windows.Forms.Label();
            this.numcLimitPeopleCnt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numcLimitPeopleCnt)).BeginInit();
            this.SuspendLayout();
            // 
            // ConditionCommon
            // 
            this.ConditionCommon.ConditionType = GDombo_ConditionExcelPainter.eConditionType.Fill;
            this.ConditionCommon.Dock = System.Windows.Forms.DockStyle.Right;
            this.ConditionCommon.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConditionCommon.Level = 1;
            this.ConditionCommon.Location = new System.Drawing.Point(485, 0);
            this.ConditionCommon.Name = "ConditionCommon";
            this.ConditionCommon.SelectColor = System.Drawing.Color.Yellow;
            this.ConditionCommon.Size = new System.Drawing.Size(215, 30);
            this.ConditionCommon.TabIndex = 1;
            this.ConditionCommon.DeleteButtonClick += new System.EventHandler(this.ConditionCommon_DeleteButtonClick);
            // 
            // cbxcomSelectOptions
            // 
            this.cbxcomSelectOptions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxcomSelectOptions.DropDownHeight = 1;
            this.cbxcomSelectOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxcomSelectOptions.FormattingEnabled = true;
            this.cbxcomSelectOptions.IntegralHeight = false;
            this.cbxcomSelectOptions.Location = new System.Drawing.Point(4, 4);
            this.cbxcomSelectOptions.Name = "cbxcomSelectOptions";
            this.cbxcomSelectOptions.Size = new System.Drawing.Size(90, 22);
            this.cbxcomSelectOptions.TabIndex = 2;
            // 
            // lbCondtion1
            // 
            this.lbCondtion1.AutoSize = true;
            this.lbCondtion1.Location = new System.Drawing.Point(97, 10);
            this.lbCondtion1.Name = "lbCondtion1";
            this.lbCondtion1.Size = new System.Drawing.Size(165, 12);
            this.lbCondtion1.TabIndex = 8;
            this.lbCondtion1.Text = "옵션을 구입한 사람 중 선착순";
            // 
            // lbCondition3
            // 
            this.lbCondition3.AutoSize = true;
            this.lbCondition3.Location = new System.Drawing.Point(324, 9);
            this.lbCondition3.Name = "lbCondition3";
            this.lbCondition3.Size = new System.Drawing.Size(17, 12);
            this.lbCondition3.TabIndex = 12;
            this.lbCondition3.Text = "명";
            // 
            // numcLimitPeopleCnt
            // 
            this.numcLimitPeopleCnt.Location = new System.Drawing.Point(266, 5);
            this.numcLimitPeopleCnt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numcLimitPeopleCnt.Name = "numcLimitPeopleCnt";
            this.numcLimitPeopleCnt.Size = new System.Drawing.Size(55, 21);
            this.numcLimitPeopleCnt.TabIndex = 11;
            this.numcLimitPeopleCnt.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // ucConditionOptionBuyOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbCondition3);
            this.Controls.Add(this.numcLimitPeopleCnt);
            this.Controls.Add(this.lbCondtion1);
            this.Controls.Add(this.cbxcomSelectOptions);
            this.Controls.Add(this.ConditionCommon);
            this.Name = "ucConditionOptionBuyOrder";
            this.Size = new System.Drawing.Size(700, 30);
            ((System.ComponentModel.ISupportInitialize)(this.numcLimitPeopleCnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucConditionCommon ConditionCommon;
        private GDombo_CustomControl.CheckBoxComboBox cbxcomSelectOptions;
        private System.Windows.Forms.Label lbCondtion1;
        private System.Windows.Forms.Label lbCondition3;
        private System.Windows.Forms.NumericUpDown numcLimitPeopleCnt;
    }
}
