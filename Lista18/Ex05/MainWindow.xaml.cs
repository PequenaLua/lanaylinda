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

namespace Ex05
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
        Livraria l;
        private void IniciarLoja(object sender, RoutedEventArgs e)
        {
            l = new Livraria(nomeLoja.Text);
            lista.Items.Clear();
        }

        private void Inserir(object sender, RoutedEventArgs e)
        {
            Livro x = new Livro(titulo.Text, genero.Text, int.Parse(preco.Text));
            l.Inserir(x);
        }

        private void Listar(object sender, RoutedEventArgs e)
        {
            lista.ItemsSource = l.Listar();
        }

        private void ListarGenero(object sender, RoutedEventArgs e)
        {
            lista.ItemsSource = l.ListarGenero();
        }

        private void Top10Vendidos(object sender, RoutedEventArgs e)
        {
            lista.ItemsSource = l.Top10Vendidos();
        }
        private void Remover(object sender, RoutedEventArgs e)
        {
            Livro y = lista.SelectedItem as Livro;
            l.Remover(y);
        }

        private void Curtir(object sender, RoutedEventArgs e)
        {
            Livro y = lista.SelectedItem as Livro;
            Livro[] n = l.Listar();
            n[Array.IndexOf(l.Listar(), y)].Vender();
        }
    }
}
