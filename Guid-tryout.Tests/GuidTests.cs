using System.Security.Cryptography;
using System.Text;
using Xunit;

namespace Guid_tryout.Tests;
public class GuidTests
{
    [Fact]
    public void Test1()
    {
      Guid testguid = Guid.AllBitsSet;//().NewGuid();
      Assert.NotEqual(testguid, Guid.Empty);
    }

    [Fact]
    public void Add_ReturnsCorrectSum()
    {
      Assert.Equal(5, 5);
    }

    [Fact]
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
      Assert.NotEqual(guid_from_short_hash, guid_from_long_hash);
    }

    [Fact]
    public void SameInputSameGuidMD5()
    {
      Guid first = new(MD5.HashData(Encoding.UTF8.GetBytes("Appelsin")));
      Guid second = new(MD5.HashData(Encoding.UTF8.GetBytes("Appelsin")));
      Console.WriteLine(first);
      Console.WriteLine(second);
      Assert.Equal(first, second);
    }

    [Fact]
    public void SameInputSameGuidSHA()
    {
      Guid first = new(SHA256.HashData([.. Encoding.UTF8.GetBytes("Appelsin").Take(16).ToArray()]));
      Guid second = new(SHA256.HashData([.. Encoding.UTF8.GetBytes("Appelsin").Take(16).ToArray()]));
      Console.WriteLine(first);
      Console.WriteLine(second);
      Assert.Equal(first, second);
    }
}
