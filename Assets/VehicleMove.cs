using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleMove : MonoBehaviour
{
    // Refers to the rigid body component
    public Rigidbody rigidbody;

    //Here I am setting the front force which is the force the vehicle will be moving towards, I did this in order to then be able to modify the front force in the inspector.
    public float frontForce = 1800f;
    //Here I am setting the sideways force so when the user presses the keys a or d, this is the force that will be used to move th vehicle in those directions.
    public float sideForce = 400f;

    // Update is called once per frame
    void FixedUpdate()
    {
        //This helps add a force to the rigid body. We then specify the force by adding 0 on the x and y axis and frontForce for the z axis which allows the object to move forward. We then multiply it by Time.deltaTime which is the amount of seconds the computer drew the last frame. 
        rigidbody.AddForce(0, 0, frontForce * Time.deltaTime);

        //This is for when the user presses the key "d"
        if (Input.GetKey("d"))
        {
        //The force is added to vehicle so that it moves right 
            rigidbody.AddForce(frontForce * Time.deltaTime, 0, 0);
        }

        //This is for when the user presses the key "a"
        if (Input.GetKey("a"))
        {
        //The force is added to vehicle so that it moves left this time as the front force is at a minus.
            rigidbody.AddForce(-frontForce * Time.deltaTime, 0, 0);
        }

        //Use the rigid body and access the y value.
        if (rigidbody.position.y < -2f)
        {
            //Find the game controller and then end the game.
            FindObjectOfType<GameController>().EndGame();
        }
    }
}
