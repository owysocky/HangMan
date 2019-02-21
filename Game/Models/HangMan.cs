using System.Collections.Generic;
using System;

namespace Game.Models
{
  string newWord;
  public class Word
  {
    public static Dictionary<int, string> wordsList = new Dictionary<int, string>() {{1, "home"}, {2, "phone"}, {3, "apple"}};

    public Word(string myNewWord)
    {
      newWord = myNewWord;
    }

    public void SetWord(string myNewWord)
    {
      newWord =  myNewWord;
    }
    // Dictionary.Count-
    Random rnd = new Random();
    int index = rnd.Next(1,1);
    string theWord = SetWord(wordsList[index]);
    string dashes = "";

    public string ShowDashes()
    {
      foreach (char letter in newWord) {
        dashes += " _";
      }
    }
  //
  //   public string ShowIncorrectLetter(string guessLetter)
  //   {
  //     return guessLetter;
  //   }
  //
  //   public string ShowCorrectLetter(string guessLetter)
  //   {
  //     for( int i=0; i<newWord.length; i++)
  //     {
  //       if(guessLetter == newWord[i])
  //       {
  //         int letterPlace = newWord[i];
  //         for(int j=0; j<dashes.length; j++)
  //         {
  //           dashes[letterPlace] = guessLetter;
  //         }
  //       }
  //     }
  //     string showIncorrect = ShowIncorrectLetter();
  //     return showIncorrect;
  //   }
  }

}
