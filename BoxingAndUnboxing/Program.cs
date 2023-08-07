using System;
namespace BoxingAndUnboxing
{
    class Program
    {


        static void Main(string[] args)
        {
            object o;//boxing is taking place here
            int x = 25;

            o = x;
            Console.WriteLine("o = " + o);
            Console.WriteLine("x = " + x);

            o = 123;
            x = (int)o;
            Console.WriteLine("o = " + o);
            Console.WriteLine("x = " + x);


        }
    }


}
