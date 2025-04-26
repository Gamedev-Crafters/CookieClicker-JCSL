
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
    CookieStore cookieStore;
    
    public EarnCookies(CookieStore cookieStore)
    {
        this.cookieStore = cookieStore;
    }

    public void Execute()
    {
        cookieStore.EarnCookie();
    }
}