using FluentAssertions;
using Model;
using NUnit.Framework;

public class AutoClickerTest
{
    [Test]
    public void TriggerAutoClick5Times()
    {
        AutoClicker autoClicker = new AutoClicker(1f);

        autoClicker.UpdateTime(5f);

        autoClicker.autoClick.Should().Be(5);
    }

    [Test]
    public void TriggerAutoClickAfterTwoSeconds()
    {
        AutoClicker autoClicker = new AutoClicker(2f);

        autoClicker.UpdateTime(2f);

        autoClicker.autoClick.Should().Be(1);
    }
}