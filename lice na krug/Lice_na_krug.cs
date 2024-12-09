using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lice_na_krug
{
    internal class Lice_na_krug
    {
        static void Main(string[] args)
        {

            int r;
            Console.Write("r = ");
            r = int.Parse(Console.ReadLine());
            double area = int.Parse(Console.ReadLine());
            area = Math.PI * r * r;
            Console.WriteLine("area =" + area);
            double perimetur = int.Parse(Console.ReadLine());
            perimetur = 2 * Math.PI * r;
            Console.WriteLine("perimetur =" + perimetur);


        }
    }
}
