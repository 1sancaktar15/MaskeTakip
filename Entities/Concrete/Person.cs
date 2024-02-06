namespace Entities;

//bir sınıfın default erisim bildirgeci internal'dir.
//bu sinif ozellikleri tutuyor (single responsibility icin)

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int DateOfBirthYear { get; set; }
    public long NationalIdentity { get; set; }
}
