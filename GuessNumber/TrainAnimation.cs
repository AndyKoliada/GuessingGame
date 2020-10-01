using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using Console = Colorful.Console;

namespace GuessNumber
{
    class TrainAnimation : IAnimation
    {
        public void Run()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 80; j++)
                {
                    Console.Clear();

                    // steam
                    Console.Write("       . . . . o o o o o o", Color.LightGray);
                    for (int s = 0; s < j / 2; s++)
                    {
                        Console.Write(" o", Color.LightGray);
                    }
                    Console.WriteLine();

                    var margin = "".PadLeft(j);
                    Console.WriteLine(margin + "                _____      o", Color.LightGray);
                    Console.WriteLine(margin + "       ____====  ]OO|_n_n__][.", Color.DeepSkyBlue);
                    Console.WriteLine(margin + "      [________]_|__|________)< ", Color.DeepSkyBlue);
                    Console.WriteLine(margin + "       oo    oo  'oo OOOO-| oo\\_", Color.Blue);
                    Console.WriteLine("   +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+    ", Color.Silver);

                    Thread.Sleep(200);
                }
            }
        }
    }
}
