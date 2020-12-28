using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    class Musteri
    {
       /*public Musteri()
        {
            ID = "13116";
        }*/
        public static string ID;
        public  string ad;
        public string soyad;
        private string TC;

       
        
        public string _tc
        {
            get
            {

                return this.TC;
            }

            set
            {
                this.TC = value;

            }
         
        }

        public static void Hesapla()
        {
            Console.WriteLine(Carp(1, 2)); 
        }

        public static int Hesapla2(int d,int f)
        {

            return d + f;

        }
   
        public static int Carp(int x,int y)
        {

            return  Hesapla2(5,6)* 2;
            
        }
    
       
    }
}
