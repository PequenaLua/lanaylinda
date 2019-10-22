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
using NegocioAutor;
using NegocioLivro;

namespace LivrariaApp
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

  

        private void InsertLivroClick(object sender, RoutedEventArgs e)
        {
            LivroWindow j2 = new LivroWindow();
            j2.ShowDialog();
        }

        private void InsertAutorClick(object sender, RoutedEventArgs e)
        {
            AutorWindow j3 = new AutorWindow();
            j3.ShowDialog();
        }

        private void ListarAutoresClick(object sender, RoutedEventArgs e)
        {
            OpAutorWindow oj = new OpAutorWindow();
            oj.ShowDialog();
        }
    }
}
