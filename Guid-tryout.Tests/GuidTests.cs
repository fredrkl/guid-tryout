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
      var hash_appelsin = MD5.HashData(Encoding.UTF8.GetBytes("retry1:5xbflsdkjfks"));
      var hash_appelsin_again = MD5.HashData(Encoding.UTF8.GetBytes("appelsinappelsinappelsinappelsij"));
      Guid hash_appelsin_guid = new(hash_appelsin);
      Guid hash_appelsin_again_guid = new(hash_appelsin_again);

      // Debugs
      Console.WriteLine(hash_appelsin_guid);
      Console.WriteLine(hash_appelsin_again_guid);

      // Asserts
      Assert.That(hash_appelsin_guid, Is.Not.EqualTo(hash_appelsin_again_guid));
      Assert.That(hash_appelsin_guid, Is.Not.Empty);
    }
}
