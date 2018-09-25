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

namespace PracticaAreas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnUnoCR_Click(object sender, RoutedEventArgs e)
        {
            int aux = int.Parse(tbxBaseR.Text);
            int aux2 = int.Parse(tbxAlturaR.Text);
            int aux3 = aux*aux2;
            tbkAreaR.Text = aux3.ToString();
        }

        private void btnAreaTri_Click(object sender, RoutedEventArgs e)
        {
            int aux = int.Parse(tbxBaseTri.Text);
            int aux2 = int.Parse(tbxAlturaTri.Text);
            int aux3 = (aux * aux2)/2;
            tbkAreaTri.Text = aux3.ToString();
        }

        private void btnAreaC_Click(object sender, RoutedEventArgs e)
        {
            double aux = double.Parse(tbxRadioC.Text);
            aux = (aux*aux) * 3.14;
            tbkAreaC.Text = aux.ToString();
        }

        private void btnAreaTra_Click(object sender, RoutedEventArgs e)
        {
            int aux = int.Parse(tbxBaseMT.Text);
            int aux2 = int.Parse(tbxBaseMrT.Text);
            int aux3 = int.Parse(tbxAlturaTra.Text);
            int aux4 = (aux+aux2)/2*aux3;
            tbkAreaTra.Text = aux4.ToString();
        }
    }
}
