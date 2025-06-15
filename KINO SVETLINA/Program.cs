using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace KINO_SVETLINA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client[] Klient = new Client[3];
            Klient[0] = new Client { FullName = "Hookin", SeatNumber = 55, TicketCount = 2 };
            Klient[1] = new Client { FullName = "Adashaa", SeatNumber = 45, TicketCount = 3 };
            Klient[2] = new Client { FullName = "Osetenovo", SeatNumber = 60, TicketCount = 1 };

            Projection[] Projekcii = new Projection[3];
            Projekcii[0] = new Projection { film = "Matricata", mqsto = "VIP", chas = 16.35 };
            Projekcii[1] = new Projection { film = "Avatar", mqsto = "Obiknovenno", chas = 20.00 };
            Projekcii[2] = new Projection { film = "50 nuansa sivo", mqsto = "VIP", chas = 19.15 };

            Ticket[] bileti = new Ticket[3];
            bileti[0] = new Ticket { cena = 15.00, plashtane = "Karta" };
            bileti[1] = new Ticket { cena = 10.00, plashtane = "V broi" };
            bileti[2] = new Ticket { cena = 20.00, plashtane = "Karta" };


            for (int i = 0; i < Klient.Length; i++)
            {
                double totalPrice = Klient[i].TicketCount * bileti[i].cena;

                Console.WriteLine($"Klient: {Klient[i].FullName}, Mqsto: {Klient[i].SeatNumber}, broi bileti: {Klient[i].TicketCount}");
                Console.WriteLine($"Film: {Projekcii[i].film}, Tip mqsto: {Projekcii[i].mqsto}, chas: {Projekcii[i].chas}");
                Console.WriteLine($"cena: {bileti[i].cena}, plashtane: {bileti[i].plashtane}, obshta suma: {totalPrice:F2}");

                if (Projekcii[i].mqsto == "VIP")
                {
                    Console.WriteLine($"[VIP] Ime: {Klient[i].FullName}, Broi bileti: {Klient[i].TicketCount}, Mqsto: {Klient[i].SeatNumber}");
                }
                else if (Projekcii[i].mqsto == "obiknoveno")
                {
                    Console.WriteLine($"obiknoveno] Film: {Projekcii[i].film},Nachalen chas: {Projekcii[i].chas}");
                }

                Console.WriteLine("-----------------------------------");
            }

            Console.WriteLine("=== Mesta s nomer nad 50 ===");
            double sumOver50 = 0;
            for (int i = 0; i < Klient.Length; i++)
            {
                if (Klient[i].SeatNumber > 50)
                {
                    double total = Klient[i].TicketCount * bileti[i].cena;
                    Console.WriteLine($"Mqsto: {Klient[i].SeatNumber}, Suma: {total:F2}");
                    sumOver50 += total;
                }
            }
            Console.WriteLine($"obshta suma na mestata: {sumOver50:F2}");

            Console.WriteLine("=== Sortirane na cena po poruchka ===");


            int[] indices = { 0, 1, 2 };


            for (int i = 0; i < indices.Length - 1; i++)
            {
                for (int j = i + 1; j < indices.Length; j++)
                {
                    double totalI = Klient[indices[i]].TicketCount * bileti[indices[i]].cena;
                    double totalJ = Klient[indices[j]].TicketCount * bileti[indices[j]].cena;

                    if (totalI > totalJ)
                    {
                        int temp = indices[i];
                        indices[i] = indices[j];
                        indices[j] = temp;
                    }
                }
            }

            for (int k = 0; k < indices.Length; k++)
            {
                int i = indices[k];
                double total = Klient[i].TicketCount * bileti[i].cena;
                Console.WriteLine($"{Klient[i].FullName} - {total:F2} lv");
            }
        }
    }

    internal class Ticket
    {
        public double cena { get; set; }
        public string plashtane { get; set; }
    }

    internal class Projection
    {
        public string film { get; set; }
        public string mqsto { get; set; }
        public double chas { get; set; }
    }

    internal class Client
    {
        public string FullName { get; internal set; }
        public int TicketCount { get; internal set; }
        public int SeatNumber { get; internal set; }
    }
}
