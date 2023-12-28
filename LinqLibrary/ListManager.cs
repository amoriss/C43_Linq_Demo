using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary;
public class ListManager
{
    public static List<Person> LoadSimpleData()
    {
        List<Person> output = new List<Person>();

        output.Add(new Person { FirstName = "Michael", LastName = "Scott", YearsOfExperience = 10 });
        output.Add(new Person { FirstName = "Jim", LastName = "Halpert", YearsOfExperience = 5 });
        output.Add(new Person { FirstName = "Pam", LastName = "Beesly", YearsOfExperience = 3 });
        output.Add(new Person { FirstName = "Dwight", LastName = "Schrute", YearsOfExperience = 7 });
        output.Add(new Person { FirstName = "Angela", LastName = "Martin", YearsOfExperience = 4 });
        output.Add(new Person { FirstName = "Stanley", LastName = "Hudson", YearsOfExperience = 4 });
        output.Add(new Person { FirstName = "Kevin", LastName = "Malone", YearsOfExperience = 6 });

        return output;
    }
}
