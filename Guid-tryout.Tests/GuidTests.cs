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
      var hash_appelsin_again = md5.ComputeHash(Encoding.UTF8.GetBytes("appelsinappelsinappelsinappelsij"));
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
