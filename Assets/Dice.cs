using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{// Defining new "variables"
   public int    sides; // int means 'integer' or just whole numbers
   public Color  colour;
   public float  size; // float means 'floating point number' or just a number with decimals
   public string nameOfDice; // string is for text
  
   // Roll the dice
   // This is a function/method
   // First word is the variable that you get BACK. "void" means it doesn't give you anything!
   // Normal brackets () are variable it needs. These are called 'parameters'
   // Note: This won't do ANYTHING until someone 'calls' it
   void Roll()
   {
       // Unity's way of printing out a simple message to it's 'console' window
       Debug.Log("Rolling!");
       Debug.Log(sides);
       Debug.Log(nameOfDice);
   }

   // Start is called when you click the play button in Unity
   void Start()
   {
       // Call the function
       Roll();
    
}
