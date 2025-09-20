using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Выберите одну операцию: +, -, *, /, !, степень, квадратный корень");
        string oper = Console.ReadLine();
        if (oper != "степень")
        {
            Console.WriteLine("Введите число или числа через пробел:");
        }
        else
        {
            Console.WriteLine("Снавала введите основание степени, затем показатель через пробел:");
        }

        string a = Console.ReadLine();
        string[] nums = a.Split(' ');
        int[] numbers = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            numbers[i] = Convert.ToInt32(nums[i]);
        }

        if (numbers.Length == 2)
        {
            if (oper == "+") Console.WriteLine(numbers[0] + numbers[1]);
            else if (oper == "-") Console.WriteLine(numbers[0] - numbers[1]);
            else if (oper == "*") Console.WriteLine(numbers[0] * numbers[1]);
            else if (oper == "/") Console.WriteLine(numbers[0] / numbers[1]);
            else if (oper == "степень")
            {
                double d1 = Convert.ToDouble(numbers[0]);
                double d2 = Convert.ToDouble(numbers[1]);
                Console.WriteLine(Math.Pow(d1, d2));
            }

        }
        else if (numbers.Length == 1)
        {
            if (oper == "!")
            {
                int s = 1;
                for (int i = 1; i <= numbers[0]; i++)
                {
                    s *= i;
                }
                Console.WriteLine(s);
            }
            else if (oper == "квадратный корень")
            {
                double d1 = Convert.ToDouble(numbers[0]);
                Console.WriteLine(Math.Sqrt(d1));
            }
        }
    }
}