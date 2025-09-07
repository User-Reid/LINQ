class Program
{
  static void Main(string[] args)
  {
    var words = new List<string> { "a", "bb", "ccc", "dddd" };

    var shortWords = words.Where(word => word.Length < 3);

    System.Console.WriteLine("First Iteration:");
    foreach (var word in shortWords)
    {
      System.Console.WriteLine(word);
    }
    words.Add("e");

    System.Console.WriteLine("Second Iteration:");
    foreach (var word in shortWords)
    {
      System.Console.WriteLine(word);
    }

    Console.ReadKey();
  }
}