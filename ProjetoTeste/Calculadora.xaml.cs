using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProjetoTeste
{
    /// <summary>
    /// Lógica interna para Calculadora.xaml
    /// </summary>
    public partial class Calculadora : Window
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btAdicao_Click(object sender, RoutedEventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);

            double num2 = Convert.ToDouble(txtNum2.Text);

            double resultado = num1 + num2;
            txtResultado.Text = Convert.ToString(resultado);
        }

        private void btMultiplicar_Click(object sender, RoutedEventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);

            double num2 = Convert.ToDouble(txtNum2.Text);

            double resultado = num1 * num2;
            txtResultado.Text = Convert.ToString(resultado);
        }

        private void btDividir_Click(object sender, RoutedEventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);

            double num2 = Convert.ToDouble(txtNum2.Text);

            double resultado = num1 / num2;
            txtResultado.Text = Convert.ToString(resultado);
        }

        private void btSubtracao_Click(object sender, RoutedEventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);

            double num2 = Convert.ToDouble(txtNum2.Text);

            double resultado = num1 - num2;
            txtResultado.Text = Convert.ToString(resultado);
        }

        private void txtResultado_TextChanged()
        {

        }
    }
}
