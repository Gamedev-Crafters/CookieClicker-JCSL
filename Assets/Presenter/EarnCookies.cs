using Model;

namespace Presenter
{
    public class EarnCookies
    {
        CookieStore cookieStore;
        ICookieDisplay cookieDisplay;
    
        public EarnCookies(CookieStore cookieStore, ICookieDisplay cookieDisplay)
        {
            this.cookieStore = cookieStore;
            this.cookieDisplay = cookieDisplay;
            cookieDisplay.DisplayCookies(cookieStore.Cookies);
        }

        public void Execute()
        {
            cookieStore.EarnCookie();
            cookieDisplay.DisplayCookies(cookieStore.Cookies);
        }
    }
}