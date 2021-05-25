using System;

namespace CSharpStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 1;

            while (true)
            {
                num++;

                if (num % 2 == 0)
                {
                    continue;
                }

                if (num % 3 == 0)
                {
                    Console.WriteLine(num);
                }

                if(num == 100)
                {
                    break;
                }
            }
        }
        void study02()
        {
            short shotNum = 0;

            int intNum = 0;

            double doubleNum = 0;

            float floatNum = 0;

            string stringTest = "";

            char charText = 'a';

            bool boolVal = true;

            Int16 dotNetShort = 0;

            Int32 dotNetInt = 0;

            Int64 dotNetDouble = 0;

            String dotNetString = "";

            var dynamicType = 0;

            var num1 = 1;

            var num2 = 2;

            Console.WriteLine(num1 + num2);
        }
        void study03()
        {
            var num = 1;

            Console.WriteLine("0 ~ 9 사이의 값을 입력 : ");

            var input = Console.ReadLine();

            if (num == int.Parse(input))
            {
                Console.WriteLine("같은 값을 입력했습니다!");
            }
            else
            {
                Console.WriteLine("다른 값을 입력했습니다!");
            }

            if (num == int.Parse(input))
            {
                Console.WriteLine("같은 값을 입력했습니다!");
            }
            else if (num != int.Parse(input))
            {
                Console.WriteLine("다른 값을 입력했습니다!");
            }
        }
    }
}
