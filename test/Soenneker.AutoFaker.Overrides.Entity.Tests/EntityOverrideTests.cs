using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.AutoFaker.Overrides.Entity.Tests;

[Collection("Collection")]
public class EntityOverrideTests : FixturedUnitTest
{
    public EntityOverrideTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
