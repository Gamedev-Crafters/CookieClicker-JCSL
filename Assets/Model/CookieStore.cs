public class CookieStore
{
    public int cookies;
    
    public void EarnCookie(int clickMultiplier = 1)
    {
        cookies += clickMultiplier;
    }
}