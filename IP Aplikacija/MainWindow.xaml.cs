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

namespace IP_Aplikacija
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Podatki pod;
        public MainWindow()
        {
            InitializeComponent();
            pod = new Podatki();
        }

        
        public MainWindow(Podatki p) {
            InitializeComponent();
            pod = p;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(tbIme.Text == "Uporabnik")
            {
                if (pod.Odgovor_ministrstva == true)
                {
                    Predlog window = new Predlog(pod);
                    window.Show();
                }
                else
                {
                    StrankaWindow window = new StrankaWindow();
                    window.Show();
                }
                Close();
            }
            if (tbIme.Text == "Admin") {
                if (pod.ImeStranke1 == null)
                {
                    MessageBox.Show("Ni nobenih zahtev");
                }
                else
                if (pod.Prosnja_stranke == true || pod.Stranka_zavrnila == true)
                {
                    pod.Prosnja_stranke = false;
                    MinistrstvoWindow window = new MinistrstvoWindow(pod);
                    window.Show();
                    Close();
                }
                else if (pod.Prosnja_stranke == false && pod.Stranka_zavrnila == false) {
                    Sklenitev_zakona sklenitev = new Sklenitev_zakona(pod);
                    sklenitev.Show();
                    Close();
                }
            }
        }
    }
}
