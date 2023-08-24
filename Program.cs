/*
  - Ett ord väljs ut
  - Informera om antal bokstäver ordet har
     Skriva ut antal _
  - Fråga om en bokstav
  - Kolla om bokstaven är rätt eller fel
  - Rätt: Bokstaven placeras där den ska vara
  - Fel: Bokstaven läggs till i listan av felaktiga bokstäver
         Rita ut en bit till av gubben
*/

string correctWord = "banana";

Console.WriteLine($"Antal tecken i ordet: {correctWord.Length}");

List<string> underlines = new();
for (int i = 0; i < correctWord.Length; i++)
{
  underlines.Add("_");
}

Console.WriteLine(string.Join(" ", underlines));

string guessLetter = Console.ReadLine().First().ToString();


Console.ReadLine();