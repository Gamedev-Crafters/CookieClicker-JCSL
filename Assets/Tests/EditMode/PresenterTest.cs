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
        var buyUpgrades = new BuyUpgrades(cookieStore, new FakeCookieDisplay(), new FakeCookieDisplay());
        cookieStore.Cookies = CookieStore.CLICK_MULTIPLIER_COST;
        
        buyUpgrades.Execute();
        
        cookieStore.clickMultiplier.Should().Be(2);
    }
    
    [Test]
    public void EarnMultiplierGetsDisplayed()
    {   
        var cookieStore = new CookieStore();
        var clickMultiplierDisplay = new FakeCookieDisplay();
        var clickCookieDisplay = new FakeCookieDisplay();
        var buyUpgrades = new BuyUpgrades(cookieStore, clickMultiplierDisplay, clickCookieDisplay);
        cookieStore.Cookies = CookieStore.CLICK_MULTIPLIER_COST;
        
        buyUpgrades.Execute();
        
        clickMultiplierDisplay.DisplayedClickMultiplier.Should().Be(2);
        clickCookieDisplay.DisplayedCookies.Should().Be(0);
    }

    [Test]
    public void EarnOneCookieWithAutoClick()
    {
        CookieStore cookieStore = new CookieStore();
        AutoClicker autoClicker = new AutoClicker(1f);
        AutoEarnCookies autoEarnCookies = new AutoEarnCookies(cookieStore, autoClicker);

        autoEarnCookies.Execute(1f);

        autoClicker.autoClick.Should().Be(1);
        cookieStore.Cookies.Should().Be(1);
    }
    
    
}

public class AutoEarnCookies
{
    private CookieStore _cookieStore;
    private AutoClicker _autoClicker;
    
    public AutoEarnCookies(CookieStore cookieStore, AutoClicker autoClicker)
    {
        _cookieStore = cookieStore;
        _autoClicker = autoClicker;
    }

    public void Execute(float deltaTime)
    {
        _autoClicker.UpdateTime(deltaTime);
        _cookieStore.EarnCookie();
    }
}