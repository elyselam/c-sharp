using System;

namespace Calculator {
    class Program {
        static void Main(string[] args) {
            Console.Write("enter a number");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("enter operator");
            string op = Console.ReadLine();

            Console.Write("enter a number");
            int num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+") {
                Console.Write(num1 + num2);
            } else if (op == "-") {
                Console.Write(num1 - num2);
            } else if (op == "/") {
                Console.Write(num1 / num2);
            } else if (op == "*") {
                Console.Write(num1 * num2);
            } else {
                Console.WriteLine("invalid operator");
            }

            Console.ReadLine();
        }
    }
}