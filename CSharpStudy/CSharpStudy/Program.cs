using System;
using System.Collections.Generic;
using FirstLibrary;

namespace CSharpStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            calc.PrintHello();
            Console.WriteLine(calc.Plus(10, 20));

            FirstClass first = new FirstClass();
            first.FirstClassPrint();
        }
        void study06()
        {
            // 1 2 3 4 5 6 7 8 9 10
            //List<int> list = new List<int>();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);

            //foreach (var num in list)
            //{
            //    Console.WriteLine(num);
            //}

            //var list = new List<string>();
            //list.Add(1);

            //var list = new List<string>()
            //{
            //    "text1",
            //    "text2",
            //    "text3",
            //    "text4"
            //};

            //foreach(var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            var list = new List<User>() {
                new User()
        {
            No = 1,
                    Name = "임똘똘"
                },
                new User()
        {
            No = 2,
                    Name = "권똘똘"
                }
    };

            foreach(var user in list)
            {
                Console.WriteLine("번호 : " + user.No + " 이름 : " + user.Name);
            }
        }
    }
}
