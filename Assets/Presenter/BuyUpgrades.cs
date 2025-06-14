using Model;

namespace Presenter
{
    public class BuyUpgrades
    {
        CookieStore cookieStore;
        IClickMultiplierDisplay clickMultiplierDisplay;
        
        public BuyUpgrades(CookieStore cookieStore, IClickMultiplierDisplay clickMultiplierDisplay)
        {
            this.cookieStore = cookieStore;
            this.clickMultiplierDisplay = clickMultiplierDisplay;
        }

        public void Execute()
        {
            cookieStore.EarnClickMultiplier();
            clickMultiplierDisplay.DisplayClickMultiplier(cookieStore.clickMultiplier);
        }
    }
}