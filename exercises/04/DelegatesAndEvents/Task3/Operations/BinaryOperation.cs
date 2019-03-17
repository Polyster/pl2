using System;

namespace Task3.Operations
{
	public class BinaryOperation<T>
	{
		private readonly T _a;
		private readonly T _b;

		public BinaryOperation(T a, T b)
		{
			_a = a;
			_b = b;
		}

		public T Operate(Func<T, T, T> function)
		{
			return function(_a, _b);
		}
	}
}