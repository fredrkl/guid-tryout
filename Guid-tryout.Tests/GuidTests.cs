namespace Guid_tryout.Tests;

public class GuidTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
      Guid testguid = Guid.AllBitsSet;//().NewGuid();
      Assert.That(testguid, Is.Not.EqualTo(Guid.Empty));
    }
}
