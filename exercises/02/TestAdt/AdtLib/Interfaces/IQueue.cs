namespace AdtLib.Interfaces
{
	public interface IQueue : IAdt
	{
		void Add(int number);
		int Get();
	}
}