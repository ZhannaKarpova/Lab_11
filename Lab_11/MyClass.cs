using System;

namespace Lab_11
{
    partial class Program
    {
        class MyClass
        {

            private double first;
            private double second;
            private double funk;
            private double x;

            public MyClass(double A, double B, double Y)
            {
                first = A;
                second = B;
                funk = Y;
            }
            public void Read(double a, double b, double y)
            {
                first = a;
                second = b;
                funk = y;
                root();
            }
            public void root()
            {
                if (first != 0) x = (funk - second) / first;
                Display();
            }
            public void Display()
            {
                Console.WriteLine("Значение х : {0}", x);
                Console.ReadKey();
            }
        }
    }
}
