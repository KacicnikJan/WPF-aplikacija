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
    /// Interaction logic for Sklenitev_zakona.xaml
    /// </summary>
    public partial class Sklenitev_zakona : Window
    {
        public Sklenitev_zakona(Podatki podatki)
        {
            InitializeComponent();
            lStranki.Content = lStranki.Content + " " + podatki.ImeStranke1 + " " + podatki.PriimekStranke11 + " " + podatki.ImeStranke2 + " " + podatki.PriimekStranke21;
            lProstor.Content = lProstor.Content + " " + podatki.Kraj;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zakon je bil uspesno sklenjen!");
            Close();
        }
    }
}
