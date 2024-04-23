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
    /// Interakční logika pro Pridat.xaml
    /// </summary>
    List<Produkt> _Produkty;
    public partial class Pridat : Window
    {
        public Pridat(List<Produkt> produkty)
        {
            _Produkty = produkty;
            InitializeComponent();
        }

        

        private void BTN_zavrit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private int VytvorId() => _Produkty.Count + 1;

        private void BTN_pridat_Click(object sender, RoutedEventArgs e)
        {
            string nazev = TxtBX_nazev.Text;
            string pocet = TxtBx_pocet.Text;
            string  cena = TxtBx_cena.Text;

            Produkt Novy = new Produkt(VytvorId(), nazev, pocet, cena);
            _Produkty.Add(Novy);    

            this.Close();
        }
    }
}
