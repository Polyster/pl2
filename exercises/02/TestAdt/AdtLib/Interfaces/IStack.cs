namespace AdtLib.Interfaces
{
	public interface IStack : IAdt
	{
		void Push(int number);
		int Pop();
		int Top();
	}
}