using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // players colour
    Color myColour;
    public Pawn[] Pawns;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Assign a colour to the player, if it doesn't have one assigned already
    /// </summary>
    /// <param name="assignedColour"></param>
    /// <returns></returns>
    public bool AssignColour(Color assignedColour)
    {
        if (myColour == null)
        {
            myColour = assignedColour;
            return true;
        }
        else 
            return false;
    }
}
