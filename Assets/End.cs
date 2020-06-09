using UnityEngine;

public class End : MonoBehaviour
{
    //Created the variable for quit which will close the game.
    public void Quit ()
    {
        //Appears in the console when the quit button is pressed.
        Debug.Log("quit");
        //This quits the application closing down the program and ending the game.
        Application.Quit();
    }   
}
