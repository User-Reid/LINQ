var listOfNumbers = new List<List<int>>
{
    new List<int> {15,68,20,12,19, 8, 55},
    new List<int> {12,1,3,4,-19, 8, 7, 6},
    new List<int> {5,-6,-2,-12,-10, 7}
};

// var listInformation = listOfNumbers.Select((list, index) => $"List {index + 1}. has {list.Count} values and averages {list.Average()}");

// System.Console.WriteLine(string.Join(Environment.NewLine, listInformation));

var result = listOfNumbers.Select(list => new
{
    Count = list.Count(),
    Average = list.Average()
}).OrderByDescending(countAndAverage => countAndAverage.Average).Select((list, index) => $"List {index + 1}. has {list.Count} values and averages {list.Average }");

System.Console.WriteLine(string.Join(Environment.NewLine, result));

// var taco = new Containers();

Console.ReadKey();