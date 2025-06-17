namespace GDombo_CustomControl
{
    partial class ColorComboBoxDropdown
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
            this.btnMoreColor = new System.Windows.Forms.Button();
            this.flpBaseColors = new System.Windows.Forms.FlowLayoutPanel();
            this.btnColorRed = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnIndigo = new System.Windows.Forms.Button();
            this.btnViolet = new System.Windows.Forms.Button();
            this.colDigMoreCol = new System.Windows.Forms.ColorDialog();
            this.flpBaseColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMoreColor
            // 
            this.btnMoreColor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMoreColor.Location = new System.Drawing.Point(0, 177);
            this.btnMoreColor.Margin = new System.Windows.Forms.Padding(0);
            this.btnMoreColor.Name = "btnMoreColor";
            this.btnMoreColor.Size = new System.Drawing.Size(150, 23);
            this.btnMoreColor.TabIndex = 0;
            this.btnMoreColor.Text = "More Color....";
            this.btnMoreColor.UseVisualStyleBackColor = true;
            this.btnMoreColor.Click += new System.EventHandler(this.btnMoreColor_Click);
            // 
            // flpBaseColors
            // 
            this.flpBaseColors.Controls.Add(this.btnColorRed);
            this.flpBaseColors.Controls.Add(this.btnOrange);
            this.flpBaseColors.Controls.Add(this.btnYellow);
            this.flpBaseColors.Controls.Add(this.btnGreen);
            this.flpBaseColors.Controls.Add(this.btnBlue);
            this.flpBaseColors.Controls.Add(this.btnIndigo);
            this.flpBaseColors.Controls.Add(this.btnViolet);
            this.flpBaseColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBaseColors.Location = new System.Drawing.Point(0, 0);
            this.flpBaseColors.Margin = new System.Windows.Forms.Padding(0);
            this.flpBaseColors.Name = "flpBaseColors";
            this.flpBaseColors.Size = new System.Drawing.Size(150, 177);
            this.flpBaseColors.TabIndex = 1;
            // 
            // btnColorRed
            // 
            this.btnColorRed.BackColor = System.Drawing.Color.Red;
            this.btnColorRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorRed.Location = new System.Drawing.Point(3, 3);
            this.btnColorRed.Name = "btnColorRed";
            this.btnColorRed.Size = new System.Drawing.Size(24, 24);
            this.btnColorRed.TabIndex = 0;
            this.btnColorRed.UseVisualStyleBackColor = false;
            this.btnColorRed.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnOrange
            // 
            this.btnOrange.BackColor = System.Drawing.Color.Orange;
            this.btnOrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrange.Location = new System.Drawing.Point(33, 3);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(24, 24);
            this.btnOrange.TabIndex = 1;
            this.btnOrange.UseVisualStyleBackColor = false;
            this.btnOrange.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYellow.Location = new System.Drawing.Point(63, 3);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(24, 24);
            this.btnYellow.TabIndex = 2;
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreen.Location = new System.Drawing.Point(93, 3);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(24, 24);
            this.btnGreen.TabIndex = 3;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlue.Location = new System.Drawing.Point(123, 3);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(24, 24);
            this.btnBlue.TabIndex = 4;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnIndigo
            // 
            this.btnIndigo.BackColor = System.Drawing.Color.Indigo;
            this.btnIndigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndigo.Location = new System.Drawing.Point(3, 33);
            this.btnIndigo.Name = "btnIndigo";
            this.btnIndigo.Size = new System.Drawing.Size(24, 24);
            this.btnIndigo.TabIndex = 5;
            this.btnIndigo.UseVisualStyleBackColor = false;
            this.btnIndigo.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnViolet
            // 
            this.btnViolet.BackColor = System.Drawing.Color.Violet;
            this.btnViolet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViolet.Location = new System.Drawing.Point(33, 33);
            this.btnViolet.Name = "btnViolet";
            this.btnViolet.Size = new System.Drawing.Size(24, 24);
            this.btnViolet.TabIndex = 6;
            this.btnViolet.UseVisualStyleBackColor = false;
            this.btnViolet.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // ColorComboBoxDropdown
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flpBaseColors);
            this.Controls.Add(this.btnMoreColor);
            this.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ColorComboBoxDropdown";
            this.Size = new System.Drawing.Size(150, 200);
            this.flpBaseColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMoreColor;
        private System.Windows.Forms.FlowLayoutPanel flpBaseColors;
        private System.Windows.Forms.ColorDialog colDigMoreCol;
        private System.Windows.Forms.Button btnColorRed;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnIndigo;
        private System.Windows.Forms.Button btnViolet;
    }
}
