using System;

namespace ModelRuchuUlicznego
{
    class Program
    {
        public class Pojazd
        {
            public string NumerRejestracyjny { get; set; }
            public string Ulica { get; set; }
            public string Dzielnica { get; set; }
        }
        public class Ulica
        {
            public string Nazwa { get; set; }
            public string Dzielnica { get; set; }
        }
        public class Skrzyżowanie
        {
            public string Ulica1 { get; set; }
            public string Ulica2 { get; set; }
        }
        public class Dzielnica
        {
            public string Nazwa { get; set; }
        }
        static void Main(string[] args)
        {
            Pojazd[] pojazdy = new Pojazd[]
            {
              new Pojazd(){NumerRejestracyjny = "EL10283",Ulica = "Aleja Krakowska", Dzielnica = "Śródmieście"},
              new Pojazd(){NumerRejestracyjny = "PO4PJ54",Ulica = "Aleja 3 Maja", Dzielnica = "Stare Miasto"},
              new Pojazd(){NumerRejestracyjny = "FSU3072",Ulica = "Aleja Krakowska", Dzielnica = "Śródmieście"},
            };
            Ulica[] ulice = new Ulica[]
            {
                new Ulica(){Nazwa = "Aleja Krakowska", Dzielnica = "Śródmieście"},
                new Ulica(){Nazwa = "Aleja 3 Maja", Dzielnica = "Stare Miasto"}
            };
            Skrzyżowanie[] skrzyżowania = new Skrzyżowanie[]
            {
                new Skrzyżowanie(){Ulica1 = "Aleja Krakowska", Ulica2 = "Aleja 3 Maja"}
            };
            Dzielnica[] dzielnice = new Dzielnica[]
            {
                new Dzielnica(){Nazwa = "Śródmieście"},
                new Dzielnica(){Nazwa = "Stare Miasto"}
            };

            int maxPojazdów = 0;
            string ulicaMazPojazdów = "";
            string DzielnicaMaxPojazdów = "";

            int minPojazdów = int.MaxValue;
            string ulicaMinPojazdów = "";
            string dzielnicaMinPojazdów = "";

            foreach(var ulica in ulice)
            {
                int pojazdyNaUlicy = 0;
                foreach(var pojazd in pojazdy)
                {
                    if(pojazd.Ulica == ulica.Nazwa && pojazd.Dzielnica == ulica.Dzielnica)
                    {
                        pojazdyNaUlicy++;
                    }
                }
                if(pojazdyNaUlicy > maxPojazdów)
                {
                    maxPojazdów = pojazdyNaUlicy;
                    ulicaMazPojazdów = ulica.Nazwa;
                    DzielnicaMaxPojazdów = ulica.Dzielnica;
                }
                if(pojazdyNaUlicy < minPojazdów)
                {
                    minPojazdów = pojazdyNaUlicy;
                    ulicaMinPojazdów = ulica.Nazwa;
                    dzielnicaMinPojazdów = ulica.Dzielnica; 
                }



            }

            Console.WriteLine("Na ulicy " + ulicaMazPojazdów + " w dzielnicy " + DzielnicaMaxPojazdów + " znajduje się najwięcej pojazdów (" + maxPojazdów + ")." );
            Console.WriteLine("Na ulicy " + ulicaMinPojazdów + " w dzielnicy " + dzielnicaMinPojazdów + " znajduje się najmniej pojazdów (" + minPojazdów + ").");

            string streetName = "Aleja Krakowska";

            Console.WriteLine($"License plate numbers on {streetName}:");
            foreach (var pojazd in pojazdy)
            {
                if (pojazd.Ulica == streetName)
                {
                    Console.WriteLine(pojazd.NumerRejestracyjny);
                }
            }
            string streetName2 = "Aleja 3 Maja";

            Console.WriteLine($"License plate numbers on {streetName}:");
            foreach (var pojazd in pojazdy)
            {
                if (pojazd.Ulica == streetName2)
                {
                    Console.WriteLine(pojazd.NumerRejestracyjny);
                }
            }


        }

    }
}