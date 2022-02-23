using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15
{
    interface ISeeries
    {
        void SetStart(int x);
        int GetNext();
        void Reset();
    }
}
