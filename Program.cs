// See https://aka.ms/new-console-template for more information

using System;
using Business;
using Entities;

namespace Workaround // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            //bir tane vatandas olusturdum demek -- instance
            Vatandas vatandas1 = new Vatandas();

            SelamVer(isim: "elif");

            //Arrays
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "elif";
            SelamVer(ogrenciler[0]);

            for(int i = 0 ; i < ogrenciler.Length ; i++)
            {
                SelamVer(ogrenciler[i]);
            }

            List<string> yeniSehirler= new List<string>{"Ankara", "İstanbul" , "İzmir"}; 
            yeniSehirler.Add("Kayseri");

            string[] sehirler=new[] {"Ankara", "İstanbul" , "İzmir"}; 

            foreach (string sehir in yeniSehirler)
            {
                Console.WriteLine(sehir);
            }

            Person person1 = new Person();
            person1.FirstName = "Elif";

            PttManager pttManager = new PttManager(new PersonManager()); //usingleri vermeyi unutma
            pttManager.GiveMask(person1);

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

        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Selam " + isim);
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


    //SOAP mimarisinde yazilmis servisi projeme dahil etmek istiyorum, nasil edecegim? --> servis: tckimlik.nvi.gov.tr
}
