using UnityEngine;

public class P4Controller : MonoBehaviour {
    
    public float movementForce = 2000;
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
        if (Input.GetKey("i"))
        {
            //Adds force north
            player.AddForce(0, 0, movementForce * Time.deltaTime);
        }

        //Move West Direction
        if (Input.GetKey("j"))
        {
            player.AddForce(-movementForce * Time.deltaTime, 0, 0);
        }

        //Move South Direction
        if (Input.GetKey("k"))
        {
            player.AddForce(0, 0, -movementForce * Time.deltaTime);
        }

        //Move East Direction
        if (Input.GetKey("l"))
        {
            player.AddForce(movementForce * Time.deltaTime, 0, 0);
        }
    }
}
