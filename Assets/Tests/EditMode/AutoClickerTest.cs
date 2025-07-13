using FluentAssertions;
using Model;
using NUnit.Framework;

public class AutoClickerTest
{
    [Test]
    public void TriggerAutoClick5Times()
    {
        AutoClicker autoClicker = new AutoClicker(1f);

        int autoClick = autoClicker.UpdateTime(5f);

        autoClick.Should().Be(5);
    }

    [Test]
    public void TriggerAutoClickAfterTwoSeconds()
    {
        AutoClicker autoClicker = new AutoClicker(2f);

        int autoClick = autoClicker.UpdateTime(2f);

        autoClick.Should().Be(1);
    }
}