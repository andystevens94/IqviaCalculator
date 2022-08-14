using System;
using System.Collections.Generic;
using System.Text;

namespace Iqvia.InterviewExercise.Expression.Interfaces
{
	public abstract class ExpressionBase
	{
		public abstract int Eval();

		public abstract override string ToString();
	}
}