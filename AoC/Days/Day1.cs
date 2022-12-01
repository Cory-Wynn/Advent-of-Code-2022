namespace AoC.Days
{
    internal class Day1
    {
        public static int PartOne()
        {
            return CaloriesByElfList().MaxBy(x => x);
        }

        public static int PartTwo()
        {
            return CaloriesByElfList().OrderByDescending(x => x).Take(3).Sum();
        }

        private static IEnumerable<int> CaloriesByElfList()
        {
            var lines = File.ReadLines("C:\\Users\\cory.wynn\\source\\repos\\AoC\\AoC\\Input\\input.txt");

            var tempList = new List<int>();
            var caloriesByElfList = new List<int>();

            foreach (var line in lines)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    tempList.Add(int.Parse(line));
                }
                else
                {
                    caloriesByElfList.Add(tempList.Sum());
                    tempList = new List<int>();
                }
            }

            return caloriesByElfList;
        }
    }
}
