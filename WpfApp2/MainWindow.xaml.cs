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
using WpfApp2.Okna;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Polozka> Polozky { get; set; }
        public MainWindow()
        {
            
            //Databaze Dat = new Databaze();
            Polozky = new();
            InitializeComponent();
            seznam.ItemsSource= Polozky;
        }

        private void AddButton(object sender, RoutedEventArgs e)
        {
            DialogPridat dialog = new(Polozky);
            dialog.Closing += Dialog_Closing;
            dialog.ShowDialog();

        }

        private void Dialog_Closing(object? sender, EventArgs e)
        {
            seznam.ItemsSource = null;
            seznam.ItemsSource = Polozky;
        }

        private void ShowButton(object sender, RoutedEventArgs e)
        {
            Polozka? info = seznam?.SelectedItem as Polozka ?? new Polozka("Neznámý", -1, -1, -1);
            MessageBox.Show($"{info.Id}   Název:{info.Nazev}   Počet:{info.Pocet}   Cena:{info.Cena}Kč");

        }

        private void EditButton(object sender, RoutedEventArgs e)
        {
            Polozka? hledana = seznam?.SelectedItem as Polozka;
            if (hledana != null)
            {
                DialogEdit edit = new DialogEdit(hledana);
                edit.Closing += Dialog_Closing;
                edit.ShowDialog();
            }

        }

        private void RemoveButton(object sender, RoutedEventArgs e)
        {
            Polozka? hledana = seznam?.SelectedItem as Polozka ?? new Polozka("Neznámý", -1, -1, -1);
            MessageBoxResult volba = MessageBox.Show($"Odebrat {hledana.Nazev}?", "Odebrat", MessageBoxButton.YesNo);
            if (volba == MessageBoxResult.Yes)
            {
                Polozky.Remove(hledana);
                seznam.ItemsSource = null;
                seznam.ItemsSource = Polozky;
            }

        }
    }
}