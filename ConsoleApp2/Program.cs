using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var cadena = "Hello";
            for (int i = 0; i < 100000; i++) {
                cadena = cadena + i.ToString();                 
            }
            Console.WriteLine(cadena);
            Console.Read();*/
            var sb = new StringBuilder();
            sb.Append("Hello");
            for (int i = 0; i < 100000; i++)
            {
                sb.Append(i);
            }

            var a = String.Empty;//vaciar un string
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
