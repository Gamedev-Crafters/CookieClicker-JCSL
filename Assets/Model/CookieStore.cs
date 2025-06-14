namespace Model
{
    public class CookieStore
    {
        public int cookies;
    
        public int multiplier = 1;
        
        public void EarnCookie()
        {
            cookies += multiplier;
        }
    }
}