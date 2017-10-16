// This class simulates a random number generator, but generates
// a predictable sequence of numbers so that they can be used in
// a method that is tested automatically
// Writen by Brian Bird, 5/10/13

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    public class MockRandom
    {
        int[] numbers = {57, 198, 2, 100, 92, 42, 13,  60,  10,  88,
                         36,  69, 25,  73, 50,  99, 11,  16, 176,  34,
                         102, 48,  5,  63,  0, 123, 55,    1,  4,  84,
                         2, 148,   8,   3,  6, 184, 137, 162, 102, 135 };

        int count = 0;

        public List<int> Numbers
        {
            get { return new List<int>(numbers); }
        }

        public int Next(int max)
        {
            int number = 0;
            do
            {
                number = numbers[count++];
                if (count >= numbers.Count())
                {
                    count = 0;
                }
            }
            while (number > max);

            return number;
        }
    }
}
