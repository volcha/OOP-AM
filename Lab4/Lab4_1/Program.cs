using System;

namespace Lab4_1 {
    class Program {
        interface Animal {
            void protection_status();
        }
        interface Habits {
            void food();
            void place();
        }
        class Tiger : Animal {
            public Tiger() { }
            public void protection_status() { Console.WriteLine("Endangered species"); }
            virtual public void color() { Console.WriteLine("Red"); }
        }
        class WhiteTiger : Tiger {
            public WhiteTiger() { }
            override public void color() { Console.WriteLine("White"); }
        }
        class Kitten : WhiteTiger {
            public Kitten() { }
            public void noise() { Console.WriteLine("Meow"); }
            public int quantity { get; set; }
        }
        class Bird {
            public int speed { get; set; }
            public Bird() { }
            public Bird(int num) {
                speed = num;   
            }
            public void features() {
                Console.WriteLine("Birds have wings and beak");
            }
        }
        class Goose : Bird, Animal {
            public Goose() { }
            public Goose(int num):base(num) { }
            public void protection_status() { Console.WriteLine("Out of danger"); }
            virtual public void swim() { Console.WriteLine("Goose like to swim"); }
        }
        class Sparrow : Goose, Habits {
            public Sparrow() { }
            public void food() { Console.WriteLine("Bread"); }
            public void place() { Console.WriteLine("City"); }
            override public void swim() { Console.WriteLine("Sparrow doesn't like to swim"); }
            public void size() { Console.WriteLine("Small"); }
        }
        static void Main() {
            Tiger Amur = new Tiger();
            Amur.protection_status();
            Amur.color();
            WhiteTiger Timur = new WhiteTiger();
            Timur.protection_status();
            Timur.color();
            Kitten Mur = new Kitten();
            Mur.protection_status();
            Mur.color();
            Mur.noise();
            Mur.quantity = 3;
            Console.WriteLine("This quantity of kitten of white tiger is {0}", Mur.quantity);
            Goose Grey = new Goose(10);
            Grey.protection_status();
            Grey.features();
            Console.WriteLine(Grey.speed);
            Grey.swim();
            Sparrow Captain = new Sparrow();
            Captain.protection_status();
            Captain.features();
            Captain.speed = 7;
            Console.WriteLine("Speed of Captain is {0}", Captain.speed);
            Captain.food();
            Captain.place();
            Captain.swim();
            Captain.size();
        }
    }
}
