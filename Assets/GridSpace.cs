using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSpace

{
    // Define variables
    public int changeCurrency = 0;
    enum GridType 
    {
    Family,
    Friends,
    Environment,
    Health,
    Fun,
    Growth,
    Money,
    Career
    }
    



    // Define functions/methods
    public void PlayerLandedOnMe()
    {
        Debug.Log("Starting your lives");
        //Add or minus number for each GridIndex

        //Store score for each GridIndex under each player

        //When 50 is reach for each GridIndex, player wins

        //Debug.Log("Player X wins")
    }
    }
