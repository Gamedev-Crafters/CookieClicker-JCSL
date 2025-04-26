using NUnit;
using NUnit.Framework;

public class CookieTest
{
    [Test]
    void earnOneCookie()
    {
        var cookieStore = new CookieStore();

        cookieStore.EarnCookie();

        cookieStore.cookies.Should().Be(1);
    }
}
