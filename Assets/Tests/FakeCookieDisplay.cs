using Presenter;

public class FakeCookieDisplay : ICookieDisplay, IClickMultiplierDisplay
{
    public int DisplayedCookies { get; set; } = 0;
    public int DisplayedClickMultiplier { get; set; } = 1;
    
    public void DisplayCookies(int cookies)
    {
        DisplayedCookies = cookies;
    }

    public void DisplayClickMultiplier(int clickMultiplier)
    {
        DisplayedClickMultiplier = clickMultiplier;
    }
}