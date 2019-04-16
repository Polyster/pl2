using System.Collections.Generic;
using Streams.Models;

namespace Streams.Interfaces
{
	public interface IContactDao
	{
		IEnumerable<Contact> FindAllContacts();
		Contact FindById(int id);
		int CreateContact(Contact c);
		void UpdateContact(Contact c);
		void DeleteContact(int id);
	}
}