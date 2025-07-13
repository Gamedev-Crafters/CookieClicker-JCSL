using Model;
using Presenter;
using UnityEngine;

namespace View
{
    public class DependencyResolver : MonoBehaviour
    {
        public CookieButtonView cookieButtonView;
        public MultiplierButtonView multiplierButtonView;
        
        private CookieStore _cookieStore;
        private EarnCookies _earnCookies;
        private BuyUpgrades _buyUpgrades;
        
        private void Awake()
        {
            _cookieStore = new CookieStore();
            _earnCookies = new EarnCookies(_cookieStore, cookieButtonView);
            _buyUpgrades = new BuyUpgrades(_cookieStore, multiplierButtonView, cookieButtonView);
            
            cookieButtonView.Initialize(_cookieStore.Cookies,_earnCookies);
            multiplierButtonView.Initialize(_cookieStore.clickMultiplier, _buyUpgrades);
        }
    }
}