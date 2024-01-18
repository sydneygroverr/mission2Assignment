using mission2;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    private static void Main(string[] arks)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        string timesRolled = Console.ReadLine();

        // convert the string to an int
        int numRolls = int.Parse(timesRolled);

        // create new Dice instance
        Dice dice = new Dice();

        // simulate rolls annd get results
        int[] results = dice.Roll(numRolls);

      
        Console.WriteLine("Results:");

        int totalRolls = numRolls;
        Console.WriteLine("Total rolls = " +  totalRolls);

        for (int i = 0; i < results.Length; i++)
        {
            int percentage = results[i] * 100 / totalRolls;
            string asterisks = new string('*', percentage);
            Console.WriteLine($"{i + 2}: {asterisks}");
        }

        Console.WriteLine("\nThank you for playing!");
    }



}