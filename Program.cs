// class Program
// {
//   static void Main(string[] args)
//   {
//     var words = new[] { "lion", "tiger", "snow leopard" };
//     var numbers = new[] { 5, 9, 2, 12, 6 };

//     var doesContainTiger = words.Contains();
//     System.Console.WriteLine(doesContainTiger);

//     var isLargerThan0 = numbers.All(number => number > 4);
//     System.Console.WriteLine(isLargerThan0);

//     bool isAnyLargerThan10 = numbers.Any(number => number > 10);
//     System.Console.WriteLine(isAnyLargerThan10);

//      Console.ReadKey();

//     Console.ReadKey();
//   }
// }
List<List<int>> taco = new List<List<int>>() {
  new List<int>() {1,2,5,-1},
  new List<int>() {0,4,4,6},
  new List<int>() {9,0}
};

System.Console.WriteLine(Exercise.CountListsContainingZeroLongerThan(3, taco));

Console.ReadKey();

public class Exercise
{
  public static int CountListsContainingZeroLongerThan(int length, List<List<int>> listsOfNumbers) => listsOfNumbers.Count(list => list.Contains(0) && list.Count > length);
}

   // var taco = listsOfNumbers.Count(list =>
    // {
    //   if (list.Contains(0) && list.Count() > length)
    //   {
    //     totalListsThatMeetCriteria++;
    //   }
    //   return totalListsThatMeetCriteria;
    // });