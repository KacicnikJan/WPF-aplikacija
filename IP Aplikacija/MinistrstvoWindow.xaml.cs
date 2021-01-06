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
    /// Interaction logic for MinistrstvoWindow.xaml
    /// </summary>
    public partial class MinistrstvoWindow : Window
    {
        Podatki p;
        public MinistrstvoWindow(Podatki podatki)
        {
            p = podatki;
            InitializeComponent();
            Lime1.Content = Lime1.Content + " " + podatki.ImeStranke1;
            LPriimek1.Content = LPriimek1.Content + " " + podatki.PriimekStranke11;
            lDatum1.Content = lDatum1.Content + " " + podatki.DatumRojstva1;

            if (podatki.ImeStranke1 != null)
            {
                if (podatki.Zaposlen1 == true)
                {
                    lZaposlena1.Content = lZaposlena1.Content + " DA";
                }
                else
                {
                    lZaposlena1.Content = lZaposlena1.Content + " NE";
                }


                Lime2.Content = Lime2.Content + " " + podatki.ImeStranke2;
                lPriimek2.Content = lPriimek2.Content + " " + podatki.PriimekStranke21;
                Ldatum2.Content = Ldatum2.Content + " " + podatki.DatumRojstva2;
                if (podatki.Zaposlen2 == true)
                {
                    lZaposlena2.Content = lZaposlena2.Content + " DA";
                }
                else
                {
                    lZaposlena2.Content = lZaposlena2.Content + " NE";
                }
            }

            if (podatki.Stranka_zavrnila == true) {
                lZavrnitev.Content = lZavrnitev.Content + " Stranka je zavrnila predlagan kraj.";
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            p.Pooblastilo = true;
            p.Odgovor_ministrstva = true;
            if (cbKraj.SelectedItem.ToString().Contains("Cerkev")) {
                p.Kraj = "Cerkev";
            }
                if (cbKraj.SelectedItem.ToString().Contains("Obcina"))
            {
                p.Kraj = "Obcina";
            }
            if (cbKraj.SelectedItem.ToString().Contains("Glavni trg")) {
                p.Kraj = "Glavni trg";
            }
            MainWindow mainWindow = new MainWindow(p);
            mainWindow.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
