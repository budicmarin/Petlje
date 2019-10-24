using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicMarinVježbaPetlje
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Upisi text: ");
            string unosTeksta = Console.ReadLine();
            
            for (int i = unosTeksta.Length; i > 0; i--)
            {
                Console.WriteLine(unosTeksta.Substring(0,i));
            }




            Console.ReadKey();
        }
    }
}
