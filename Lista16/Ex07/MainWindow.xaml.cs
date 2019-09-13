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

namespace Ex07
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        Historico h;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAluno(object sender, RoutedEventArgs e)
        {
            h = new Historico();
            h.SetNome(txtNome.Text);
            list.Items.Clear();
            txtDisciplina.Clear();
            txtSemestre.Clear();
            txtMedia.Clear();
        }

        private void btnInserir(object sender, RoutedEventArgs e)
        {
            bool apvd = (double.Parse(txtMedia.Text) >= 60 ? true : false);
            h.Inserir(new Disciplina(txtNome.Text, txtSemestre.Text, double.Parse(txtMedia.Text), apvd));
            list.ItemsSource = h.Listar();
            txtDisciplina.Clear();
            txtSemestre.Clear();
            txtMedia.Clear();
        }
        private void btnExcluir(object sender, RoutedEventArgs e)
        {
            h.Apagar(list.SelectedIndex);
            list.ItemsSource = h.Listar();
        }

        private void btnIRA(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(h.CalcularIRA().ToString("0.0"), "IRA");
        }
    }
}
