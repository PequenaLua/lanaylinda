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

namespace Ex08___WPF
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
        Estoque es = new Estoque();
        
        private void ListarDescricaoClick(object sender, RoutedEventArgs e)
        {
            lista.ItemsSource = es.ListarDescricao();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lista.ItemsSource = es.ListarPreco();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lista.ItemsSource = es.Vencidos();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            lista.ItemsSource = es.AVencer(int.Parse(dias.Text));
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            lista.ItemsSource = es.EstoqueBaixo(int.Parse(qtd.Text));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(es.Total().ToString(), "Total em R$");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            es.Excluir(lista.SelectedItem as Produto);
        }
    }
}
