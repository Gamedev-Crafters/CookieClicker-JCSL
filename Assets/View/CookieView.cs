using System;
using Model;
using Presenter;
using TMPro;
using UnityEngine;

public class CookieView : MonoBehaviour, ICookieDisplay, IClickMultiplierDisplay
{
    CookieStore cookieStore;
    EarnCookies earnCookies;
    BuyUpgrades buyUpgrades;
    public TMP_Text  cookiesLabel;
    public TMP_Text clickMultiplierLabel;
    
    void Start()
    {
       cookieStore = new CookieStore();
       earnCookies = new EarnCookies(cookieStore, this);
       buyUpgrades = new BuyUpgrades(cookieStore, this);
       
       DisplayCookies(cookieStore.Cookies);
       DisplayClickMultiplier(cookieStore.clickMultiplier);
    }

    public void ClickCookieButton()
    {
        earnCookies.Execute();
    }

    public void ClickBuyUpgradesButton()
    {
        buyUpgrades.Execute();
    }

    public void DisplayCookies(int cookies)
    {
        cookiesLabel.text = cookies.ToString();
    }

    public void DisplayClickMultiplier(int clickMultiplier)
    {
        clickMultiplierLabel.text = "Add Multiplier \nx" + clickMultiplier;
    }
}
