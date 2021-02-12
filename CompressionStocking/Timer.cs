using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CompressionStocking
{
	public class Timer : ITimer
	{
		public void CompressTimer()
		{
			Thread.Sleep(5000);

		}
		public void DecompressTimer()
		{
			Thread.Sleep(2000);

		}
	}
}
