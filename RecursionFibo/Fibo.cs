using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionFibo
{
    class Fibo
    {
        public int FiboLoop(int input)
        {
            int currentNumber = 0;
            int oldNumber1 = 1;
            int oldNumber2 = 1;

            if (input == 0)
            {

                return 0;
            }
            if (input < 3)
            {

                return 1;
            }
            else
            {

                for (int i = 2; i < input; i++)
                {
                    currentNumber = oldNumber1 + oldNumber2;
                    oldNumber2 = oldNumber1;
                    oldNumber1 = currentNumber;

                }
                return currentNumber;
            }

        }

        public int CalcFibo(int input)
        {
            if (input == 0)
            {
                return 0;
            }
            if (input < 3)
            {
                return 1;
            }
            else
            {
                return CalcFibo(input - 1) + CalcFibo(input - 2);
            }

        }
    }
}
