// class Program
// {
//   static void Main(string[] args)
//   {
//     var numbers = new[] { 5, 9, 2, 12, 6 };
//     var isLargerThan0 = numbers.All(number => number > 4);
//     System.Console.WriteLine(isLargerThan0);

//     bool isAnyLargerThan10 = numbers.Any(number => number > 10);
//     System.Console.WriteLine(isAnyLargerThan10);

//      Console.ReadKey();

//     Console.ReadKey();
//   }
// }
var salad = new List<string>() {
  "Howdy",
  "asdfjlk;as  ",
  "   "
};

System.Console.WriteLine(Exercise.IsAnyWordWhiteSpace(salad));

Console.ReadKey();

public static class Exercise
{
  public static bool IsAnyWordWhiteSpace(List<string> words)
{
    foreach (string word in words)
    {
      if (word.All(char.IsWhiteSpace))
      {
        return true;
      }
    }
      return false;
  }
}