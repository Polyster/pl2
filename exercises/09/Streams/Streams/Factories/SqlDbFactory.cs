using Streams.Daos;
using Streams.Interfaces;

namespace Streams.Factories
{
	public class SqlDbFactory : IContactDbFactory
	{
		private readonly string _connectionString;

		public SqlDbFactory(string connectionString)
		{
			this._connectionString = connectionString;
		}

		public IContactDao CreateContactDao()
		{
			return new SqlContactDao(_connectionString);
		}
	}
}
