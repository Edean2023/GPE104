using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Max speed of the player
    public float maxSpeed = 2f;
    // rotation speed of player
    float rotSpeed = 180f;
    // Update is called once per frame
    void Update()
    {
        // Rotate the ship

        // Gets rotation quaternion
        Quaternion rot = transform.rotation;
        
        // Gets the Z euler angle
         float z = rot.eulerAngles.z;
        
        // Change the z angle on input
        z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;

        // Recreate the quaternion
        rot = Quaternion.Euler( 0, 0, z );

        // Feed the quaternion into the rotation
        transform.rotation = rot;

        // Move the ship
        Vector3 pos = transform.position;

        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime , 0);

        pos += rot * velocity;
        // Updates position
        transform.position = pos;
        




    }
}
