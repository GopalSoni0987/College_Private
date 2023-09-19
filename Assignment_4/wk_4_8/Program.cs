﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk_4_8
{
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            Season currentSeason = Season.Summer;

            switch (currentSeason)
            {
                case Season.Spring:
                    Console.WriteLine("It's Spring! Flowers are blooming.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's Summer! Enjoy the warm weather.");
                    break;
                case Season.Autumn:
                    Console.WriteLine("It's Autumn! The leaves are changing color.");
                    break;
                case Season.Winter:
                    Console.WriteLine("It's Winter! Time for snow and cold weather.");
                    break;
                default:
                    Console.WriteLine("Unknown season.");
                    break;

            }
            Console.Read();
        }
    }
}
