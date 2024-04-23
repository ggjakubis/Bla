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

namespace Evidence_obchod.Okna
{
    /// <summary>
    /// Interakční logika pro Edit.xaml
    /// </summary>
    public partial class Edit : Window
    { 
         public Produkt Z { get; set; }
    
        public Edit(Produkt Z)
        {
            Z = z;
            InitializeComponent();
            DataContext = Z;
        }

        private void BTN_ulozit_Click(object sender, RoutedEventArgs e)
        {
            Z.Nazev = TxtBx_nazev.Text;
            Z.Pocet =Convert.ToInt32(TxtBx_pocet.Text);
            Z.Cena = Convert.ToInt32(TxtBx_cena.Text);
            this.Close();
        }

        private void BTN_zahodit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
