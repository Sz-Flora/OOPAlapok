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
        public string nev = "Peti";
        public int kor = 22;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely person = new Szemely();
            Console.WriteLine($"A személy neve: {person.nev} és életkora: {person.kor}");
        }
    }
}
