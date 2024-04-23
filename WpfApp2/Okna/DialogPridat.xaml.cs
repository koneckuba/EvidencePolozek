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

namespace WpfApp2.Okna
{
    /// <summary>
    /// Interakční logika pro DialogPridat.xaml
    /// </summary>
    public partial class DialogPridat : Window
    {
        List<Polozka> _polozky;
        public DialogPridat(List<Polozka> polozky)
        {
            InitializeComponent();
            _polozky = polozky;
        }
        private int VytvorId() => _polozky.Count + 1;
        private void SaveButton(object sender, RoutedEventArgs e)
        {
            string nazev = ProNazev.Text;
            int pocet = int.Parse(ProPocet.Text);
            int cena = int.Parse(ProCenu.Text);

            Polozka Novy = new Polozka(nazev,pocet,VytvorId(),cena);
            _polozky.Add(Novy);

            this.Close();
            
        }


        private void CancelButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
