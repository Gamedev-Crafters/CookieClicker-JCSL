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

        cookieStore.Cookies.Should().Be(1);
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
        var buyUpgrades = new BuyUpgrades(cookieStore, new FakeCookieDisplay());
        cookieStore.Cookies = CookieStore.CLICK_MULTIPLIER_COST;
        
        buyUpgrades.Execute();
        
        cookieStore.clickMultiplier.Should().Be(2);
    }
    
    [Test]
    public void EarnMultiplierGetsDisplayed()
    {   
        var cookieStore = new CookieStore();
        var clickMultiplierDisplay = new FakeCookieDisplay();
        var buyUpgrades = new BuyUpgrades(cookieStore, clickMultiplierDisplay);
        cookieStore.Cookies = CookieStore.CLICK_MULTIPLIER_COST;
        
        buyUpgrades.Execute();
        
        clickMultiplierDisplay.DisplayedClickMultiplier.Should().Be(2);
    }
}