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

namespace Ex04
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

        private void BtnCalc_Click(object sender, RoutedEventArgs e)
        {
            EquacaoIIGrau y = new EquacaoIIGrau();
            y.SetABC(double.Parse(txtA.Text), double.Parse(txtB.Text), double.Parse(txtC.Text));
            txtDelta.Text = y.Delta().ToString("0");
            double x1 = 0, x2 = 0;
            if(y.RaizesReais() == true)
            {
                y.X1(out x1);
                txtX1.Text = Convert.ToString(x1);
                y.X2(out x2);
                txtX2.Text = Convert.ToString(x2);
            }
            else
            {
                txtX1.Text = "Não real";
                txtX2.Text = "Não real";
            }
        }
    }
}
