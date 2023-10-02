using System.Collections;

internal class Program
{
    

    private static void Main(string[] args)
    {
        //Array list type and size dynamic
        ArrayList array = new ArrayList();
        array.Add("Saiful Islam");
        array.Add("Age" + 30);
        array.Add("phone"+ 01714456);
        array.Add(3.012);
        array.Add(200);
        //array.Remove(3.012);
        //array.Reverse();

        foreach (var value in array)
        {
            Console.WriteLine(value);
        }
        array.RemoveAt(4); // remove by index number

       // array.RemoveRange(20, 25); // remove by range

        foreach(var value in array)
        {
            Console.WriteLine(value);
        }


        //List : Type fixed but size dynamic

        List<string> names = new List<string>();
        names.Add("student");
        names.Add("Employee");
        names.Add("Business");
        names.Add("Politician");

        foreach( var value in names)
        {
            Console.WriteLine(value);
        }
        names.Remove("Politician");
        foreach (var value in names)
        {  
            if (value  == "Politician")
            {
                Console.WriteLine("Data found");
            }
            else
            {
                Console.WriteLine("Data not Found");
            }
            Console.WriteLine(value);
        }

        

        Console.ReadKey();
    }
}