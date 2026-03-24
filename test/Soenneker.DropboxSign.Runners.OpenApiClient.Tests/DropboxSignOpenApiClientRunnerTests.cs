using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.DropboxSign.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class DropboxSignOpenApiClientRunnerTests : FixturedUnitTest
{
    public DropboxSignOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
