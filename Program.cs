using System;

namespace ConsoleTriviant
{
    class Program
    {
        static int Score = 0; // aantal vragen goed
        static string Vraag = "Wanneer eindigde de Eerste Wereldoorlog"; // Vraag 1
        static string[] Antwoorden = { "1918", "1945", "1938", "1905" }; //Antwoorden van vraag 1
        static int JuisteAntwoord = 0; // Juiste Antwoord



        static void Main(string[] args)
        {
            //Introductie
            Console.WriteLine("welkom bij het spel triviant");
            Console.WriteLine("Je krijgt zodadelijk een aantal vragen waar jij het goede antwoord op moet geven");
            Console.WriteLine("Om te beginnen druk op ENTER");
            Console.ReadLine();
            showVraag(1);
            showAntwoorden();
            int Antwoord = int.Parse(Console.ReadLine());

            switch (checkAntwoord(Antwoord))
            {
                case 1:
                    Console.WriteLine("Goed gedaan.");
                    Score++;
                    break;
                case 0:
                    Console.WriteLine("Dat is helaas fout. Het goede antwoord is " + Antwoorden[JuisteAntwoord]);
                    break;
                case 99:
                    Console.WriteLine("Dit is geen geldige invoer");
                    break;
            }


        }

        static void showVraag(int Nr)
        {
            Console.WriteLine("Vraag " + Nr + ":");
            Console.WriteLine(Vraag);
            Console.WriteLine("");
        }

        static void showAntwoorden()
        {
            int teller = 0;
            foreach (string antwoord in Antwoorden)
            {
                teller++;
                Console.WriteLine((teller) + ", " + antwoord);
            }
            Console.WriteLine("");
            Console.WriteLine("Type uw keuze: 1, 2, 3 of 4");
        }

        static int checkAntwoord(int Antw)
        {
            if (Antw == JuisteAntwoord + 1)
            {
                return 1;
            }
            else if (Antw > 4)
            {
                return 99;
            }
            else
            {
                return 0;
            }
        }

        }

}
