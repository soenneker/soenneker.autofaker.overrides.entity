using Soenneker.Tests.HostedUnit;

namespace Soenneker.AutoFaker.Overrides.Entity.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class EntityOverrideTests : HostedUnitTest
{
    public EntityOverrideTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
