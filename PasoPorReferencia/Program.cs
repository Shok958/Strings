using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasoPorReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            Write(a);
            Console.WriteLine(a);
            Console.ReadLine();
        }

        static void Write(int a) {
            a = 20;
        }
    }
}
