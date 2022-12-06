using System.Text;

namespace AoC.Days
{
    internal class Day5
    {
        private static readonly IEnumerable<string> Input = File.ReadLines("C:\\Users\\cory.wynn\\source\\repos\\AoC\\AoC\\Input\\Day5-input.txt");

        private static readonly IEnumerable<Command> _commands = Input
            .Skip(10)
            .Select(c => new Command(int.Parse(c.Split(" ")[1]), int.Parse(c.Split(" ")[3]), int.Parse(c.Split(" ")[5])));

        public static string PartOne()
        {
            var stacks = CreateStacks();

            foreach (var command in _commands)
            {
                var moves = Enumerable.Range(0, command.Move);

                foreach (var move in moves)
                {
                    stacks[command.To - 1].Push(stacks[command.From - 1].Pop());
                }
            }

            return GetOutput(stacks);
        }

        public static string PartTwo()
        {
            var stacks = CreateStacks();

            foreach (var command in _commands)
            {
                var crates = Enumerable.Range(0, command.Move)
                    .Select(_ => stacks[command.From - 1].Pop())
                    .Reverse();

                foreach (var crate in crates)
                {
                    stacks[command.To - 1].Push(crate);
                }
            }

            return GetOutput(stacks);
        }

        private static Stack<char>[] CreateStacks()
        {
            var stacks = new Stack<char>[9];
            stacks[0] = new Stack<char>("BSVZGPW".ToCharArray());
            stacks[1] = new Stack<char>("JVBCZF".ToCharArray());
            stacks[2] = new Stack<char>("VLMHNZDC".ToCharArray());
            stacks[3] = new Stack<char>("LDMZPFJB".ToCharArray());
            stacks[4] = new Stack<char>("VFCGJBQCH".ToCharArray());
            stacks[5] = new Stack<char>("GFQTSLB".ToCharArray());
            stacks[6] = new Stack<char>("LGCZV".ToCharArray());
            stacks[7] = new Stack<char>("NLG".ToCharArray());
            stacks[8] = new Stack<char>("JFHC".ToCharArray());
            return stacks;
        }

        private static string GetOutput(Stack<char>[] stacks)
        {
            var output = new StringBuilder();

            foreach (var stack in stacks)
            {
                output.Append(stack.Peek().ToString());
            }

            return output.ToString();
        }
    }

    public record Command(int Move, int From, int To);
}
