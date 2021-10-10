using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Dice 
{// Defining Dice functions
   
   int sides = 10;
   
   void Start()

   // Rolling the dice
   
   {Debug.Log(Random.Range (1, sides));
   }
}