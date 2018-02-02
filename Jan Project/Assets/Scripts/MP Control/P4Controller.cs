using UnityEngine;

public class P4Controller : MonoBehaviour {
    
    public float movementForce = 2000;
    public float rotationSpeed = 180;

    public GameObject ballPrefab;
    public Transform ballSpawn;
    public float destroyTime = 5;

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

        //Shoots Ball
        if (Input.GetKey("o"))
        {
            Fire();
        }
    }

    void Fire()
    {
        //Create ball from ball prefab
        var ball = (GameObject)Instantiate(ballPrefab, ballSpawn.position, ballSpawn.rotation);

        //Add velocity to the ball
        ball.GetComponent<Rigidbody>().velocity = ball.transform.forward * 6;

        //Destroy the ball after destroyTime seconds
        Destroy(ball, destroyTime);
    }
}
