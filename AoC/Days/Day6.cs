namespace AoC.Days
{
    public static class Day6
    {
        public static int PartOne(string input)
        {
            return GetIndex(input, 4);
        }

        public static int PartTwo(string input)
        {
            return GetIndex(input, 14);
        }

        private static int GetIndex(string input, int packetStart)
        {
            for (int i = 0; i < input.Length; i++)
            {
                var range = new Range(i, i + packetStart);
                var chars = input.Take(range);

                if (chars.Distinct().Count() == chars.Count())
                {
                    return i + packetStart;
                }
            }

            throw new Exception();
        }
    }
}
