using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        double Operand1;
        double Operand2;
        double Result;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void N1_Click_1(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "1";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "1";
            }
        }

        private void N2_Click_1(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "2";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "2";
            }
        }

        private void N3_Click_1(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "3";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "3";
            }
        }

        private void N4_Click_1(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "4";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "4";
            }
        }

        private void N5_Click_1(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "5";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "5";
            }
        }

        private void N6_Click_1(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "6";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "6";
            }
        }

        private void N7_Click_1(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "7";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "7";
            }
        }

        private void N8_Click_1(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "8";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "8";
            }
        }

        private void N9_Click_1(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "" && textBox_Result.Text != null)
            {
                textBox_Result.Text = "9";
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + "9";
            }
        }

        private void N0_Click_1(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "0";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Operand1 = Convert.ToDouble(textBox_Result.Text);
            textBox_Result.Text = "0";
            Operation = "+";
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            Operand1 = Convert.ToDouble(textBox_Result.Text);
            textBox_Result.Text = "0";
            Operation = "-";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            Operand1 = Convert.ToDouble(textBox_Result.Text);
            textBox_Result.Text = "0";
            Operation = "*";
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            Operand1 = Convert.ToDouble(textBox_Result.Text);
            textBox_Result.Text = "0";
            Operation = "/";
        }

        private void SQ_Click(object sender, EventArgs e)
        {
            Operand1 = Convert.ToDouble(textBox_Result.Text);
            textBox_Result.Text = (Operand1 * Operand1).ToString();

        }

        private void SQRT_Click(object sender, EventArgs e)
        {
            Operand1 = Convert.ToDouble(textBox_Result.Text);
            textBox_Result.Text = Math.Sqrt(Operand1).ToString();
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + ".";
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            Operand2 = Convert.ToDouble(textBox_Result.Text);

            if (Operation == "+")
            {
                Result = (Operand1 + Operand2);
                textBox_Result.Text = Convert.ToString(Result);
            }

            if (Operation == "-")
            {
                Result = (Operand1 - Operand2);
                textBox_Result.Text = Convert.ToString(Result);
            }

            if (Operation == "*")
            {
                Result = (Operand1 * Operand2);
                textBox_Result.Text = Convert.ToString(Result);
            }

            if (Operation == "/")
            {
                if (Operand2 == 0)
                {
                    textBox_Result.Text = "The number is not divisible by 0";
                }
                else
                {
                    Result = (Operand1 / Operand2);
                    textBox_Result.Text = Convert.ToString(Result);
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void TextBox_Result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

    //    private void Button1_Click(object sender, EventArgs e)
    //    {
    //        int x = int.Parse(textBox1.Text);
    //        int y = int.Parse(textBox2.Text);
    //        textBox3.Text = (x + y).ToString();
    //    }

    //    static string ConvertToBinary(int n)
    //    {
    //        string result = "";
    //        while (n > 0)
    //        {
    //            int reminder = n % 2;
    //            result = reminder + result;
    //            n = n / 2;
    //        }
    //        return result;
    //    }

    //    private void Button2_Click(object sender, EventArgs e)
    //    {
    //        textBox3.Text = ConvertToBinary(int.Parse(textBox1.Text));
    //    }

    //    private void CheckBox1_CheckChanged(object sender, EventArgs e)
    //    {
    //        if (checkBox1.Checked)
    //        {
    //            textBox1.Text = ConvertToBinary(int.Parse(textBox1.Text));
    //            textBox2.Text = ConvertToBinary(int.Parse(textBox2.Text));
    //            textBox3.Text = ConvertToBinary(int.Parse(textBox3.Text));
    //        }
    //        else
    //        {
    //            textBox1.Text = Convert.ToInt32(textBox1.Text, 2).ToString();
    //            textBox2.Text = Convert.ToInt32(textBox2.Text, 2).ToString();
    //            textBox3.Text = Convert.ToInt32(textBox3.Text, 2).ToString();
    //        }
    //    }

   