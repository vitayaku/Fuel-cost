using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Расчет_стоимости_бензина
{
    public partial class Form1 : Form
    {
        int litres;
        double cost;
        string mark;
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= '0' && e.KeyChar<='9')||(e.KeyChar == (char)Keys.Back))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                litres = Convert.ToInt32(textBox1.Text);
                mark = Convert.ToString(comboBox1.SelectedItem);

                switch (mark)
                {
                    case "АИ 92":
                        cost = litres * 43.5;
                        break;
                    case "АИ 95":
                        cost = litres * 47.5;
                        break;
                    case "АИ 98":
                        cost = litres * 54.67;
                        break;
                }
                label3.Text = "Стоимость  составит: " + cost + " рублей";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Укажите марку и количество литров", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
