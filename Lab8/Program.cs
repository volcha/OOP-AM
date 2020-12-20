using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8 {
    class Stack<T> {
        List<T> obj = new List<T>();
        public void Push(T a) {
            if (a == null) {
                throw new ArgumentNullException(nameof(a));
            }
            obj.Add(a);
        }
        public int count => obj.Count;
        public T Pop() {
            T a = obj.LastOrDefault();
            if (a == null) {
                throw new NullReferenceException("Stack is empty");
            }
            obj.RemoveAt(count - 1);
            return a;
        }
        public T Pop(int n) {
            T a = obj[n];
            obj.RemoveAt(n);
            return a;
        }
    }
    class Program {
        static void Main() {
            Stack<int> st1 = new Stack<int>();
            st1.Push(202);
            st1.Push(67);
            st1.Push(-80);
            st1.Push(208);
            Console.WriteLine("There is {0} int objects", st1.count);
            int p1 = st1.Pop(2);
            Console.WriteLine("Element {0} was removed", p1);
            p1 = st1.Pop(0);
            Console.WriteLine("Element {0} was removed", p1);
            Console.WriteLine("There is {0} int objects", st1.count);
            Stack<double> st2 = new Stack<double>();
            st2.Push(46.8);
            st2.Push(-3.1);
            st2.Push(-6.6);
            st2.Push(381.86);
            st2.Push(0.001);
            Console.WriteLine("There is {0} double objects", st2.count);
            double p2;
            int c = st2.count;
            for (int i = 0; i < c - 2; ++i) {
                p2 = st2.Pop(2);
                Console.WriteLine("Element {0} was removed", p2);
            }
            Console.WriteLine("There is {0} double objects", st2.count);
            Stack<string> st3 = new Stack<string>();
            st3.Push("Timofeeva");
            st3.Push("Merculov");
            st3.Push("Pavlovich");
            Console.WriteLine("There is {0} string objects", st3.count);
            string p3;
            c = st3.count;
            for (int i = 0; i < c; ++i) {
                p3 = st3.Pop();
                Console.WriteLine("Element {0} was removed", p3);
            }
            Console.WriteLine("There is {0} string objects", st3.count);
        }
    }
}
