using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    public enum StepResult
    {
        Moved,
        KnockOut,
        Blocked

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    /// <summary>
    /// Attempts to move the pawn by a required number of steps
    /// </summary>
    /// <param name="stepCount">number of steps we want to move</param>
    /// <returns>if the pawn moved, knocked another pawn out, or got blocked</returns>
    public StepResult MoveAttempt(int stepCount)
    {

        return StepResult.Blocked;
    }
}
