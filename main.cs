using System;

class Program {
  public static void Main (string[] args) {
      System.Random random = new System.Random();
        // This function accepts user input
        double numA;
        double numB;

    Console.Write("This is a multiplication calculator. Enter two numbers below...");
    Console.WriteLine("");
    Console.Write("Enter a number:");
    numA = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter another number: ");
    numB = Convert.ToDouble(Console.ReadLine());
    
    double product = 0; 
    double counter = 0;
      
    while ( counter < Math.Abs(numB)) 
    {   counter++;
        product = product + Math.Abs(numA);
    }
    if ((numA < 0 && numB > 0) || (numB < 0 && numA > 0) )
        Console.WriteLine("-" + product);
    else
        Console.WriteLine(product);
    Console.WriteLine("");
    Console.Write("/Done");
  }
}