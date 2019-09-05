using System.Windows;
using System.Windows.Controls;

namespace SistemaCsharpComTela
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            gaussop.IsChecked = true;
            op1.IsChecked = true;


        }

        private void Op2_Checked(object sender, RoutedEventArgs e)
        {
            x13.Visibility = Visibility.Visible;
            x23.Visibility = Visibility.Visible;
            x33.Visibility = Visibility.Visible;
            x31.Visibility = Visibility.Visible;
            x32.Visibility = Visibility.Visible;
            x33.Visibility = Visibility.Visible;
            y3.Visibility = Visibility.Visible;
            labelx3.Visibility = Visibility.Visible;
            labely3.Visibility = Visibility.Visible;



            labelx4.Visibility = Visibility.Hidden;
            x14.Visibility = Visibility.Hidden;
            x24.Visibility = Visibility.Hidden;
            x34.Visibility = Visibility.Hidden;
            y4.Visibility = Visibility.Hidden;
            labely4.Visibility = Visibility.Hidden;
            x41.Visibility = Visibility.Hidden;
            x42.Visibility = Visibility.Hidden;
            x43.Visibility = Visibility.Hidden;
            x44.Visibility = Visibility.Hidden;


            labely1.Margin = new Thickness(240, labely1.Margin.Top, labely1.Margin.Right, labely1.Margin.Bottom);
            labely2.Margin = new Thickness(240, labely2.Margin.Top, labely2.Margin.Right, labely2.Margin.Bottom);
            labely3.Margin = new Thickness(240, labely3.Margin.Top, labely3.Margin.Right, labely3.Margin.Bottom);
            y1.Margin = new Thickness(262, labely1.Margin.Top, labely1.Margin.Right, labely1.Margin.Bottom);
            y2.Margin = new Thickness(262, labely2.Margin.Top, labely2.Margin.Right, labely2.Margin.Bottom);
            y3.Margin = new Thickness(262, labely3.Margin.Top, labely3.Margin.Right, labely3.Margin.Bottom);
        }

        private void Op1_Checked(object sender, RoutedEventArgs e)
        {
            x13.Visibility = Visibility.Hidden;
            x23.Visibility = Visibility.Hidden;
            x33.Visibility = Visibility.Hidden;
            x31.Visibility = Visibility.Hidden;
            x32.Visibility = Visibility.Hidden;
            x33.Visibility = Visibility.Hidden;
            y3.Visibility = Visibility.Hidden;
            labelx3.Visibility = Visibility.Hidden;
            labely3.Visibility = Visibility.Hidden;
            x41.Visibility = Visibility.Hidden;
            x42.Visibility = Visibility.Hidden;
            x43.Visibility = Visibility.Hidden;
            x44.Visibility = Visibility.Hidden;
            labelx4.Visibility = Visibility.Hidden;
            x14.Visibility = Visibility.Hidden;
            x24.Visibility = Visibility.Hidden;
            x34.Visibility = Visibility.Hidden;
            y4.Visibility = Visibility.Hidden;
            labely4.Visibility = Visibility.Hidden;
            labely1.Margin = new Thickness(140, labely1.Margin.Top, labely1.Margin.Right, labely1.Margin.Bottom);
            labely2.Margin = new Thickness(140, labely2.Margin.Top, labely2.Margin.Right, labely2.Margin.Bottom);
            y1.Margin = new Thickness(162, labely1.Margin.Top, labely1.Margin.Right, labely1.Margin.Bottom);
            y2.Margin = new Thickness(162, labely2.Margin.Top, labely2.Margin.Right, labely2.Margin.Bottom);
        }

        private void Op3_Checked(object sender, RoutedEventArgs e)
        {
            x13.Visibility = Visibility.Visible;
            x23.Visibility = Visibility.Visible;
            x33.Visibility = Visibility.Visible;
            x31.Visibility = Visibility.Visible;
            x32.Visibility = Visibility.Visible;
            x33.Visibility = Visibility.Visible;
            y3.Visibility = Visibility.Visible;
            labelx3.Visibility = Visibility.Visible;
            labely3.Visibility = Visibility.Visible;
            x41.Visibility = Visibility.Visible;
            x42.Visibility = Visibility.Visible;
            x43.Visibility = Visibility.Visible;
            x44.Visibility = Visibility.Visible;
            labelx4.Visibility = Visibility.Visible;
            x14.Visibility = Visibility.Visible;
            x24.Visibility = Visibility.Visible;
            x34.Visibility = Visibility.Visible;
            y4.Visibility = Visibility.Visible;
            labely4.Visibility = Visibility.Visible;


            labely1.Margin = new Thickness(269, labely1.Margin.Top, labely1.Margin.Right, labely1.Margin.Bottom);
            labely2.Margin = new Thickness(269, labely2.Margin.Top, labely2.Margin.Right, labely2.Margin.Bottom);
            labely3.Margin = new Thickness(269, labely3.Margin.Top, labely3.Margin.Right, labely3.Margin.Bottom);

            y1.Margin = new Thickness(295, labely1.Margin.Top, labely1.Margin.Right, labely1.Margin.Bottom);
            y2.Margin = new Thickness(295, labely2.Margin.Top, labely2.Margin.Right, labely2.Margin.Bottom);
            y3.Margin = new Thickness(295, labely3.Margin.Top, labely3.Margin.Right, labely3.Margin.Bottom);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Opparada_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(opparada.SelectedIndex==0)
            {

                errolabel.Visibility = Visibility.Hidden;
                errotxt.Visibility = Visibility.Hidden;
                qtdlinhalabel.Visibility = Visibility.Visible;
                qtdlinhatxt.Visibility = Visibility.Visible;
            }
            else
            {
                errolabel.Visibility = Visibility.Visible;
                errotxt.Visibility = Visibility.Visible;
                qtdlinhalabel.Visibility = Visibility.Hidden;
                qtdlinhatxt.Visibility = Visibility.Hidden;
            }

        }

        private void Gaussop_Checked(object sender, RoutedEventArgs e)
        {
            listaparadas.Visibility = Visibility.Hidden;
        }

        private void Jacobbiop_Checked(object sender, RoutedEventArgs e)
        {
            listaparadas.Visibility = Visibility.Visible;
            opparada.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int tamanho = 2;
            if (op3.IsChecked == true)
                tamanho = 4;
            else if (op2.IsChecked == true)
                tamanho = 3;
            else if (op1.IsChecked == true)
                tamanho = 2;

            double[,] a = new double[tamanho, tamanho];
            double[] b = new double[tamanho];
           
                a[0, 0] = double.Parse(x11.Text);
                a[0, 1] = double.Parse(x21.Text);
                a[1, 0] = double.Parse(x12.Text);
                a[1, 1] = double.Parse(x22.Text);
                b[0] = double.Parse(y1.Text);
                b[1] = double.Parse(y2.Text);
                if(tamanho==3 || tamanho==4)
                {
                    a[0, 2] = double.Parse(x31.Text);
                    a[1, 2] = double.Parse(x32.Text);
                    a[2, 0] = double.Parse(x13.Text);
                    a[2, 1] = double.Parse(x23.Text);
                    a[2, 2] = double.Parse(x33.Text);
                    b[2] = double.Parse(y3.Text);                  
                }
                if(tamanho==4)
                {
                    a[0, 3] = double.Parse(x41.Text);
                    a[1, 3] = double.Parse(x42.Text);
                    a[3, 0] = double.Parse(x14.Text);
                    a[3, 1] = double.Parse(x24.Text);
                    a[3, 2] = double.Parse(x34.Text);
                    a[3, 3] = double.Parse(x44.Text);
                    a[2, 3] = double.Parse(x43.Text);
                    b[3] = double.Parse(y4.Text);
                }
                

            if (jacobbiop.IsChecked == true)
            {
                Jacobbi jacobbi = new Jacobbi();
                JanelaJacobbi jacobbi1 = new JanelaJacobbi();
                jacobbi1.txttela.Text = jacobbi.SolucaoErro(b, a, 15);
                jacobbi1.ShowDialog();
            }
            // c = calcula.Eliminacao(a, b);
            if (determinanteop.IsChecked == true)
            {
                Gauss calcula = new Gauss();
                double det = calcula.Determinante(a, b);
                _ = MessageBox.Show("O determinante é" + det.ToString());
            }
            
          
        }

        private void X21_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
