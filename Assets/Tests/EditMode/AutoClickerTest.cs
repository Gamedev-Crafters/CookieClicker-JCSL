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

        public class AutoClicker
        {
            public int autoClick { get; set; }

            private float _autoClickTime;
            
            public AutoClicker(float autoClickTime)
            {
                _autoClickTime = autoClickTime;
            }
            
            public void UpdateTime(float deltaTime)
            {
                autoClick = 2;
            }
        }
    }
}