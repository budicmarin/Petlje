using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicMarinPetljeDomacaZadaca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisi ocjenu");
            int ocjena = Convert.ToInt16(Console.ReadLine());
            int sum = 0;
            float prosjek=0F;
            float counter = 0F;
            if (ocjena < 1 || ocjena > 5)
            {
                Console.WriteLine("Unio si ocjenu koja nije u intervalu od 1-5");
                Console.WriteLine("Upisi ocjenu");
                ocjena = Convert.ToInt16(Console.ReadLine());

            }
            while (ocjena!=0)
            {
                if (ocjena == 1)
                {
                    prosjek = 1f;
                    ocjena = 0;
                }
                else
                {
                    sum = sum + ocjena;
                    counter += 1;
                    Console.WriteLine("Upisi ocjenu");
                    ocjena = Convert.ToInt16(Console.ReadLine());
                    if (ocjena<1 && ocjena >5 )
                    {
                        Console.WriteLine("Unio si ocjenu koja nije u intervalu od 1-5");
                        Console.WriteLine("Upisi ocjenu");
                        ocjena = Convert.ToInt16(Console.ReadLine());

                    }
                }
                
            
            }
            
            if (prosjek != 1)
            {
                prosjek = sum / counter;
                Console.WriteLine("Prosijek ocjena je " + sum / counter);
            }
            else
            {
                Console.WriteLine("Prosjek ocjena je "+ prosjek);
            }
            Console.ReadKey();
        }
    }
}
