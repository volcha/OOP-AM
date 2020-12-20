using System;
using System.Collections.Generic;

namespace Lab9_2_Lambda {
    class Program {
        delegate bool Bi(int x);
        public delegate void Lambda(int x, int y);
        static void Main() {
            List<int> numbers = new List<int>() { -10, 0, -46, 19, 1024 };
            Bi positive = x => x > 0;
            int index = numbers.FindIndex(x => x > 0);
            Console.WriteLine(numbers[index]);
            Lambda lambda = (x, y) => Console.WriteLine(x * y);
            lambda(5, -11);
            Func<double, double> f = x => x * -1;
            Console.WriteLine(f(31.345));
            Action a = () => Console.WriteLine("Action!");
            a();
        }
    }
}
