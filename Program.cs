using System;

namespace Study_cs
{
    class Program
    {

        static float count(float first, float second, Char sign)
        {
            try
            {
                switch (sign)
                {
                    case '+':
                        return first + second;
                    case '-':
                        return first - second;
                    case '/':
                        if (second == 0f)
                        {
                            Console.Error.WriteLine("На ноль делить нельзя");
                            return Single.NaN;
                        }
                        else
                        {
                            return first / second;
                        }
                    case ':':
                        if (second == 0f)
                        {
                            Console.Error.WriteLine("На ноль делить нельзя");
                            return Single.NaN;
                        }
                        else
                        {
                            return first / second;
                        }
                    case '*':
                        return first * second;
                    case '^':
                        return Convert.ToSingle(Math.Pow(first, second));
                    default:
                        Console.Error.WriteLine("Неправильный ввод");
                        return Single.NaN;
                }
            }
            catch
            {
                Console.Error.WriteLine("Что-то не удалось посчитать");
                
            }

            return Single.NaN;
        }
        
        static void main()
        {
            Console.WriteLine("Введите выражение в формате \"первое_число знак второе_число\"");
            string input = Console.ReadLine();
            string[] splittedInput = input.Split(' ');
            float first;
            Char sign;
            float second;
            try
            {
                first = Convert.ToSingle(splittedInput[0]);
                sign = Convert.ToChar(splittedInput[1]);
                second = Convert.ToSingle(splittedInput[2]);
            }
            catch
            {
                Console.Error.WriteLine("Вы ввели что-то неправильно");
                return;
            }

            float res = count(first, second, sign);

            if (float.IsNaN(res))
            {
                
                return;
            }
            
            Console.WriteLine(res);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                main();
            }
        }
    }
}