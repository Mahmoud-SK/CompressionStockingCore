using System;
using System.Collections.Generic;
using System.Text;

namespace CompressionStocking
{
	public class Lace : IPump
	{
		public void PumpStart(Direction direction_)
		{
			Console.WriteLine("Lace started: " + direction_.ToString());

		}
		public void PumpStop()
		{
			Console.WriteLine("Lace has been stopped");
		}
	}
}
