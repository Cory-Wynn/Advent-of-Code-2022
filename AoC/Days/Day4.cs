namespace AoC.Days
{
    internal class Day4
    {
        private static readonly IEnumerable<string> Pairs = File.ReadLines("C:\\Users\\cory.wynn\\source\\repos\\AoC\\AoC\\Input\\Day4-input.txt");

        public static int PartOne()
        {
            var totalOverlaps = 0;

            foreach (var pair in Pairs)
            {
                var (elf1ShiftStart, elf1ShiftEnd) = Elf1Shift(pair);
                var (elf2ShiftStart, elf2ShiftEnd) = Elf2Shift(pair);

                if ((elf1ShiftStart <= elf2ShiftStart && elf1ShiftEnd >= elf2ShiftEnd)
                || (elf2ShiftStart <= elf1ShiftStart && elf2ShiftEnd >= elf1ShiftEnd))
                {
                    totalOverlaps ++;
                }
            }

            return totalOverlaps;
        }

        public static int PartTwo()
        {
            var totalOverlaps = 0;

            foreach (var pair in Pairs)
            {
                var (elf1ShiftStart, elf1ShiftEnd) = Elf1Shift(pair);
                var (elf2ShiftStart, elf2ShiftEnd) = Elf2Shift(pair);

                if (!(elf2ShiftEnd < elf1ShiftStart || elf2ShiftStart > elf1ShiftEnd))
                {
                    totalOverlaps++;
                }
            }

            return totalOverlaps;
        }

        private static (int elf2ShiftStart, int elf2ShiftEnd) Elf2Shift(string pair)
        {
            var elf2ShiftStart = int.Parse(pair.Split(",")[1].Split("-")[0]);
            var elf2ShiftEnd = int.Parse(pair.Split(",")[1].Split("-")[1]);
            return (elf2ShiftStart, elf2ShiftEnd);
        }

        private static (int elf1ShiftStart, int elf1ShiftEnd) Elf1Shift(string pair)
        {
            var elf1ShiftStart = int.Parse(pair.Split(",")[0].Split("-")[0]);
            var elf1ShiftEnd = int.Parse(pair.Split(",")[0].Split("-")[1]);
            return (elf1ShiftStart, elf1ShiftEnd);
        }
    }
}
