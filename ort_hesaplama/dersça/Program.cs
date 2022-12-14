using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dersça
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\n \t\tSınav not ortalaması ve geçme kalma durumu belirleme programı\n\n");
            Console.Write("Lütfen vize notunuzu giriniz:");
            int vize=Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen vize ağırlığını giriniz notunuzu giriniz:");
            int vizea = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen ödev notunuzu giriniz:");
            int ödev = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen ödev ağırlığını giriniz notunuzu giriniz:");
            int ödeva = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen final notunuzu giriniz:");
            int final = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen final ağırlığını giriniz notunuzu giriniz:");
            int finala = Convert.ToInt32(Console.ReadLine());
            double ort = (vize * vizea + ödev * ödeva + final * finala) / 100.0;
            string harf = "FF";
            if (ort < 45 || final < 50)
                harf = "FF";
            else if (ort < 49)
                harf = "DD";
            else if (ort < 54)
                harf = "DC";
            else if (ort < 57)
                harf = "CC";
            else if (ort < 61)
                harf = "CB";
            else if (ort < 69)
                harf = "BB";
            else if (ort < 76)
                harf = "BA";
            else if (ort < 84)
                harf = "AB";
            else
                harf = "AA";
            Console.WriteLine(harf);
           

            Console.ReadKey();
        }
    }
}
