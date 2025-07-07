namespace GDombo_ConditionExcelPainter
{
    partial class ucConditionDuplicate
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
            this.lbCondtion1 = new System.Windows.Forms.Label();
            this.ucConditionCommon = new GDombo_ConditionExcelPainter.ucConditionCommon();
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
            this.cbxcomSelectCols.TabIndex = 6;
            // 
            // lbCondtion1
            // 
            this.lbCondtion1.AutoSize = true;
            this.lbCondtion1.Location = new System.Drawing.Point(96, 10);
            this.lbCondtion1.Name = "lbCondtion1";
            this.lbCondtion1.Size = new System.Drawing.Size(193, 12);
            this.lbCondtion1.TabIndex = 7;
            this.lbCondtion1.Text = "이 같은 사람들 중 중복되는 데이터";
            // 
            // ucConditionCommon
            // 
            this.ucConditionCommon.ConditionType = GDombo_ConditionExcelPainter.eConditionType.Font;
            this.ucConditionCommon.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucConditionCommon.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucConditionCommon.Level = 0;
            this.ucConditionCommon.Location = new System.Drawing.Point(485, 0);
            this.ucConditionCommon.Name = "ucConditionCommon";
            this.ucConditionCommon.SelectColor = System.Drawing.Color.Coral;
            this.ucConditionCommon.Size = new System.Drawing.Size(215, 30);
            this.ucConditionCommon.TabIndex = 0;
            this.ucConditionCommon.DeleteButtonClick += new System.EventHandler(this.ucConditonCommon_DeleteButtonClick);
            // 
            // ucConditionDuplicate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbCondtion1);
            this.Controls.Add(this.cbxcomSelectCols);
            this.Controls.Add(this.ucConditionCommon);
            this.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "ucConditionDuplicate";
            this.Size = new System.Drawing.Size(700, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucConditionCommon ucConditionCommon;
        private GDombo_CustomControl.CheckBoxComboBox cbxcomSelectCols;
        private System.Windows.Forms.Label lbCondtion1;
    }
}
