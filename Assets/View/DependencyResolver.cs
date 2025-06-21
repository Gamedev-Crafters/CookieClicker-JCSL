using Model;
using Presenter;
using UnityEngine;

namespace View
{
    public class DependencyResolver : MonoBehaviour
    {
        public CookieView cookieView;
        
        
        private CookieStore _cookieStore;
        private EarnCookies _earnCookies;
        private BuyUpgrades _buyUpgrades;
        
        private void Start()
        {
            _cookieStore = new CookieStore();
            _earnCookies = new EarnCookies(_cookieStore, cookieView);
            _buyUpgrades = new BuyUpgrades(_cookieStore, cookieView, cookieView);
        }
    }
}