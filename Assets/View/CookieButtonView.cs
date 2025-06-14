using System;
using Model;
using Presenter;
using TMPro;
using UnityEngine;

public class CookieButtonView : MonoBehaviour, ICookieDisplay, IClickMultiplierDisplay
{
    CookieStore cookieStore;
    EarnCookies earnCookies;
    BuyUpgrades buyUpgrades;
    TMP_Text  cookiesLabel;
    public TMP_Text clickMultiplierLabel;
    
    void Start()
    {
       cookiesLabel = gameObject.GetComponentInChildren<TMP_Text>();
       cookieStore = new CookieStore();
       earnCookies = new EarnCookies(cookieStore, this);
       buyUpgrades = new BuyUpgrades(cookieStore, this);
       
       DisplayCookies(cookieStore.cookies);
       DisplayClickMultiplier(cookieStore.clickMultiplier);
    }

    public void ClickCookiButton()
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
