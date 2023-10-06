internal class Program
{
    private static void Main(string[] args)
    {
        try// actual code which may be with error or without error.
        {
            Console.Write("Enter a number: ");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Squre of {number} is {number*number}");
        }
        catch // Provide a messege if any error occured
        {
            Console.WriteLine("Error Occured.");
        }
        finally // final direction for the user about the next step.
        {
            Console.WriteLine("Retry with different number.");
        }
        try
        {
            Console.Write("Enter a number: ");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Squre of {number} is {number * number}");
        }
        catch(Exception ex)
        {
            Console.Write("Error Info:" + ex.Message);
        }
        finally
        {
            Console.WriteLine("Re-try with a different number.");
        }
        try
        {
            int num = int.Parse(Console.ReadLine());

            int result = 100 / num;

            Console.WriteLine("100 / {0} = {1}", num, result);
        }
        catch (DivideByZeroException ex)
        {
            Console.Write("Cannot divide by zero. Please try again.");
        }
        catch (InvalidOperationException ex)
        {
            Console.Write("Invalid operation. Please try again.");
        }
        catch (FormatException ex)
        {
            Console.Write("Not a valid format. Please try again.");
        }
        catch (Exception ex)
        {
            Console.Write("Error occurred! Please try again.");
        }
        Console.ReadKey();
    }
    
}