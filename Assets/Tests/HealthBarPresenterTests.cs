using FluentAssertions;
using Moq;
using NUnit.Framework;
using UnityEngine;

[TestFixture]
public class HealthBarPresenterTests
{
    [Test]
    public void DamageButtonShouldDealDamage()
    {
        var player = new Player();
        var healthBar = new Mock<IHealthBar>();

        var healthBarPresenter = new HealthBarPresenter(player, healthBar.Object);
        healthBarPresenter.DamageButtonClicked();

        player.Health.Should().Be(90);
    }
}
