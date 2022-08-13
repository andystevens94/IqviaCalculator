using System;
using Xunit;

namespace Iqvia.InterviewExercise.Expression.Tests
{
    public sealed class Stage1
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(30, 22, 52)]
        [InlineData(-22, 10, -12)]
        [InlineData(0, 2, 2)]
        public void AddTest(int arg1, int arg2, int expected)
        {
            var adder = new AddExpression(new LiteralExpression(arg1), new LiteralExpression(arg2));
            var actual = adder.Eval();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 4, 1)]
        [InlineData(10, 5, 5)]
        [InlineData(15, 25, -10)]
        [InlineData(2, 2, 0)]
        public void SubtractTest(int arg1, int arg2, int expected)
        {
            var subtracter = new SubtractExpression(new LiteralExpression(arg1), new LiteralExpression(arg2));
            var actual = subtracter.Eval();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 4, 20)]
        [InlineData(10, 9, 90)]
        [InlineData(4, -4, -16)]
        [InlineData(-5, -4, 20)]
        public void MultiplyTest(int arg1, int arg2, int expected)
        {
            var multiplier = new MultiplyExpression(new LiteralExpression(arg1), new LiteralExpression(arg2));
            var actual = multiplier.Eval();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20, 4, 5)]
        [InlineData(100, 25, 4)]
        [InlineData(21, -7, -3)]
        [InlineData(-88, -11, 8)]
        public void DivideTest(int arg1, int arg2, int expected)
        {
            var divider = new DivideExpression(new LiteralExpression(arg1), new LiteralExpression(arg2));
            var actual = divider.Eval();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20)]
        [InlineData(-10)]
        public void NegateTest(int arg1)
        {
            var negator = new NegateExpression(new LiteralExpression(arg1));
            var actual = negator.Eval();

            Assert.Equal(-1 * arg1, actual);
        }

        [Fact]
        public void CompositeTest1()
        {
            var expression = new MultiplyExpression(
                new AddExpression(new LiteralExpression(2),
                    new SubtractExpression(new LiteralExpression(4), new LiteralExpression(1))),
                new DivideExpression(new LiteralExpression(10), new LiteralExpression(5)));

            Assert.Equal("((2+(4-1))*(10/5))", expression.ToString());
            Assert.Equal(10, expression.Eval());
        }

        [Fact]
        public void CompositeTest2()
        {
            var expression = new MultiplyExpression(
                new LiteralExpression(6),
                new DivideExpression(new LiteralExpression(10),
                   new AddExpression(new LiteralExpression(3), new LiteralExpression(2))));

            Assert.Equal("(6*(10/(3+2)))", expression.ToString());
            Assert.Equal(12, expression.Eval());
        }

        [Fact]
        public void NullArgValidation()
        {
            Assert.Throws<ArgumentNullException>(() => new AddExpression(null, null));
        }
    }
};