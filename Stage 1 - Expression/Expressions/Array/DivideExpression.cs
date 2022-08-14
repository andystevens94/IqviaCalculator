using Iqvia.InterviewExercise.Expression.Expressions.Abstract;

namespace Iqvia.InterviewExercise.Expression
{
	public class DivideExpression : ExpressionArrayBase
	{
		public DivideExpression(params ExpressionBase[] inputs) : base(inputs)
		{
		}

		public override int Eval()
		{
			int value = _inputs[0].Eval();
			for (int i = 1; i < _inputs.Length; i++)
			{
				value = value / _inputs[i].Eval();
			}
			return value;
		}

		public override string ToString()
		{
			return base.ConcatInputs('/');
		}
	}
}