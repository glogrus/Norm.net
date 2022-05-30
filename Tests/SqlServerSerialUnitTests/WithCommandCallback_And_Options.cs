namespace SqlSerialUnitTests;

public partial class SqlSerialUnitTest
{
    [Fact]
    public void WithCommandCallback_And_Options_Test()
    {
        // reset to default
        NormOptions.Configure(o => { });

        bool withCommentHeaderCalled = false;
        bool optionsCommentHeaderCalled = false;
        using var connection = new SqlConnection(_DatabaseFixture.ConnectionString);

        NormOptions.Configure(options =>
        {
            options.DbCommandCallback = cmd => optionsCommentHeaderCalled = true;
        });

        connection
            .WithCommandCallback(cmd => withCommentHeaderCalled = true)
            .Execute("select 1");

        Assert.True(withCommentHeaderCalled);
        Assert.True(optionsCommentHeaderCalled);
    }
}