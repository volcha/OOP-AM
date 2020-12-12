using System;

namespace Lab7 {
    class Server {
        public Server() { }
        public int[] numbers = new int[10];
        public void analysis(int a) {
            if (a == 0) { ++numbers[0]; }
            int copy = a;
            while (a > 0) {
                ++numbers[a % 10];
                a = a / 10;
            }
            for (int i = 0; i < 10; ++i) {
                if (numbers[i] > 0) { Console.WriteLine("В числе {0} {1} цифр(а/ы) {2}", copy, numbers[i], i); }
            }
        }
        public void func() { Console.WriteLine("Server method"); }
    }
    static class Utility { //сервис
        static public void func() { Console.WriteLine("Utility method"); }
    }
    class Client {
        public Client() { }
        public void serv(Server s) {
            Console.Write("Client requests a function from "); 
            s.func();
            s.analysis(346937418);
        }
        public void utili() {
            Console.Write("Client requests a function from ");
            Utility.func();
        }
    }
    class Program{
        static void Main() {
            Server s = new Server();
            Client c = new Client();
            c.serv(s);
            c.utili();
            Utility.func();
        }
    }
}
