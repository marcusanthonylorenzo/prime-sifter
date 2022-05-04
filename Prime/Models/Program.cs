using System;
using Prime.Models;

public class Program
{
    public static void Main()
    {
      Console.WriteLine("Type a number: ");
      int userNumber = int.Parse(Console.ReadLine()); //number = 5
      PrimeN userNumberPrimes = new PrimeN(userNumber); //number = 5
      userNumberPrimes.TruePrime(); //calling TruePrime function with a l
      for (int index = 2; index < userNumberPrimes.BoolArray.Length-1; index++) 
    {
      if(userNumberPrimes.BoolArray[index])
      {
        Console.WriteLine(index);
      }
    }
  }
}


