using Iqvia.InterviewExercise.Expression.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iqvia.InterviewExercise.Expression
{
	public class NegateExpression : ExpressionSingleBase
	{
		public NegateExpression(ExpressionBase input) : base(input)
		{
		}

		public override int Eval()
		{
			int value = _input.Eval();
			return value * -1;
		}

		public override string ToString()
		{
			int value = _input.Eval();
			return (value * -1).ToString();
		}
	}
}