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
using System.Windows.Shapes;

namespace IP_Aplikacija
{
    /// <summary>
    /// Interaction logic for StrankaWindow.xaml
    /// </summary>
    public partial class StrankaWindow : Window
    {
        public StrankaWindow()
        {
            InitializeComponent();
        }
        Podatki po;
        public StrankaWindow(Podatki p)
        {
            InitializeComponent();
            po = p;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                Podatki pod = new Podatki();
                string imePriimek1;
                string imePriimek2;
                string datum1;
                string datum2;

                bool zaposlen1;
                bool zaposlen2;


            if (tbIme1.Text.Length > 0 && tbPriimek1.Text.Length > 0 && tbIme2.Text.Length > 0 && tbPriimek2.Text.Length > 0 && Date1.SelectedDate != null && Date2.SelectedDate != null)
            {
                lOpozorilo.Content = "";
                pod.ImeStranke1 = tbIme1.Text;
                pod.PriimekStranke11 = tbPriimek1.Text;
                pod.ImeStranke2 = tbIme2.Text;
                pod.PriimekStranke21 = tbPriimek2.Text;

                datum1 = Date1.SelectedDate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
                pod.DatumRojstva1 = datum1;
                datum2 = Date2.SelectedDate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
                pod.DatumRojstva2 = datum2;

                if (cbZaposlen1.IsChecked == true)
                {
                    zaposlen1 = true;
                }
                else
                {
                    zaposlen1 = false;
                }

                pod.Zaposlen1 = zaposlen1;

                if (cbZaposlen2.IsChecked == true)
                {
                    zaposlen2 = true;
                }
                else
                {
                    zaposlen2 = false;
                }

                pod.Zaposlen2 = zaposlen2;
                pod.Prosnja_stranke = true;

                MainWindow mainWindow = new MainWindow(pod);
                mainWindow.Show();
                Close();
            }
            else {
                lOpozorilo.Content = "Potrebno je vpisati vse podatke!";
            }

                
      
        }
    }
}
