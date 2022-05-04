using System;
using System.Collections.Generic;

namespace Prime.Models
{
  public class PrimeN
  {
    public bool[] BoolArray { get; }
    public List<int>[] PrimeCount { get; }
    public PrimeN(int num)
    {
      BoolArray = new bool[num+1];
      for(int index = 2; index < num+1; index++)
      {
        BoolArray[index] = true;
      }
    }

    public void TruePrime()
    {
      for(int index = 2; index < BoolArray.Length; index++)
      {
        for(int mult = 2; mult*index < BoolArray.Length - 1; mult++) 
        {
          BoolArray[mult*index] = false;
        }
      }
        
      // for(int index = 2; index < BoolArray.Length; index++)
      //   Console.WriteLine($"{index}: {BoolArray[index]}"); //want to see what is in BoolArray
      }
    }
  }
