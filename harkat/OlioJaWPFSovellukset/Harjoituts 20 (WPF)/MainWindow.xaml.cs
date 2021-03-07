using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Harjoituts_20__WPF_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LoadFromFile();
        }

        private void OpiskelijaIDValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void btnAddOpiskelija_Click(object sender, RoutedEventArgs e)
        {
            string etunimi = etunimiInput.Text;
            string sukunimi = sukunimiInput.Text;
            string opiskelijaID = opiskelijaIDInput.Text;

            if (etunimi.Length < 2 || sukunimi.Length < 2 || opiskelijaID.Length < 2)
            {
                return;
            }

            try
            {
                if (KokoelmaManageri.TarkistaID(opiskelijaID))
                {
                    KokoelmaManageri.LisääOpiskelija(etunimi, sukunimi, opiskelijaID);
                    SetActivityMessage("Uusi opiskelija lisätty kokoelmaan: " + KokoelmaManageri.Opiskelijat[opiskelijaID].HaeData());
                }
            }
            catch (Exception ex)
            {
                SetActivityMessage(ex.Message);
            }
            finally
            {
                ClearInputFields();
            }

            RefreshGrid();
        }

        private void ClearInputFields()
        {
            etunimiInput.Text = "";
            sukunimiInput.Text = "";
            opiskelijaIDInput.Text = "";
        }

        private void RefreshGrid()
        {
            OpiskelijatGrid.ItemsSource = KokoelmaManageri.PalautaOpiskelijat();
        }

        private void btnDeleteSelected_Click(object sender, RoutedEventArgs e)
        {

            string poistetutOpiskelijat = "";

            foreach (Opiskelija opiskelija in OpiskelijatGrid.ItemsSource)
            {
                if (opiskelija.IsSelected)
                {
                    poistetutOpiskelijat += " " + opiskelija.Etunimi + " " + opiskelija.Sukunimi + ", ";
                    KokoelmaManageri.PoistaOpiskelija(opiskelija);
                }
            }

            if (poistetutOpiskelijat.Equals(""))
                return;

            SetActivityMessage("Opiskelijat" + poistetutOpiskelijat + " poistettu kokoelmasta");

            RefreshGrid();
        }

        void SetActivityMessage(string message)
        {
            activityMessage.Text = message;
        }

        private void btnLoadFromFile_Click(object sender, RoutedEventArgs e)
        {
            LoadFromFile();
        }
        private void btnSaveToFile_Click(object sender, RoutedEventArgs e)
        {
            SaveToFile();
        }

        private void LoadFromFile()
        {
            string loadSuccessfulMessage = KokoelmaManageri.LoadFromFile();

            if (loadSuccessfulMessage == "")
            {
                SetActivityMessage("Opiskelija Kokoelma on haettu tiedostosta onnistuneesti!");
                RefreshGrid();
            }
            else
            {
                SetActivityMessage("Tiedoston lataaminen ei onnistunut, error: " + loadSuccessfulMessage);
            }
        }

        private void SaveToFile()
        {
            string saveSuccessfulMessage = KokoelmaManageri.SaveToFile();

            if (saveSuccessfulMessage == "")
            {
                SetActivityMessage("Opiskelija Kokoelma on tallennettu tieodstoon!");
            }
            else
            {
                SetActivityMessage("Tiedostoon tallentaminen ei onnistunut, error: " + saveSuccessfulMessage);
            }
        }
    }
}
