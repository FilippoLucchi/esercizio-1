using Giocatore.domain;
using System.Text;

namespace BlaisePascal.PlayerTest;
    

    public class PlayerTests
    {
    [Fact]
    public void PlayerShouldStartAtLevel1()
    {
        Player player = new Player("TestPlayer", 1, 0, 100, 100, true, 0);
        Assert.Equal(1, player.Level);

    }

    public void StartLevelCannotBeNegative()
    {
        Player player = new Player("TestPlayer", -1, 0, 50, 100, true, 0);
        Assert.Throws<ArgumentOutOfRangeException>(() => new Player("TestPlayer", -1, 0, 50, 100, true, 0));
    }

    public void PlayerShouldStartWithZeroExperience()
    {
        Player player = new Player("TestPlayer", 1, 0, 100, 100, true, 0);
        Assert.Equal(0, player.Experience);
    }

    public void PlayerShouldNotStartWithNegativeExperience()
    {
        Player player = new Player("TestPlayer", 1, -1, 50, 100, true, 0);
        Assert.Throws<ArgumentOutOfRangeException>(() => new Player("TestPlayer", 1, -1, 50, 100, true, 0));
    }

    public void PlayerShouldStartWithFullHealth()
    {
        Player player = new Player("TestPlayer", 1, 0, 100, 100, true, 0);
        Assert.Equal(player.MaxHealth, player.Health);
    }

    public void PlayerCannotStartWithNegativeHealth()
    {
        Player player = new Player("TestPlayer", 1, 0, -1, 100, true, 0);
        Assert.Throws<ArgumentOutOfRangeException>(() => new Player("TestPlayer", 1, 0, -1, 100, true, 0));
    }
    public void PlayerShouldBeAliveAtStart()
    {
        Player player = new Player("TestPlayer", 1, 0, 100, 100, true, 0);
        Assert.True(player.IsAlive);
    }

    public void PlayerShouldStartWithZeroGold()
    {
        Player player = new Player("TestPlayer", 1, 0, 100, 100, true, 0);
        Assert.Equal(0, player.Gold);
    }

    public void PlayerCannotStartWithNegativeGold()
    {
        Player player = new Player("TestPlayer", 1, 0, 100, 100, true, -1);
        Assert.Throws<ArgumentOutOfRangeException>(() => new Player("TestPlayer", -1, 0, 100, 100, true, -1));
    }

    public void PlayerShouldTakeDamage()
    {
        Player player = new Player("TestPlayer", 1, 0, 100, 100, true, 0);
        player.TakeDamage(30);
        Assert.Equal(70, player.Health);
    }

    public void PlayerShouldNotTakeNegativeDamage()
    {
        Player player = new Player("TestPlayer", 1, 0, 100, 100, true, 0);
        Assert.Throws<ArgumentOutOfRangeException>(() => player.TakeDamage(-1));
    }

    public void PlayerShouldDieWhenHealthReachesZero()
    {
        Player player = new Player("TestPlayer", 1, 0, 100, 100, true, 0);
        player.TakeDamage(100);
        Assert.False(player.IsAlive);
    }

    public void PlayerShouldGainExperience()
    {
        Player player = new Player("TestPlayer", 1, 0, 100, 100, true, 0);
        player.AddExperience(500);
        Assert.Equal(50, player.Experience);
    }

    public void PlayerShouldNotGainNegativeExperience()
    {
        Player player = new Player("TestPlayer", 1, 0, 50, 100, true, 0);
        Assert.Throws<ArgumentOutOfRangeException>(() => player.AddExperience(-1));
        
    }

    public void PlayerShouldLevelUpWhenExperienceReaches100()
    {
        Player player = new Player("TestPlayer", 1, 0, 100, 100, true, 0);
        player.AddExperience(100);
        Assert.Equal(2, player.Level);
        Assert.Equal(0, player.Experience);
    }

    public void PlayerShouldBeAbleToResetHealth() {
        Player player = new Player("TestPlayer", 1, 0, 50, 100, true, 0);
        player.ResetHealth();
        Assert.Equal(player.Health, player.MaxHealth);
    }

    public void PlayerShouldBeAbleToAddGold()
    {
        Player player = new Player("TestPlayer", 1, 0, 50, 100, true, 0);
        player.AddGold(50);
        Assert.Equal(50, player.Gold);

    }

    public void PlayerShouldNotAddNegativeGold()
    {
        Player player = new Player("TestPlayer", 1, 0, 50, 100, true, 0);
        Assert.Throws<ArgumentOutOfRangeException>(() => player.AddGold(-1));
    }

    public void MaxHealthCannotBeLessThanHealth()
    {
        Player player = new Player("TestPlayer", 1, 0, 101, 100, true, 0);
        Assert.Throws<ArgumentOutOfRangeException>(() => new Player("TestPlayer", 1, 0, 101, 100, true, 0));
    }

}

