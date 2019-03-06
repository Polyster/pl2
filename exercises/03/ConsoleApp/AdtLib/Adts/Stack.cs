using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdtLib.Interfaces;

namespace AdtLib.Adts
{
	public class Stack<T> : IStack<T>
	{
		private readonly int _maxSize;
		private int _top;
		private T[] _data;

		/// <summary>
		/// Default constructor for stack initialization
		/// </summary>
		/// <param name="maxSize">Maximal size of stack</param>
		public Stack(int maxSize)
		{
			_maxSize = maxSize;
			_top = 0;
			_data = new T[maxSize];
		}

		public bool IsEmpty() => _top == 0;

		public bool IsFull() => _top == _maxSize;

		public void Clear() => _data = new T[_maxSize];

		public void Push(T item)
		{
			if (!IsFull())
			{
				_data[_top++] = item;
			}
			else throw new ApplicationException("Stack overflow!");
		}

		public T Pop()
		{
			if (!IsEmpty())
			{
				return _data[--_top];
			}

			throw new ApplicationException("Stack is empty!");
		}

		public T Top()
		{
			if (!IsEmpty())
			{
				return _data[_top - 1];
			}

			throw new ApplicationException("Stack is empty!");
		}
	}
}