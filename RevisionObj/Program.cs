using System;

namespace RevisionObj
{
    
    class A 
    {
        public string s = "hello world";
        public static int reponseatouteslesquestion = 42; 
        public string name =" "; 

        public A()
        {
             s = "bye bye";
        }

        public A(string news)
        {
            s = news;
        }

        public A(string news, string newname)
        {
            s = news;
            name = newname;
        }

        public override string ToString()
        {
            return s;
        }

        public void test(string ss)
        {
            Console.WriteLine(ToString() + " " + ss);
        }

        public void parle(A autre)
        {
            Console.WriteLine("Je suis l'objet " + name + " et je parle à l'objet " + autre.name); // methode pour faire communiquer deux objet distincs
            autre.pense();
        }

        public void pense()
        {
            Console.WriteLine("je suis " + name + " c'est qui ce " + s + " ?");
        }

        public static void testclass()
        {
            new A().test("tout le monde");
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

            A a; //On crée un instance 
            a = new A("", "Theo"); // on ajoute une string a l'instance

            // Console.WriteLine(new A().ToString());
            // Console.WriteLine(a.s);
            // a.test("Theo");
            // A.testclass();

            A aa; //On crée un instance 
            aa = new A("boulet", "Stonks"); // on ajoute une string a l'instance

            // aa.test("yaaas");

            a.parle(aa);

        }
    }
}
