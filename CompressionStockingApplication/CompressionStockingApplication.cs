using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompressionStocking;

namespace CompressionStockingApplication
{

    class StubCompressionCtrl : ICompressionCtrl
    {
        public void Compress()
        {
            Console.WriteLine("StubCompressionCtrl::Compress() called");
        }

        public void Decompress()
        {
            Console.WriteLine("StubCompressionCtrl::Decompress() called");
        }
    }

    class CompressionStockingApplication
    {
        static void Main(string[] args)
        {
                        IPump Pump_ = new Pump();
            ITimer Timer_ = new Timer();
            IPump Pump_Lace = new Lace();
            ITimer Timer_lace = new LaceTimer();

            IFeatures GreenLED = new LED("Green");
            IFeatures RedLED = new LED("Red");
            IFeatures VDevice = new VibratingDevice();

            var compressionStockingstocking = new StockingCtrl(new CompressionCtrl(Pump_,Timer_, GreenLED, RedLED, VDevice));
            var compressionStockingstocking_Lace = new StockingCtrl(new CompressionCtrl(Pump_Lace, Timer_lace, GreenLED, RedLED, VDevice));

            ConsoleKeyInfo consoleKeyInfo;
            
         

            Console.WriteLine("Compression Stocking Control User Interface");
            Console.WriteLine("A:   Compress");
            Console.WriteLine("Z:   Decompress");
            Console.WriteLine("P:   Pump");
            Console.WriteLine("L:   Lace");
            Console.WriteLine("ESC: Terminate application");

            StockingCtrl Pumpy = compressionStockingstocking;

            do
            {
                consoleKeyInfo = Console.ReadKey(true); // true = do not echo character
                if (consoleKeyInfo.Key == ConsoleKey.P)  Pumpy = compressionStockingstocking;
                if (consoleKeyInfo.Key == ConsoleKey.L)  Pumpy = compressionStockingstocking_Lace;
                if (consoleKeyInfo.Key == ConsoleKey.A)  Pumpy.StartBtnPushed();
                if (consoleKeyInfo.Key == ConsoleKey.Z)  Pumpy.StopBtnPushed();

            } while (consoleKeyInfo.Key != ConsoleKey.Escape);
        }
    }
}
