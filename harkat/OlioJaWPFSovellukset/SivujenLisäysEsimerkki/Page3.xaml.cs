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
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            // Kun nappia painaa, siirrytään takaisin sivulle 2
            this.NavigationService.Navigate(MainWindow.page2);
        }
    }
}
