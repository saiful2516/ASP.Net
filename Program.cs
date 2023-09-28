using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        int sum = 0;
        for ( int i =0; i<=10; i++)
        {
            sum = sum + i;
            if (i%2==0)
            {
                Console.WriteLine(i);
            }

        }
        Console.WriteLine(sum);


        //While loop: at least one time run then check the condition.
        int j = 0;
        while(true)
         {
            if(j>4)
            {
                break;
            }
            Console.WriteLine("Hello");
            j++;

         }
        //while loop with continue statement
        int k = 0;
        
        while (k < 20)
        {
            k++;
            if (k % 5 == 0)
            {
                continue;
            }
            Console.WriteLine(k);
        }
        //do while loop
        int n = 0;
        do
        {
            if (n % 2 == 0)
            {
                Console.WriteLine(n);
            }
            n++;

        } while (n < 21);

        Console.ReadKey();
        
    }
}