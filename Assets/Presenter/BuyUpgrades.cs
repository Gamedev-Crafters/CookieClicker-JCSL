using Model;

namespace Presenter
{
    public class BuyUpgrades
    {
        private CookieStore _cookieStore;
        private IClickMultiplierDisplay _clickMultiplierDisplay;
        private ICookieDisplay _cookieDisplay;
        
        public BuyUpgrades(CookieStore cookieStore, IClickMultiplierDisplay clickMultiplierDisplay, ICookieDisplay cookieDisplay)
        {
            _cookieStore = cookieStore;
            _clickMultiplierDisplay = clickMultiplierDisplay;
            _cookieDisplay = cookieDisplay;
        }

        public void Execute()
        {
            _cookieStore.BuyClickMultiplier();
            _clickMultiplierDisplay.DisplayClickMultiplier(_cookieStore.clickMultiplier);
            _cookieDisplay.DisplayCookies(_cookieStore.Cookies);
        }
        
        public bool CanExecute => _cookieStore.CanBuyClickMultiplierUpgrade();
    }
}