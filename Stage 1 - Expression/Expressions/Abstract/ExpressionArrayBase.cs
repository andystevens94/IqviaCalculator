using System;
using System.Linq;

namespace Iqvia.InterviewExercise.Expression.Expressions.Abstract
{
	public abstract class ExpressionArrayBase : ExpressionBase
	{
		protected readonly ExpressionBase[] _inputs;

		protected ExpressionArrayBase(ExpressionBase[] inputs)
		{
			if (inputs.Length < 2)
			{
				throw new ArgumentException();
			}
			if (inputs.Contains(null))
			{
				throw new ArgumentNullException();
			}
			_inputs = inputs;
		}

		protected string ConcatInputs(char ExpressionOperator)
		{
			string[] values = new string[_inputs.Length];
			for (int i = 0; i < _inputs.Length; i++)
			{
				values[i] = _inputs[i].ToString();
			}
			string concatValues = string.Join(ExpressionOperator, values);
			return $"({concatValues})";
		}
	}
}