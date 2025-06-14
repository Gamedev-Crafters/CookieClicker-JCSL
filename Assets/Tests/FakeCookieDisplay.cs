public class FakeCookieDisplay : ICookieDisplay
{
    public int DisplayedCookies { get; set; } = 0;
    public void DisplayCookies(int cookies)
    {
        DisplayedCookies = cookies;
    }
}