using Iqvia.InterviewExercise.Expression.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

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