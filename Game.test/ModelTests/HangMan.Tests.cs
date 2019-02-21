using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Models;
using System.Collections.Generic;
using System;

namespace Game.Tests
{
  [TestClass]
  public class HangManTest
  {
    [TestMethod]
    public void Word_CheckIfHappening_True()
    {
      Word testWord = new Word();

      Assert.AreEqual("home", testWord.FindWord());
    }

    [TestMethod]
    public void PrintDash_CheckIfHappening_True()
    {
      Word testWord = new Word();

      Assert.AreEqual(" _ _ _ _", testWord.ShowDashes());
    }
  }
}
