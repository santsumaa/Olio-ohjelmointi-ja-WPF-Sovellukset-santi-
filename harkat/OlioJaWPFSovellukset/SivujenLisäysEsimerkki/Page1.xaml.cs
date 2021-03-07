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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            // Kun nappia painaa, siirrytään sivulle 2. Tässä käytetään MainWindow luotua staattista muuttujaa
            // jotta ei tarvtise aina luoda uutta sivua "new Page2()" komennolla
            this.NavigationService.Navigate(MainWindow.page2);
        }
    }
}
