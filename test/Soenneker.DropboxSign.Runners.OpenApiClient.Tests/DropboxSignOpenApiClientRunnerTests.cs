using Soenneker.Tests.HostedUnit;

namespace Soenneker.DropboxSign.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class DropboxSignOpenApiClientRunnerTests : HostedUnitTest
{
    public DropboxSignOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
