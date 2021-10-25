using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

// Defining Dice functions
public class Dice
{
    public int Roll()
    {
        System.Random random = new System.Random();

        return random.Next(1, 7);
    }

}
