﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lice_na_trapec
{
    internal class Lice_na_trapec
    {
        static void Main(string[] args)
        {

            Console.Write("b1 = ");
            var b1 = double.Parse(Console.ReadLine());
            Console.Write("b2 = ");
            var b2 = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            var h = double.Parse(Console.ReadLine());
            var area = (b1 + b2) * h / 2;
            Console.WriteLine("area = " + area);

         
        }
    }
}
