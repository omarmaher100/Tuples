using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    class Program
    {
        static (string, string, int) MyData()
        {
            return ("Omar", "maher", 123456);
        }

        static (string firstName, string lastName, int password) MyData2()
        {
            return ("Omar", "maher", 123456);
        }

        static void Main(string[] args)
        {
            //  (var firstName, var lastName, var password) = MyData2();
            var (firstName, lastName, password) = MyData2();

            Console.WriteLine($"My name is {firstName} " +
                 $"{ lastName} and my password is " +
                 $"{ password}");




            #region MyData2
            //var userData2 = MyData2();
            //Console.WriteLine($"My name is { userData2.firstName} " +
            //    $"{ userData2.lastName} and my password is " +
            //    $"{ userData2.password}");

            //Console.WriteLine($"My name is { userData2.Item1} " +
            //    $"{ userData2.Item2} and my password is " +
            //    $"{ userData2.Item3}");
            #endregion

            #region MyData
            //var userData = MyData();
            //Console.WriteLine($"My name is { userData.Item1} " +
            //    $"{ userData.Item2} and my password is " +
            //    $"{ userData.Item3}");
            #endregion

        }
    }
}
