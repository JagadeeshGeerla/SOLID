using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
           // BaseClass objBase = new BaseClass();
           //BaseClass.strStatic = "statttttt";
            Console.WriteLine(BaseClass.strStatic);
            BaseClass.Display();
                      
            Console.ReadKey();
        }
    }

    abstract class DataProvider
    {
        public abstract void hello();
        public void thereis()
        {
            Console.WriteLine("d");
        }

    }

   interface IInterface
    {
         void Hee();

    }

    class BaseClass
    {
        public static void Display()
        {
            Console.WriteLine("Display BaseClass");
        }

        public static string strStatic;
        static BaseClass( )
        {
            strStatic = "str";

            Console.WriteLine($"Inside baseclass ctor {strStatic}");        

        }
    }

    //class SubClass : BaseClass
    //{
    //    public override void Display()
    //    {
    //        Console.WriteLine("Display SubClass");
    //    }
    //}
}
