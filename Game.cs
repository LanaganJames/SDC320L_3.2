/*******************************************************************
* Name: James Lanagan
* Date: 05/29/2026
* Assignment: SDC320 Performance Assessment - Abstraction
*
* Abstract base class representing a game.
*******************************************************************/
public abstract class Game
{
    public string Name { get; set; }
    public int NumPlayers { get; set; }

    public Game(string name, int numPlayers)
    {
        Name = name;
        NumPlayers = numPlayers;
    }

    public abstract string StartGame();
    public abstract string StartTurn();
    public abstract string EndTurn();

    public override string ToString()
    {
        return
            "Welcome to " + Name + ". We have " + NumPlayers + " players with us today.\n" +
            StartGame() + "\n" +
            StartTurn() + "\n" +
            EndTurn() + "\n";
    }
}