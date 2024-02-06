namespace Business;
using Entities;

//bir class'i olusturdugun zaman onun interface'ini olusturdugundan emin ol. 
//aslinda once interface olusturma ile baslanir.
//interface'ler newlenemezler, referans tutuculardir.
//microservice implemantasyonunu, bagimliligi, interface ile yapariz.
public interface IApplicantService
{
    //burda sadece metodlarin imzalari olusturulur.

    //default olarak public'dir
    void ApplyForMask(Person person);

    List<Person> GetList();

    //TC vatandasi mi kontrol edilir.
    bool CheckPerson(Person person);

}
