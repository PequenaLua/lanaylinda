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
    /// Lógica interna para AutorWindow.xaml
    /// </summary>
    public partial class AutorWindow : Window
    {
        public AutorWindow()
        {
            InitializeComponent();
            SelectClick(null, null);
        }

        private void SelectClick(object sender, RoutedEventArgs e)
        {
            NAutor n = new NAutor();
            grid.ItemsSource = null;
            grid.ItemsSource = n.Select();
        }

        private void InsertClick(object sender, RoutedEventArgs e)
        {

            Autor l = new Autor();
            l.Nome = txtNome.Text;
            l.Biografia = txtBiografia.Text;
            NAutor n = new NAutor();
            n.Insert(l);

            SelectClick(sender, e);
        }

        private void UpdateClick(object sender, RoutedEventArgs e)
        {
            Autor outro = grid.SelectedItem as Autor;
            if (outro != null)
            {
                Autor l = new Autor();
                l.Id = outro.Id;
                l.Nome = txtNome.Text;
                l.Biografia = txtBiografia.Text;
                NAutor n = new NAutor();
                n.Update(l);
                SelectClick(sender, e);
            }
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            Autor l = grid.SelectedItem as Autor;
            NAutor n = new NAutor();
            n.Delete(l);
            SelectClick(sender, e);
        }

        private void grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid.SelectedItem != null)
            {
                Autor l = grid.SelectedItem as Autor;
                txtBiografia.Text = l.Biografia;
                txtNome.Text = l.Nome;
            }
        }
    }
}
