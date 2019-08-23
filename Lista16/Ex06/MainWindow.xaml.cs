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

namespace Ex06
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        Bingo b = new Bingo();
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void btnIniciar(object sender, RoutedEventArgs e)
        {         
            b.Iniciar(int.Parse(txtNumeroDeBolas.Text));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Bingo b = new Bingo();
            txtSort.Text = b.Proximo().ToString();
            int[] vetor = b.Sorteados();
            vetor[0] = 0;
            foreach (int k in vetor) txtSorteados.Text += k + " - ";
        }
    }
}
