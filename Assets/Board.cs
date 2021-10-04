using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board
{
    // Define variables
    // TODO: Replace these with an Array (or a fancy 'List<GridSpace>()')
    public GridSpace aGridSpace1;
    public GridSpace aGridSpace2;
    public GridSpace aGridSpace3;
    public GridSpace aGridSpace4;
    public GridSpace aGridSpace5;

    public void Setup()
    {
        // TODO: Use a for loop to 'new' ALL the gridspaces
        aGridSpace1 = new GridSpace();
        aGridSpace2 = new GridSpace();
        aGridSpace3 = new GridSpace();
        aGridSpace4 = new GridSpace();
        aGridSpace5 = new GridSpace();
    }
}
