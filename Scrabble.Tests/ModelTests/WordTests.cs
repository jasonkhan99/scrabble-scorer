using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class ClassTests
  {

    [TestMethod]
    public void WordConstructor_CreatesInstanceOfClass_Word()
    {
      Word newWord = new Word("");
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnsWord_String()
    {
      string word = "dog";
      Word newWord = new Word("dog");
      string result = newWord.UserWord;
      Assert.AreEqual(word, result);
    }

    [TestMethod]
    public void ValueConstructor_CreatesInstanceOfClass_Value()
    {
      Value newValue = new Value();
      Assert.AreEqual(typeof(Value), newValue.GetType());
    }

    [TestMethod]
    public void GetValueScore_ReturnsValue_Int()
    {
      Value newValue = new Value("abcd", 10);
      Assert.AreEqual(newValue.Score, 10);
    }

  }
}