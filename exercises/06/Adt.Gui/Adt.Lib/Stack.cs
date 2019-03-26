using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adt.Lib
{
	public class Stack
	{
		private readonly int _maxSize;
		private int _top;
		private int?[] _data;

		public int?[] Data => _data.Where(v => v != null).ToArray();

		public Stack(int maxSize)
		{
			_maxSize = maxSize;
			_top = 0;
			_data = new int?[maxSize];
		}

		public bool IsEmpty() => _top == 0;

		public bool IsFull() => _top == _maxSize;

		public void Clear() => _data = new int?[_maxSize];

		public void Push(int number)
		{
			if (!IsFull())
			{
				_data[_top++] = number;
			}
			else throw new ApplicationException("Stack overflow!");
		}

		public int Pop()
		{
			if (!IsEmpty())
			{
				int index = --_top;
				int result = _data[index] ?? throw new ApplicationException($"Element at index {index} was set to null!");
				_data[index] = null;
				return result;
			}

			throw new ApplicationException("Stack is empty!");
		}

		public int Top()
		{
			if (!IsEmpty())
				return _data[_top] ?? throw new ApplicationException($"Element at index {_top} was set to null!");
			throw new ApplicationException("Stack is empty!");
		}
	}
}