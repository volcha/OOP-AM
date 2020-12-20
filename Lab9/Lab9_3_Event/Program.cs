using System;

namespace Lab9_3_Event {
    class Publisher {
        public delegate void Account();
        public event Account BankAccount;
        int sum { get; set; } 
        public Publisher(int s) { sum = s; }
        public void Put(int s) {
            sum += s;
            if (BankAccount != null) BankAccount();
            Console.WriteLine($"На счёт положили {s}. На карте {sum}");
        }
        public void Take(int s) {
            if (sum > s) {
                sum -= s;
                if (BankAccount != null) BankAccount();
                Console.WriteLine($"Со счёта списали {s}. На карте {sum}");
            }
            else {
                if (BankAccount != null) BankAccount();
                Console.WriteLine($"Недостаточно средств. На карте {sum}");
            }
        }
    }
    class Subscriber {
        private Publisher publisher = null;
        private int value { set; get; }
        public Subscriber(Publisher p, int s) {
            publisher = p;
            value = s;
            publisher.BankAccount += Print;
        }
        void Print() {
            Console.WriteLine("Изменение баланса");
        }
        public void Put() { publisher.Put(value); }
        public void Take() { publisher.Take(value); }
    }
    class Program {
        static void Main() {
            Publisher publisher = new Publisher(1000);
            Subscriber subscriber1 = new Subscriber(publisher, 700);
            Subscriber subscriber2 = new Subscriber(publisher, 5000);
            Subscriber subscriber3 = new Subscriber(publisher, 1300);
            subscriber1.Put();
            subscriber2.Take();
            subscriber3.Take();
        }
    }
}
