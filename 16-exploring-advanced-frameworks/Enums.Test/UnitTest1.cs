namespace Enums.Test;

public class UnitTest1
{
    [Theory(DisplayName = "Deve conter um valor para o tipo de jogo")]
    [InlineData(GameType.Action)]
    [InlineData(GameType.Adventure)]
    [InlineData(GameType.Sports)]
    [InlineData(GameType.Other)]
    public void ShouldContainGameType(GameType gameType)
    {
        Game game = new(gameType);

        game.Type.Should().Be(gameType);
        game.Type.ToString().Should().BeEquivalentTo(gameType.ToString());
    }

    [Theory(DisplayName = "Deve conter um índice para o tipo de jogo")]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    public void ShouldContainGameTypeByIndex(int gameTypeIndex)
    {
        var gameTypeByIndex = (GameType)gameTypeIndex;

        Game game = new(gameTypeByIndex);

        game.Type.Should().Be(gameTypeByIndex);
        game.Type.Should().Be((GameType)gameTypeIndex);
        game.Type.ToString().Should().BeEquivalentTo(gameTypeByIndex.ToString());
    }
}
