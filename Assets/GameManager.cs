using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Variables
    public string instructions;

    public Board theBoard;

    public Player player1;
    public Player player2;

    // When you click Play in Unity, this function will run
    private void Start()
    {
        // Spawn the board (using plain C#, not Unity style)
        theBoard = new Board();
        theBoard.Setup();
        
        player1 = new Player();
        player2 = new Player();
        
        FakeGame();
    }

    // For testing before we get to actual interactivity in Unity
    public void FakeGame()
    {
        // TODO
        // Set each players name
        
        player1.TakeTurn();
        player2.TakeTurn();
        player1.TakeTurn();
        player2.TakeTurn();
    }

    // TODO
    // Figure out who's winning
    // If a players reaches 

    //Need "if' statement if (player) 

    // Determine when someone has won
    //Need "if' statement 

    //      How many gridspaces are there?
    //      Use an 'if' to check if any player is further than the max the board has

    
}
