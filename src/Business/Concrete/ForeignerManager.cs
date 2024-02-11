namespace Business;
using Entities;

public class ForeignerManager:IApplicantService
{
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
