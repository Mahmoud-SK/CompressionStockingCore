using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CompressionStocking
{
	public class Timer : ITimer
	{
		public void StartTimer(int time)
		{
			Thread.Sleep(time*1000);
		}
	}
}
