namespace Business;
using Entities;
using System;

//bu sinif operasyonlari tutuyor (single responsibility icin)
//Ciplak class kalmasin! --> kural: inheritance veya implemantasyon zaafiyeti.

//IApplicantService: Bu, PersonManager sınıfının uyguladığı arayüzün adıdır. Arayüzler, bir sınıfın uyması gereken bir dizi yöntemi tanımlar.
public class PersonManager : IApplicantService 
{
    //encapsulation
    //Metod == Fonksiyon --> siklikla kullanacagimiz operasyonlar icin
    public void ApplyForMask(Person person)
    {

    }

    public List<Person> GetList()
    {
        return null;
    }

    //TC vatandasi mi kontrol edilir.
    public bool CheckPerson(Person person)
    {
        return true;
    }
}
