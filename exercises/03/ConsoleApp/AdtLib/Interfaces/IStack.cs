using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdtLib.Interfaces
{
	public interface IStack<T> : IAdt
	{
		void Push(T item);
		T Pop();
		T Top();
	}
}