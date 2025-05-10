using System;
using TMPro;
using UnityEngine;

public class CookieButtonView : MonoBehaviour, ICookieDisplay
{
    CookieStore cookieStore;
    EarnCookies earnCookies;
    TMP_Text  cookiesLabel;
    
    void Start()
    {
       cookiesLabel = gameObject.GetComponentInChildren<TMP_Text>();
       cookieStore = new CookieStore();
       earnCookies = new EarnCookies(cookieStore, this);
    }

    public void ClickCookiButton()
    {
        earnCookies.Execute();
    }

    public void DisplayCookies(int cookies)
    {
        cookiesLabel.text = cookies.ToString();
    }
}
