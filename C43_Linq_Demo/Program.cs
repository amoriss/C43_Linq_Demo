using LinqLibrary;
using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace C43_Linq_Demo;

internal class Program
{
    static void Main(string[] args)
    {
        var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        List<Person> people = ListManager.LoadSimpleData(); //method that populates list

        //sort by last name
        //people.OrderBy(x => x.LastName).ToList().ForEach(x => Console.WriteLine(x.FullName));


        //filter where first names have a length of greater than 3
        var greaterThan3 = people.Where(x => x.FirstName.Length > 3);
        //foreach (var item in greaterThan3)
        //{
        //    Console.WriteLine(item.FullName);
        //}


        //filter where employees have years of experience greater than 6

        var greaterThan6 = people.Where(x => x.YearsOfExperience > 6);
        //foreach (var item in greaterThan6)
        //{
        //    Console.WriteLine($"Full Name: {item.FullName}  YOE: {item.YearsOfExperience}");
        //}

        //Find all people whose first name starts with M
        var startsWithM = people.Where(x => x.FirstName.StartsWith("M"));
        //foreach (var item in startsWithM)
        //{
        //    Console.WriteLine(item.FullName);
        //}

        Console.WriteLine(list.Average()); 



    }
}
