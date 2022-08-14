using System;
using System.Collections.Generic;
using System.Text;

namespace Iqvia.InterviewExercise.Expression.Interfaces
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