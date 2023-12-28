namespace LinqLibrary;
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int YearsOfExperience { get; set; }


    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }
}
