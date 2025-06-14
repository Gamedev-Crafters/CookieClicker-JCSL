using FluentAssertions;
using Model;
using NUnit;
using NUnit.Framework;

public class CookieTest
{
    [Test]
    public void EarnOneCookie()
    {
        var cookieStore = new CookieStore();

        cookieStore.EarnCookie();

        cookieStore.cookies.Should().Be(1);
    }
    
    [Test]
    public void EarnTwoCookies()
    {
        var cookieStore = new CookieStore();

        cookieStore.EarnCookie();
        cookieStore.EarnCookie();

        cookieStore.cookies.Should().Be(2);
    }
    
    [Test]
    public void NewCookieStoreHasZeroCookies()
    {
        var cookieStore = new CookieStore();

        cookieStore.cookies.Should().Be(0);
    }
    
    /* Tests:
     - Cookies below 0 are not allowed
     */
    
}