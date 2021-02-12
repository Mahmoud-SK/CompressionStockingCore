using System;
using System.Collections.Generic;
using System.Text;

namespace CompressionStocking
{
	public class VibratingDevice : IFeatures
	{
		public void On()
		{
			Console.WriteLine("Vibrating device ON");

		}

		public void Off()
		{
			Console.WriteLine("Vibrating device OFF");

		}

	}
}
