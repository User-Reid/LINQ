

Console.ReadKey();

void Main(string[] args)
{
  var wordsNoUpperCase = new string[] {
    "quick","brown", "fox"
  };
  System.Console.WriteLine(IsAnyWordUpperCase(wordsNoUpperCase));

  var wordsWithUppercase = new string[] {
    "quick", "brown", "FOX"
  };
  System.Console.WriteLine(IsAnyWordUpperCase(wordsWithUppercase));
  Console.ReadKey();
}

public static bool IsAnyWordUpperCase_Linq(IEnumberable<string> words) {
  return words.Any(word => word.All(letter => char.IsUpper(letter)));
}

bool IsAnyWordUpperCase(IEnumerable<string> words) {
  foreach (var word in words)
  {
    bool areAllUppercase = true;
    foreach (var letter in word)
    {
      if (char.IsLower(letter))
      {
        areAllUppercase = false;
      }
    }
    if (areAllUppercase)
    {
      return true;
    }
  }
  return false;
}