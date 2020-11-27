using System;

namespace Lab1_1 {
    class Function {
        public static int GetMin(int[] array) { //ищет минимальное число в массиве
            int min = array[0];
            for (int i = 1; i < array.Length; ++i) {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }
        public int GetMax(int[] array) { //ищет максимальное число в массиве
            int max = array[0];
            for (int i = 1; i < array.Length; ++i) {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }
        public static void factorial(int n) {
            if (n < 0)
                Console.WriteLine("Некоректно введённые данные");
            else {
                int f = 1;
                for (int i = 2; i <= n; ++i) {
                    f = f * i;
                }
                Console.WriteLine($"Факториал = {f}");
            }
        }
        public void simple(int n) {
            int fals = 0;
            for (int i = 2; i <= n / 2; ++i) {
                Console.WriteLine(n % i);
                if (n % i == 0) {
                    fals++;
                    Console.WriteLine("Число не простое");
                    break;
                }
            }
            if (fals == 0)
                Console.WriteLine("Число простое");
        }
    }
    class Greeting {
        string str;
        public Greeting() {
            str = "Hello";
        }
        public Greeting(string str) {
            this.str = str;
        }
        public void print() {
            Console.WriteLine(str);
        }
    }
    class Program{
        static void Main() {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; ++i) {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = Function.GetMin(numbers);
            Console.WriteLine($"Минимальное число = {min}");
            Function max = new Function();
            Console.WriteLine($"Максимальное число = {max.GetMax(numbers)}");
            int fact = Convert.ToInt32(Console.ReadLine());
            Function.factorial(fact);
            int num = Convert.ToInt32(Console.ReadLine());
            Function obj = new Function();
            obj.simple(num);

            Greeting g, g1, g2, g3;
            g = new Greeting();
            g1 = new Greeting("Good morning");
            g2 = new Greeting("Good evening");
            g3 = new Greeting("Good night");
            g.print();
            g1.print();
            g2.print();
            g3.print();
        }
    }
}