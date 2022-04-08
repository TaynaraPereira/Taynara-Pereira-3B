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

namespace ProjetoEscola1
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

        private void btCadastro_Click(object sender, RoutedEventArgs e)
        {
                 string nome_fantasia = txtNomeFantasia.Text;
                 string nome_razaosocial = txtRazaoSocial.Text;
                 string nome_cnpj = txtCnpj.Text;
                 string nome_inscricaoestadual = txtInscrEstadual.Text;
                 string Tipo = "";
                 string nome_responsavel = txtResponsavel.Text;
                 string nome_cidade = txtNomeCidade.Text;
                 string nome_estado = txtEstado.Text;
                  string nome_Bairro = txtBairro.Text;
                  string nome_Rua = txtRua.Text;

           if(rdTipoPRIVADO.IsChecked ==true)
            {
                Tipo = rdTipoPRIVADO.ToString();
            }

            if (rdTipoPUBLICO.IsChecked== true)
            {
                Tipo = rdTipoPUBLICO.ToString();
            }




            MessageBox.Show("Nome Fantasia: " + nome_fantasia + Environment.NewLine +
                "Razão social: " + nome_razaosocial + Environment.NewLine +
                "CNPJ: " + nome_cnpj + Environment.NewLine +
                "Inscrição Estadual: " + nome_inscricaoestadual + Environment.NewLine +
                "TIPO: " + Tipo + Environment.NewLine +
                "Responsavel" + nome_responsavel + Environment.NewLine +
                "Cidade: " + nome_cidade + Environment.NewLine +
                "Estado:" + nome_estado + Environment.NewLine +
                "Bairro: " + nome_Bairro + Environment.NewLine +
                "Rua: " + nome_Rua + Environment.NewLine   );

          

        }
    }
}
