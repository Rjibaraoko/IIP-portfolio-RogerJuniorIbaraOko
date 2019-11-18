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

namespace _02.wpf.Pizza
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Name)
            {
                case "Radio1":
                    image.Source = new BitmapImage(new Uri("D:/IIP-portfolio-RogerJuniorIbaraOko/Les 1/02.wpf.Pizza/Images/PHot.png"));
                    Compo.Content = String.Empty;
                    Compo.Content = "Tomatensaus, mozzarella, paprika, gegrilde ham, pepperoni & champignons";
                    return;
                case "Radio2":
                    image.Source = new BitmapImage(new Uri("D:/IIP-portfolio-RogerJuniorIbaraOko/Les 1/02.wpf.Pizza/Images/P4S.png"));
                    Compo.Content = String.Empty;
                    Compo.Content = "Tomatensaus, mozzarella, gegrilde ham & ananas";
                    return;
                case "Radio3":
                    image.Source = new BitmapImage(new Uri("D:/IIP-portfolio-RogerJuniorIbaraOko/Les 1/02.wpf.Pizza/Images/PHawai.png"));
                    Compo.Content = String.Empty;
                    Compo.Content = "Tomatensaus, mozzarella, gegrilde ham & ananas";
                    return;
            }

            
    }
    }
}
