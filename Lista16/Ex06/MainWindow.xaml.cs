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
        Bingo b;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void btnIniciar(object sender, RoutedEventArgs e)
        {
            b = new Bingo();
            b.Iniciar(int.Parse(txtNumeroDeBolas.Text));
            txtSorteados.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = b.Proximo();
            txtSort.Text = n.ToString();
            txtSorteados.Text += n.ToString() + " ";
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (txtNumeroDeBolas != null) txtNumeroDeBolas.Text = slider.Value.ToString();
        }
    }
}
