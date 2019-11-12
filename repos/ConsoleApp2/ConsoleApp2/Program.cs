using System;

namespace ConsoleApplication
{
    public struct foo
    {
        public foo(double arg) { this.y = arg; }
        public double y;
    }
    public class bar
    {
        public bar(double arg) { this.y = arg; }
        public double y;
    }
    class Class1
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("starting struct loop...");
            for (int i = 0; i < 90000000; i++)
            { foo test = new foo(3.14); }
            
            System.Console.WriteLine("struct loop complete. starting object loop...");
            
            for (int i = 0; i < 90000000; i++)
            { bar test2 = new bar(3.14); }
            
            System.Console.WriteLine("All done");
            Console.ReadLine();
        }
    }
}