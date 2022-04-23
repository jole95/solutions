using System;

namespace Zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stanjaPobjede = new string[] { "01", "12", "20" }; // KS, SP, PK
            int bodovi = 0;

            while (true)
            {
                Console.WriteLine("---ODABERITE JEDNU OD  OPCIJA---\n\n 0 - Kamen \n 1 - Škare \n 2 - Papir \n 3 - Izlaz\n ");             
                var akcija = Console.ReadLine();
                string error = string.Empty;                
                string racunaloAkcija = string.Empty;

                if (akcija == "0")
                    Console.WriteLine("Vaš odabir -> Kamen");

                else if (akcija == "1")
                    Console.WriteLine("Vaš odabir -> Škare");

                else if (akcija == "2")
                    Console.WriteLine("Vaš odabir -> Papir");
                else if (akcija == "3")
                {
                    Console.WriteLine("Igra je završena!");
                    break;
                }

                else
                {
                    Console.WriteLine("Pogrešan unos");
                    error = "Pogrešan unos";
                }

                if (error == string.Empty)
                {
                    // postoji neka akcija (Valjan unos);
                    Random random = new Random();
                    racunaloAkcija = random.Next(3).ToString();
                    string potez = akcija + racunaloAkcija;

                    foreach (string stanjePobjede in stanjaPobjede)
                    {
                        if (potez == stanjePobjede)
                        {
                            bodovi = bodovi + 1;
                            break;
                        }

                    }

                    Console.WriteLine(String.Format("Računalo bira -> {0}\n", racunaloAkcija == "0" ? "Kamen" : racunaloAkcija == "1" ? "Škare" : "Papir"));
                }
              
                Console.WriteLine(String.Format("Ukupan broj bodova {0}\n", bodovi));
            }

            Console.ReadKey();
        }
    }
}
