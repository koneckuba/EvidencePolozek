using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Polozka
    {
        
        public Polozka(string nazev, int pocet, int id, int cena)
        {
            Nazev = nazev;
            Pocet = pocet;
            Id = id;
            Cena = cena;
        }

        public string Nazev {  get; set; }
        public int? Pocet {  get; set; }
        public int? Id { get; set; }
        public int? Cena { get; set; }

        public override string ToString()
        {
            return $"{Nazev} {Pocet}krát {Cena}Kč";
        }
    }
}
