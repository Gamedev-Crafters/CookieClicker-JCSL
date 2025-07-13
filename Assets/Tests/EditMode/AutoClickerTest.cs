using NUnit.Framework;
using FluentAssertions;

namespace Tests.EditMode
{
    public class AutoClickerTest
    {
        [Test]
        public void TriggerEventAfterTime()
        {
            AutoClicker autoClicker = new AutoClicker(1f);
            
            autoClicker.UpdateTime(5f);

            autoClicker.autoClick.Should().BeGreaterThan(1);
        }

        [Test]
        public void TriggerEventAfterTwoSeconds()
        {
            AutoClicker autoClicker = new AutoClicker(2f);
            
            autoClicker.UpdateTime(2f);

            autoClicker.autoClick.Should().Be(1);
        }
        
        public class AutoClicker
        {
            public int autoClick { get; set; }

            private float _autoClickTargetTime;
            private float _timePassed;
            
            public AutoClicker(float autoClickTargetTime)
            {
                _autoClickTargetTime = autoClickTargetTime;
            }
            
            public void UpdateTime(float deltaTime)
            {
                _timePassed += deltaTime;

                if (_timePassed >= _autoClickTargetTime)
                {
                    autoClick++;
                }
            }
        }
    }
}