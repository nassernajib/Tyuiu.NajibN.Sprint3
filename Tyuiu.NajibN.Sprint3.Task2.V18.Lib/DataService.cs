﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NajibN.Sprint3.Task2.V18.Lib
{
    public class DataService : ISprint3Task2V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double ProductSeries = 1;
            do
            {
                ProductSeries = ProductSeries * ((Math.Cos(value)) + Math.Pow(startValue / 8, 3));
                startValue++;

            } while (startValue <= stopValue);
            return Math.Round(ProductSeries, 3);
        }
    }
}
