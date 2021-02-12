using System;
using System.Collections.Generic;
using System.Text;

namespace CompressionStocking
{

	public class LED : IFeatures
	{
		private string color_;

		public LED(string color)
		{
			color_ = color;
		}
		public void On()
		{
			Console.WriteLine($"{color_} Led turned ON");

		}

		public void Off()
		{
			Console.WriteLine($"{color_} Led turned OFF");

		}

	}
}
