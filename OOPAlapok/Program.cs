using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAlapok
{
    public class Szemely
    {
        private string nev;
        private int kor;

        public Szemely(string Nev, int Kor)
        {
            nev = Nev;
            kor = Kor;
        }

        public int Kor
        {
            get { return kor; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Hiba: Az életkor nem lehet negatív! 0-ra állítva.");
                    kor = 0;
                }
                else
                {
                    kor = value;
                }
            }
        } 

        public string Kiir()
        {
            return $"A személy neve: {nev} és életkora: {kor}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely person = new Szemely("Ilona", 44);
            Console.WriteLine(person.Kiir());
        }
    }
}
