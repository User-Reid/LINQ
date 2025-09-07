var words = new List<string> { "a", "bb", "ccc", "dddd" };
var wordsLongerThan2Letters = words.Where(word => word.Length > 2);

var numbers = new int[] { 1, 2, 3, 4, 5, 6 };
var oddNumbers = numbers.Where(number => number % 2 == 1);

Console.ReadKey();