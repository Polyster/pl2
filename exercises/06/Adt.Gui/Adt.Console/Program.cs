using System;
using System.Data;
using System.Data.SqlClient;
using Adt.EntityFramework;
using Adt.EntityFramework.Models;

namespace Adt.Console
{
	class Program
	{
		private const string ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=pl2;Trusted_Connection=True;";

		static void Main(string[] args)
		{
			//AdoNet();
			//EF6();
		}


		private static void AdoNet()
		{
			var connection = new SqlConnection(ConnectionString);
			var createStatement =
			@"CREATE TABLE Student 
				(
					Id INT,
					Firstname VARCHAR(50),
					Lastname VARCHAR(50),
					Email VARCHAR(50),
					Gender VARCHAR(50)
				);";
			var command = new SqlCommand(createStatement, connection);

			try
			{
				connection.Open();
				command.ExecuteNonQuery();
				command = new SqlCommand(
					"INSERT INTO Student (Id, Firstname, Lastname, Email, Gender) values (1, 'Eliza', 'Radolf', 'eradolf0@csmonitor.com', 'Female');",
					connection);
				command.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				System.Console.WriteLine(e.ToString());
			}
			finally
			{
				connection.Close();
			}
		}

		private static void EF6()
		{
			using (var dbContext = new StudentDbContext())
			{
				dbContext.Student.Add(new Student
				{
					Id = 1,
					Firstname = "Eliza",
					Lastname = "Radolf",
					Email = "eradolf0@csmonitor.com",
					Gender = "Female"
				});
				dbContext.SaveChanges();
			}
		}
	}
}