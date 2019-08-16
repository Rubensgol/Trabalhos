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

            op1.IsChecked = true;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

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


            labely1.Margin = new Thickness(300, labely1.Margin.Top, labely1.Margin.Right, labely1.Margin.Bottom);
            labely2.Margin = new Thickness(300, labely2.Margin.Top, labely2.Margin.Right, labely2.Margin.Bottom);
            labely3.Margin = new Thickness(300, labely3.Margin.Top, labely3.Margin.Right, labely3.Margin.Bottom);

            y1.Margin = new Thickness(322, labely1.Margin.Top, labely1.Margin.Right, labely1.Margin.Bottom);
            y2.Margin = new Thickness(322, labely2.Margin.Top, labely2.Margin.Right, labely2.Margin.Bottom);
            y3.Margin = new Thickness(322, labely3.Margin.Top, labely3.Margin.Right, labely3.Margin.Bottom);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
