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

namespace Ex08
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
        Loja l = new Loja();

        private void btnInserir(object sender, RoutedEventArgs e)
        {
            Veiculo x = new Veiculo();
            x.SetPlaca(txtPlaca.Text);
            x.SetFabricante(txtFabricante.Text);
            x.SetModelo(txtModelo.Text);
            x.SetAno(int.Parse(txtAno.Text));
            x.SetPreco(decimal.Parse(txtPreco.Text));
            bool ver;
            if (check.IsChecked == true) ver = true;
            else ver = false;
            x.SetVendido(ver);
            l.Inserir(x);
        }

        private void btnVender(object sender, RoutedEventArgs e)
        {

        }
    }
}
