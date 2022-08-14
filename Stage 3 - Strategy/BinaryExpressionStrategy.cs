using Iqvia.InterviewExercise.Expression.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iqvia.InterviewExercise.Expression
{
	public class BinaryExpressionStrategy : ExpressionBase
	{
		private readonly Func<int, int, int> _expressionFunction;
		private readonly string _expressionOperator;
		private readonly ExpressionBase _input1;
		private readonly ExpressionBase _input2;

		public BinaryExpressionStrategy(ExpressionBase input1, ExpressionBase input2, string expressionOperator, Func<int, int, int> expressionFunction)
		{
			_input1 = input1;
			_input2 = input2;
			_expressionOperator = expressionOperator;
			_expressionFunction = expressionFunction;
		}

		public override int Eval()
		{
			return _expressionFunction.Invoke(_input1.Eval(), _input2.Eval());
		}

		public override string ToString()
		{
			string input1String = _input1.ToString();
			string input2String = _input2.ToString();

			return $"({input1String}{_expressionOperator}{input2String})";
		}
	}
}