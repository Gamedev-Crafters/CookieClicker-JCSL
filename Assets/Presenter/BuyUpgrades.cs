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
            cookieStore.BuyClickMultiplier(0);
            clickMultiplierDisplay.DisplayClickMultiplier(cookieStore.clickMultiplier);
        }
    }
}