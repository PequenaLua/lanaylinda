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

namespace Ex07___WPF
{
    /// <summary>
    /// Lógica interna para VeiculoWindow.xaml
    /// </summary>
    public partial class VeiculoWindow : Window
    {
        public VeiculoWindow()
        {
            InitializeComponent();
        }
        Veiculo vc;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        internal Veiculo GetVeiculo()
        {
            vc = new Veiculo(txtPlaca.Text, txtFabricante.Text, txtModelo.Text, int.Parse(txtAno.Text), decimal.Parse(txtPreco.Text));
            return vc;
        }

    }
}
