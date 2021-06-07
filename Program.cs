using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3 types of built in delegates- func, action, predicate
//syntax for generic delegate- delegate T demo<T>(T n);
//output will always be in form of function delegate
//action delegate does not return any value
//predicate delegate takes 1 parameter and return boolean value

//NOTE- follow format for 3 types of generic delegate (written in copy)
namespace generic_delegates
{
    class Program
    {

        //make static methods

        public static double Demo1(int x, float y, double z)    //for function delegate         
        {
            return x + y + z;
        }

        public static void Demo2(int x, float y, double z)               //for action delegate
        {
            Console.WriteLine(x + y + z);
        }

        public static bool Demo3(string name)
        {
            if (name.Length > 3)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            //make function delegate
            Func<int, float, double,double> obj1 = new Func<int, float, double,double>(Demo1);
            double result = obj1.Invoke(20, 40.09f, 3930.008);
            Console.WriteLine(result);




            //action delegate
            
             Action<int, float, double> obj2 = new Action<int, float, double>(Demo2);
            obj2.Invoke(50, 40.07f, 4940.08);
            
          


            //predicate delegate
            Predicate<string> obj3 = new Predicate<string>(Demo3);
            bool result3 = obj3.Invoke("roshi");
            Console.WriteLine(result3);
            Console.ReadLine();
        }
    }
}
    
       