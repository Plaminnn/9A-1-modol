using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JIVotni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stoka[] stoki = new Stoka[10];
            int broiStoki = 0;

            Console.WriteLine("Kolko stoki shte vuvedesh?");
            int broi = int.Parse(Console.ReadLine());

            for (int i = 0; i < broi; i++)
            {
                Console.WriteLine("Ime na hranata:");
                string ime = Console.ReadLine();

                Console.WriteLine("Vid jivotno:");
                string vid = Console.ReadLine();

                stoki[broiStoki] = new Stoka(ime, vid);
                broiStoki++;
            }

            Console.WriteLine("Vuvedenite stoki sa:");
            for (int i = 0; i < broiStoki; i++)
            {
                Console.WriteLine($"{i + 1}: {stoki[i].Ime}, {stoki[i].vid}");
            }

            // Sortirane
            for (int i = 0; i < broiStoki - 1; i++)
            {
                for (int j = i + 1; j < broiStoki; j++)
                {
                    if (string.Compare(stoki[i].Ime, stoki[j].Ime) > 0)
                    {
                        Stoka temp = stoki[i];
                        stoki[i] = stoki[j];
                        stoki[j] = temp;
                    }
                }
            }

            Console.WriteLine("=================");
            for (int i = 0; i < broiStoki; i++)
            {
                Console.WriteLine($"{i + 1}: {stoki[i].Ime}, {stoki[i].vid}");
            }
        }
    }
}
    

