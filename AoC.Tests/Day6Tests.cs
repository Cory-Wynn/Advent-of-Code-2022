using AoC.Days;
using FluentAssertions;

namespace AoC.Tests
{
    public class Day6Tests
    {
        [Theory]
        [InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz", 5)]
        [InlineData("nppdvjthqldpwncqszvftbrmjlhg", 6)]
        [InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 10)]
        [InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 11)]
        public void PartOneShouldBeExpectedResult(string input, int expectedResult)
        {
            var result = Day6.PartOne(input);

            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData("mjqjpqmgbljsphdztnvjfqwrcgsmlb", 19)]
        [InlineData("bvwbjplbgvbhsrlpgdmjqwftvncz", 23)]
        [InlineData("nppdvjthqldpwncqszvftbrmjlhg", 23)]
        [InlineData("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg", 29)]
        [InlineData("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw", 26)]
        public void PartTwoShouldBeExpectedResult(string input, int expectedResult)
        {
            var result = Day6.PartTwo(input);

            result.Should().Be(expectedResult);
        }
    }
}