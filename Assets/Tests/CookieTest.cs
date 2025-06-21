using System;
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

        cookieStore.Cookies.Should().Be(1);
    }
    
    [Test]
    public void EarnTwoCookies()
    {
        var cookieStore = new CookieStore();

        cookieStore.EarnCookie();
        cookieStore.EarnCookie();

        cookieStore.Cookies.Should().Be(2);
    }
    
    [Test]
    public void NewCookieStoreHasZeroCookies()
    {
        var cookieStore = new CookieStore();

        cookieStore.Cookies.Should().Be(0);
    }
    
    [Test]
    public void ApplyMultiplier()
    {
        var cookieStore = new CookieStore();
        cookieStore.clickMultiplier = 2;
        
        cookieStore.EarnCookie();
        
        cookieStore.Cookies.Should().Be(2);
    }

    [Test]
    public void BuyMultiplier()
    {
        var cookieStore = new CookieStore();
        cookieStore.EarnCookie();
        cookieStore.Cookies.Should().Be(1);
        
        cookieStore.BuyClickMultiplier(1);
        
        cookieStore.Cookies.Should().Be(0);
        cookieStore.clickMultiplier.Should().Be(2);
    }

    [Test]
    public void CookiesBelowZeroAreNotAllowed()
    {
        var cookieStore = new CookieStore();
        
        Action act = () => { cookieStore.Cookies -= 1; };

        act.Should().Throw<AssertionException>();
    }

}