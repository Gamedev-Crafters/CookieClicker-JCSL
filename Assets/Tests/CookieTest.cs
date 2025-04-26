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
    
    [Test]
    public void earnTwoCookies()
    {
        var cookieStore = new CookieStore();

        cookieStore.EarnCookie();
        cookieStore.EarnCookie();

        cookieStore.cookies.Should().Be(2);
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