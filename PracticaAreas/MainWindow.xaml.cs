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
            
        }

        private void btnAreaTri_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnAreaC_Click(object sender, RoutedEventArgs e)
        {
            /*double aux = double.Parse(tbxRadioC.Text);
            aux = (aux*aux) * 3.14;
            tbkAreaC.Text = aux.ToString();*/
        }

        private void btnAreaTra_Click(object sender, RoutedEventArgs e)
        {
           /* int aux = int.Parse(tbxBaseMT.Text);
            int aux2 = int.Parse(tbxBaseMrT.Text);
            int aux3 = int.Parse(tbxAlturaTra.Text);
            int aux4 = (aux+aux2)/2*aux3;
            tbkAreaTra.Text = aux4.ToString();*/
        }

        private void cbTipoFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            panelConfiguracion.Children.Clear();
            switch (cbTipoFigura.SelectedIndex)
            {
                case 0:  //Rectangulo
                    panelConfiguracion.Children.Add(new ControlAreaRectangulo());
                    break;
                case 1:  //Triangulo
                    panelConfiguracion.Children.Add(new ControlAreaTriangulo());
                    break;
                case 2:  //Circulo
                    panelConfiguracion.Children.Add(new ControlAreaCirculo());
                    break;
                case 3:  //Trapecio
                    panelConfiguracion.Children.Add(new ControlAreaTrapecio());
                    break;
                default:
                    break;
            }
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            double area = 0.0;
            switch (cbTipoFigura.SelectedIndex)
            {
                case 0: //Rectangulo
                    var ControlAreaRectangulo = (ControlAreaRectangulo)panelConfiguracion.Children[0];
                    int aux = int.Parse(ControlAreaRectangulo.tbxBaseR.Text);
                    int aux2 = int.Parse(ControlAreaRectangulo.tbxAlturaR.Text);
                    area = aux*aux2;
                    break;
                case 1: //Triangulo
                    var ControlAreaTriangulo = (ControlAreaTriangulo)panelConfiguracion.Children[0];
                    aux = int.Parse(ControlAreaTriangulo.tbxAlturaTri.Text);
                    aux2 = int.Parse(ControlAreaTriangulo.tbxAlturaTri.Text);
                    area = (aux * aux2)/2;
                    break;
                case 2: //Circulo
                    break;
                case 3: //Trapecio
                    break;
                default:
                    break;

            }
            lblResultadoArea.Text = area.ToString();
        }
    }
}
