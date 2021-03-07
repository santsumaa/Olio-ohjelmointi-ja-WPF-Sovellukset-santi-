using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SivujenLisäysEsimerkki
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            // Kun nappia painaa, siirrytään takaisin sivulle 1.
            this.NavigationService.Navigate(MainWindow.page1);
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            // Kun nappia painaa, siirrytään sivulle 3.
            this.NavigationService.Navigate(MainWindow.page3);
        }
    }
}
