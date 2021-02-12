using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CompressionStocking
{
	public class LaceTimer : ITimer
	{
		public void CompressTimer()
		{
			for (int i = 0; i < 40; i++)
			{
				Console.WriteLine("Click::CompressTimer()");
				Thread.Sleep(100);
			}

		}
		public void DecompressTimer()
		{
			for (int i = 0; i < 40; i++)
			{
				Console.WriteLine("Click::DecompressTimer()");
				Thread.Sleep(100);
			}

		}
	}
}
