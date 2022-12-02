namespace AoC.Days
{
    internal class Day2
    {
        private static readonly IEnumerable<string> Lines = File.ReadLines("C:\\Users\\cory.wynn\\source\\repos\\AoC\\AoC\\Input\\Day2-input.txt");

        private static readonly Dictionary<string, int> ShapeValue = new()
        {
            { "X", 1 },
            { "Y", 2 },
            { "Z", 3 }
        };

        public static int PartOne()
        {
            var totalScore = 0;

            foreach (var line in Lines)
            {
                var player1 = line.Substring(0, 1);
                var player2 = line.Substring(2, 1);

                totalScore += RoundScore(player1, player2);
            }

            return totalScore;
        }

        public static int PartTwo()
        {
            var totalScore = 0;

            foreach (var line in Lines)
            {
                var player1 = line.Substring(0, 1);
                var player2 = ShapeToChoose(player1, line.Substring(2, 1));

                totalScore += RoundScore(player1, player2);
            }

            return totalScore;
        }

        private static int RoundScore(string player1, string player2)
        {
            var roundScore = 0;

            switch (player1)
            {
                case "A":
                    switch (player2)
                    {
                        case "X":
                            // tie
                            roundScore += 3;
                            roundScore += ShapeValue[player2];
                            break;
                        case "Y":
                            // win
                            roundScore += 6;
                            roundScore += ShapeValue[player2];
                            break;
                        case "Z":
                            // lose
                            roundScore += ShapeValue[player2];
                            break;
                    }
                    break;
                case "B":
                    switch (player2)
                    {
                        case "X":
                            // lose
                            roundScore += ShapeValue[player2];
                            break;
                        case "Y":
                            // tie
                            roundScore += 3;
                            roundScore += ShapeValue[player2];
                            break;
                        case "Z":
                            // win
                            roundScore += 6;
                            roundScore += ShapeValue[player2];
                            break;
                    }
                    break;
                case "C":
                    switch (player2)
                    {
                        case "X":
                            // win
                            roundScore += 6;
                            roundScore += ShapeValue[player2];
                            break;
                        case "Y":
                            // lose
                            roundScore += ShapeValue[player2];
                            break;
                        case "Z":
                            // tie
                            roundScore += 3;
                            roundScore += ShapeValue[player2];
                            break;
                    }
                    break;
            }

            return roundScore;
        }

        private static string ShapeToChoose(string player1, string player2)
        {
            switch (player1)
            {
                case "A": // rock
                    switch (player2)
                    {
                        case "X": // lose
                            return "Z";
                        case "Y": // draw
                            return "X";
                        case "Z": // win
                            return "Y";
                    }
                    break;
                case "B": // paper
                    switch (player2)
                    {
                        case "X": // lose
                            return "X";
                        case "Y": // draw
                            return "Y";
                        case "Z": // win
                            return "Z";
                    }
                    break;
                case "C": // scissors
                    switch (player2)
                    {
                        case "X": // lose
                            return "Y";
                        case "Y": // draw
                            return "Z";
                        case "Z": // win
                            return "X";
                    }
                    break;
            }
            return string.Empty;
        }
    }
}
