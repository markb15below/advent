using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class _2WrappingPaperTestCalculator
    {
        public int Calculate(int d1, int d2, int d3)
        {
            var initialArea = 2 * (d1 * d2 + d2 * d3 + d1 * d3);

            var dimensions = new[] {d1, d2, d3};
            Array.Sort(dimensions);

            var slack = dimensions[0] * dimensions[1];

            return initialArea + slack;
        }

        public int CalculateRibbon(int d1, int d2, int d3)
        {
            var dimensions = new[] { d1, d2, d3 };
            Array.Sort(dimensions);

            var perimeter = dimensions[0] * 2 + dimensions[1] * 2;
            var cubicVolume = d1 * d2 * d3;
            return perimeter + cubicVolume;
        }
    }
}
