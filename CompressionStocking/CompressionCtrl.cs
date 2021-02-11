using System;
using System.Collections.Generic;
using System.Text;

namespace CompressionStocking
{
	public class CompressionCtrl : ICompressionCtrl
	{
		private readonly IPump pump_;
		private readonly ITimer timer_;

		public CompressionCtrl(IPump pump, ITimer timer)
		{
			timer_ = timer;
			pump_ = pump;
		}
		public void Compress()
		{
			Console.WriteLine("Compression called");
			pump_.PumpStart(Direction.Forward);
			timer_.StartTimer(5);
			pump_.PumpStop();
			Console.WriteLine("Compression Done");
		}
		public void Decompress()
		{
			Console.WriteLine("Decompression called");
			pump_.PumpStart(Direction.Backward);
			timer_.StartTimer(2);
			pump_.PumpStop();
			Console.WriteLine("Decompression Done");

		}
	}
}
