using System;

namespace Iqvia.InterviewExercise.Expression.Expressions.Abstract
{
	public abstract class ExpressionSingleBase : ExpressionBase
	{
		protected readonly ExpressionBase _input;

		protected ExpressionSingleBase(ExpressionBase input)
		{
			if (input == null)
			{
				throw new ArgumentNullException();
			}
			_input = input;
		}
	}
}