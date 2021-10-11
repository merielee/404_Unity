using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Dice


{// Defining Dice functions

    int player1RandomNum;
    int player2RandomNum;
    int player1Points = 50;
    int player2Points = 50;

    public void Roll()

    {
        System.Random random = new System.Random();

        for (int i = 0; i < 10; i++)
        {
            Debug.Log("Press any key to roll the dice");

            player1RandomNum = random.Next(1, 7);
            Debug.Log("Player 1 rolled a " + player1RandomNum);

            player2RandomNum = random.Next(1, 7);
            Debug.Log("Player 2 rolled a " + player2RandomNum);
        }

    }

}