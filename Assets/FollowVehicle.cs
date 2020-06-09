using UnityEngine;

public class FollowVehicle : MonoBehaviour
{
    //This variable stores the refernce to the vehicle and gives information about his position, rotation and scale.
    public Transform vehicle;
    //This stores 3 numbers.
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //transform refers to the current object which is the vehicle, and then the position of the camera. The camera then moves to the position of the vehicle so when the vehicle moves, the camera follows. 
        transform.position = vehicle.position + offset;
    }
}
