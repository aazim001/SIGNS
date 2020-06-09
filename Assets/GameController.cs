using UnityEngine;
//This is used to change to a different scene or reload the current scene.
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //This is a boolean variable so it is set to false.
    bool gamefinish = false;

    //Setting the restarttime to 2f means that it will take a few seconds after the vehicle has collided with the object and then restart the level.
    public float restarttime = 2f;

    //References the UI to enable when the level is completed.
    public GameObject completelevelUI; 

    //Function to complete the level.
    public void CompleteLevel()
    {
        //Here we enable the UI.
        completelevelUI.SetActive(true);
    }

    //Function to end the game
    public void EndGame()
    {
        //Checks if the game has already ended
        if (gamefinish == false)
        {
            //Setting gamefinish to true
            gamefinish = true;
            Debug.Log("End");
            //If it has ended, the game will then restart as it is called after a delay. 
            Invoke("Restart", restarttime);
        }
    }

    //The restart method
    void Restart ()
    {
        //Loading the next scene with the current scene.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
