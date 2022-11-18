using System.Text.RegularExpressions;

namespace Calculadora_Nueva
{
    public partial class Calculadora : Form
    {
        double num1 = 0, num2 = 0;
        double result;
        string operador = "";
        public Calculadora()
        {
            InitializeComponent();
        }
        private void numSet(double val) 
        {
            if (num1 != 0 && num2 != 0)
            {
                num1 = val;
                num2 = 0;
            } else if(num1 == 0){
                num1 = val;
            }
            else
            {
                num2= val;
            }
            
        }
        private void agregarNumero(string numero)
        {
            if (txtResultado.Text == "0") txtResultado.Text = "";
            
            txtResultado.Text += numero;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            num1= 0;
            num2 = 0;
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            agregarNumero(boton.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            numSet(Convert.ToDouble(txtResultado.Text));
            operador = "/";
            txtResultado.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            numSet(Convert.ToDouble(txtResultado.Text));
            operador = "*";
            txtResultado.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            numSet(Convert.ToDouble(txtResultado.Text));
            operador = "-";
            txtResultado.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            numSet(Convert.ToDouble(txtResultado.Text));
            operador = "+";
            txtResultado.Text = "";
        }

        
        private void button16_Click(object sender, EventArgs e)
        {
            numSet(Convert.ToDouble(txtResultado.Text));
            switch (operador)
            {
                case "+": txtResultado.Text = Convert.ToString(result = num1 + num2);
                    break;
                case "-":
                    txtResultado.Text = Convert.ToString(result = num1 - num2);
                    break;
                case "*":
                    txtResultado.Text = Convert.ToString(result = num1 * num2);
                    break;
                case "/":
                    txtResultado.Text = Convert.ToString(result = num1 / num2);
                    break;
            }
        }
    }
}