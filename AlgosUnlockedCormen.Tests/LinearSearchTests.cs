namespace AlgosUnlockedCormen.Tests;

public class LinearSearchTests 
{
    [Fact]
    public void TestFindMatchNoMatch()
    {
      LinearSearch ls = new();
      var searchText =  "the wizard of oz";
      var result = ls.findMatch(searchText) > -1 ? $"FOUND => {searchText}": $"NOT found => {searchText}";
      Console.WriteLine($"Search result: {result}");
    }

    [Fact]
    public void TestFindMatchSentinel(){
      LinearSearch ls = new();
      var searchText =  "the wonderful wizard of oz";
      var result = ls.findMatchSentinel(searchText) > -1 ? $"FOUND => {searchText}": $"NOT found => {searchText}";
      Console.WriteLine($"Search result: {result}");
    }
}
