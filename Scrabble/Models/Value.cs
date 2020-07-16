namespace Scrabble.Models
{
  public class Value
  {
    public int Score { get; }
    public string Letters { get; }
    public Value(string inputLetters, int inputScore)
    {
      Letters = inputLetters;
      Score = inputScore;
    }
  }
}