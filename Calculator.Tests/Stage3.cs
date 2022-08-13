using Iqvia.InterviewExercise.Expression.Extensions;
using Xunit;

namespace Iqvia.InterviewExercise.Expression.Tests
{
    public sealed class Stage3
    {
        [Fact]
        public void ModStrategyTest()
        {
            var expression =
                new BinaryExpressionStrategy(new LiteralExpression(20), new LiteralExpression(3),
                    "%", (a, b) => a % b);

            Assert.Equal("(20%3)", expression.ToString());
            Assert.Equal(2, expression.Eval());
        }

        [Fact]
        public void CombinedtrategyTest()
        {
            var expression = 2.Times(
                new BinaryExpressionStrategy(7.Plus(4), new LiteralExpression(3),
                    "%", (a, b) => a % b));

            Assert.Equal("(2*((7+4)%3))", expression.ToString());
            Assert.Equal(4, expression.Eval());
        }
    }
}