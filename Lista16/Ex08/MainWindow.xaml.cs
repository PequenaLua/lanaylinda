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
            txtPlaca.Clear();
            txtFabricante.Clear();
            txtModelo.Clear();
            txtAno.Clear();
            txtPreco.Clear();
        }

        private void btnTotal(object sender, RoutedEventArgs e)
        {
          MessageBox.Show($"R$ {l.Total().ToString()}");
        }
        private void btnListarTodos(object sender, RoutedEventArgs e)
        {
            Veiculo[] y = l.Listar();
            list.ItemsSource = y;
        }
        private void btnListarValor(object sender, RoutedEventArgs e)
        {
            if (txtValorMaximo.Text != null) { 
                Veiculo[] g = l.ListarValor(decimal.Parse(txtValorMaximo.Text));
                list.ItemsSource = g;
            }
        }

        private void btnVender(object sender, RoutedEventArgs e)
        {
            Veiculo[] f = l.Listar();
            int u = Array.IndexOf(f, list.SelectedItem);
            if (f[u].GetVendido() == false)
            {
                f[u].Vender();
                f = l.Listar();
                list.ItemsSource = f;
            }
            else MessageBox.Show("O veículo já está vendido");
        }

        private void btnConfirmarNome(object sender, RoutedEventArgs e)
        {
            l.SetNome(txtNomeLoja.Text);
            main.Title = txtNomeLoja.Text; 
        }
    }
}
