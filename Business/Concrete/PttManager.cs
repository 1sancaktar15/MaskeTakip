namespace Business;
using Entities;
using System;

// bir sinif baska bir sinifi kullanırken (entity sinifinda gecerli degil) new'liyorsa ileride bu yazilimda degisiklik talebi geldiginde uygulama direnc gosterir.
public class PttManager
{
    public void GiveMask(Person person)
    {
        //iste burda bagimlilik olustu. 
        PersonManager personManager = new PersonManager();

        if(personManager.CheckPerson(person)) //personManager.Checkperson(person) == true
        {
            Console.WriteLine(person.FirstName + " icin maske verildi.");
        } 
    }

}
