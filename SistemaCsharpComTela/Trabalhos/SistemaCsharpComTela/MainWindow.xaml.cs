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
                try
                {
                  a[0, 0] = double.Parse(x11.Text);    
                }
                catch (System.Exception)
                {
                    MessageBox.Show("linha 1 e coluna 1  erro")
                    throw;
                }
                //a[0, 0] = double.Parse(x11.Text);
                try
                {
                    a[0, 1] = double.Parse(x21.Text);    
                }
                catch (System.Exception)
                {
                    MessageBox.Show("coluna 1 linha 2 erro")
                    throw;
                }
                //a[0, 1] = double.Parse(x21.Text);
                try
                {
                   a[1, 0] = double.Parse(x12.Text); 
                }
                catch (System.Exception)
                {
                    MessageBox.Show("coluna 2 linha 1 erro")
                    throw;
                }
                //a[1, 0] = double.Parse(x12.Text);
                try
                {
                    a[1, 1] = double.Parse(x22.Text);    
                }
                catch (System.Exception)
                {
                    MessageBox.Show("colua 2 linha 2 erro")
                    throw;
                }
                //a[1, 1] = double.Parse(x22.Text);
                try
                {
                    b[0] = double.Parse(y1.Text);    
                }
                catch (System.Exception)
                {
                    MessageBox.Show("erro mt loko ai b[0]")
                    throw;
                }
                //b[0] = double.Parse(y1.Text);
                try
                {
                    b[1] = double.Parse(y2.Text);    
                }
                catch (System.Exception)
                {
                    MessageBox.Show("erro mt loko ai b[1]")
                    throw;
                }
                //b[1] = double.Parse(y2.Text);
                if(tamanho==3)
                {
                    try
                    {
                        a[0, 2] = double.Parse(x31.Text);
                    }
                    catch (System.Exception)
                    {
                      MessageBox.Show("coluna 1 linha 3 erro")  
                        throw;
                    }
                    //a[0, 2] = double.Parse(x31.Text);
                    try
                    {
                        a[1, 2] = double.Parse(x32.Text);    
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show("coluna 2 linha 3 erro")
                        throw;
                    }
                    //a[1, 2] = double.Parse(x32.Text);
                    try
                    {
                        a[2, 0] = double.Parse(x13.Text);    
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show("coluna 3 linha 1 erro")
                        throw;
                    }
                    //a[2, 0] = double.Parse(x13.Text);
                    try
                    {
                        a[2, 1] = double.Parse(x23.Text);    
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show("coluna 3 linha 2 erro")
                        throw;
                    }
                    
                    //a[2, 1] = double.Parse(x23.Text);
                    try
                    {
                        a[2, 2] = double.Parse(x33.Text);
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show("coluna 3 linha 3 erro")
                        throw;
                    }
                    //a[2, 2] = double.Parse(x33.Text);
                    try
                    {
                        b[2] = double.Parse(y3.Text);                      
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show("b[2] erro mt loko")
                        throw;
                    }
                    //b[2] = double.Parse(y3.Text);                  
                }
                if(tamanho==4)
                {
                    try
                    {
                        a[0, 3] = double.Parse(x14.Text);
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show("coluna 1 linha 4 erro")
                        throw;
                    }
                    //a[0, 3] = double.Parse(x14.Text);
                    try
                    {
                        a[1, 3] = double.Parse(x24.Text);
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show("coluna 2 linha 4 erro")
                        throw;
                    }
                    //a[1, 3] = double.Parse(x24.Text);
                    try
                    {
                        a[3, 0] = double.Parse(x41.Text);    
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show("coluna 4 linha 1 erro")
                        throw;
                    }
                    //a[3, 0] = double.Parse(x41.Text);
                    try
                    {
                        a[3, 1] = double.Parse(x42.Text);
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show("coluna 4 linha 2 erro")
                        throw;
                    }
                    //a[3, 1] = double.Parse(x42.Text);
                    try
                    {
                        a[3, 2] = double.Parse(x43.Text);    
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show("coluna 4 linha 3 erro")
                        throw;
                    }
                    //a[3, 2] = double.Parse(x43.Text);
                    try
                    {
                        a[3, 3] = double.Parse(x44.Text);    
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show("coluna 4 linha 4 erro")
                        throw;
                    }
                    //a[3, 3] = double.Parse(x44.Text);
                    try
                    {
                        a[2, 3] = double.Parse(x34.Text);
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show("coluna 3 linha 4 erro")
                        throw;
                    }
                    //a[2, 3] = double.Parse(x34.Text);
                    try
                    {
                        b[3] = double.Parse(y4.Text);
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show("b[3] erro")
                        throw;
                    }
                    //b[3] = double.Parse(y4.Text);
                }
                CalculaSistemaLinear calcula = new CalculaSistemaLinear();
                Jacobbi jacobbi = new Jacobbi();
                double[] c = new double[tamanho];
                c=jacobbi.SolucaoErro(b, a, 10);
                //c = calcula.Eliminacao(a, b);
                MessageBox.Show("teste");
          
        }

        private void X21_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
