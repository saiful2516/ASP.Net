internal class Program
{
    private static void Main(string[] args)
    {
        int a = 15;
        long l = 500;
        a = Convert.ToInt32(l);
        bool b = true;
        a = Convert.ToInt32(b);
        char c = 'f';
        a = c;
        Console.WriteLine(b);

        int result =  Add(50, 90);
        Console.WriteLine(result);
       



        Console.ReadKey();
    }

    //Method name start with verb and pascal case
    //method name change best way is using refactor/name, fist right clich on calling method Add
    static int Add(int firstNumber, int secondNumber)
    {
        int sum = firstNumber + secondNumber;
        return sum;
    }

}