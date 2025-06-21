using System;
using NUnit.Framework;

namespace Model
{
    public class CookieStore
    {
        public int Cookies 
        {
            get => _cookies;
            set
            {
                Assert.IsTrue(value >= 0);
                _cookies = value;
            }
        }
        
        public int clickMultiplier = 1;
        
        private int _cookies;
        
        public void EarnCookie()
        {
            Cookies += clickMultiplier;
        }

        private void EarnClickMultiplier()
        {
            clickMultiplier ++;
        }

        public void BuyClickMultiplier(int cookieCost)
        {
            Assert.IsTrue(cookieCost <= Cookies);
            Cookies -= cookieCost;
            EarnClickMultiplier();
        }
    }
}