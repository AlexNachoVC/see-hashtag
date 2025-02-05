namespace Calculator
{
    public class CalculatorClass
    {
        public static void Explore()
        {
            double num1 = 0;
            double num2 = 0;
            double result = 0;
            char option;

            Console.WriteLine("------------------");
            Console.WriteLine("Calculator Program");
            Console.WriteLine("------------------");

            Console.WriteLine("Enter number 1: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an option: ");
            Console.WriteLine("+ : Add");
            Console.WriteLine("- : Subtract");
            Console.WriteLine("* : Multiply");
            Console.WriteLine("/ : Divide");
            option = Convert.ToChar(Console.ReadLine());

            switch (option)
            {
                case '+':
                    Console.WriteLine("Result = " + (num1 + num2) );
                    break;
                case '-':
                    Console.WriteLine("Result = " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("Result = " + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine("Result = " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

        }
    }
}