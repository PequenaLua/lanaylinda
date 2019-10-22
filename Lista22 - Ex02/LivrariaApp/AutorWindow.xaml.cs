using ModeloAutor;
using NegocioAutor;
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
    /// Lógica interna para AutorWindow.xaml
    /// </summary>
    public partial class AutorWindow : Window
    {
        public AutorWindow()
        {
            InitializeComponent();
        }

        private void InsertClick(object sender, RoutedEventArgs e)
        {
            Autor a = new Autor();
            a.Biografia = txtBiografia.Text;
            a.Nome = txtNome.Text;
            NAutor n = new NAutor();
            n.Insert(a);
            txtNome.Clear();
            txtBiografia.Clear();
            DialogResult = true;
        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
        internal Autor GetAutor()
        {
            Autor a = new Autor();
            a.Biografia = txtBiografia.Text;
            a.Nome = txtNome.Text;
            return a;
        }

    }
}
