using System.Collections.Generic;
using System.Data.SqlClient;
using Streams.Interfaces;
using Streams.Models;

namespace Streams.Daos
{
	public class SqlContactDao : IContactDao
	{
		private readonly string _connectionString;

		public SqlContactDao(string connectionString)
		{
			_connectionString = connectionString;
		}

		public Contact FindById(int id)
		{
			Contact result = null;
			var sql = @"SELECT Id, Name, Age, Email, BirthDate, Weight, MaritalStatus
									FROM Contact
									WHERE Id = @Id";
			using (var connection = new SqlConnection(_connectionString))
			{
				connection.Open();
				var command = new SqlCommand(sql, connection);

				command.Parameters.AddWithValue("@Id", id);

				var reader = command.ExecuteReader();
				while (reader.Read())
				{
					result = ParseContact(reader);
				}
			}

			return result;
		}

		public int CreateContact(Contact c)
		{
			var sql = @"INSERT INTO Contact (Name, Age, Email, BirthDate, Weight, MaritalStatus) 
									VALUES (@Name, @Age, @Email, @BirthDate,  @Weight, @MaritalStatus);
									SELECT CAST(scope_identity() AS int)";

			using (var connection = new SqlConnection(_connectionString))
			{
				connection.Open();
				var command = new SqlCommand(sql, connection);

				command.Parameters.AddWithValue("@Name", c.Name);
				command.Parameters.AddWithValue("@Age", c.Age);
				command.Parameters.AddWithValue("@Email", c.Email);
				command.Parameters.AddWithValue("@BirthDate", c.BirthDate);
				command.Parameters.AddWithValue("@Weight", c.Weight);
				command.Parameters.AddWithValue("@MaritalStatus", c.MaritalStatus);

				var identity = (int) command.ExecuteScalar();
				return identity;
			}
		}

		public void UpdateContact(Contact c)
		{
			string sql = @"UPDATE Contact 
											SET Name = @Name, Age = @Age, Email = @Email, BirthDate = @BirthDate, Weight = @Weight, MaritalStatus = @MaritalStatus
											WHERE Id = @Id";
			using (var connection = new SqlConnection(_connectionString))
			{
				connection.Open();
				var command = new SqlCommand(sql, connection);

				command.Parameters.AddWithValue("@Name", c.Name);
				command.Parameters.AddWithValue("@Age", c.Age);
				command.Parameters.AddWithValue("@Email", c.Email);
				command.Parameters.AddWithValue("@BirthDate", c.BirthDate);
				command.Parameters.AddWithValue("@Weight", c.Weight);
				command.Parameters.AddWithValue("@MaritalStatus", c.MaritalStatus);
				command.Parameters.AddWithValue("@Id", c.Id);

				command.ExecuteNonQuery();
			}
		}

		public void DeleteContact(int id)
		{
			string sql = @"DELETE FROM Contact 
											WHERE Id = @Id";
			using (var connection = new SqlConnection(_connectionString))
			{
				connection.Open();
				var command = new SqlCommand(sql, connection);

				command.Parameters.AddWithValue("@Id", id);

				command.ExecuteNonQuery();
			}
		}

		public IEnumerable<Contact> FindAllContacts()
		{
			var result = new List<Contact>();
			var sql = @"SELECT Id, Name, Age, Email, BirthDate, Weight, MaritalStatus
									FROM Contact";
			using (var connection = new SqlConnection(_connectionString))
			{
				connection.Open();
				var command = new SqlCommand(sql, connection);
				var reader = command.ExecuteReader();
				while (reader.Read())
				{
					result.Add(ParseContact(reader));
				}
			}

			return result;
		}


		private Contact ParseContact(SqlDataReader reader)
		{
			var i = 0;
			return new Contact
			{
				Id = reader.GetInt32(i++),
				Name = reader.GetString(i++),
				Age = reader.GetInt32(i++),
				Email = reader.GetString(i++),
				BirthDate = reader.GetDateTimeOffset(i++),
				Weight = reader.GetDouble(i++),
				MaritalStatus = (MaritalStatus) reader.GetInt32(i++)
			};
		}
	}
}