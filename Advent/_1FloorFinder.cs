using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class _1FloorFinder
    {
        public int FindFloor(string input)
        {
            return input.Aggregate(0, (currentFloor, nextChar) =>
            {
                var nextFloor = currentFloor += nextChar == '(' ? 1 : -1;
                return nextFloor;
            });
        }

        public int FindBasementEnteringCharacterPosition(string input)
        {
            var currentFloor = 0;
            
            for (var i = 0; i < input.Length; i++)
            {
                var nextChar = input[i];
                currentFloor += nextChar == '(' ? 1 : -1;

                if (currentFloor < 0)
                {
                    return i + 1;
                }
            }

            throw new ArgumentException("No basement hit");
        }
    }
}
