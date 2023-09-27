internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter English Score: ");
        string englishScoreWithString = Console.ReadLine();
        int englishScore = Convert.ToInt32(englishScoreWithString);
        string result = String.Empty;

        if(englishScore>100||englishScore<0)
        {
            result = "Score should be 0 to 100";
        }
        else if(englishScore >= 50)
        {
            result = "Congtratulations, You have passed"; 
        }
        else
        {
            result = "Sorry, You have failed";
        }
        Console.WriteLine(result);
        Console.ReadKey();
    }
}