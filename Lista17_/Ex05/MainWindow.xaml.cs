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
        Concurso c = new Concurso();
        private void btnInserir(object sender, RoutedEventArgs e)
        {
            Candidato x = new Candidato(txtNome.Text, DateTime.Parse(data.Text), int.Parse(pontos.Text));
            c.Inserir(x);
        }

        private void Listar(object sender, RoutedEventArgs e)
        {
            lista.ItemsSource = c.Listar();
        }

        private void Classificados(object sender, RoutedEventArgs e)
        {
            lista.ItemsSource = c.Classificados();
        }
    }
}
