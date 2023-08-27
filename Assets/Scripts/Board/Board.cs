using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board: MonoBehaviour
{
    public List<Square> Track;
    // Start is called before the first frame update
    void Start()
    {
        Track = CreateTheTrack(4);
    }

    /// <summary>
    /// creates a new track for the board, according to the number of players we want
    /// </summary>
    /// <param name="numberOfPlayers"></param>
    /// <returns> new List of Squares </returns>
    private List<Square> CreateTheTrack(int numberOfPlayers)
    {
        // create an empty track
        List<Square> newTrack = new List<Square>();

        for (int i = 0; i < numberOfPlayers; i++)
        {
            // Pick a new random colour and assign it to the next home square
            Color newColour = UnityEngine.Random.ColorHSV();
            newTrack.Add(new Square(newColour));
        }
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
