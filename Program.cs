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

      Console.WriteLine("Hi! My name is " + fullName + ". I'm running on " +
      numberOfCupsOfCoffee + " cup of coffee. Today is: " + today);



      Console.WriteLine("what is your name?");
      var user = Console.ReadLine();

      if (user == "Alice")
      {
        Console.WriteLine("How was Wonderland Alice?");
      }
      else
      {
        Console.WriteLine("Nice to meet you " + user);
      }

      Console.WriteLine("Let pick two numbers... first choice?");
      var operand1 = double.Parse(Console.ReadLine());
      Console.WriteLine("Perfect! Lets pick a second number!");
      var operand2 = double.Parse(Console.ReadLine());

      var sum = operand1 + operand2;
      var difference = operand1 - operand2;
      var quotient = operand1 / operand2;
      var product = operand1 * operand2;
      var remainder = operand1 % operand2;

      Console.WriteLine("when we add your two numbers together we get: " + sum);
      Console.WriteLine("When we subtract your two numbers from each other its:  " + difference);
      Console.WriteLine("If we divide your numbers, we get: " + quotient);
      Console.WriteLine("When we multiply your numbers together we get: " + product);
      Console.WriteLine("The remainder of the two numbers when divided is: " + remainder);













    }
  }
}
