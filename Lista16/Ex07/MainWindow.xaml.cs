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
        }

        private void btnInserir(object sender, RoutedEventArgs e)
        {
            Disciplina x = new Disciplina();
            x.SetNome(txtDisciplina.Text);
            x.SetSemestre(txtSemestre.Text);
            x.SetMedia(double.Parse(txtMedia.Text));
            bool ok;
            if (chAp.IsChecked == true) ok = true;
            else ok = false;
            x.SetAprovado(ok);
            list.Items.Add(x.ToString());
        }
        private void btnExcluir(object sender, RoutedEventArgs e)
        {
            list.Items.Remove(list.SelectedItem); 
        }

        private void btnIRA(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(h.CalcularIRA().ToString(), "IRA");
        }
    }
}
