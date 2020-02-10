using System;

namespace variables
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Number of cups of coffee");

      var numberOfCupsOfCoffee = "1";

      var fullName = "chez balogh";

      var today = "2/10/20";

      Console.WriteLine(numberOfCupsOfCoffee + " " + fullName + " " + today);

      Console.WriteLine("what is your name?");
      var user = Console.ReadLine();
      Console.WriteLine("hello: " + user);

      Console.WriteLine("pick a number");
      var operand1 = double.Parse(Console.ReadLine());
      Console.WriteLine("Pick a second number");
      var operand2 = double.Parse(Console.ReadLine());

      var sum = operand1 + operand2;
      var difference = operand1 - operand2;
      var quotient = operand1 / operand2;
      var product = operand1 * operand2;
      var remainder = operand1 % operand2;

      Console.WriteLine("the sum of your two numbers is " + sum);
      Console.WriteLine("the difference of your two numbers is " + difference);
      Console.WriteLine("the quotient of your two numbers is " + quotient);
      Console.WriteLine("the product of your two numbers is " + product);
      Console.WriteLine("the remainder of your two numbers is " + remainder);













    }
  }
}
