internal class Program
{
    private static void Main(string[] args)
    {

        //user input
        //Explicit Conversion
        Console.WriteLine("Enter your first Number:");
       
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your Second Number:");
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        //string messege = Console.ReadLine(); comment shor key: ctrl+k+c

        int result = firstNumber + secondNumber;

        Console.WriteLine("Output is:" +result);
        char c = 'A';
        int acii = c; // find the ascii value
        Console.WriteLine(acii);

        Console.ReadKey();
    }
}