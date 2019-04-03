using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
	public class ContactBook<T> : IEnumerable<T>, IEnumerator<T> where T : IContact
	{
		private readonly List<T> _data;
		private int _index;

		public ContactBook(int size)
		{
			_data = new List<T>(size);
			_index = 0;
		}

		public void AddContact(IContact contact)
		{
			throw new NotImplementedException();
		}

		#region IEnumerable methods

		public IEnumerator<T> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		#endregion

		#region IEnumerator methods

		public T Current => throw new NotImplementedException();

		object IEnumerator.Current => Current;

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public bool MoveNext()
		{
			throw new NotImplementedException();
		}

		public void Reset()
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}