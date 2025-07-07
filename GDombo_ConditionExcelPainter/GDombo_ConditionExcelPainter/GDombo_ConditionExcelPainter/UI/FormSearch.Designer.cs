namespace GDombo_ConditionExcelPainter
{
    partial class FormSearch
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
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btnAllSearch = new System.Windows.Forms.Button();
            this.dgvAllSearchResult = new System.Windows.Forms.DataGridView();
            this.colColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRowIdx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpMain.Controls.Add(this.tbxSearch, 1, 0);
            this.tlpMain.Controls.Add(this.lbSearch, 0, 0);
            this.tlpMain.Controls.Add(this.btnAllSearch, 2, 0);
            this.tlpMain.Controls.Add(this.dgvAllSearchResult, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(684, 161);
            this.tlpMain.TabIndex = 0;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSearch.Location = new System.Drawing.Point(153, 4);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(428, 21);
            this.tbxSearch.TabIndex = 0;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSearch.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSearch.Location = new System.Drawing.Point(3, 0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(144, 29);
            this.lbSearch.TabIndex = 1;
            this.lbSearch.Text = "찾을 내용 :";
            this.lbSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAllSearch
            // 
            this.btnAllSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAllSearch.Location = new System.Drawing.Point(587, 3);
            this.btnAllSearch.Name = "btnAllSearch";
            this.btnAllSearch.Size = new System.Drawing.Size(94, 23);
            this.btnAllSearch.TabIndex = 3;
            this.btnAllSearch.Text = "모두 찾기";
            this.btnAllSearch.UseVisualStyleBackColor = true;
            this.btnAllSearch.Click += new System.EventHandler(this.btnAllSearch_Click);
            // 
            // dgvAllSearchResult
            // 
            this.dgvAllSearchResult.AllowUserToAddRows = false;
            this.dgvAllSearchResult.AllowUserToDeleteRows = false;
            this.dgvAllSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllSearchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colColName,
            this.colRowIdx,
            this.colValue});
            this.tlpMain.SetColumnSpan(this.dgvAllSearchResult, 3);
            this.dgvAllSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllSearchResult.Location = new System.Drawing.Point(3, 32);
            this.dgvAllSearchResult.MultiSelect = false;
            this.dgvAllSearchResult.Name = "dgvAllSearchResult";
            this.dgvAllSearchResult.ReadOnly = true;
            this.dgvAllSearchResult.RowHeadersVisible = false;
            this.dgvAllSearchResult.RowTemplate.Height = 23;
            this.dgvAllSearchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllSearchResult.Size = new System.Drawing.Size(678, 126);
            this.dgvAllSearchResult.TabIndex = 4;
            this.dgvAllSearchResult.SelectionChanged += new System.EventHandler(this.dgvAllSearchResult_SelectionChanged);
            // 
            // colColName
            // 
            this.colColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colColName.HeaderText = "행 이름";
            this.colColName.Name = "colColName";
            this.colColName.ReadOnly = true;
            this.colColName.Width = 70;
            // 
            // colRowIdx
            // 
            this.colRowIdx.HeaderText = "열 인덱스";
            this.colRowIdx.Name = "colRowIdx";
            this.colRowIdx.ReadOnly = true;
            // 
            // colValue
            // 
            this.colValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colValue.HeaderText = "값";
            this.colValue.Name = "colValue";
            this.colValue.ReadOnly = true;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 161);
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSearch_FormClosing);
            this.Shown += new System.EventHandler(this.FormSearch_Shown);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllSearchResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btnAllSearch;
        private System.Windows.Forms.DataGridView dgvAllSearchResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRowIdx;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
    }
}