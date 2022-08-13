using Xunit;
using Iqvia.InterviewExercise.Expression.Extensions;

namespace Iqvia.InterviewExercise.Expression.Tests
{
    public sealed class Stage2
    {
        [Fact]
        public void FluentTest1()
        {
            var expression = 2.Plus(4).Times(10);

            Assert.Equal(60, expression.Eval());
        }

        [Fact]
        public void FluentTest2()
        {
            var expression = 6.Times(7).Minus(9).Plus(2).Times(2);

            Assert.Equal(70, expression.Eval());
        }

        [Fact]
        public void FluentTest3()
        {
            var expression1 = new MultiplyExpression(2.Times(5), 20.DividedBy(5));
            var expression2 = 6.Times(2);
            var finalExpression = expression1.Plus(expression2);

            Assert.Equal(52, finalExpression.Eval());
        }
    }
}