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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetoTeste
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btAcessar_Click(object sender, RoutedEventArgs e)
        {

            string senha = txtSenha.Password.ToString();
            string user = txtUsuario.Text;


            if (user == "thaypereira69021@gmail.com" & senha == "1234")
            {

                MessageBox.Show("Usuário e senha corretos!");
                txtUsuario.Clear();
                txtSenha.Clear();
                Calculadora calculadora = new Calculadora();
                calculadora.Show();
                this.Close();
            }
            else
            {

                MessageBox.Show("Usuário ou senha incorreto!");
                txtUsuario.Clear();
                txtSenha.Clear();
            }
        }
    }
}
