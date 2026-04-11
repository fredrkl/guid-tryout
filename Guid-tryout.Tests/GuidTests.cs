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
      var short_hash = MD5.HashData(Encoding.UTF8.GetBytes("retry1:5xbflsdkjfks"));
      var long_hash = MD5.HashData(Encoding.UTF8.GetBytes("appelsinappelsinappelsinappelsij"));
      Guid guid_from_short_hash = new(short_hash);
      Guid guid_from_long_hash = new(long_hash);

      // Debugs
      Console.WriteLine(guid_from_short_hash);
      Console.WriteLine(guid_from_long_hash);

      // Asserts
      Assert.That(guid_from_short_hash, Is.Not.EqualTo(guid_from_long_hash));
      Assert.That(guid_from_short_hash, Is.Not.Empty);
    }

    [Test]
    public void SameInputSameGuid()
    {
      Guid first = new(MD5.HashData(Encoding.UTF8.GetBytes("Appelsin")));
      Guid second = new(MD5.HashData(Encoding.UTF8.GetBytes("Appelsin")));
      Assert.That(first, Is.EqualTo(second));
    }
}
