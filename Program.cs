using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    public class Program
    {
        static void Main(string[] args)
        {
            calisan c1 = new calisan();
            c1.calisanID = 125;
            c1.isim = "Ayşe";
            c1.soyisim = "Söğüt";
            calisan.maas = 56.000;

            Console.WriteLine("çalışan ıd:" + c1.calisanID);
            Console.WriteLine("isim:" + c1.isim);
            Console.WriteLine("soyisim:" + c1.soyisim);
            Console.WriteLine("maaş:" + calisan.maas);

            Console.ReadLine(); 
    }
    }
}
