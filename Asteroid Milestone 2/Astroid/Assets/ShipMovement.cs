using System.Collections;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    // Max speed of the player
    public float topSpeed = 14f;
    // rotation speed of player
    float rotationSpeed = 180f;
    float shipBoundaryRadiusUp = 0.5f;
    float shipBoundaryRadiusDown = 3.5f;
    float shipBoundaryRadiusLeft = 2f;
    float shipBoundaryRadiusRight = 2f;
    // This will be used to stop player movement later


    public bool canMove;
    // Start is called before the first frame update
   /* void Start()
    {
        canMove = true;
    }
    */
    
        
    // Update is called once per frame
    void Update()
    {
        // Rotate the ship

        // Gets rotation quaternion
        Quaternion rot = transform.rotation;
        
        // Gets the Z euler angle
         float z = rot.eulerAngles.z;
        
        // Change the z angle on input
        z -= Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        // Recreate the quaternion
        rot = Quaternion.Euler( 0, 0, z );

        // Feed the quaternion into the rotation
        transform.rotation = rot;

        // Move the ship
        Vector3 pos = transform.position;

        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * topSpeed * Time.deltaTime , 0);

        pos += rot * velocity;

        // This allows for any screen ratio
        float screenRatio = (float)Screen.width / (float)Screen.height; 
        float widthOrtho = Camera.main.orthographicSize * screenRatio;



    }
}
