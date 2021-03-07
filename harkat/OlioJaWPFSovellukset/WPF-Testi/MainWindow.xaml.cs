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

namespace WPF_Testi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // muokkaa tbInfo - textboxin sisältöä
            tbInfo.Text = "";
        }

        // Button on automaattisesti yhdistetty luotuun button -kontrolliin
        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            tbInfo.Text = "Hyöydyllinen info viesti! :)";
        }
    }
}
