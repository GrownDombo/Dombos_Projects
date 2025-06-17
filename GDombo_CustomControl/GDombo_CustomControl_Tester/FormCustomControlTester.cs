using GDombo_CustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDombo_CustomControl_Tester
{
    public partial class FormCustomControlTester : Form
    {
        public FormCustomControlTester()
        {
            InitializeComponent();
            // CheckBoxComboBox
            checkBoxComboBox1.AddItem("Apple", true);
            checkBoxComboBox1.AddItem("Banana");
            checkBoxComboBox1.AddItem("Grape");
            checkBoxComboBox1.AddItem("Orange");

            // DoubleBufferDataGridView
            DoubleBufferedDataGridView grid = doubleBufferedDataGridView1; // 컨트롤 이름 확인해서 바꿔주세요
            // 컬럼 정의
            grid.Columns.Clear();
            grid.Columns.Add("ID", "ID");
            grid.Columns.Add("Name", "Name");
            grid.Columns.Add("Email", "Email");
            grid.Columns.Add("Date", "Created Date");
            // 데이터 삽입
            grid.Rows.Clear();
            Random rand = new Random();
            for (int i = 1; i <= 10000; i++)
            {
                string name = $"User{i}";
                string email = $"user{i}@example.com";
                string date = DateTime.Now.AddDays(-rand.Next(0, 1000)).ToShortDateString();

                grid.Rows.Add(i, name, email, date);
            }
            // 자동 크기 조절 (옵션)
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Vertical FlowLayout
            for (int i = 1; i <= 100; i++)
            {
                Label lableTemp = new Label();
                lableTemp.Text = $"Lable Text {i}";
                lableTemp.Name = $"Lable Name {i}";
                lableTemp.TextAlign = ContentAlignment.MiddleCenter;
                lableTemp.BorderStyle = BorderStyle.FixedSingle;
                verticalFlowLayoutPanel1.Controls.Add(lableTemp);
            }

        }
    }
}
