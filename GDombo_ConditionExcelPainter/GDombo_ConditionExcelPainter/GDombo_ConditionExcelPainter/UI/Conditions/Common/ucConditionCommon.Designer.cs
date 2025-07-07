namespace GDombo_ConditionExcelPainter
{
    partial class ucConditionCommon
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
            this.components = new System.ComponentModel.Container();
            this.btnFontOrFill = new System.Windows.Forms.Button();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.numcLevel = new System.Windows.Forms.NumericUpDown();
            this.colorComboBox1 = new GDombo_CustomControl.ColorComboBox();
            this.ttConditionCommon = new System.Windows.Forms.ToolTip(this.components);
            this.lbLv = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numcLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFontOrFill
            // 
            this.btnFontOrFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFontOrFill.Location = new System.Drawing.Point(77, 3);
            this.btnFontOrFill.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnFontOrFill.Name = "btnFontOrFill";
            this.btnFontOrFill.Size = new System.Drawing.Size(47, 24);
            this.btnFontOrFill.TabIndex = 3;
            this.btnFontOrFill.Text = "Font";
            this.btnFontOrFill.UseVisualStyleBackColor = true;
            this.btnFontOrFill.Click += new System.EventHandler(this.btnFontOrFill_Click);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 5;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.Controls.Add(this.btnFontOrFill, 2, 0);
            this.tlpMain.Controls.Add(this.btnDelete, 4, 0);
            this.tlpMain.Controls.Add(this.numcLevel, 1, 0);
            this.tlpMain.Controls.Add(this.colorComboBox1, 3, 0);
            this.tlpMain.Controls.Add(this.lbLv, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(221, 30);
            this.tlpMain.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Image = global::GDombo_ConditionExcelPainter.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(191, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // numcLevel
            // 
            this.numcLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numcLevel.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numcLevel.Location = new System.Drawing.Point(35, 4);
            this.numcLevel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numcLevel.Name = "numcLevel";
            this.numcLevel.Size = new System.Drawing.Size(39, 22);
            this.numcLevel.TabIndex = 5;
            this.numcLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colorComboBox1
            // 
            this.colorComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.colorComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.colorComboBox1.DropDownHeight = 1;
            this.colorComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorComboBox1.FormattingEnabled = true;
            this.colorComboBox1.IntegralHeight = false;
            this.colorComboBox1.Location = new System.Drawing.Point(130, 4);
            this.colorComboBox1.Name = "colorComboBox1";
            this.colorComboBox1.SelectedColor = System.Drawing.Color.Red;
            this.colorComboBox1.Size = new System.Drawing.Size(58, 22);
            this.colorComboBox1.TabIndex = 6;
            // 
            // lbLv
            // 
            this.lbLv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLv.AutoSize = true;
            this.lbLv.Location = new System.Drawing.Point(3, 9);
            this.lbLv.Name = "lbLv";
            this.lbLv.Size = new System.Drawing.Size(26, 12);
            this.lbLv.TabIndex = 7;
            this.lbLv.Text = "Lv :";
            // 
            // ucConditionCommon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "ucConditionCommon";
            this.Size = new System.Drawing.Size(221, 30);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numcLevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFontOrFill;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolTip ttConditionCommon;
        private System.Windows.Forms.NumericUpDown numcLevel;
        private GDombo_CustomControl.ColorComboBox colorComboBox1;
        private System.Windows.Forms.Label lbLv;
    }
}
