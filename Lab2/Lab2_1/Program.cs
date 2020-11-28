using System;

namespace Lab2_1 {
    class J {
        public J() { }
        public void print() {
            Console.WriteLine("method of J");
        }
    }
    class D {
        public D() { }
        public void print() {
            Console.WriteLine("method of D");
        }
    }
    class E {
        public E() { }
        public void print() {
            Console.WriteLine("method of E");
        }
    }
    class F {
        public F() { }
        public void print() {
            Console.WriteLine("method of F");
        }
    }
    class K {
        public K() { }
        public void print() {
            Console.WriteLine("method of K");
        }
    }
    class B {
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
    class C {
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
    class A {
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
            K objK = new K();
            F objF = new F();
            E objE = new E();
            D objD = new D();
            J objJ = new J();
            C objC = new C();
            B objB = new B();
            objA.print();
            objB.print();
            objA.b.print();
            objD.print();
            objA.b.d.print();
            objC.print();
            objA.c.print();
            objE.print();
            objA.c.e.print();
            objF.print();
            objA.c.f.print();
            objK.print();
            objA.c.k.print();
            objJ.print();
            objA.j.print();
        }
    }
}