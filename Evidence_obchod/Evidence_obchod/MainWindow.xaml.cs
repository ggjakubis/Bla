using Evidence_obchod.Okna;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Evidence_obchod
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Produkt> Produkty {  get; set; }
        public MainWindow()
        {
            Produkty = new();
            InitializeComponent();
            seznam.ItemsSource = Produkty;
        }

        private void BTN_pridat_Click(object sender, RoutedEventArgs e)
        {
            Pridat dialog = new(Produkty);
            dialog.Closing += Dialog_Closing;
            dialog.ShowDialog();
        }

        private void Dialog_Closing(object? sender, EventArgs e)
        {
            seznam.ItemsSource = null;
            seznam.ItemsSource = Produkty;
        }

        private void BTN_detail_Click(object sender, RoutedEventArgs e)
        {
            Produkt? info = seznam?.SelectedItem as Produkt ?? new Produkt(-1, "Neznámý", "Nenalezen");
            MessageBox.Show($"{info.Id} {info.Nazev} {info.Pocet} {info.Cena}");
        }

        private void BTN_edit_Click(object sender, RoutedEventArgs e)
        {
            Produkt? hledany = seznam?.SelectedItem as Produkt;
            if (hledany != null)
            {
                Edit edit = new Edit(hledany);
                edit.Closing += Dialog_Closing;
                edit.ShowDialog();
            }

        }

        private void BTN_odstranit_Click(object sender, RoutedEventArgs e)
        {
            Produkt? hledany = seznam?.SelectedItem as Produkt;
            MessageBoxResult volba = MessageBox.Show($"Odebrat {hledany.Nazev}?", "Odebrat", MessageBoxButton.YesNo);
            if (volba == MessageBoxResult.Yes)
            {
                Produkty.Remove(hledany);
                seznam.ItemsSource = null;
                seznam.ItemsSource = Produkty;
            }
    }
}