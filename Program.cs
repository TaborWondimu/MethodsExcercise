using System;
namespace MethodExercise
{
    internal class Program
    {
        private static void Main (string[] args)
        {
           /*Console.WriteLine("What is your Name?");
              string userName = Console.ReadLine();

              Console.WriteLine("What is your favourite Color?");
              string userColor = Console.ReadLine();

              Console.WriteLine("What is your favourite Animal?");
              string Animal = Console.ReadLine();

              Console.WriteLine("what is your favourite Band?");
              string Band = Console.ReadLine();
              Console.WriteLine($" There was a guy named {userName}\n whose favourite color is {userColor}\n his favourite animal is {Animal}\n his favourite band is {Band}");
            */
              Console.WriteLine("give me a number to add");
              int num1 = int.Parse(Console.ReadLine());

              Console.WriteLine("give the other number to be added");
              int num2 = int.Parse(Console.ReadLine());

              int add = Add(num1, num2);
              Console.WriteLine($"sum is : {add}");

              Console.WriteLine("give me a number to subtract");
              num1 = int.Parse(Console.ReadLine());

              Console.WriteLine("Subtract by");
              num2 = int.Parse(Console.ReadLine());
  
              int subtract = Subtract(num1, num2);
              Console.WriteLine($"Difference is : {subtract}");

              Console.WriteLine("give me a number to multiply");
              num1 = int.Parse(Console.ReadLine());

              Console.WriteLine("multiply by");
              num2 = int.Parse(Console.ReadLine());

              int multiply = Multiply(num1, num2);
              Console.WriteLine($"product is : {multiply}");


              Console.WriteLine("give me a number to divide");
              num1 = int.Parse(Console.ReadLine());

              Console.WriteLine("divide by");
              num2 = int.Parse(Console.ReadLine());

              int divide = Divide(num1, num2);
              Console.WriteLine($"answer is : {divide}");

              Console.WriteLine("give me a number to perform modulus");
              num1 = int.Parse(Console.ReadLine());

              Console.WriteLine("give me the other name");
              num2 = int.Parse(Console.ReadLine());

              int modulus = Modulus(num1, num2);
              Console.WriteLine($"answer is : {modulus}");
  }
        public static int Add(params int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];

                }
            return sum;
        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
        public static int Modulus(int num1, int num2)
        {
            return  num1%num2;
        }
    }
}