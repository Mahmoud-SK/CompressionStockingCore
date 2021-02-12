using System;
using System.Collections.Generic;
using System.Text;

namespace CompressionStocking
{
	public class CompressionCtrl : ICompressionCtrl
	{
		private readonly IPump pump_;
		private readonly ITimer timer_;
		private readonly IFeatures LED_Green_;
		private readonly IFeatures LED_Red_;
		private readonly IFeatures VibratingDevice_;

		public CompressionCtrl(IPump pump, ITimer timer, IFeatures LED_Green, IFeatures LED_Red, IFeatures VibratingDevice)
		{
			timer_ = timer;
			pump_ = pump;
			LED_Green_ = LED_Green;
			LED_Red_ = LED_Red;
			VibratingDevice_ = VibratingDevice; 

		}
		public void Compress()
		{
			Console.WriteLine("Compression called");
			pump_.PumpStart(Direction.Forward);
			LED_Green_.On();
			VibratingDevice_.On();
			timer_.CompressTimer();
			pump_.PumpStop();
			LED_Green_.Off();
			Console.WriteLine("Compression Done");
			VibratingDevice_.Off();
		}
		public void Decompress()
		{
			Console.WriteLine("Decompression called");
			pump_.PumpStart(Direction.Backward);
			LED_Red_.On();
			VibratingDevice_.On();
			timer_.DecompressTimer();
			pump_.PumpStop();
			LED_Red_.Off();
			Console.WriteLine("Decompression Done");
			VibratingDevice_.Off();
		}
	}
}
