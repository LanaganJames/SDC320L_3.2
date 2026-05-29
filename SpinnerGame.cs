/*******************************************************************
* Name: James Lanagan
* Date: 05/29/2026
* Assignment: SDC320 Performance Assessment - Abstraction
*
* Represents a board game that uses a spinner.
*******************************************************************/
public class SpinnerGame : BoardGame
{
    public SpinnerGame(string name, int numPlayers, int maxMove)
        : base(name, numPlayers, maxMove)
    {
    }

    public override string StartGame()
    {
        return "To start the game, players spin the spinner. Closest to max value goes first.";
    }

    public override string StartTurn()
    {
        return "To start a turn, spin to move up to " + MaxMove + " spaces.";
    }
}