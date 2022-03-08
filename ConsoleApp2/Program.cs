
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Person
    {
        public int age;
    }

    struct location
    {
        public int x, y;
        public location(int a, int b)
        {
            x = a;
            y = b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var a = new location(10, 20);
            //var b = a;
            //a.x = 100;
            //Console.WriteLine(b.x);
            //Console.ReadKey();

            Person p1 = new Person();
            Person p2 = new Person();
            p1.age = 5;
            p2.age = 10;
            Console.WriteLine(p1.age + " " + p2.age);
            Square(p1, p2);
            Console.WriteLine(p1.age + " " + p2.age);

            Console.WriteLine("----------------");

            int num1 = 5;
            int num2 = 10;
            Console.WriteLine(num1 + " " + num2);
            Squarest(num1, num2);
            Console.WriteLine(num1 + " " + num2);


            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();

            //var dd = new Program();
            //var tNum = new int[4] { 1, 2, 3, 4 };

            //var ss = dd.NewArray(tNum);
        }
        static void Square(Person a, Person b)
        {
            a.age = a.age * a.age;
            b.age = b.age * b.age;
            Console.WriteLine(a.age + " " + b.age);
        }

        static void Squarest(int a, int b)
        {
            a = a * a;
            b = b * b;
            Console.WriteLine(a + " " + b);
        }






        public int[] NewArray(int[] nums)
        {
            var rs = new int[nums.Length];

            var pdt = 1;
            for (var i = 0; i < nums.Length; i++)
            {
                rs[i] = pdt;
                pdt = pdt * nums[i];
            }

            var pt2 = 1;
            for (var j = nums.Length - 1; j >= 0; j--)
            {
                rs[j] = rs[j] * pt2;
                pt2 = pt2 * nums[j];
            }

            return rs;
        }
    }
}
