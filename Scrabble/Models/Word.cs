using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class Word
  {
    public string UserWord { get; }
    public Word(string inputWord)
    {
      UserWord = inputWord;
    }
  }
}