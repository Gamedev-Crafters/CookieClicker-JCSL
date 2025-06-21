using NUnit.Framework;

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

        private void EarnClickMultiplier()
        {
            clickMultiplier ++;
        }

        public void BuyClickMultiplier(int cookieCost)
        {
            Assert.IsTrue(cookieCost <= cookies);
            cookies -= cookieCost;
            EarnClickMultiplier();
        }
    }
}