
using FluentAssertions;
using NUnit.Framework;

public class PresenterTest
{
    [Test]
    public void EarnCookies()
    {
        var cookieStore = new CookieStore();
        var earnCookies = new EarnCookies(cookieStore);

        earnCookies.Execute();

        cookieStore.cookies.Should().Be(1);
    }
}

public class EarnCookies
{
    public EarnCookies(CookieStore cookieStore)
    {
        throw new System.NotImplementedException();
    }

    public void Execute()
    {
        throw new System.NotImplementedException();
    }
}