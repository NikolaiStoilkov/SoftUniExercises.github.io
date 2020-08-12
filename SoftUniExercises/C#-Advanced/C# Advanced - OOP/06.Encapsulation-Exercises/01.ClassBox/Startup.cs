﻿namespace ClassBox
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Box box = new Box(length, width, height);
            box.CalculateSurfaceArea();
            box.CalculateLateralArea();
            box.CalculateVolume();
        }
    }
}