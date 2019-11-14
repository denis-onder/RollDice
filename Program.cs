using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollDice
{
  class Program
  {
    static void Roll(int len, int numberToCheck)
    {
      var rnd = new Random();
      int[] rolls = new int[len];
      for (int i = 0; i < rolls.Length; i++)
      {
        rolls[i] = rnd.Next(1, 7);
        Console.WriteLine($"Roll {i + 1} => {rolls[i]}");
      }
      CheckOccurences(numberToCheck, rolls);
    }
    static void CheckOccurences(int numberToCheck, int[] arr)
    {
      int counter = 0;
      Console.WriteLine($"Checking how many times {numberToCheck} occurs in the array...");
      foreach (int item in arr) if (item == numberToCheck) counter++;
      Console.WriteLine($"Number of occurences: {counter}");
    }
    static void Main(string[] args)
    {
      Console.Write("Enter how many times do you want to roll the dice: ");
      int n = int.Parse(Console.ReadLine());
      Console.Write("Enter the number for checking how many times it occurs in the array: ");
      int n1 = int.Parse(Console.ReadLine());
      Roll(n, n1);
      Console.WriteLine("Press ENTER to exit.");
      Console.ReadLine();
    }
  }
}
