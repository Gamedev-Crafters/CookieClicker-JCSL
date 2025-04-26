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

    [Test]
    public void EarnCookiesGetsDisplayed()
    {
        var cookieStore = new CookieStore();
        var cookieDisplay = new FakeCookieDisplay();
        var earnCookies = new EarnCookies(cookieStore, cookieDisplay);
        
        earnCookies.Execute();
        
        cookieDisplay.DisplayedCookies.Should().Be(1);
    }
}

public interface ICookieDisplay
{
    int DisplayedCookies { get; }
}

public class FakeCookieDisplay : ICookieDisplay
{
    public int DisplayedCookies { get; } = 1;
}

public class EarnCookies
{
    CookieStore cookieStore;
    ICookieDisplay cookieDisplay;
    
    public EarnCookies(CookieStore cookieStore)
    {
        this.cookieStore = cookieStore;
    }
    
    public EarnCookies(CookieStore cookieStore, ICookieDisplay cookieDisplay)
    {
        this.cookieStore = cookieStore;
        this.cookieDisplay = cookieDisplay;
    }

    public void Execute()
    {
        cookieStore.EarnCookie();
    }
}