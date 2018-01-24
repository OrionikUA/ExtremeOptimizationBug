using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extreme.Statistics.Distributions;

namespace ExtremeOptimizationBug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Func(0.25, 255, 1, false));
            Console.WriteLine(Func(0.25, 256, 1, false));
            Console.WriteLine(Func(0.25, 300, 1, false));
            Console.WriteLine(Func(0.1, 255, 1, false));
            Console.WriteLine(Func(0.1, 256, 1, false));
            Console.WriteLine(Func(0.1, 255, 2, false));
            Console.WriteLine(Func(0.1, 256, 2, false));
            Console.WriteLine(Func(0.1, 300, 2, false));
            Console.WriteLine(Func(0.1, 511, 2, false));

            Console.ReadLine();
        }

        public static string Func(double x, double deg1, double deg2, bool cumulative)
        {
            string res = new FDistribution(deg1, deg2).ProbabilityDensityFunction(x).ToString(CultureInfo.CurrentCulture);
            return $"x = {x}  \t deg1 = {deg1}\t deg2 = {deg2}\t cumulative = {cumulative}\t result = {res}";
        }
    }
}
