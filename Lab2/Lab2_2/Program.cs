using System;

namespace Lab2_2 {
    class A {
        public class B {
            public class D {
                public D() { }
                public void print() {
                    Console.WriteLine("method of D");
                }
            }
            D objD = null;
            public D d {
                get {
                    Console.Write("-> d ");
                    return objD;
                }
            }
            public B() {
                objD = new D();
            }
            public void print() {
                Console.WriteLine("method of B");
            }
        }
        public class C {
            public class E {
                public E() { }
                public void print() {
                    Console.WriteLine("method of E");
                }
            }
            public class F {
                public F() { }
                public void print() {
                    Console.WriteLine("method of F");
                }
            }
            public class K {
                public K() { }
                public void print() {
                    Console.WriteLine("method of K");
                }
            }
            E objE = null;
            F objF = null;
            K objK = null;
            public E e {
                get {
                    Console.Write("-> e ");
                    return objE;
                }
            }
            public F f {
                get {
                    Console.Write("-> f ");
                    return objF;
                }
            }
            public K k {
                get {
                    Console.Write("-> k ");
                    return objK;
                }
            }
            public C() {
                objE = new E();
                objF = new F();
                objK = new K();
            }
            public void print() {
                Console.WriteLine("method of C");
            }
        }
        public class J {
            public J() { }
            public void print() {
                Console.WriteLine("method of J");
            }
        }
        B objB = null;
        C objC = null;
        J objJ = null;
        public B b {
            get {
                Console.Write("a -> b ");
                return objB;
            }
        }
        public C c {
            get {
                Console.Write("a -> c ");
                return objC;
            }
        }
        public J j {
            get {
                Console.Write("a -> j ");
                return objJ;
            }
        }
        public A() {
            objB = new B();
            objC = new C();
            objJ = new J();
        }
        public void print() {
            Console.WriteLine("method of A");
        }
    }
    class Program {
        static void Main() {
            A objA = new A();
            objA.print();
            objA.b.print();
            objA.b.d.print();
            objA.c.print();
            objA.c.e.print();
            objA.c.f.print();
            objA.c.k.print();
            objA.j.print();
        }
    }
}