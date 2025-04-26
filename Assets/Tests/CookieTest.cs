using FluentAssertions;
using NUnit;
using NUnit.Framework;

public class CookieTest
{
    [Test]
    public void earnOneCookie()
    {
        var cookieStore = new CookieStore();

        cookieStore.EarnCookie();

        cookieStore.cookies.Should().Be(1);
    }
}

internal class CookieStore
{
    public int cookies;

    public void EarnCookie()
    {
        cookies = 1;
    }
}