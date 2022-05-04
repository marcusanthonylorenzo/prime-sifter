using System;
using Prime.Models;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Type a number: ");
    int userNumber = int.Parse(Console.ReadLine()); 
    PrimeN userNumberPrimes = new PrimeN(userNumber); 
    userNumberPrimes.TruePrime(); 
    List<int> array = new List<int>();

    for (int index = 2; index < userNumberPrimes.BoolArray.Length-1; index++) 
    {
    if(userNumberPrimes.BoolArray[index])
    {
      Console.WriteLine(index);
      if (userNumberPrimes.BoolArray[index] == true){
        array.Add(index);
      }
    }
    }
    
  Console.WriteLine(array.Count());
}


