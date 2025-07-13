using Model;
using Presenter;
using UnityEngine;
using UnityEngine.Serialization;

namespace View
{
    public class DependencyResolver : MonoBehaviour
    {
        [FormerlySerializedAs("cookieView")] public MultiplierButtonView _multiplierButtonView;
        
        
        private CookieStore _cookieStore;
        private EarnCookies _earnCookies;
        private BuyUpgrades _buyUpgrades;
        
        private void Awake()
        {
            _cookieStore = new CookieStore();
            _earnCookies = new EarnCookies(_cookieStore, _multiplierButtonView);
            _buyUpgrades = new BuyUpgrades(_cookieStore, _multiplierButtonView, _multiplierButtonView);
            
            _multiplierButtonView.Initialize(_cookieStore.Cookies,_cookieStore.clickMultiplier,_earnCookies,_buyUpgrades);
        }
    }
}