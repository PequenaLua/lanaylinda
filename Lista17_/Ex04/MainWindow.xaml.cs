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

namespace Ex04
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
        QuadroMedalhas q = new QuadroMedalhas();
        private void AdicionarPais(object sender, RoutedEventArgs e)
        {
            Pais p = new Pais(txtNome.Text, int.Parse(ouro.Text), int.Parse(prata.Text), int.Parse(bronze.Text));
            q.Inserir(p);
        }

        private void ListarPaises(object sender, RoutedEventArgs e)
        {
            lista.ItemsSource = q.Listar(); 
        }
    }
}
