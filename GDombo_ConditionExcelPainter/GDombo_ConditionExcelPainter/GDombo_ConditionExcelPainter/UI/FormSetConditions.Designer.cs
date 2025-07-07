namespace GDombo_ConditionExcelPainter
{
    partial class FormSetConditions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.cbxOrderBy2 = new System.Windows.Forms.ComboBox();
            this.lbOrderBy2 = new System.Windows.Forms.Label();
            this.vflpCondition = new GDombo_CustomControl.VerticalFlowLayoutPanel();
            this.cbxBuyCntCol = new System.Windows.Forms.ComboBox();
            this.lbBuyCntCol = new System.Windows.Forms.Label();
            this.cbxGoodsOptionCol = new System.Windows.Forms.ComboBox();
            this.lbGoodsOptionCol = new System.Windows.Forms.Label();
            this.cbxAddCondition = new System.Windows.Forms.ComboBox();
            this.lbAddCondition = new System.Windows.Forms.Label();
            this.cbxOrderBy = new System.Windows.Forms.ComboBox();
            this.lbOrderBy = new System.Windows.Forms.Label();
            this.lbSelectPrimaryKey = new System.Windows.Forms.Label();
            this.cbxPrimaryKey = new System.Windows.Forms.ComboBox();
            this.btnAddCondtion = new System.Windows.Forms.Button();
            this.vflpOptionCnt = new GDombo_CustomControl.VerticalFlowLayoutPanel();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.btnSet = new System.Windows.Forms.Button();
            this.ucConditionOrder1 = new GDombo_ConditionExcelPainter.ucConditionOrder();
            this.ucConditionDuplicate1 = new GDombo_ConditionExcelPainter.ucConditionDuplicate();
            this.ucConditionCount1 = new GDombo_ConditionExcelPainter.ucConditionQuantity();
            this.ucConditionCount2 = new GDombo_ConditionExcelPainter.ucConditionQuantity();
            this.tlpMain.SuspendLayout();
            this.vflpCondition.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.Controls.Add(this.cbxOrderBy2, 1, 2);
            this.tlpMain.Controls.Add(this.lbOrderBy2, 0, 2);
            this.tlpMain.Controls.Add(this.vflpCondition, 0, 7);
            this.tlpMain.Controls.Add(this.cbxBuyCntCol, 1, 3);
            this.tlpMain.Controls.Add(this.lbBuyCntCol, 0, 3);
            this.tlpMain.Controls.Add(this.cbxGoodsOptionCol, 1, 4);
            this.tlpMain.Controls.Add(this.lbGoodsOptionCol, 0, 4);
            this.tlpMain.Controls.Add(this.cbxAddCondition, 1, 6);
            this.tlpMain.Controls.Add(this.lbAddCondition, 0, 6);
            this.tlpMain.Controls.Add(this.cbxOrderBy, 1, 1);
            this.tlpMain.Controls.Add(this.lbOrderBy, 0, 1);
            this.tlpMain.Controls.Add(this.lbSelectPrimaryKey, 0, 0);
            this.tlpMain.Controls.Add(this.cbxPrimaryKey, 1, 0);
            this.tlpMain.Controls.Add(this.btnAddCondtion, 2, 6);
            this.tlpMain.Controls.Add(this.vflpOptionCnt, 0, 5);
            this.tlpMain.Controls.Add(this.pnBottom, 0, 8);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 9;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpMain.Size = new System.Drawing.Size(744, 381);
            this.tlpMain.TabIndex = 0;
            // 
            // cbxOrderBy2
            // 
            this.cbxOrderBy2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxOrderBy2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrderBy2.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbxOrderBy2.FormattingEnabled = true;
            this.cbxOrderBy2.Location = new System.Drawing.Point(143, 65);
            this.cbxOrderBy2.Name = "cbxOrderBy2";
            this.cbxOrderBy2.Size = new System.Drawing.Size(568, 20);
            this.cbxOrderBy2.TabIndex = 16;
            // 
            // lbOrderBy2
            // 
            this.lbOrderBy2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbOrderBy2.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbOrderBy2.Location = new System.Drawing.Point(3, 60);
            this.lbOrderBy2.Name = "lbOrderBy2";
            this.lbOrderBy2.Size = new System.Drawing.Size(134, 30);
            this.lbOrderBy2.TabIndex = 15;
            this.lbOrderBy2.Text = "졍렬 기준 선택2 :";
            this.lbOrderBy2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // vflpCondition
            // 
            this.vflpCondition.AutoScroll = true;
            this.vflpCondition.AutoSize = true;
            this.vflpCondition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.SetColumnSpan(this.vflpCondition, 3);
            this.vflpCondition.Controls.Add(this.ucConditionOrder1);
            this.vflpCondition.Controls.Add(this.ucConditionDuplicate1);
            this.vflpCondition.Controls.Add(this.ucConditionCount1);
            this.vflpCondition.Controls.Add(this.ucConditionCount2);
            this.vflpCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.vflpCondition.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.vflpCondition.Location = new System.Drawing.Point(3, 189);
            this.vflpCondition.MaximumSize = new System.Drawing.Size(0, 300);
            this.vflpCondition.Name = "vflpCondition";
            this.vflpCondition.Size = new System.Drawing.Size(738, 144);
            this.vflpCondition.TabIndex = 1;
            this.vflpCondition.WrapContents = false;
            // 
            // cbxBuyCntCol
            // 
            this.cbxBuyCntCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxBuyCntCol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBuyCntCol.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbxBuyCntCol.FormattingEnabled = true;
            this.cbxBuyCntCol.Location = new System.Drawing.Point(143, 95);
            this.cbxBuyCntCol.Name = "cbxBuyCntCol";
            this.cbxBuyCntCol.Size = new System.Drawing.Size(568, 20);
            this.cbxBuyCntCol.TabIndex = 13;
            // 
            // lbBuyCntCol
            // 
            this.lbBuyCntCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBuyCntCol.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbBuyCntCol.Location = new System.Drawing.Point(3, 90);
            this.lbBuyCntCol.Name = "lbBuyCntCol";
            this.lbBuyCntCol.Size = new System.Drawing.Size(134, 30);
            this.lbBuyCntCol.TabIndex = 12;
            this.lbBuyCntCol.Text = "수량 컬럼 선택 :";
            this.lbBuyCntCol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxGoodsOptionCol
            // 
            this.cbxGoodsOptionCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxGoodsOptionCol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGoodsOptionCol.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbxGoodsOptionCol.FormattingEnabled = true;
            this.cbxGoodsOptionCol.Location = new System.Drawing.Point(143, 125);
            this.cbxGoodsOptionCol.Name = "cbxGoodsOptionCol";
            this.cbxGoodsOptionCol.Size = new System.Drawing.Size(568, 20);
            this.cbxGoodsOptionCol.TabIndex = 10;
            this.cbxGoodsOptionCol.SelectedIndexChanged += new System.EventHandler(this.cbxSelectOption_SelectedIndexChanged);
            // 
            // lbGoodsOptionCol
            // 
            this.lbGoodsOptionCol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbGoodsOptionCol.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbGoodsOptionCol.Location = new System.Drawing.Point(3, 120);
            this.lbGoodsOptionCol.Name = "lbGoodsOptionCol";
            this.lbGoodsOptionCol.Size = new System.Drawing.Size(134, 30);
            this.lbGoodsOptionCol.TabIndex = 9;
            this.lbGoodsOptionCol.Text = "옵션 컬럼 선택 :";
            this.lbGoodsOptionCol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxAddCondition
            // 
            this.cbxAddCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAddCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAddCondition.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbxAddCondition.FormattingEnabled = true;
            this.cbxAddCondition.Location = new System.Drawing.Point(143, 161);
            this.cbxAddCondition.Name = "cbxAddCondition";
            this.cbxAddCondition.Size = new System.Drawing.Size(568, 20);
            this.cbxAddCondition.TabIndex = 7;
            // 
            // lbAddCondition
            // 
            this.lbAddCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAddCondition.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbAddCondition.Location = new System.Drawing.Point(3, 156);
            this.lbAddCondition.Name = "lbAddCondition";
            this.lbAddCondition.Size = new System.Drawing.Size(134, 30);
            this.lbAddCondition.TabIndex = 6;
            this.lbAddCondition.Text = "조건 추가 :";
            this.lbAddCondition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxOrderBy
            // 
            this.cbxOrderBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOrderBy.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbxOrderBy.FormattingEnabled = true;
            this.cbxOrderBy.Location = new System.Drawing.Point(143, 35);
            this.cbxOrderBy.Name = "cbxOrderBy";
            this.cbxOrderBy.Size = new System.Drawing.Size(568, 20);
            this.cbxOrderBy.TabIndex = 5;
            // 
            // lbOrderBy
            // 
            this.lbOrderBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbOrderBy.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbOrderBy.Location = new System.Drawing.Point(3, 30);
            this.lbOrderBy.Name = "lbOrderBy";
            this.lbOrderBy.Size = new System.Drawing.Size(134, 30);
            this.lbOrderBy.TabIndex = 4;
            this.lbOrderBy.Text = "졍렬 기준 선택 :";
            this.lbOrderBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSelectPrimaryKey
            // 
            this.lbSelectPrimaryKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSelectPrimaryKey.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSelectPrimaryKey.Location = new System.Drawing.Point(3, 0);
            this.lbSelectPrimaryKey.Name = "lbSelectPrimaryKey";
            this.lbSelectPrimaryKey.Size = new System.Drawing.Size(134, 30);
            this.lbSelectPrimaryKey.TabIndex = 0;
            this.lbSelectPrimaryKey.Text = "기본키 선택 :";
            this.lbSelectPrimaryKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxPrimaryKey
            // 
            this.cbxPrimaryKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxPrimaryKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrimaryKey.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbxPrimaryKey.FormattingEnabled = true;
            this.cbxPrimaryKey.Location = new System.Drawing.Point(143, 5);
            this.cbxPrimaryKey.Name = "cbxPrimaryKey";
            this.cbxPrimaryKey.Size = new System.Drawing.Size(568, 20);
            this.cbxPrimaryKey.TabIndex = 1;
            // 
            // btnAddCondtion
            // 
            this.btnAddCondtion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddCondtion.Image = global::GDombo_ConditionExcelPainter.Properties.Resources.Add;
            this.btnAddCondtion.Location = new System.Drawing.Point(714, 156);
            this.btnAddCondtion.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddCondtion.Name = "btnAddCondtion";
            this.btnAddCondtion.Size = new System.Drawing.Size(30, 30);
            this.btnAddCondtion.TabIndex = 8;
            this.btnAddCondtion.UseVisualStyleBackColor = true;
            this.btnAddCondtion.Click += new System.EventHandler(this.btnAddCondtion_Click);
            // 
            // vflpOptionCnt
            // 
            this.vflpOptionCnt.AutoScroll = true;
            this.vflpOptionCnt.AutoSize = true;
            this.vflpOptionCnt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.SetColumnSpan(this.vflpOptionCnt, 3);
            this.vflpOptionCnt.Dock = System.Windows.Forms.DockStyle.Top;
            this.vflpOptionCnt.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.vflpOptionCnt.Location = new System.Drawing.Point(3, 153);
            this.vflpOptionCnt.MaximumSize = new System.Drawing.Size(0, 200);
            this.vflpOptionCnt.Name = "vflpOptionCnt";
            this.vflpOptionCnt.Size = new System.Drawing.Size(738, 0);
            this.vflpOptionCnt.TabIndex = 11;
            this.vflpOptionCnt.WrapContents = false;
            // 
            // pnBottom
            // 
            this.tlpMain.SetColumnSpan(this.pnBottom, 3);
            this.pnBottom.Controls.Add(this.btnSet);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBottom.Location = new System.Drawing.Point(3, 339);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(738, 39);
            this.pnBottom.TabIndex = 14;
            // 
            // btnSet
            // 
            this.btnSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSet.Location = new System.Drawing.Point(0, 0);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(738, 39);
            this.btnSet.TabIndex = 0;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // ucConditionOrder1
            // 
            this.ucConditionOrder1.ConditionType = GDombo_ConditionExcelPainter.eConditionType.Font;
            this.ucConditionOrder1.Level = 0;
            this.ucConditionOrder1.Location = new System.Drawing.Point(3, 3);
            this.ucConditionOrder1.Name = "ucConditionOrder1";
            this.ucConditionOrder1.nLimitPeopleCnt = 10;
            this.ucConditionOrder1.SelectColor = System.Drawing.Color.Red;
            this.ucConditionOrder1.Size = new System.Drawing.Size(711, 30);
            this.ucConditionOrder1.TabIndex = 1;
            // 
            // ucConditionDuplicate1
            // 
            this.ucConditionDuplicate1.ConditionType = GDombo_ConditionExcelPainter.eConditionType.Fill;
            this.ucConditionDuplicate1.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucConditionDuplicate1.Level = 0;
            this.ucConditionDuplicate1.Location = new System.Drawing.Point(3, 39);
            this.ucConditionDuplicate1.Name = "ucConditionDuplicate1";
            this.ucConditionDuplicate1.SelectColor = System.Drawing.Color.Coral;
            this.ucConditionDuplicate1.Size = new System.Drawing.Size(711, 30);
            this.ucConditionDuplicate1.TabIndex = 4;
            // 
            // ucConditionCount1
            // 
            this.ucConditionCount1.ConditionType = GDombo_ConditionExcelPainter.eConditionType.Fill;
            this.ucConditionCount1.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucConditionCount1.Level = 1;
            this.ucConditionCount1.Location = new System.Drawing.Point(3, 75);
            this.ucConditionCount1.Name = "ucConditionCount1";
            this.ucConditionCount1.nGoodsCount = 120;
            this.ucConditionCount1.nLimitPeopleCnt = 50;
            this.ucConditionCount1.SelectColor = System.Drawing.Color.Green;
            this.ucConditionCount1.Size = new System.Drawing.Size(711, 30);
            this.ucConditionCount1.TabIndex = 2;
            // 
            // ucConditionCount2
            // 
            this.ucConditionCount2.ConditionType = GDombo_ConditionExcelPainter.eConditionType.Fill;
            this.ucConditionCount2.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ucConditionCount2.Level = 2;
            this.ucConditionCount2.Location = new System.Drawing.Point(3, 111);
            this.ucConditionCount2.Name = "ucConditionCount2";
            this.ucConditionCount2.nGoodsCount = 60;
            this.ucConditionCount2.nLimitPeopleCnt = 50;
            this.ucConditionCount2.SelectColor = System.Drawing.Color.Yellow;
            this.ucConditionCount2.Size = new System.Drawing.Size(711, 30);
            this.ucConditionCount2.TabIndex = 3;
            // 
            // FormSetConditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(744, 381);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetConditions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSetConditions";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormSetConditions_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.vflpCondition.ResumeLayout(false);
            this.pnBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lbSelectPrimaryKey;
        private System.Windows.Forms.Label lbOrderBy;
        private System.Windows.Forms.ComboBox cbxOrderBy;
        private System.Windows.Forms.ComboBox cbxPrimaryKey;
        private System.Windows.Forms.ComboBox cbxAddCondition;
        private System.Windows.Forms.Label lbAddCondition;
        private System.Windows.Forms.Button btnAddCondtion;
        private System.Windows.Forms.ComboBox cbxGoodsOptionCol;
        private System.Windows.Forms.Label lbGoodsOptionCol;
        private GDombo_CustomControl.VerticalFlowLayoutPanel vflpOptionCnt;
        private System.Windows.Forms.Label lbBuyCntCol;
        private System.Windows.Forms.ComboBox cbxBuyCntCol;
        private GDombo_CustomControl.VerticalFlowLayoutPanel vflpCondition;
        private ucConditionOrder ucConditionOrder1;
        private ucConditionQuantity ucConditionCount1;
        private ucConditionQuantity ucConditionCount2;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Button btnSet;
        private ucConditionDuplicate ucConditionDuplicate1;
        private System.Windows.Forms.ComboBox cbxOrderBy2;
        private System.Windows.Forms.Label lbOrderBy2;
    }
}