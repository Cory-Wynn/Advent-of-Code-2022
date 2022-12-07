using AoC.Days;

namespace AoC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Day1.PartOne());
            Console.WriteLine(Day1.PartTwo());

            Console.WriteLine(Day2.PartOne());
            Console.WriteLine(Day2.PartTwo());

            Console.WriteLine(Day3.PartOne());
            Console.WriteLine(Day3.PartTwo());

            Console.WriteLine(Day4.PartOne());
            Console.WriteLine(Day4.PartTwo());

            Console.WriteLine(Day5.PartOne());
            Console.WriteLine(Day5.PartTwo());

            var Day6Input = File.ReadAllText("C:\\Users\\cory.wynn\\source\\repos\\AoC\\AoC\\Input\\Day6-input.txt");

            Console.WriteLine(Day6.PartOne(Day6Input));
            Console.WriteLine(Day6.PartTwo(Day6Input));
        }
    }
}