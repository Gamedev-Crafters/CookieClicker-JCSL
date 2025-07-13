using Presenter;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MultiplierButtonView : MonoBehaviour, IClickMultiplierDisplay
{
    public TMP_Text clickMultiplierLabel;
    public Button clickBuyUpgradeButton;
    
    private BuyUpgrades _buyUpgrades;
    
    public void Initialize(int initialClickMultiplier, BuyUpgrades buyUpgrades)
    {
        _buyUpgrades = buyUpgrades;
        DisplayClickMultiplier(initialClickMultiplier);
        clickBuyUpgradeButton.onClick.AddListener(ClickBuyUpgradesButton);
    }
    
    private void Update()
    {
        clickBuyUpgradeButton.interactable = _buyUpgrades.CanExecute;
    }

    private void ClickBuyUpgradesButton()
    {
        _buyUpgrades.Execute();
    }

    public void DisplayClickMultiplier(int clickMultiplier)
    {
        clickMultiplierLabel.text = "Add Multiplier \nx" + clickMultiplier;
    }
}