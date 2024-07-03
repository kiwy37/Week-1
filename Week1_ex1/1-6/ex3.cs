using System;

namespace Week1_ex1;

class ex3
{
    public void Swap<T>(ref T a, ref T b)
    {
        (a, b) = (b, a);
    }
}