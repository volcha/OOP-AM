using System;

namespace Lab9_1_delegate {
    class Program {
        public delegate void TypeD1(int a, double b);
        public delegate int TypeD2(string s, int a);
        public delegate void Anon();
        public delegate int Fact(int a);
        static void Main() {
            TypeD1 deleg1 = Max;
            TypeD1 dlg1 = new TypeD1(Max);
            if (deleg1.Equals(dlg1)) { Console.WriteLine("Equals"); }
            else { Console.WriteLine("Not equals"); };
            Console.WriteLine(dlg1.Method.ToString());
            deleg1(3, 5.833);
            deleg1.Invoke(44, 39.5);
            deleg1 = Same;
            if (deleg1.Equals(dlg1)) { Console.WriteLine("Equals"); }
            else { Console.WriteLine("Not equals"); };
            deleg1(3, 3.98);
            deleg1(74, 12.2);
            Console.WriteLine();

            TypeD2 deleg2 = Len;
            TypeD2 dlg2 = new TypeD2(Len);
            if (deleg2.Equals(dlg2)) { Console.WriteLine("Equals"); }
            else { Console.WriteLine("Not equals"); };
            Console.WriteLine(dlg2.Method.ToString());
            int print = deleg2("Sfwgfsa", 9);
            Console.WriteLine(print);
            deleg2 = Word;
            if (deleg2.Equals(dlg2)) { Console.WriteLine("Equals"); }
            else { Console.WriteLine("Not equals"); };
            Console.WriteLine(deleg2("I am tired", 5));
            Console.WriteLine(deleg2("I am tired", 12));
            Console.WriteLine(deleg2("I am tired", 4));
            Console.WriteLine(deleg2("I am tired", 6));
            Console.WriteLine();

            deleg1 += Max;
            deleg1(2, 2.02);
            Delegate[] dlg_list = deleg1.GetInvocationList();
            for (int i = 0; i < dlg_list.Length; ++i){
                Console.WriteLine(dlg_list[i].Method.ToString());
            }
            Console.WriteLine();

            deleg2 += Len;
            Console.WriteLine(deleg2("I am tired", 7));
            dlg_list = deleg2.GetInvocationList();
            for (int i = 0; i < dlg_list.Length; ++i) {
                Console.WriteLine(dlg_list[i].Method.ToString());
            }
            Console.WriteLine();

            Anon a = delegate () {
                Console.WriteLine("Anonymous method");
            };
            a();
            Fact fa = delegate (int n) {
                if (n < 0) return -1;
                else {
                    int f = 1;
                    for (int i = 2; i <= n; ++i) {
                        f = f * i;
                    }
                    return f;
                }
            };
            Console.WriteLine(fa(11));
            Console.WriteLine();

            Func<int, int> f = delegate (int a) {
                int res = 0;
                while (a > 0) {
                    res = res * 10 + a % 10;
                    a /= 10;
                }
                return res;
            };
            Console.WriteLine(f(35681));
        }
        public static void Max(int a, double b) {
            if (a > b) { Console.WriteLine("{0} больше {1}", a, b); }
            else { Console.WriteLine("{0} больше {1}", b, a); }
        }
        public static void Same(int a, double b) {
            if (a == (int)b) { Console.WriteLine("Идентичны"); }
            else { Console.WriteLine("Не идентичны"); }
        }
        public static int Len(string s, int a) {
            if (s.Length == a) { return 0; }
            else { return s.Length - a; }
        }
        public static int Word(string s, int a) {
            if (a > s.Length) { return -1; }
            else if (s[a-1] == ' ') { return 0; }
            else {
                int k = 1;
                for (int i = 0; i < a; ++i) {
                    if (s[i] == ' ') {
                        ++k;
                    }
                }
                return k;
            }
        }
    }
}
