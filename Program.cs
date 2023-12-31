﻿/*
  - Ett ord väljs ut
  - Informera om antal bokstäver ordet har
     Skriva ut antal _
  - Fråga om en bokstav
  - Kolla om bokstaven är rätt eller fel
  - Rätt: Bokstaven placeras där den ska vara
  - Fel: Bokstaven läggs till i listan av felaktiga bokstäver
         Rita ut en bit till av gubben
*/

/*
  - Vinna
  - Förlora
  - (Rita gubbe?)
*/

// -- Väl ett ord
string correctWord = "banana";

Console.WriteLine($"Antal tecken i ordet: {correctWord.Length}");

List<string> underlines = MakeUnderlines(correctWord);

int guessesLeft = 7;

while (underlines.Contains("_") && guessesLeft > 0)
{
  Console.WriteLine($"Du har {guessesLeft} gissningar kvar");

  // -- Skriv ut nuvarande status för ordet
  Console.WriteLine(string.Join(" ", underlines));

  // -- Gissar en bokstav
  string guessLetter = GimmeGuess();

  // -- Kolla om bokstav är i ordet
  if (correctWord.Contains(guessLetter))
  {
    for (int i = 0; i < correctWord.Length; i++)
    {
      if (correctWord[i].ToString() == guessLetter)
      {
        underlines[i] = guessLetter;
      }
    }
  }
  else
  {
    Console.WriteLine("NOT EXISTS");
    guessesLeft--;
  }
}

if (guessesLeft == 0)
{
  Console.WriteLine("LOSER");

}
else
{
  Console.WriteLine("CONGRATS");
}

Console.ReadLine();

static string GimmeGuess()
{
  string guessLetter = "";

  guessLetter = Console.ReadLine().ToLower();
  if (guessLetter.Length > 1)
  {
    guessLetter = guessLetter.First().ToString();
  }

  return guessLetter;
}

static List<string> MakeUnderlines(string correctWord)
{
  List<string> underlines = new();
  for (int i = 0; i < correctWord.Length; i++)
  {
    underlines.Add("_");
  }

  return underlines;
}