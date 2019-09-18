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

        private void IniciarPA(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            PA p = new PA(int.Parse(pE.Text), int.Parse(razao.Text));
        }
        Sequencia x = p as Sequencia;
        x.Iniciar();
        private void ProximoPA(object sender, RoutedEventArgs e)
        {
            x.In
        }
    }
}
