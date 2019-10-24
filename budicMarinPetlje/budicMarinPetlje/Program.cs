using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicMarinPetlje
{
    class Program
    {
        static void Main(string[] args)
        {
            string unosTeksta;
            Console.WriteLine("Unesi jednu riječ");
            unosTeksta = Console.ReadLine();
            Console.WriteLine(unosTeksta);
            for (int i=0;i<unosTeksta.Length;i++)
            {
                Console.WriteLine(unosTeksta.Substring(0,i+1));
            }
            
            Console.ReadKey();
        }
    }
}
