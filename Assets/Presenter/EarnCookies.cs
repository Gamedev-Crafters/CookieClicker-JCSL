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
            cookieDisplay.DisplayCookies(cookieStore.cookies);
        }

        public int Multiplier { get; set; } = 1;

        public void Execute()
        {
            cookieStore.EarnCookie(Multiplier);
            cookieDisplay.DisplayCookies(cookieStore.cookies);
        }
    }
}