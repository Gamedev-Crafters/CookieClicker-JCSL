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
        public const int CLICK_MULTIPLIER_COST = 5;
        
        private int _cookies;
        
        public void EarnCookie()
        {
            Cookies += clickMultiplier;
        }

        private void EarnClickMultiplier()
        {
            clickMultiplier ++;
        }

        public void BuyClickMultiplier()
        {
            Assert.IsTrue(CLICK_MULTIPLIER_COST <= Cookies);
            Cookies -= CLICK_MULTIPLIER_COST;
            EarnClickMultiplier();
        }

        public bool CanBuyClickMultiplierUpgrade()
        {
            return _cookies >= CLICK_MULTIPLIER_COST;
        }
    }
}