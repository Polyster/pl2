using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Streams.Interfaces;
using Streams.Models;

namespace Streams.Daos
{
	public class XmlContactDao : IContactDao
	{
		private readonly string _fileName;

		public XmlContactDao(string fileName)
		{
			_fileName = fileName;
		}

		public Contact FindById(int id)
		{
			var result = FindAllContacts().FirstOrDefault(c => c.Id == id);
			return result;
		}

		public int CreateContact(Contact contact)
		{
			var contacts = FindAllContacts().ToList();
			if (contacts.Count != 0)
				contact.Id = contacts.Max(c => c.Id) + 1;
			else contact.Id = 0;


			contacts.Add(contact);

			Save(contacts);
			return contact.Id;
		}

		public IEnumerable<Contact> FindAllContacts()
		{
			var result = new List<Contact>();
			if (File.Exists(_fileName))
			{
				using (var stream = new FileStream(_fileName, FileMode.Open))
				{
					var serializer = new XmlSerializer(typeof(List<Contact>));
					result = (List<Contact>) serializer.Deserialize(stream);
				}
			}

			return result;
		}

		public void UpdateContact(Contact c)
		{
			DeleteContact(c.Id);
			CreateContact(c);
		}

		public void DeleteContact(int id)
		{
			var contacts = FindAllContacts().ToList();
			contacts.Remove(contacts.FirstOrDefault(c => c.Id == id));
			Save(contacts);
		}

		private void Save(List<Contact> contacts)
		{
			using (var stream = new FileStream(_fileName, FileMode.Create))
			{
				var serializer = new XmlSerializer(typeof(List<Contact>));
				serializer.Serialize(stream, contacts);
			}
		}
	}
}