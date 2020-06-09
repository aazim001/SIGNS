using UnityEngine;

public class VehicleCrash : MonoBehaviour

{
    //Created the variable for vehicle move 
    public VehicleMove move;

    //Created the variable for the crash sound
    private AudioSource crashSound;

    //The audio gets assigned to the audio source and gets the component
    void Start()
    {
        crashSound = GetComponent<AudioSource>();
    }

    //This function is called when the 2 objects collide
    void OnCollisionEnter(Collision crashinfo)
    {
        //This is called when the vehicle collides with the asteroid 
        if (crashinfo.collider.tag == "Asteroid")
        {
            //When the vehicle now crashes with the object, the sound will be played
            crashSound.Play();
            //This action will happen if the name of the collider that is hit is "asteroid". 
            move.enabled = false;
            //Here is where the game ends, finding the game controller. 
            FindObjectOfType<GameController>().EndGame();
        }
    }
}
