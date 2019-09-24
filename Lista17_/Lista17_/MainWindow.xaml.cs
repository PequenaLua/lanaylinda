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

namespace Ex01
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DisciplinaSemestral x = new DisciplinaSemestral(
                snome.Text, int.Parse(s1bim.Text), int.Parse(s2bim.Text),
                int.Parse(sfinal.Text));
            list.Items.Add(x);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DisciplinaAnual x = new DisciplinaAnual(
                anome.Text, int.Parse(a1bim.Text), int.Parse(a2bim.Text),
                int.Parse(a3bim.Text), int.Parse(a4bim.Text),
                int.Parse(afinal.Text));
            list.Items.Add(x);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            IMedia x = list.SelectedItem as IMedia;
            MessageBox.Show(x.GetMedia().ToString());
        }
    }
}