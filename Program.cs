// See https://aka.ms/new-console-template for more information

using System;

namespace Workaround // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            //bir tane vatandas olusturdum demek -- instance
            Vatandas vatandas1 = new Vatandas();

            
            Console.ReadLine();

        }

        private static void Degiskenler()
        {
            string mesaj = "hello";
            double tutar = 100000;
            int sayi = 100;
            bool girisYapilmisMi = false;


            //birsuru degisken tanimlamak yerine mantiksal gruplara ayiriyorum,bunlari bir kutuya koyalim, ordan cagiralim --> bunlara nesne, class denir
            //yazilimda surdurebilirlik seviyesi !!
            string ad = "Elif";
            string soyad = "Ozun";
            int dogumYili = 2003 ;
            long tcNo = 12345678910;

            Console.WriteLine(mesaj);
            Console.WriteLine(tutar * 1.18);

        }
    }

    public class Vatandas
    {
        //get ve set -- prop 
        //public oldugu icin degiskenlerin ilk harfinin buyuk olmasına onem goster --> pascal casing 

        public string Ad { get; set; }        
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }

    };
}
