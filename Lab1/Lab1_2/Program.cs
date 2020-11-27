using System;

namespace Lab1_2 {
    class Program {
        class A {
            B objB = null;
            public B b {
                get {
                    Console.Write("a -> b ");
                    return objB;
                }
            }
            C objC = null;
            public C c {
                get {
                    Console.Write("a -> c ");
                    return objC;
                }
            }
            J objJ = null;
            public J j {
                get {
                    Console.Write("a -> j ");
                    return objJ;
                }
            }
            public A(B b, C c, J j) {
                objB = b;
                objC = c;
                objJ = j;
            }
            public void methA() {
                Console.WriteLine("hash={0} Method A", this.GetHashCode());
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
            public B(D d) {
                objD = d;
            }
            public void methB() {
                Console.WriteLine("hash={0} Method B", this.GetHashCode());
            }
        }
        class C {
            E objE = null;
            public E e {
                get {
                    Console.Write("-> e ");
                    return objE;
                }
            }
            F objF = null;
            public F f {
                get {
                    Console.Write("-> f ");
                    return objF;
                }
            }
            K objK = null;
            public K k {
                get {
                    Console.Write("-> k ");
                    return objK;
                }
            }
            public C(E e, F f, K k) {
                objE = e;
                objF = f;
                objK = k;
            }
            public void methC() {
                Console.WriteLine("hash={0} Method C", this.GetHashCode());
            }
        }
        class J {
            public J() { }
            public int vJ = 0;
            public J(int val) {
                vJ = val;
            }
            public void methJ() {
                Console.WriteLine("hash={0} Method J", this.GetHashCode());
            }
        }
        class D {
            public D() { }
            public int vD = 7;
            public D(int val) {
                vD = val;
            }
            public void methD() {
                Console.WriteLine("hash={0} Method D", this.GetHashCode());
            }
        }
        class E {
            public E() { }
            public int vE = 202;
            public E(int val) {
                vE = val;
            }
            public void methE() {
                Console.WriteLine("hash={0} Method E", this.GetHashCode());
            }
        }
        class F {
            public F() { }
            public int vF = 67;
            public F(int val) {
                vF = val;
            }
            public void methF() {
                Console.WriteLine("hash={0} Method F", this.GetHashCode());
            }
        }
        class K {
            public K() { }
            public int vK = 31;
            public K(int val) {
                vK = val;
            }
            public void methK() {
                Console.WriteLine("hash={0} Method K", this.GetHashCode());
            }
        }
        static void Main() {
            K objK = new K();
            F objF = new F();
            E objE = new E();
            D objD = new D();
            J objJ = new J();
            C objC = new C(objE, objF, objK);
            B objB = new B(objD);
            A objA = new A(objB, objC, objJ);
            objA.methA();
            objB.methB();
            objA.b.methB();
            objC.methC();
            objA.c.methC();
            objJ.methJ();
            objA.j.methJ();
            objD.methD();
            objA.b.d.methD();
            objE.methE();
            objA.c.e.methE();
            objF.methF();
            objA.c.f.methF();
            objK.methK();
            objA.c.k.methK();
        }
    }
}