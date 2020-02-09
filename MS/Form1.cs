using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a = 1.1;// цена профиля накл белый
        double a1 = 1.4;// цена профиля накл кор
        double a2 = 1.2;// цена профиля вн белый
        double a3 = 1.6;// цена профиля вн кор
        double a4 = 3.1;// цена профиля дв белый
        double a5 = 3.6;// цена профиля дв кор
        double b = 0.5; // цена сетки
        double c = 5; // прочее
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double width, height, per, square ;
            double  cost = 0;
            if (!double.TryParse(tBwidth.Text, out width) || !double.TryParse(tBheight.Text, out height))
            {
                MessageBox.Show("Недопустимое значение ширины или высоты!");
                return;
            }
            if (width == 0 || height == 0)
            {
                MessageBox.Show("Ширина или высота не могут быть равны 0!");
                return;
            }
            if (width >= 3000 || height >= 3000)
            {
                MessageBox.Show("Введите корректное значение ширины или высоты!");
                return;
            }
            if (!rBtnInvoice.Checked && !rBtnInside.Checked && !rBtnDoor.Checked)
            {
                MessageBox.Show("Не выбран тип сетки!");
                return;
            }
            if(!rBtnWhite.Checked && !rBtnBrown.Checked)
            {
                MessageBox.Show("Не выбран цвет сетки!");
                return;
            }
            Data dt = new Data(width, height);
            per = dt.Perimetr(width, height);
            square = dt.Square(width, height);
            if (rBtnInvoice.Checked && rBtnWhite.Checked)
            {
                cost = 1.1 * per * a + 1.1 * square * b + c;
            }
            if (rBtnInvoice.Checked && rBtnBrown.Checked)
            {
                cost = 1.1 * per * a1  + 1.1 * square * b  + c;
            }
            if (rBtnInside.Checked && rBtnWhite.Checked)
            {
                cost = 1.1 * per * a2  + 1.1 * square * b  + c;
            }
            if (rBtnInside.Checked && rBtnBrown.Checked)
            {
                cost = 1.1 * per * a3  + 1.1 * square * b  + c;
            }
            if (rBtnDoor.Checked && rBtnWhite.Checked)
            {
                cost = 1.1 * per * a4  + 1.1 * square * b  + c;
            }
            if (rBtnDoor.Checked && rBtnBrown.Checked)
            {
                cost = 1.1 * per * a5  + 1.1 * square * b  + c;
            }
            if (chkBImpost.Checked)
                cost = cost + 2;

            tBcost.Text = cost.ToString();
        }

        private void tBwidth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               tBheight.Focus();
            }
        }

        private void tBheight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalc.Focus();
            }
        }

        private void chkBImpost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalc.Focus();
            }
        }

        private void rBtnInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalc.Focus();
            }
        }

        private void rBtnWhite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalc.Focus();
            }
        }

        private void rBtnInside_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalc.Focus();
            }
        }

        private void rBtnDoor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalc.Focus();
            }
        }

        private void rBtnBrown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalc.Focus();
            }
        }
    }
}
