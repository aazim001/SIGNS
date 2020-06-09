using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    //Referencing the game controller UI
    public GameController gameController;

    //Creating the trigger for when the vehicle passes the finish line, if anything has hit the trigger
    void OnTriggerEnter()
    {
        //Appears in the console when the vehicle crosses the finish line
        Debug.Log("Done");
        //This accesses the complete level function in the game controller
        gameController.CompleteLevel();
    }

}

