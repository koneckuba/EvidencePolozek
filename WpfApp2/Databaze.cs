using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{ 
    internal class Databaze
    {
        public Polozka Pol { get; set; }
        public Databaze(Polozka pol)
        {
            Pol = pol;
            
        }
        
        public void Pridani()
        {
            Pol.Pocet += 12;
        }
        

    }
}
