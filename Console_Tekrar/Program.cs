using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Tekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen Adınızı giriniz");
            string ad = Console.ReadLine();
            Console.WriteLine("Lütfen Soyadınızı giriniz");
            string soyad = Console.ReadLine();
            Console.WriteLine("Lütfen Yaşınızı giriniz");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hoşgeldiniz adınız{ad}, soyadınız {soyad}, yaşınız {yas}.");


        }
    }
}
