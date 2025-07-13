using Presenter;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace View
{
    public class CookieButtonView : MonoBehaviour, ICookieDisplay
    {
        private EarnCookies _earnCookies;

        public TMP_Text cookiesLabel;
        public Button clickCookieButton;

        public void Initialize(int initialCookies, EarnCookies earnCookies)
        {
            _earnCookies = earnCookies;
            DisplayCookies(initialCookies);
            clickCookieButton.onClick.AddListener(ClickCookieButton);
        }

        private void ClickCookieButton()
        {
            _earnCookies.Execute();
        }


        public void DisplayCookies(int cookies)
        {
            cookiesLabel.text = cookies.ToString();
        }
    }
}