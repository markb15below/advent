using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    public class _3PresentDeliveryTracker
    {
        public int Track(string input)
        {
            var visitedCoords = GetHashSet(input);

            return visitedCoords.Count;
        }

        private static HashSet<(int, int)> GetHashSet(IEnumerable<char> input)
        {
            var visitedCoords = new HashSet<(int, int)> {(0, 0)};
            var x = 0;
            var y = 0;


            foreach (var c in input)
            {
                switch (c)
                {
                    case 'v':
                        y -= 1;
                        break;
                    case '^':
                        y += 1;
                        break;
                    case '>':
                        x += 1;
                        break;
                    case '<':
                        x -= 1;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException($"Invalid char {c}");
                }

                var newCoord = (x, y);

                if (!visitedCoords.Contains(newCoord))
                {
                    visitedCoords.Add(newCoord);
                }
            }
            return visitedCoords;
        }

        public int TrackRobot(string input)
        {
            var santaInput = input.Where((c, i) => i % 2 == 0);
            var roboInput = input.Where((c, i) => i % 2 == 1);
            var santaSet = GetHashSet(santaInput);
            var roboSet = GetHashSet(roboInput);

            santaSet.UnionWith(roboSet);
            return santaSet.Count;
        }
    }
}
