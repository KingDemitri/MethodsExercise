using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    internal class Methods

    {
        //private static int items;

        public static int Add(int num1, int num2)
        {

            int sum = num1 + num2;
            return sum;

        }

        public static void Multiply(int num1, int num2)
        {

            var answer = num1 * num2;
            Console.WriteLine($"{num1 * num2} = {answer}");

    }

        public static int Subtract(int num1, int num2)
        {

            int sum = num1 - num2;
            return sum;


        }
        public static int Divide(int num1, int num2)
        {

            int sum = num1 / num2;
            return sum;

        }

        public static void AddWithParam(params int[] numbers)
        {

            int sum = 0;
            foreach (var num in numbers)
            {
                sum = sum + num;
        }
            Console.WriteLine(sum);
        }


    }
}
