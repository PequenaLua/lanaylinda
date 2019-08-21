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

namespace Ex02
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

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            Esfera x = new Esfera();
            x.SetRaio(double.Parse(txtRaio.Text));
            txtArea.Text = x.CalcArea().ToString("0.00");
            txtVolume.Text = x.CalcVolume().ToString("0.00");
        }
    }
}
