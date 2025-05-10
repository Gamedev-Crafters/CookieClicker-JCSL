using TMPro;
using UnityEngine;

public class CookieButtonView : MonoBehaviour, ICookieDisplay
{
    CookieStore cookieStore;
    EarnCookies earnCookies;
    TMP_Text  cookiesLabel;
    
    public int DisplayedCookies { get; set; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       cookieStore = new CookieStore();
       earnCookies = new EarnCookies(cookieStore, this);
       cookiesLabel = gameObject.GetComponentInChildren<TMP_Text>();
    }

    public void ClickCookiButton()
    {
        earnCookies.Execute();
        cookiesLabel.text = DisplayedCookies.ToString();
    }

}
