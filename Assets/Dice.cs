using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Dice 


{// Defining Dice functions
   
      int player1RandomNum;
      int player2RandonNum;
      int player1Points = 50;
      int player2Points = 50;

      public void Roll
      
      {
         public Random random = new Random ();

            {for (int) i = 0; int < 10; i++);
         
            Debug.Log("Press any key to roll the dice");}   

            Input.inputString();

            {public player1RandomNum = random.Next(1, 7);
            Debug.Log("Player 1 rolled a " + player1RandomNum);}
            
            {public player2RandomNum = random.Next(1, 7);
            Debug.Log("Player 2 rolled a " + player2RandomNum);}

                        Input.inputString();
            
            Input.inputString();
      }
       
}