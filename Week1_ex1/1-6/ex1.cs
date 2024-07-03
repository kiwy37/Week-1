using System;

namespace Week1_ex1;

class ex1
{
    // Metoda care calculeaza suma a doua numere folosind operatorul +
    public int Sum(int a, int b)
    {
        return a + b;
    }

    // Metoda care calculeaza suma a doua numere fara a folosi operatorul +
    public int SumWithoutPlus(int a, int b)
    {
        while (b != 0)
        {
            int carry = a & b;
            a = a ^ b;
            b = carry << 1;
        }
        return a;
    }

    // Suprascrierea metodei Sum pentru double si float
    public double Sum(double x, double y)
    {
        return x + y;
    }

    public float Sum(float x, float y)
    {
        return x + y;
    }

    // Suprascrierea metodei Sum pentru 3 parametri
    public int Sum(int a, int b, int c)
    {
        return Sum(a, b) + c;
    }

    // Suprascrierea metodei Sum pentru 4 parametri
    public int Sum(int a, int b, int c, int d)
    {
        return Sum(a, b, c) + d;
    }

    // Metoda care calculează suma pentru un numar variabil de parametri
    public int Sum(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total = Sum(total, number);
        }
        return total;
    }
}
