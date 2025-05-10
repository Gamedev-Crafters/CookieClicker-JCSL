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