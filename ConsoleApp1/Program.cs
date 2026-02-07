using System;

class Program {
  static void Main() {

    // First task with calculating natural numbers
    // basA is the base, exponent is the power
    int baseA, exponent;
        
    Console.Write("Enter baseA: ");
    baseA = int.Parse(Console.ReadLine());
    Console.Write("Enter exponent: ");
    exponent = int.Parse(Console.ReadLine());

    long result = 1;
    int count = 0;

    while (count < exponent) {
      result *= baseA;
      ++count;
    }

    // The second task involves crossing out the second digit
    // initialNumber - the initial number
    string initialNumber;
    Console.Write("Enter start (> 2 digits): ");
    initialNumber = Console.ReadLine();

    // Check: the number must be three digits or more
    int limit = 3;
    if (initialNumber.Length < limit) {
      Console.WriteLine("The number must contain more than two digits!");
      return;
    }

    // Take the second digit (index 1, since the count starts from 0)
    char secondDigit;
    secondDigit = initialNumber[1];

    // Remove the second digit: first part (before) + third and further
    string removedSecond;
    removedSecond = initialNumber.Remove(1, 1);

    // Add the second digit to the end
    string newString;
    newString = removedSecond + secondDigit;

    // Convert the result to a number
    int endNumber;
    endNumber = int.Parse(newString);

    Console.WriteLine($"Result: {result}");
    Console.WriteLine($"End number: {endNumber}");
  }
}