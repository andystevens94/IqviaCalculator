using Iqvia.InterviewExercise.Expression.Expressions.Abstract;

namespace Iqvia.InterviewExercise.Expression
{
	public class LiteralExpression : ExpressionBase
	{
		private readonly int _value;

		public LiteralExpression(int value)
		{
			_value = value;
		}

		public override int Eval()
		{
			return _value;
		}

		public override string ToString()
		{
			return _value.ToString();
		}
	}
}