using FluentAssertions;
using Model;
using NUnit.Framework;
using Presenter;

public class PresenterTest
{
    [Test]
    public void EarnCookies()
    {
        var cookieStore = new CookieStore();
        var earnCookies = new EarnCookies(cookieStore, new FakeCookieDisplay());

        earnCookies.Execute();

        cookieStore.cookies.Should().Be(1);
    }

    [Test]
    public void EarnCookiesGetsDisplayed()
    {
        var cookieStore = new CookieStore();
        var cookieDisplay = new FakeCookieDisplay();
        var earnCookies = new EarnCookies(cookieStore, cookieDisplay);
        
        earnCookies.Execute();
        
        cookieDisplay.DisplayedCookies.Should().Be(1);
    }

    [Test]
    public void ApplyMultiplier()
    {
        var cookieStore = new CookieStore();
        var cookieDisplay = new FakeCookieDisplay();
        var earnCookies = new EarnCookies(cookieStore, cookieDisplay);
        earnCookies.Multiplier = 2;
        
        earnCookies.Execute();
        
        cookieDisplay.DisplayedCookies.Should().Be(2);
    }
}

public class FakeCookieDisplay : ICookieDisplay
{
    public int DisplayedCookies { get; set; } = 0;
    public void DisplayCookies(int cookies)
    {
        DisplayedCookies = cookies;
    }
}