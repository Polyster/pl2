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
			_index = -1;
		}

		public void AddContact(T contact)
		{
			_data.Add(contact);
		}

		#region IEnumerable methods

		public IEnumerator<T> GetEnumerator()
		{
			return _data.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		#endregion

		#region IEnumerator methods

		public void Dispose()
		{
			// throw new NotImplementedException();
		}

		public bool MoveNext()
		{
			return _index++ < _data.Count;
		}

		public void Reset()
		{
			_index = -1;
		}

		public T Current => _data.ElementAt(_index);

		object IEnumerator.Current => Current;

		#endregion
	}
}