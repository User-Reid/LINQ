

Console.ReadKey();

void Main(string[] args)
{
  var numbers = new List<int> { 5, 3, 7, 1, 2, 4 };
  var numbersWith10 = numbers.Append(10);

  System.Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");
  System.Console.WriteLine($"Numbers: {string.Join(", ", numbersWith10)}");
}

var ordredOddNumbers = numbers.Where(number => number % 2 == 1).OrderBy(number => number);