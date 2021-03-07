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

namespace SivujenLisäysEsimerkki
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // luodaan staattiset muuttujat sivuista, jotta ei tarvitse aina luoda uutta sivua esim "new Page1()"
        public static Page1 page1 = new Page1();
        public static Page2 page2 = new Page2();
        public static Page3 page3 = new Page3();

        public MainWindow()
        {
            InitializeComponent();

            // Kun ohjelma käynnistyy, siirytään automaattisesti sivulle 1, joka olisi sovellukset "etusivu"
            MainFrame.NavigationService.Navigate(page1);
        }
    }
}
