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
using System.Windows.Shapes;
using ModeloAutor;
using NegocioAutor;

namespace LivrariaApp
{
    /// <summary>
    /// Lógica interna para OpAutorWindow.xaml
    /// </summary>
    public partial class OpAutorWindow : Window
    {
        public OpAutorWindow()
        {
            InitializeComponent();
            NAutor n = new NAutor();
            grid.ItemsSource = null;
            grid.ItemsSource = n.Select();
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            NAutor n = new NAutor();
            n.Delete(grid.SelectedItem as Autor);
            grid.ItemsSource = null;
            grid.ItemsSource = n.Select();
        }

        private void UpdateClick(object sender, RoutedEventArgs e)
        {
            AutorWindow j2 = new AutorWindow();
            if (j2.ShowDialog().Value) { 
            NAutor n = new NAutor();
            n.Update(grid.SelectedItem as Autor);
            grid.ItemsSource = null;
            grid.ItemsSource = n.Select();
            }
        }
    }
}
