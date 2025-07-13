using System;
using UnityEngine.Assertions;

namespace Model
{
    public class AutoClicker
    {
        private float _autoClickTargetTime;
        private float _timePassed;

        public AutoClicker(float autoClickTargetTime)
        {
            _autoClickTargetTime = autoClickTargetTime;
        }

        public int UpdateTime(float deltaTime)
        {
            int autoClick = 0;
            _timePassed += deltaTime;

            if (_timePassed >= _autoClickTargetTime)
            {
                float autoClicksAmount = _timePassed / _autoClickTargetTime;
                autoClick += (int)autoClicksAmount;
                _timePassed -= autoClick;
                Assert.IsTrue(_timePassed >= 0);
            }
            
            return autoClick; 
        }
    }
}