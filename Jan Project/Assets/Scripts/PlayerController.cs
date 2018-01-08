using UnityEngine;

public class PlayerController : MonoBehaviour {
    
    public float movementForce = 4000;
    public float rotationSpeed = 180;

    private Rigidbody player;

    // Use this for initialization
    void Start ()
    {
        player = GetComponent<Rigidbody>();
	}
	
	// Controls player movement
	void Update ()
    {
        //Move North Direction
        if (Input.GetKey("w"))
        {
            //Adds force north
            player.AddForce(0, 0, movementForce * Time.deltaTime);
        }

        //Move West Direction
        if (Input.GetKey("a"))
        {
            player.AddForce(-movementForce * Time.deltaTime, 0, 0);
        }

        //Move South Direction
        if (Input.GetKey("s"))
        {
            player.AddForce(0, 0, -movementForce * Time.deltaTime);
        }

        //Move East Direction
        if (Input.GetKey("d"))
        {
            player.AddForce(movementForce * Time.deltaTime, 0, 0);
        }
    }
}
