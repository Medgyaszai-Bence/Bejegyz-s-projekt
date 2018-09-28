using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bejegyzes> bejegyzeslista = new List<Bejegyzes>();
            bejegyzeslista.Add(new Bejegyzes("Jakab Áron", "java kezdőknek"));
            bejegyzeslista.Add(new Bejegyzes("Kocsis Gabriella", "főzés kezdőknek"));

            string beolvas;
            using (StreamReader reader = new StreamReader("bejegyzesek.txt"))
            {
                beolvas = reader.ReadLine();
                beolvas.Split(';');
            }

            Console.WriteLine(beolvas);


            int bekerszam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem adja meg hány bejegyzést szeretne megadni: ");

            for (int i = 0; i < bekerszam; i++)
            {
                bejegyzeslista.Add(new Bejegyzes(Convert.ToString(Console.ReadLine()), Convert.ToString(Console.ReadLine())));
                Console.WriteLine("Kérem adja meg a bejegyzést: ");
            }
















        }
    }
}
