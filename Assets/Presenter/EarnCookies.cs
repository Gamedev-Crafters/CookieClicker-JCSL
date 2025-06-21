using Model;

namespace Presenter
{
    public class EarnCookies
    {
        private CookieStore _cookieStore;
        private ICookieDisplay _cookieDisplay;
    
        public EarnCookies(CookieStore cookieStore, ICookieDisplay cookieDisplay)
        {
            _cookieStore = cookieStore;
            _cookieDisplay = cookieDisplay;
            cookieDisplay.DisplayCookies(cookieStore.Cookies);
        }

        public void Execute()
        {
            _cookieStore.EarnCookie();
            _cookieDisplay.DisplayCookies(_cookieStore.Cookies);
        }
    }
}