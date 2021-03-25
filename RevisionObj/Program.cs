using System;

namespace RevisionObj
{
    
    class A 
    {
        public string s = "hello world";
        public static int reponseatouteslesquestion = 42; 

        public override string ToString()
        {
            return "Coucou";
        }

        public void test(string ss)
        {
            Console.WriteLine(ToString() + " " + ss);
        }

        public static void testclass()
        {
            new A().test("Bonjour tout le monde");
        }
    }
    class Program
    {

        

        static void Main(string[] args)
        {
            // if (args.Length > 0)
            // {
            //     Console.WriteLine("hello "+ args[0] + " !");
            // }
            // Console.WriteLine("Hello World!");

            A a;
            a = new A();

            Console.WriteLine(new A().ToString());
            Console.WriteLine(a.s);
            a.test("Theo");
            A.testclass();
        }
    }
}
