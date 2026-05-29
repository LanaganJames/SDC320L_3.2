/*******************************************************************
* Name: James Lanagan
* Date: 05/29/2026
* Assignment: SDC320 Performance Assessment - Abstraction
*
* Main application class.
*******************************************************************/
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("James Lanagan - Week 3 Abstraction Performance Assessment\n");

        // Card Game
        Console.WriteLine("Card Game Information");
        CardGame cardGame = new CardGame("Rummy", 2, 13);
        Console.WriteLine(cardGame);

        // Dice Game
        Console.WriteLine("Board Game with Dice Game Information");
        DiceGame diceGame = new DiceGame("Monopoly", 4, 12);
        Console.WriteLine(diceGame);

        // Spinner Game
        Console.WriteLine("Board Game with Spinner Game Information");
        SpinnerGame spinnerGame = new SpinnerGame("Life", 3, 10);
        Console.WriteLine(spinnerGame);
    }
}
