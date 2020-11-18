using System;
using System.Windows.Forms;

namespace EjemploNumeros
{
    public partial class Form1 : Form
    {
        double valor1, valor2;
        string operacion = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void Metodo_Click(object sender, EventArgs e)
        {
            double resultado;
            string botonTexto = ((Button)sender).Text;
            switch (botonTexto)
            {
                case "R":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Sqrt(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Log":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Log(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Abs":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Abs(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Acos":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Acos(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Asin":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Asin(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Atan":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Atan(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Ceil":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Ceiling(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Cos":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Cos(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Cosh":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Cosh(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Exp":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Exp(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Flr":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Floor(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Log1":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Log10(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Rnd":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Round(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Sign":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Sign(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Sin":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Sin(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Sinh":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Sinh(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Tan":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Tan(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Tanh":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Tanh(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "Trte":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    resultado = Math.Truncate(valor1);
                    lblNumeros.Text = resultado + "";
                    break;
                case "+":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = botonTexto;
                    valor1 = double.Parse(lblNumeros.Text); 
                    lblNumeros.Text = "";
                    break;
                case "-":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = botonTexto;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;
                case "*":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = botonTexto;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;
                case "/":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = botonTexto;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;
                case "=":
                    if (lblNumeros.Text== "")
                    {
                        break;
                    }
                    switch (operacion)
                    {
                        case "+":
                            valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = (valor1 + valor2) + "";
                            break;
                        case "-":
                            valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = (valor1 - valor2) + "";
                            break;
                        case "*":
                            valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = (valor1 * valor2) + "";
                            break;
                        case "/":
                            valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = (valor1 / valor2) + "";
                            break;
                    }
                    break;
                case "C":
                    lblNumeros.Text = "";
                    break;
                case ".":
                    if (lblNumeros.Text.IndexOf(".") == -1)
                    {
                        lblNumeros.Text += botonTexto;
                    }
                    break;
                default:
                    lblNumeros.Text += botonTexto;
                    break;
            }
        }
    }
}
