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

    public void EarnMultiplier()
    {
        var cookieStore = new CookieStore();
        var buyUpgrades = new BuyUpgrades(cookieStore);

        buyUpgrades.Execute();
        
        cookieStore.clickMultiplier.Should().Be(2);
    }
}

public class BuyUpgrades
{
    CookieStore cookieStore;
    
    public BuyUpgrades(CookieStore cookieStore)
    {
        this.cookieStore = cookieStore;
    }

    public void Execute()
    {
        cookieStore.EarnClickMultiplier();
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