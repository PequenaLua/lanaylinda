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

namespace Ex03
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
        ISorteio s;

        private void BeginBingo(object sender, RoutedEventArgs e)
        {
            Bingo b = new Bingo(int.Parse(txtNumeroDeBolas.Text));
            s = b as ISorteio;
            txtSorteados.Text = "";
        }

        private void Sortear(object sender, RoutedEventArgs e)
        {
            txtSort.Text = s.Sortear().ToString();
        }

        private void Sorteados(object sender, RoutedEventArgs e)
        {
            txtSorteados.Text = "";
            int[] v = s.Sorteados();
            foreach(int i in v){
                txtSorteados.Text += i.ToString();
                txtSorteados.Text += " ";
            }
        }

        private void BeginMega(object sender, RoutedEventArgs e)
        {
            Mega m = new Mega();
            s = m as ISorteio;
            txtSorteados.Text = "";
        }
    }
}
