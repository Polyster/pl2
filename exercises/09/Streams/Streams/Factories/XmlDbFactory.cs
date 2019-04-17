using Streams.Daos;
using Streams.Interfaces;

namespace Streams.Factories
{
	public class XmlDbFactory : IContactDbFactory
	{
		private readonly string _fileName;

		public XmlDbFactory(string fileName)
		{
			_fileName = fileName;
		}

		public IContactDao CreateContactDao()
		{
			return new XmlContactDao(_fileName);
		}
	}
}