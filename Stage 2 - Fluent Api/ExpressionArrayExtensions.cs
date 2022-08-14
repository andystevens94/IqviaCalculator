using Iqvia.InterviewExercise.Expression.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iqvia.InterviewExercise.Expression.Extensions
{
	public static class ExpressionArrayExtensions
	{
		public static ExpressionArrayBase Plus(this int intialValue, int operateValue)
		{
			LiteralExpression[] expressions = IntsToLiteralExpressions(intialValue, operateValue);
			return new AddExpression(expressions);
		}

		public static ExpressionArrayBase Plus(this ExpressionArrayBase intialValue, int operateValue)
		{
			return new AddExpression(intialValue, new LiteralExpression(operateValue));
		}

		public static ExpressionArrayBase Plus(this ExpressionArrayBase intialValue, ExpressionArrayBase operateValue)
		{
			return new AddExpression(intialValue, operateValue);
		}

		public static ExpressionArrayBase Times(this int intialValue, int operateValue)
		{
			LiteralExpression[] expressions = IntsToLiteralExpressions(intialValue, operateValue);
			return new MultiplyExpression(expressions);
		}

		public static ExpressionArrayBase Times(this ExpressionArrayBase intialValue, int operateValue)
		{
			return new MultiplyExpression(intialValue, new LiteralExpression(operateValue));
		}

		public static ExpressionArrayBase Times(this ExpressionArrayBase intialValue, ExpressionArrayBase operateValue)
		{
			return new MultiplyExpression(intialValue, operateValue);
		}

		public static ExpressionArrayBase Minus(this int intialValue, int operateValue)
		{
			LiteralExpression[] expressions = IntsToLiteralExpressions(intialValue, operateValue);
			return new SubtractExpression(expressions);
		}

		public static ExpressionArrayBase Minus(this ExpressionArrayBase intialValue, int operateValue)
		{
			return new SubtractExpression(intialValue, new LiteralExpression(operateValue));
		}

		public static ExpressionArrayBase Minus(this ExpressionArrayBase intialValue, ExpressionArrayBase operateValue)
		{
			return new SubtractExpression(intialValue, operateValue);
		}

		public static ExpressionArrayBase DividedBy(this int intialValue, int operateValue)
		{
			LiteralExpression[] expressions = IntsToLiteralExpressions(intialValue, operateValue);
			return new DivideExpression(expressions);
		}

		public static ExpressionArrayBase DividedBy(this ExpressionArrayBase intialValue, int operateValue)
		{
			return new DivideExpression(intialValue, new LiteralExpression(operateValue));
		}

		public static ExpressionArrayBase DividedBy(this ExpressionArrayBase intialValue, ExpressionArrayBase operateValue)
		{
			return new DivideExpression(intialValue, operateValue);
		}

		private static LiteralExpression[] IntsToLiteralExpressions(params int[] intialValues)
		{
			var expressions = new LiteralExpression[intialValues.Length];
			for (int i = 0; i < intialValues.Length; i++)
			{
				expressions[i] = new LiteralExpression(intialValues[i]);
			}
			return expressions;
		}
	}
}