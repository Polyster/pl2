using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Streams.Interfaces;
using Streams.Models;

namespace Streams.Daos
{
	public class SqlContactDao : IContactDao
	{
		public IEnumerable<Contact> FindAllContacts()
		{
			throw new NotImplementedException();
		}

		public Contact FindById(int id)
		{
			throw new NotImplementedException();
		}

		public int CreateContact(Contact c)
		{
			throw new NotImplementedException();
		}

		public void UpdateContact(Contact c)
		{
			throw new NotImplementedException();
		}

		public void DeleteContact(int c)
		{
			throw new NotImplementedException();
		}
	}
}
