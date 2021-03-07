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

namespace Harjoitus_19__WPF_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Kerros1 kerros1 = new Kerros1();
        public static Kerros2 kerros2 = new Kerros2();
        public static Kerros3 kerros3 = new Kerros3();
        public static Kerros4 kerros4 = new Kerros4();
        public static Kerros5 kerros5 = new Kerros5();

        private List<Button> elevatorButtons = new List<Button>();

        private int currentFloor = 0;

        public MainWindow()
        {
            InitializeComponent();

            elevatorButtons.Add(btnFloorOne);
            elevatorButtons.Add(btnFloorTwo);
            elevatorButtons.Add(btnFloorThree);
            elevatorButtons.Add(btnFloorFour);
            elevatorButtons.Add(btnFloorFive);

            // alussa siirrytään ensimmäiselle kerrokselle
            ChangeFloor(1);
        }

        private void btnChangeFloor(object sender, RoutedEventArgs e)
        {
            Button buttonPressed = (Button)sender;

            int targetFloor = int.Parse(buttonPressed.Content.ToString());

            ChangeFloor(targetFloor);
        }


        private void ChangeFloor(int targetFloor)
        {
            if (currentFloor == targetFloor)
                return;


            ClearButtonColors(targetFloor);

            //Tähän kohtaan voisi tehdä jonkun ajastimen hissille, että hissi olisi perillä esim 5sek kuluttua.

            switch (targetFloor)
            {
                case 1:
                    MainFrame.NavigationService.Navigate(kerros1);
                    break;
                case 2:
                    MainFrame.NavigationService.Navigate(kerros2);
                    break;
                case 3:
                    MainFrame.NavigationService.Navigate(kerros3);
                    break;
                case 4:
                    MainFrame.NavigationService.Navigate(kerros4);
                    break;
                case 5:
                    MainFrame.NavigationService.Navigate(kerros5);
                    break;
            }

            currentFloor = targetFloor;
            elevatorText.Text = "Kerros " + currentFloor;
        }

        private void ClearButtonColors(int i)
        {
            foreach (Button nappi in elevatorButtons)
            {
                if (elevatorButtons[i - 1].Equals(nappi))
                {
                    elevatorButtons[i - 1].Background = new SolidColorBrush(Colors.Green);
                }
                else
                {
                    nappi.Background = new SolidColorBrush(Colors.White);
                }
            }
        }
    }
}
