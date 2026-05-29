/*******************************************************************
* Name: James Lanagan
* Date: 05/29/2026
* Assignment: SDC320 Performance Assessment - Abstraction
*
* Abstract class for board games.
*******************************************************************/
public abstract class BoardGame : Game
{
    public int MaxMove { get; set; }

    public BoardGame(string name, int numPlayers, int maxMove)
        : base(name, numPlayers)
    {
        MaxMove = maxMove;
    }

    public override string EndTurn()
    {
        return "The turn is over when the player finishes their move.";
    }

    public abstract override string StartGame();
    public abstract override string StartTurn();
}