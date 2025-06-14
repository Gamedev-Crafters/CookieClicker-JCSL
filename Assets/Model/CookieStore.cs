namespace Model
{
    public class CookieStore
    {
        public int cookies;
    
        public int clickMultiplier = 1;
        
        public void EarnCookie()
        {
            cookies += clickMultiplier;
        }

        public void EarnClickMultiplier()
        {
            clickMultiplier ++;
        }
    }
}