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

    public static int ScoreLetter(string singleLetter)
    {
      Value line1 = new Value ("aeioulnrst", 1);
      Value line2 = new Value ("dg", 2);
      Value line3 = new Value ("bcmp", 3);
      Value line4 = new Value ("fhvwy", 4);
      Value line5 = new Value ("k", 5);
      Value line6 = new Value ("jx", 8);
      Value line7 = new Value ("qz", 10);
      Value[] scoringKey = { line1, line2, line3, line4, line5, line6, line7 };
      for (int i = 0; i < scoringKey.Length; i++)
      {
        if (scoringKey[i].Letters.Contains(singleLetter))
        {
          return scoringKey[i].Score;
        }
      }
      return 0;
    }

    public int ScoreWord()
    {
      int outputScore = 0;
      for (int i = 0; i < UserWord.Length; i++)
      {
        outputScore += Word.ScoreLetter(UserWord[i].ToString());
      }
      return outputScore;
    }
  }
}