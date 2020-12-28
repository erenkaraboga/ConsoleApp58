using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri.ID = "123546546";
            Musteri Eren = new Musteri();
            Eren.ad = "Eren";
            Eren.soyad = "Karaboğa";
            Eren._tc = "1656813116";
            Musteri Ceren = new Musteri();
            Musteri.Hesapla();
            


            Console.WriteLine(Musteri.Carp(6, 7));
           
           
            Console.ReadLine();
            
        
        }

    }

}   
