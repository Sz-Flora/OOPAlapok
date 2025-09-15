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
<<<<<<< HEAD
        private string _nev;
        private int _kor;

        public string Nev
        {
            get { return _nev; } //private adattag kiolvasásához
            set { _nev = value; } //private adattag beállításához
=======
        private string nev;
        private int kor;

        public Szemely(string Nev, int Kor)
        {
            nev = Nev;
            kor = Kor;
>>>>>>> 5aacd71b631b7b820f135c7d80caad79ab73a233
        }

        public int Kor
        {
<<<<<<< HEAD
            get { return _kor; }
            set 
            {
                if (value > 0) 
                    _kor = value; 
                else
                    Console.WriteLine("Az életkor nem lehet negatív.");
            }
        }

        /*public Szemely(string Nev, int Kor)
        {
            nev = Nev;
            kor = Kor;
        }*/

        /*public string Kiir()
        {
            return $"A személy neve: {nev} és életkora: {kor}";
        }*/
=======
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
>>>>>>> 5aacd71b631b7b820f135c7d80caad79ab73a233
    }
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Szemely person = new Szemely();
            person.Nev = "Kiss Ilona";
            person.Kor = 23;
            Console.WriteLine($"A személy neve:{person.Nev} és {person.Kor} éves");
            /*Szemely person = new Szemely("Ilona", 44);
            Console.WriteLine(person.Kiir());*/
=======
            Szemely person = new Szemely("Ilona", 44);
            Console.WriteLine(person.Kiir());
>>>>>>> 5aacd71b631b7b820f135c7d80caad79ab73a233
        }
    }
}
