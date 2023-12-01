using System;
using System.Globalization;
using System.IO;
using System.Linq;

class Day1
{
    static void Main()
    {
        string numbers;
         PuzzleRaw = File.ReadAllLines(@".\Puzzle.txt");
        int PuzzleAnswer = 0;

        foreach (string line in PuzzleRaw)
        {
            Console.WriteLine($"Processing {line}");
            numbers = new string(line.Where(char.IsDigit).ToArray());
            char firstNumber = numbers[0];
            char lastNumber = numbers; // ^ operator is used to get the last element
            Console.WriteLine($"Answer for this line is {firstNumber}{lastNumber}");
            PuzzleAnswer += int.Parse($"{firstNumber}{lastNumber}");
            Console.WriteLine(PuzzleAnswer);
        }

        Console.WriteLine(PuzzleAnswer);
        File.WriteAllText(@".\Answer.txt", PuzzleAnswer.ToString());
    }
}