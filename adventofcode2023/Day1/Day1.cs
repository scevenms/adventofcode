using System;
using System.IO;
using System.Linq;

class Day1
{
    static void Main()
    {
        string[] PuzzleRaw = File.ReadAllLines(@".\Puzzle.txt");
        int PuzzleAnswer = 0;

        foreach (string line in PuzzleRaw)
        {
            Console.WriteLine($"Processing {line}");
            string numbers = new string(line.Where(char.IsDigit).ToArray());
            if (!string.IsNullOrEmpty(numbers))
            {
                int firstNumber = numbers[0];
                int lastNumber = numbers[numbers.Length - 1];
                Console.WriteLine($"Answer for this line is {firstNumber}{lastNumber}");
                PuzzleAnswer += int.Parse($"{firstNumber}{lastNumber}");
                Console.WriteLine(PuzzleAnswer);
            }
        }

        Console.WriteLine(PuzzleAnswer);
        File.WriteAllText(@".\Answer.txt", PuzzleAnswer.ToString());
    }
}
