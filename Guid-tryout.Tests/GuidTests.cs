using System.Security.Cryptography;
using System.Text;

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

    [Test]
    public void GuidFromString()
    {
      var md5 = MD5.Create();
      var hash_appelsin = md5.ComputeHash(Encoding.UTF8.GetBytes("appelsin"));
      var hash_appelsin_again = md5.ComputeHash(Encoding.UTF8.GetBytes("appelsin"));
      Guid actual = new(hash_appelsin);
      Assert.That(actual, Is.Not.Empty);
      Guid expected = new(hash_appelsin_again);
      Console.WriteLine(actual);
      Console.WriteLine(expected);
      Assert.That(new Guid(hash_appelsin), Is.EqualTo(expected));
    }
}
