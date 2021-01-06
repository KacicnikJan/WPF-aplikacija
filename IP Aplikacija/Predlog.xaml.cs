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
    /// Interaction logic for Predlog.xaml
    /// </summary>
    public partial class Predlog : Window
    {
        Podatki pod;
        public Predlog(Podatki p)
        {
            InitializeComponent();
            pod = p;
            if (p.Pooblastilo == true) {
                lPooblastilo.Content = lPooblastilo.Content
                    + "\nVasa vloga za zakonsko zvezo je bila odobrena.";
            }

            lProstor.Content = lProstor.Content + " " + p.Kraj;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pod.Stranka_zavrnila = true;
            MainWindow mainWindow = new MainWindow(pod);
            mainWindow.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            pod.Stranka_zavrnila = false;
            MainWindow mainWindow = new MainWindow(pod);
            mainWindow.Show();
            Close();

        }
    }
}
