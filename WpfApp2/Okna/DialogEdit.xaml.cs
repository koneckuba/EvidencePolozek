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
    /// Interakční logika pro DialogEdit.xaml
    /// </summary>
    public partial class DialogEdit : Window
    {
        public Polozka P {  get; set; }
        public DialogEdit(Polozka p)
        {
            P = p;
            InitializeComponent();
            DataContext =P;
        }

        private void SaveButton(object sender, RoutedEventArgs e)
        {
            P.Nazev = ProNazev.Text;
            P.Pocet = int.Parse(ProPocet.Text);
            P.Cena = int.Parse(ProCenu.Text);

            this.Close();
        }

        private void CancelButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
