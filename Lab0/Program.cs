using System;

namespace Lab1 {
    class TestClass {
        public int a;
        private int b;
        public TestClass() {
            a = 0;
            b = 0;
            Console.WriteLine("Конструктор по умолчанию");
        }
        public TestClass(int a) {
            this.a = a;
            b = 0;
            Console.WriteLine("Параметрический конструктор с одним полем");
        }
        public TestClass(int a, int b) {
            this.a = a;
            this.b = b;
            Console.WriteLine("Параметрический конструктор с двумя полями");
        }
        public TestClass(TestClass TC) {
            a = TC.a;
            b = TC.b;
            Console.WriteLine("Копирующий конструктор");
        }
        public void F() {
            Console.WriteLine("TestClass, 1");
        }
        public void F(int a) {
            Console.WriteLine("TestClass, 2");
        }
        public void F(TestClass TC) {
            Console.WriteLine("TestClass, 3");
        }
    }
    class Program {
        public void F() {
            Console.WriteLine("Program, 1");
        }
        public void F(int a) {
            Console.WriteLine("Program, 2");
        }
        public void F(Program Pro) {
            Console.WriteLine("Program, 3");
        }
        static void Main() {
            TestClass T1 = new TestClass();
            TestClass T2 = new TestClass(4);
            TestClass T3 = new TestClass(19, 2);
            TestClass T4 = new TestClass(T1);
            T4.F();
            T2.F(T1);
            T3.F(777);
            Program Pro = new Program();
            Pro.F(Pro);
            Pro.F(202);
            Pro.F();
        }
    }
}