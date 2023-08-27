using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public List<GameObject> Track;
    public int squaresBetweenBases = 9;

    #region Square prefabs

    public GameObject SquarePrefab;
    public GameObject HomeSquarePrefab;
    public GameObject StartSquarePrefab;

    #endregion

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
            SpawnSquare(newTrack, StartSquarePrefab);
            for (int spawnCounter = 0; spawnCounter < squaresBetweenBases; spawnCounter++)
            {
                SpawnSquare(newTrack, SquarePrefab);
            }


        }
        throw new NotImplementedException();
    }

    private void SpawnSquare(List<GameObject> newTrack, GameObject squareType)
    {
        // Pick a new random colour and assign it to the next home square
        Color newColour = UnityEngine.Random.ColorHSV();

        // Instantiate a new game object square
        GameObject newSquare = Instantiate(squareType, this.transform);

        // Init the square that was just added
        newSquare.GetComponent<Square>().Init(newColour);

        // Add the new square to the Track list
        newTrack.Add(newSquare);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
