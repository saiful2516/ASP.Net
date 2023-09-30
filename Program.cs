internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = new int[5];
       // numbers[0] = 10;
        //numbers[1] = 20;
       // numbers[2] = 30;
       // numbers[3] = 40;

        for(int i = 0; i < numbers.Count(); i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        int sum = numbers.Sum();
        Console.WriteLine(sum);

        for(int i = 0; i<numbers.Count(); i++)
        {
            Console.WriteLine("Output" +numbers[i]);
            // numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        foreach(var data in numbers)
        {
            Console.WriteLine(data);
        }

        Console.ReadKey();
    }
}