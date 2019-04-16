namespace Streams.Interfaces
{
	public interface IContactDbFactory
	{
		IContactDao CreateContactDao();
	}
}