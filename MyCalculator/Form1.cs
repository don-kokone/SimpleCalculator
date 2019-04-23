using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {

        double value = 0;
        string operation = string.Empty;
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

       

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed)) 
                result.Clear();

            operation_pressed = false;

            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
            equation.Text = value + " " + operation;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(result.Text);
            operation_pressed = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
            equation.Text = "";
            switch (operation)
            {

                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }
    }
}
