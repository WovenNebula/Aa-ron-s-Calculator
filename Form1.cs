using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_ron_Calculator
{
    public partial class Calculator : Form
    {
        Double number = 0;
        String operations = "";
        bool operationsPressed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((solution.Text == "0")||(operationsPressed))
                solution.Clear();
            operationsPressed = false;
            Button p = (Button)sender;
            if (p.Text == ".")
            {
                if (!solution.Text.Contains("."))
                    solution.Text = solution.Text + p.Text;
            }
            else
                solution.Text = solution.Text + p.Text;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            solution.Text = "0";
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (number != 0)
            {
                button15.PerformClick();
                operationsPressed = true;
                operations = b.Text;
                buttonsPressed.Text = number + " " + operations;
            }
            else
            {
                operations = b.Text;
                number = Double.Parse(solution.Text);
                operationsPressed = true;
                buttonsPressed.Text = number + " " + operations;
            }
            operations = b.Text;
            number = Double.Parse(solution.Text);
            operationsPressed = true;
            buttonsPressed.Text = number + "" + operations;
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            switch (operations)
            {
                case "+":
                    solution.Text = (number + Double.Parse(solution.Text)).ToString();
                    break;
                case "-":
                    solution.Text = (number - Double.Parse(solution.Text)).ToString();
                    break;
                case "*":
                    solution.Text = (number * Double.Parse(solution.Text)).ToString();
                    break;
                case "/":
                    solution.Text = (number / Double.Parse(solution.Text)).ToString();
                    break;
                default:
                    break;
            }
            number = double.Parse(solution.Text);
            operations = "";
            


        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            solution.Clear();
            number = 0;
        }
    }
}
