using System;
using AdtLib.Adts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdtTest
{
	[TestClass]
	public class AdtTest
	{
		[TestMethod]
		public void TestStack()
		{
			int min = 1;
			int max = 10;

			var stack = new Stack(max);
			for (int i = min; i <= max; i++)
			{
				stack.Push(i);
			}

			Assert.IsTrue(stack.IsFull());
			for (int i = min; i <= max; i++)
			{
				stack.Pop();
			}

			Assert.IsTrue(stack.IsEmpty());

			Assert.ThrowsException<ApplicationException>(() =>
			{
				var s = new Stack(2);
				s.Pop();
			});

			Assert.ThrowsException<ApplicationException>(() =>
			{
				var s = new Stack(2);
				s.Push(1);
				s.Pop();
				s.Pop();
			});

			Assert.ThrowsException<ApplicationException>(() =>
			{
				var s = new Stack(2);
				s.Push(1);
				s.Push(2);
				s.Push(3);
			});
		}
	}
}