
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using System.Linq;



internal class Program
{
    private static void Main(string[] args)
    {
       var aPerson = Tuple.Create(1, "Dept:Computer Sciences", "Type: Employee");
        Console.WriteLine(aPerson.Item1);
        Console.WriteLine(aPerson.Item2);
        Console.WriteLine(aPerson.Item3);

        var numbers = Tuple.Create(1, 2, Tuple.Create(3, 4, 5, 6, 7, 8), 9, 10, 11, 12, 13);
        Console.WriteLine(numbers.Item1); // returns 1
        Console.WriteLine(numbers.Item2); // returns 2
        Console.WriteLine(numbers.Item3); // returns (3, 4, 5, 6, 7,  8)
        Console.WriteLine(numbers.Item3.Item1); // returns 3
        Console.WriteLine(numbers.Item4); // returns 9
        Console.WriteLine(numbers.Rest.Item1); //returns 13

        var person = Tuple.Create(1, "Steve", "Jobs");
        DisplayTuple(person);
        Console.ReadKey();
    }
    static void DisplayTuple(Tuple<int,string,string> person)
    {
        Console.WriteLine($"Id = {person.Item1}");
        Console.WriteLine($"First Name = {person.Item2}");
        Console.WriteLine($"Last Name = {person.Item3}");
    }
}