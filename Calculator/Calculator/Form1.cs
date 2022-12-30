using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Calculator;

namespace Calculator
{
    public partial class Form1 : Form
    {
        static bool IsDark = true;
        static public string input;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void BtnAllClear_Click(object sender, EventArgs e)
        {
            textBox1.Text= string.Empty;
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }


        private void BtnRemoveLast_Click(object sender, EventArgs e)
        {
            
            string newstr = Helper.DeleteLast(textBox1.Text);
            textBox1.Text = newstr;
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            textBox1.Text+= ",";
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            input = textBox1.Text;
            textBox1.Text = Helper.Result(input);
        }

        private void BtnExp_Click(object sender, EventArgs e)
        {
            textBox1.Text += "^";
        }

        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            textBox1.Text += "^0,5";
        }

        private void BtnReverseExp_Click(object sender, EventArgs e)
        {
            textBox1.Text += "`";
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            if (IsDark)
            {
                Btn1.BackColor = Color.FromArgb(250, 250, 250);
                Btn2.BackColor = Color.FromArgb(250, 250, 250);
                Btn3.BackColor = Color.FromArgb(250, 250, 250);
                Btn4.BackColor = Color.FromArgb(250, 250, 250);
                Btn5.BackColor = Color.FromArgb(250, 250, 250);
                Btn6.BackColor = Color.FromArgb(250, 250, 250);
                Btn7.BackColor = Color.FromArgb(250, 250, 250);
                Btn8.BackColor = Color.FromArgb(250, 250, 250);
                Btn9.BackColor = Color.FromArgb(250, 250, 250);
                BtnZero.BackColor = Color.FromArgb(250, 250, 250);
                BtnDot.BackColor = Color.FromArgb(250, 250, 250);
                BtnColor.BackColor = Color.FromArgb(250, 250, 250);

                Btn1.ForeColor = Color.FromArgb(10, 10, 10);
                Btn2.ForeColor = Color.FromArgb(10, 10, 10);
                Btn3.ForeColor = Color.FromArgb(10, 10, 10);
                Btn4.ForeColor = Color.FromArgb(10, 10, 10);
                Btn5.ForeColor = Color.FromArgb(10, 10, 10);
                Btn6.ForeColor = Color.FromArgb(10, 10, 10);
                Btn7.ForeColor = Color.FromArgb(10, 10, 10);
                Btn8.ForeColor = Color.FromArgb(10, 10, 10);
                Btn9.ForeColor = Color.FromArgb(10, 10, 10);
                BtnZero.ForeColor = Color.FromArgb(10, 10, 10);
                BtnColor.ForeColor = Color.FromArgb(10, 10, 10);
                BtnDot.ForeColor = Color.FromArgb(10, 10, 10);

                BtnPlus.BackColor = Color.FromArgb(170, 205, 233);
                BtnMinus.BackColor = Color.FromArgb(170, 205, 233);
                BtnMultiply.BackColor = Color.FromArgb(170, 205, 233);
                BtnDivide.BackColor = Color.FromArgb(170, 205, 233);
                BtnExp.BackColor = Color.FromArgb(170, 205, 233);
                BtnRemoveLast.BackColor = Color.FromArgb(170, 205, 233);
                BtnReverseExp.BackColor = Color.FromArgb(170, 205, 233);
                BtnAllClear.BackColor = Color.FromArgb(170, 205, 233);
                button21.BackColor = Color.FromArgb(170, 205, 233);
                button22.BackColor = Color.FromArgb(170, 205, 233);
                BtnSqrt.BackColor = Color.FromArgb(170, 205, 233);

                BtnPlus.ForeColor = Color.FromArgb(10, 10, 20);
                BtnMinus.ForeColor = Color.FromArgb(10, 10, 20);
                BtnMultiply.ForeColor = Color.FromArgb(10, 10, 20);
                BtnDivide.ForeColor = Color.FromArgb(10, 10, 20);
                BtnExp.ForeColor = Color.FromArgb(10, 10, 20);
                BtnRemoveLast.ForeColor = Color.FromArgb(10, 10, 20);
                BtnReverseExp.ForeColor = Color.FromArgb(10, 10, 20);
                BtnAllClear.ForeColor = Color.FromArgb(10, 10, 20);
                button21.ForeColor = Color.FromArgb(10, 10, 20);
                button22.ForeColor = Color.FromArgb(10, 10, 20);
                BtnSqrt.ForeColor = Color.FromArgb(10, 10, 20);

                panel1.BackColor = Color.FromArgb(224, 234, 243);
                textBox1.BackColor = Color.FromArgb(214, 224, 243);
                textBox1.ForeColor = Color.Black;
                BtnResult.BackColor = Color.FromArgb(184, 184, 243);
                BtnResult.ForeColor = Color.FromArgb(10, 10, 20);
                IsDark = false;
            }
            else
            {
                Btn1.BackColor = Color.FromArgb(29, 35, 60);
                Btn2.BackColor = Color.FromArgb(29, 35, 60);
                Btn3.BackColor = Color.FromArgb(29, 35, 60);
                Btn4.BackColor = Color.FromArgb(29, 35, 60);
                Btn5.BackColor = Color.FromArgb(29, 35, 60);
                Btn6.BackColor = Color.FromArgb(29, 35, 60);
                Btn7.BackColor = Color.FromArgb(29, 35, 60);
                Btn8.BackColor = Color.FromArgb(29, 35, 60);
                Btn9.BackColor = Color.FromArgb(29, 35, 60);
                BtnZero.BackColor = Color.FromArgb(29, 35, 60);
                BtnColor.BackColor = Color.FromArgb(29, 35, 60);
                BtnDot.BackColor = Color.FromArgb(29, 35, 65);

                Btn1.ForeColor = Color.FromKnownColor(KnownColor.Control);
                Btn2.ForeColor = Color.FromKnownColor(KnownColor.Control);
                Btn3.ForeColor = Color.FromKnownColor(KnownColor.Control);
                Btn4.ForeColor = Color.FromKnownColor(KnownColor.Control);
                Btn5.ForeColor = Color.FromKnownColor(KnownColor.Control);
                Btn6.ForeColor = Color.FromKnownColor(KnownColor.Control);
                Btn7.ForeColor = Color.FromKnownColor(KnownColor.Control);
                Btn8.ForeColor = Color.FromKnownColor(KnownColor.Control);
                Btn9.ForeColor = Color.FromKnownColor(KnownColor.Control);
                BtnZero.ForeColor = Color.FromKnownColor(KnownColor.Control);
                BtnColor.ForeColor = Color.FromKnownColor(KnownColor.Control);
                BtnDot.ForeColor = Color.FromKnownColor(KnownColor.Control);
                button21.ForeColor = Color.FromKnownColor(KnownColor.Control);
                button22.ForeColor = Color.FromKnownColor(KnownColor.Control);
                BtnPlus.ForeColor = Color.FromKnownColor(KnownColor.Control);
                BtnMinus.ForeColor = Color.FromKnownColor(KnownColor.Control);
                BtnMultiply.ForeColor = Color.FromKnownColor(KnownColor.Control);
                BtnDivide.ForeColor = Color.FromKnownColor(KnownColor.Control);
                BtnAllClear.ForeColor = Color.FromKnownColor(KnownColor.Control);
                BtnExp.ForeColor = Color.FromKnownColor(KnownColor.Control);
                BtnRemoveLast.ForeColor = Color.FromKnownColor(KnownColor.Control);
                BtnReverseExp.ForeColor = Color.FromKnownColor(KnownColor.Control);
                BtnSqrt.ForeColor = Color.FromKnownColor(KnownColor.Control);
                textBox1.ForeColor = Color.FromKnownColor(KnownColor.Control);

                BtnPlus.BackColor = Color.FromArgb(25, 35, 64);
                BtnMinus.BackColor = Color.FromArgb(25, 35, 64);
                BtnMultiply.BackColor = Color.FromArgb(25, 35, 64);
                BtnDivide.BackColor = Color.FromArgb(25, 35, 64);
                BtnAllClear.BackColor = Color.FromArgb(25, 35, 64);
                BtnExp.BackColor = Color.FromArgb(25, 35, 64);
                BtnRemoveLast.BackColor = Color.FromArgb(25, 35, 64);
                BtnReverseExp.BackColor = Color.FromArgb(25, 35, 64);
                BtnSqrt.BackColor = Color.FromArgb(25, 35, 64);
                button21.BackColor = Color.FromArgb(25, 35, 64);
                button22.BackColor = Color.FromArgb(25, 35, 64);

                panel1.BackColor = Color.FromArgb(26, 31, 54);
                panel2.BackColor = Color.FromArgb(26, 31, 54);

                textBox1.BackColor = Color.FromArgb(26, 31, 51);
                BtnResult.BackColor = Color.FromArgb(40, 65, 100);
                BtnResult.ForeColor = Color.FromKnownColor(KnownColor.Control);
                IsDark= true;
            }
        }
    }
}
