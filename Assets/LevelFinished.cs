using UnityEngine;
//Helps load the next scene
using UnityEngine.SceneManagement;

public class LevelFinished : MonoBehaviour
{
    //Function to load the next scene
    public void LoadNextLevel () 
    {
       //This will load the next scene in the game which is the next level after the animation through using an animation event as I add one to the build index.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
} 
