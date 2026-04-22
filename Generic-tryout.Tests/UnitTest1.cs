namespace Generic_tryout.Tests;

public class UnitTest1
{
    [Fact]
    public void GenericLearning()
    {
      Console.WriteLine("Appelsin");
      Assert.True(true);
      List<int> intlist = new List<int>(4);
      intlist.Add(1);
      Console.WriteLine(intlist);
      Assert.NotEmpty(intlist);
    }
}
