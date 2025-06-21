using Model;

namespace Presenter
{
    public class BuyUpgrades
    {
        private CookieStore _cookieStore;
        private IClickMultiplierDisplay _clickMultiplierDisplay;
        
        public BuyUpgrades(CookieStore cookieStore, IClickMultiplierDisplay clickMultiplierDisplay)
        {
            _cookieStore = cookieStore;
            _clickMultiplierDisplay = clickMultiplierDisplay;
        }

        public void Execute()
        {
            _cookieStore.BuyClickMultiplier();
            _clickMultiplierDisplay.DisplayClickMultiplier(_cookieStore.clickMultiplier);
        }
        
        public bool CanExecute => _cookieStore.CanBuyClickMultiplierUpgrade();
    }
}