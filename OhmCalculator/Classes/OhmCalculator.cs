using System;
using System.Collections.Generic;
using OhmCalculator.Core.Interfaces;
using OhmCalculator.Repositories;

namespace OhmCalculator.Classes
{
    public class OhmCalculator : IOhmValueCalculator
    {
        /// <summary>
        /// Implementation of the IOhmValueCalculator interface for calculating the Ohm value of a resistor based on the band colors.
        /// </summary>
        /// <param name="bandAColor"></param>
        /// <param name="bandBColor"></param>
        /// <param name="bandCColor"></param>
        /// <param name="bandDColor"></param>
        /// <returns></returns>
        public int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            ValuesRepository valuesRepository = new ValuesRepository();
            int result = 0;
        
            Dictionary<string, int> a = valuesRepository.a;
            Dictionary<string, int> b = valuesRepository.b;
            Dictionary<string, int> c = valuesRepository.c; 
            Dictionary<string, float> d = valuesRepository.d;
                        
             var calc = (a[bandAColor] * 10 + b[bandBColor]) * Math.Pow(10, c[bandCColor]) * (1 + d[bandDColor]);
             result = Convert.ToInt32(calc);

            return result; 
        }
    }
}