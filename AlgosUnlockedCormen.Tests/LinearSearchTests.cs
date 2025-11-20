namespace AlgosUnlockedCormen.Tests;

public class LinearSearchTests 
{
    [Fact]
    public void Test1()
    {
      LinearSearch ls = new();
      var result = ls.findMatch("the wizard of oz") > -1 ? "found": "not found";
      Console.WriteLine($"Search result: {result}");
    }
}
