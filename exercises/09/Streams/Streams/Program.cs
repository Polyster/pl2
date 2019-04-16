using System;
using Streams.Factories;
using Streams.Interfaces;
using Streams.Models;

namespace Streams
{
	class Program
	{
		static void Main(string[] args)
		{
			Task(new XmlDbFactory("contacts.xml")
					 .CreateContactDao());
			//Task(new SqlDbFactory("Server=(localdb)\\mssqllocaldb;Database=pl2_09;Trusted_Connection=True;")
			//		 .CreateContactDao());
		}

		static void Task(IContactDao dao)
		{
			var contact = new Contact
			{
				Name = "Peter Parker",
				Age = 32,
				BirthDate = new DateTimeOffset(1975, 4, 5, 0, 0, 0, 0, TimeSpan.Zero),
				Email = "peter.parker@spiderman.com",
				Weight = 70.3,
				MaritalStatus = MaritalStatus.Single
			};
			Console.WriteLine(contact);

			int id = dao.CreateContact(contact);
			Console.WriteLine($"Generated id: {id}");

			contact = dao.FindById(id);
			Console.WriteLine(contact);

			contact.MaritalStatus = MaritalStatus.Married;

			dao.UpdateContact(contact);
			Console.WriteLine(contact);

			contact = dao.FindById(id);
			Console.WriteLine(contact);

			dao.DeleteContact(contact.Id);

			contact = dao.FindById(id);
			if (contact == null)
				Console.WriteLine("Not found");
		}
	}
}