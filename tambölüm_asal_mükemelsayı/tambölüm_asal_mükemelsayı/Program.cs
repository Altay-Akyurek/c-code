using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tambölüm_asal_mükemelsayı
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("bir sayı giriniz: \n\n");
            int n=Convert.ToInt32(Console.ReadLine());
            
            int adet = 0;
            int toplam = 0;
            Console.WriteLine("tam bölenleri");
            for (int i=1;i<=n;i++)
            {
                
                if (n % i == 0)
                {
                    adet++;
                    toplam += i;
                    
                    Console.WriteLine(i);

                }
            }
            if (adet == 2)
            {

                Console.WriteLine("\t\t{0} asal sayıdır", n);
            }
            else
            {
                Console.WriteLine("\t\t{0} asal sayı değildir:",n);
            }
            if (toplam==n*2)
            {
                Console.WriteLine("\t\t{0} mükemmel sayıdır:", n);

            }
            else
            {
                Console.WriteLine("\t\t{0} mükemmel sayı değildir:", n);
            }
            Console.ReadKey();
            
        }
    }
}
