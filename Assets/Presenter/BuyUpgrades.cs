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
            cookieStore.BuyClickMultiplier();
            clickMultiplierDisplay.DisplayClickMultiplier(cookieStore.clickMultiplier);
        }
        
        public bool CanExecute => cookieStore.CanBuyClickMultiplierUpgrade();
    }
}