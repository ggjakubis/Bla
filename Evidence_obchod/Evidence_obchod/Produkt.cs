using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidence_obchod
{
    public class Produkt
    {
        public Produkt(int id, string nazev, int pocet, int cena) 
        {
            Id = id;
            Nazev = nazev;
            Pocet = pocet;
            Cena = cena;
        }
        public int Id { get; set; }
        public string Nazev { get; set; } 
        public int Pocet { get; set; } 
        public int Cena { get; set; }

        public override string ToString()
        {
            return $"{Nazev} {Pocet} {Cena}";
        }
    }
}
