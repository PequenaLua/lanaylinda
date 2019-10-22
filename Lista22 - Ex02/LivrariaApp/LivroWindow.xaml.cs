using ModeloLivro;
using NegocioLivro;
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

        private void InsertClick(object sender, RoutedEventArgs e)
        {
            Livro l = new Livro();
            l.IdAutor = int.Parse(txtIdAutor.Text);
            l.Sinopse = txtSinopse.Text;
            l.Genero = txtGenero.Text;
            l.Titulo = txtTitulo.Text;
            NLivro n = new NLivro();
            n.Insert(l);
            txtIdAutor.Clear();
            txtSinopse.Clear();
            txtGenero.Clear();
            txtTitulo.Clear();
        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
