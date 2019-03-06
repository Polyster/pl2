using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdtLib.Interfaces
{
	public interface IAdt
	{
		bool IsEmpty();
		bool IsFull();
		void Clear();
	}
}