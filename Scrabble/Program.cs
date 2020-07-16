using System;
using System.Collections.Generic;
using Scrabble.Models;

namespace Scrabble {
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter your word");
      Word inputString = new Word(Console.ReadLine());
      int outputScore = inputString.ScoreWord();
      Console.WriteLine(outputScore);
    }
  }
}