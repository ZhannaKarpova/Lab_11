using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class MyClass
    {
        static void ShowEmployee()
        {
            new Equalissation();
        }
        struct Equalissation { }

        private double first;
        private double second;
        private double funk;
        private double x;

        public MyClass(double k, double b)
        {
            first = k;
            second = b;
            funk = 0;
        }
        public void Read(double k, double b)
        {
            first = k;
            second = b;
            funk = 0;
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
    class myProgram
    {
        static void Main(string[] args)
        {

            MyClass qwr = new MyClass(0, 0);
            Console.Write("Введите значение k: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение b: ");
            double j = 0;
            double s = Convert.ToDouble(Console.ReadLine());
            qwr.Read(h,s);

        }
    } }
