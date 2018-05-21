using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        float a, b;
        int count;
        bool znak = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button16_Click(object sender, EventArgs e)//С
        {
            textBox1.Text = "";
            label1.Text = "";
           
        }

        private void button17_Click(object sender, EventArgs e)//^2
        {
            if (textBox1.Text!="")
            {
            double x;
            x = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(x);
            }
            else
            {
                return;
            }
        }

        private void button18_Click(object sender, EventArgs e)//корень
        {
            if (textBox1.Text != "")
            {
                double y;
                y = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Sqrt(y));
            }
            else
            {
                return;
            }
        }

        private void button11_Click(object sender, EventArgs e)//+
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
           
        }

        private void button12_Click(object sender, EventArgs e)//-
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void button13_Click(object sender, EventArgs e)//*
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void button14_Click(object sender, EventArgs e)//деление
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;

                default:
                    break;
            }
      }


        private void button15_Click(object sender, EventArgs e)//=
        {
            calculate();
            label1.Text = "";
            
        }
        
       

        private void button20_Click(object sender, EventArgs e)//косинус
        {
            if (textBox1.Text != "")
            {
                double c;
                c = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Cos(c));
            }
            else
            {
                return;
            }
        }

        private void button19_Click(object sender, EventArgs e)//синус
        {
            if (textBox1.Text != "")
            {
                double s;
                s = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Sin(s));
            }
            else
            {
                return;
            }
        }

        private void button21_Click(object sender, EventArgs e)//тангенс
        {
            if (textBox1.Text != "")
            {
                double t;
                t = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Tan(t));
            }
            else
            {
                return;
            }
        }

        private void button22_Click(object sender, EventArgs e)//лог
        {
            if (textBox1.Text != "")
            {
                double l;
                l = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Log(l));
            }
            else
            {
                return;
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(button1_KeyDown);

        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(button2_KeyDown);
        }

        private void button11_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(button11_KeyDown);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void посмотретьСправкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пользователь может использвоать калькулятор для подсчета простых значений, а так же для сложных.");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n Создатели: Сырых Марина Викторовна\n Костоманова Ксения Владимирована \n Дата создания: 20.04.2018 \n Дата последнего изменения:10.05.2018 \n Версия: 2.1");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
