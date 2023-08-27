using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board: MonoBehaviour
{
    public List<GameObject> Track;

    public GameObject SquarePrefab;
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
    private List<GameObject> CreateTheTrack(int numberOfPlayers)
    {
        // create an empty track
        List<GameObject> newTrack = new List<GameObject>();

        for (int i = 0; i < numberOfPlayers; i++)
        {
            // Pick a new random colour and assign it to the next home square
            Color newColour = UnityEngine.Random.ColorHSV();
            
            // Instantiate a new game object square
            GameObject newSquare = Instantiate(SquarePrefab, this.transform);

            // Add the HomeSquare component to the new game object and init the square
            newSquare.AddComponent<HomeSquare>().Init(newColour);

            // Add the new square to the Track list
            newTrack.Add(newSquare);


        }
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
