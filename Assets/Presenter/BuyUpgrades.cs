using Model;

namespace Presenter
{
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
}