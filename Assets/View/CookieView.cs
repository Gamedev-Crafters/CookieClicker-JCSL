using System;
using Model;
using Presenter;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CookieView : MonoBehaviour, ICookieDisplay, IClickMultiplierDisplay
{
    CookieStore cookieStore;
    EarnCookies earnCookies;
    BuyUpgrades buyUpgrades;

    public TMP_Text  cookiesLabel;
    public Button clickCookieButton;
    
    
    public TMP_Text clickMultiplierLabel;
    public Button clickBuyUpgradeButton;
    
    private void Start()
    {
       cookieStore = new CookieStore();
       earnCookies = new EarnCookies(cookieStore, this);
       buyUpgrades = new BuyUpgrades(cookieStore, this);
       
       DisplayCookies(cookieStore.Cookies);
       DisplayClickMultiplier(cookieStore.clickMultiplier);
       
       clickCookieButton.onClick.AddListener(ClickCookieButton);
       clickBuyUpgradeButton.onClick.AddListener(ClickBuyUpgradesButton);
    }

    private void Update()
    {
        clickBuyUpgradeButton.interactable = buyUpgrades.CanExecute;
    }
    
    private void ClickCookieButton()
    {
        earnCookies.Execute();
    }

    private void ClickBuyUpgradesButton()
    {
        buyUpgrades.Execute();
        DisplayCookies(cookieStore.Cookies);
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
