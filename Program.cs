using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;



internal class Program
{
    private static void Main(string[] args)
    {   //Dictionary type fixed
        Dictionary<int, string> aDictionary = new Dictionary<int, string>();
        aDictionary.Add(1, "phoenix");
        aDictionary.Add(2, "Honda");
        aDictionary.Add(3, "Hero");
        string outPut;
        if(aDictionary.TryGetValue(5, out outPut))  // Bolean type output
        {
            Console.WriteLine("find data:" + outPut);
        }
        else
        {
            Console.WriteLine("Not found");
        }
        foreach(var data in aDictionary)
        {
            Console.WriteLine("Id:" + data.Key +" value:" +data.Value);
        }
        //Hashtable dynamic type
        Hashtable aHashtable = new Hashtable();
        aHashtable.Add(1, "FSV");
        aHashtable.Add(2, "Two");
        aHashtable.Add(3, 4);
        aHashtable.Add(4, 35.5);
        aHashtable.Add(5, 30.5);
        aHashtable.Add(6, 10);
        aHashtable["1"] = "Fisrt entry";
        foreach(var data in aHashtable.Values)
        {
            Console.WriteLine(data);
        }
        foreach (var data in aHashtable.Keys)
        {
            Console.WriteLine(data);
        }
        if (aHashtable.Contains("1"))
        {
            Console.WriteLine("Data found");
        }
        Console.ReadKey();
        
       
    }
}