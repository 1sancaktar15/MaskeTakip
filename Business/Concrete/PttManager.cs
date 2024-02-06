namespace Business;
using Entities;
using Business;
using System;

// bir sinif baska bir sinifi kullanırken (entity sinifinda gecerli degil) new'liyorsa ileride bu yazilimda degisiklik talebi geldiginde uygulama direnc gosterir.
public class PttManager
{
    //Bagimliligi kaldirmak icin dependency injection 
    //bagimli olunan sinif yerine o sinifin interface'ini kullanacagim.
    //class basladiginda lazim olacak --> constructor blogu
    //field'lar class'in icinde _ad (altcizgi) ile yazilir.
    private IApplicantService _applicantService;

    public PttManager(IApplicantService applicantService) //Constructor --> newlendiginde calisir.
    {
       _applicantService = applicantService; // --> classlarda field'larin _ baslama sebebi budur, Constructordan set ederiz.
    }
    public void GiveMask(Person person)
    {

        //iste burda bagimlilik olustu. 
        PersonManager personManager = new PersonManager();

        if(_applicantService.CheckPerson(person)) //personManager.Checkperson(person) == true
        {
            Console.WriteLine(person.FirstName + " icin maske verildi.");
        } 
    }

}
