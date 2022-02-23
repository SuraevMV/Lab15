using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15
{
    class ArithProgression : ISeeries
    {
        int step;
        int firstNumber;
        int nextNumber;

        public int GetNext()
        {
            nextNumber += step;
            return nextNumber;
        }

        public void Reset()
        {
            nextNumber = firstNumber;
        }
        public void SetStep(int s)
        {
            step = s;
        }
        public void SetStart(int x)
        {
            firstNumber = x;
            nextNumber = firstNumber;
        }
    }
}
