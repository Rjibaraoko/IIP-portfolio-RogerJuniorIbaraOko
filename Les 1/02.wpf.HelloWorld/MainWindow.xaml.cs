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

namespace _02.wpf.HelloWorld
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void YES(object sender, RoutedEventArgs e)
        {
            lblHello.Content = " Hallo " + txtNaam.Text;

        }

        private void RESET_Click(object sender, RoutedEventArgs e)
        {
            txtNaam.Text = String.Empty;
            lblHello.Content = String.Empty;
            lblHello.Content = "Wat is jouw naam?";

        }
    }
}
