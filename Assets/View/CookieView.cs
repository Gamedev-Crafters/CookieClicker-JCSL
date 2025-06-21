using System;
using Model;
using Presenter;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CookieView : MonoBehaviour, ICookieDisplay, IClickMultiplierDisplay
{
    public TMP_Text  cookiesLabel;
    public Button clickCookieButton;
    
    public TMP_Text clickMultiplierLabel;
    public Button clickBuyUpgradeButton;
    
    private EarnCookies _earnCookies;
    private BuyUpgrades _buyUpgrades;
    
    public void Initialize(int initialCookies, int initialClickMultiplier, EarnCookies earnCookies, BuyUpgrades buyUpgrades)
    {
        _earnCookies = earnCookies;
        _buyUpgrades = buyUpgrades;
        
       DisplayCookies(initialCookies);
       DisplayClickMultiplier(initialClickMultiplier);
       
       clickCookieButton.onClick.AddListener(ClickCookieButton);
       clickBuyUpgradeButton.onClick.AddListener(ClickBuyUpgradesButton);
    }

    private void Update()
    {
        clickBuyUpgradeButton.interactable = _buyUpgrades.CanExecute;
    }
    
    private void ClickCookieButton()
    {
        _earnCookies.Execute();
    }

    private void ClickBuyUpgradesButton()
    {
        _buyUpgrades.Execute();
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
