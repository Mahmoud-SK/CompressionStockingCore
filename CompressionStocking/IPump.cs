using System;
using System.Collections.Generic;
using System.Text;

namespace CompressionStocking
{
	public enum Direction
	{
		Forward,
		Backward
	}
	public interface IPump
	{
		void PumpStart(Direction direction_);
		void PumpStop();

	}
}
