using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This is used in order to help change scenes
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //This function will be called when the play button is pressed
   public void EnterGame ()
    {
        //This will load the next scene in the queue which is the first level after the user enters the game as I add one to the build index.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
