/*******************************************************************
* Name: James Lanagan
* Date: 05/29/2026
* Assignment: SDC320 Performance Assessment - Abstraction
*
* Represents a board game that uses dice.
*******************************************************************/
public class DiceGame : BoardGame
{
    public DiceGame(string name, int numPlayers, int maxMove)
        : base(name, numPlayers, maxMove)
    {
    }

    public override string StartGame()
    {
        return "To start the game, players roll the dice. Highest roll goes first.";
    }

    public override string StartTurn()
    {
        return "To start a turn, roll the dice to determine movement up to " + MaxMove + " spaces.";
    }
}
