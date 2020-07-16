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
      Word newWord = new Word();
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

  }
}