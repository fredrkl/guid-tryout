namespace Guid_tryout.Tests;
public class JourneyReferenceTests
{
    [Fact]
    public void RegularRefernce()
    {
      JourneyReference newReference = new(Guid.NewGuid(), 17);
    }
}
