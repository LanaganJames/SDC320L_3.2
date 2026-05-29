/*******************************************************************
* Name: Your Name
* Date: 05/29/2026
* Assignment: SDC320 Performance Assessment - Abstraction
*
* Represents a card-based game.
*******************************************************************/
public class CardGame : Game
{
    public int NumCards { get; set; }

    public CardGame(string name, int numPlayers, int numCards)
        : base(name, numPlayers)
    {
        NumCards = numCards;
    }

    public override string StartGame()
    {
        return "To start the game, the dealer gives each player " + NumCards + " cards.";
    }

    public override string StartTurn()
    {
        return "To start a turn, a player draws or plays a card.";
    }

    public override string EndTurn()
    {
        return "The turn ends when the player discards.";
    }
}