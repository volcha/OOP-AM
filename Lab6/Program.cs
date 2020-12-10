using System;

namespace Lab6 {
    class Profbureau {
        public Profbureau() { Sveta = null; }
        public Profbureau(Proforg a) { Sveta = a; a.Yana = this; }
        public void party() { Console.WriteLine("Организовать вечеринку"); }
        public Proforg Sveta { set; get; }
    }
    class Proforg {
        public Proforg() { Yana = null; }
        public Proforg(Profbureau a) { Yana = a; a.Sveta = this; }
        public void docs() { Console.WriteLine("Собрать документы"); }
        public Profbureau Yana { set; get; }
    }
    class Headman {
        private int N = 0;
        public Students[] st = null;
        private int size = 0;
        public Headman() {
            N = 3;
            this.st = new Students[N];
        }
        public Headman(int N) {
            this.N = N;
            this.st = new Students[N];
        }
        public int phone = 38483992;
        public void setStudent(Students a) { if (size < N) { this.st[size] = a; ++size; } }
    }
    class Students {
        public Students() { }
        public Students(Headman a) { a.setStudent(this); Nat = a; }
        public int phone;
        public Headman Nat { set; get; }
    }
    class Program {
        static void Main() {
            Profbureau prb = new Profbureau();
            Proforg pro = new Proforg();
            prb.Sveta = pro;
            pro.Yana = prb;
            prb.Sveta.Yana.party();
            prb.Sveta.docs();
            Headman starosta = new Headman(5);
            Students s1 = new Students(starosta);
            s1.phone = 356373;
            Students s2 = new Students(starosta);
            s2.phone = 583992;
            Students s3 = new Students(starosta);
            s3.phone = 938384;
            Students s4 = new Students();
            s4.phone = 483920;
            starosta.setStudent(s4);
            s4.Nat = starosta;
            Students s5 = new Students();
            s5.phone = 293884;
            starosta.setStudent(s5);
            s5.Nat = starosta;
            for (int i = 0; i < 4; ++i) {
                Console.WriteLine("Студент {0}, номер телефона {1}", i + 1, starosta.st[i].phone);
            }
            Console.WriteLine("Студент {0}, номер телефона {1}", 5, s1.Nat.st[4].phone);
            Console.WriteLine("Телефон старосты {0}",s5.Nat.phone);
        }
    }
}
