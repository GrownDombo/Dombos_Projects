using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDombo_CustomControl
{
    internal partial class CheckBoxComboBoxDropdown : UserControl
    {
        internal event EventHandler<EventArgs> CheckedChanged;
        internal CheckBox[] GetItems => vflpMain.Controls.OfType<CheckBox>().ToArray();
        internal CheckBoxComboBoxDropdown()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }
        internal void AddItem(string item, bool isChecked)
        {
            CheckBox checkBox = new CheckBox
            {
                Name = $"cbx{item}",
                Text = item,
                AutoSize = true,
                Checked = isChecked

            };
            checkBox.CheckedChanged += CheckBox_CheckedChanged;
            vflpMain.Controls.Add(checkBox);
        }
        internal void AddItemRange(string[] items)
        {
            CheckBox[] arrCheckBox = new CheckBox[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                string sText = items[i];
                CheckBox checkBox = new CheckBox
                {
                    Name = $"cbx{sText}",
                    Text = sText,
                    AutoSize = true,
                    Checked = false
                };
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
                arrCheckBox[i] = checkBox;
            }
            vflpMain.Controls.AddRange(arrCheckBox);
        }
        internal CheckBox FirstCheckBoxStringContain(string sText)
        {
            CheckBox[] arrCheckBox = GetItems;
            foreach (CheckBox checkBox in arrCheckBox)
            {
                if (checkBox.Text.Contains(sText))
                    return checkBox;
            }
            return null;
        }
        internal void ItemClear()
        {
            vflpMain.Controls.Clear();
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChanged?.Invoke(this, e);
        }
    }
}
