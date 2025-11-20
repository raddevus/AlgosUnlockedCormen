namespace AlgosUnlockedCormen.Tests;

public class LinearSearchTests 
{
    [Fact]
    public void TestFindMatchNoMatch()
    {
      LinearSearch ls = new();
      var result = ls.findMatch("the wizard of oz") > -1 ? "found": "not found";
      Console.WriteLine($"Search result: {result}");
    }

    [Fact]
    public void TestFindMatchSentinel(){
      LinearSearch ls = new();
          
      var result = ls.findMatchSentinel("the wonderful wizard of oz") > -1 ? "found": "not found";
      Console.WriteLine($"Search result: {result}");
    }
}
