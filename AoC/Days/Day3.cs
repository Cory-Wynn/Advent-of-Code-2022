namespace AoC.Days
{
    internal class Day3
    {
        private static readonly IEnumerable<string> Rucksacks = File.ReadLines("C:\\Users\\cory.wynn\\source\\repos\\AoC\\AoC\\Input\\Day3-input.txt");

        public static int PartOne()
        {
            var total = 0;

            foreach (var rucksack in Rucksacks)
            {
                var compartmentOne = rucksack.Substring(0, rucksack.Length / 2).ToCharArray();
                var compartmentTwo = rucksack.Substring(rucksack.Length / 2, rucksack.Length / 2).ToCharArray();

                var duplicateItem = compartmentOne.First(item => compartmentTwo.Contains(item));
                total += ItemValue(duplicateItem);
            }

            return total;
        }

        public static int PartTwo()
        {
            var total = 0;
            var rucksackGroups = Rucksacks.Chunk(3);

            foreach (var group in rucksackGroups)
            {
                var duplicateItem = group[0].First(item => group[1].Contains(item) && group[2].Contains(item));
                total += ItemValue(duplicateItem);
            }

            return total;
        }


        private static int ItemValue(char item)
        {
            const string items = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (var i = 0; i < items.Length; i++)
            {
                if (item == items[i])
                {
                    return i + 1;
                }
            }

            return 0;
        }
    }
}
