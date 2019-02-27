using System;
using AdtLib.Interfaces;

namespace AdtLib.Adts
{
	/// <summary>
	/// Implementation of queue abstract data type 
	/// </summary>
	public class Queue : IQueue
	{
		private readonly int _maxSize;
		private int _tail;
		private int _head;
		private int?[] _data;

		/// <summary>
		/// Default constructor for queue initialization
		/// </summary>
		/// <param name="maxSize">Maximal size of queue</param>
		public Queue(int maxSize)
		{
			_maxSize = maxSize;
			_tail = -1;
			_head = 0;
			_data = new int?[maxSize];
		}

		public bool IsEmpty() => _head == _tail + 1;

		public bool IsFull() => _tail + 1 == _maxSize;

		public void Clear() => _data = new int?[_maxSize];

		public void Add(int number)
		{
			if (!IsFull())
			{
				_data[++_tail] = number;
			}
			else throw new ApplicationException("Queue overflow!");
		}

		public int Get()
		{
			if (!IsEmpty())
			{
				int index = _head++;

				// let's make it circular
				// if next push would have been over the maxSize
				// reset the head and tail
				if (index + 1 == _maxSize)
				{
					_tail = -1;
					_head = 0;
				}

				int result = _data[index] ?? throw new ApplicationException($"Element at index {index} was set to null!");
				_data[index] = null;
				return result;
			}
			throw new ApplicationException("Queue is empty!");
		}
	}
}