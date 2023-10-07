using System.Text;
using System;
using System.Collections.Generic;
using System.IO;


internal class Program
{



    static readonly string textFile = @"F:/HIS/Programming/C#/File.text";

    private static void Main(string[] args)
    {
        string path = @"F:/HIS/Programming/C#/File.text";

        // Delete the file if it exists.  
        if (File.Exists(path))
        {
            File.Delete(path);
        }

        //Create the file.  
        using (FileStream fs = File.Create(path))
        {
            AddText(fs, "This is some text");
            AddText(fs, "This is some more text,");
            AddText(fs, "\r\nand this is on a new line");
            AddText(fs, "\r\n\r\nThe following is a subset of characters:\r\n");

            for (int i = 1; i < 150; i++)
            {
                AddText(fs, Convert.ToChar(i).ToString());

            }
        }

        //Open the stream and read it back.  
        using (FileStream fs = File.OpenRead(path))
        {
            byte[] b = new byte[1024];
            UTF8Encoding temp = new UTF8Encoding(true);
            while (fs.Read(b, 0, b.Length) > 0)
            {
                Console.WriteLine(temp.GetString(b));
            }
        }
        Console.ReadKey();
    }
    private static void AddText(FileStream fs, string value)
    {
        byte[] info = new UTF8Encoding(true).GetBytes(value);
        fs.Write(info, 0, info.Length);
    }
}