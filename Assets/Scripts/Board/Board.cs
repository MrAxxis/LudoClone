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

    public List<Color> PlayerColours;

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

            // adds the new colour to the player colours
            PlayerColours.Add(newColour);

            // spawn the start square
            SpawnSquare(newTrack, StartSquarePrefab, newColour);

            // spawn the blank squares in between
            for (int normalCounter = 0; normalCounter < squaresBetweenBases; normalCounter++)
            {
                SpawnSquare(newTrack, SquarePrefab, Color.white);
            }

            // spawn the home squares
            for (int homeCounter = 0; homeCounter < numberOfPlayers; homeCounter++)
            {
                SpawnSquare(newTrack, HomeSquarePrefab, newColour);
            }

        }

        return newTrack;
    }

    /// <summary>
    /// Spawns a square according to <paramref name="squareType"></paramref></param>,
    /// assigns it <paramref name="colour"></paramref></param>, 
    /// adds it into the <paramref name="newTrack"></param>
    /// </summary>
    private void SpawnSquare(List<GameObject> newTrack, GameObject squareType, Color colour)
    {

        // Instantiate a new game object square
        GameObject newSquare = Instantiate(squareType, this.transform);

        // Init the square that was just added
        newSquare.GetComponent<Square>().Init(colour);

        // Add the new square to the Track list
        newTrack.Add(newSquare);
    }
}
