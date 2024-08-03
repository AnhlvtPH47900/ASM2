using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTBC
{
    public class Dayso
    {
        public double CalculateAverage(List<double> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("The list of numbers cannot be null or empty.");
            }
            return numbers.Average();
        }
    }
}
