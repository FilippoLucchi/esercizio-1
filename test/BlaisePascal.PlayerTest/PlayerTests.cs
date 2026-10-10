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
}

