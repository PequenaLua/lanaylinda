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
using ModeloLivro;
using NegocioLivro;

namespace LivrariaApp
{
    /// <summary>
    /// Lógica interna para LivroWindow.xaml
    /// </summary>
    public partial class LivroWindow : Window
    {
        public LivroWindow()
        {
            InitializeComponent();
        }

        private void SelectClick(object sender, RoutedEventArgs e)
        {
            NLivro n = new NLivro();
            grid.ItemsSource = null;
            grid.ItemsSource = n.Select();
        }

        private void InsertClick(object sender, RoutedEventArgs e)
        {
           
            Livro l = new Livro();
            l.Titulo = txtTitulo.Text;
            l.Genero = txtGenero.Text;
            l.IdAutor = int.Parse(txtIdAutor.Text);
            l.Sinopse = txtSinopse.Text;
            NLivro n = new NLivro();
            n.Insert(l);
            grid.ItemsSource = null;
            grid.ItemsSource = n.Select();
        }

        private void UpdateClick(object sender, RoutedEventArgs e)
        {
            Livro outro = grid.SelectedItem as Livro;
            Livro l = new Livro();
            l.Id = outro.Id;
            l.Titulo = txtTitulo.Text;
            l.Genero = txtGenero.Text;
            l.IdAutor = int.Parse(txtIdAutor.Text);
            l.Sinopse = txtSinopse.Text;
            NLivro n = new NLivro();
            n.Update(l);
            grid.ItemsSource = null;
            grid.ItemsSource = n.Select();
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            Livro l = grid.SelectedItem as Livro;
            NLivro n = new NLivro();
            n.Delete(l);
            grid.ItemsSource = null;
            grid.ItemsSource = n.Select();
        }
    }
}
