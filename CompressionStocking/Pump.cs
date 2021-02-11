using System;
using System.Collections.Generic;
using System.Text;

namespace CompressionStocking
{
	public class Pump : IPump
	{
		public void PumpStart(Direction direction_)
		{
			Console.WriteLine("Pump started: " + direction_.ToString());

		}
		public void PumpStop()
		{
			Console.WriteLine("Pump has been stopped");

		}
	}
}
