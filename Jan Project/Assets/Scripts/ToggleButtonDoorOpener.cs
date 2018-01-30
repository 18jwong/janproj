using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleButtonDoorOpener : MonoBehaviour {

	public GameObject door1;
	public GameObject door2;
	public Vector3 firstPositionDoor1;
	public Vector3 secondPositionDoor1;
	public Vector3 firstPositionDoor2;
	public Vector3 secondPositionDoor2;

	private bool firstState = true;

	private void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "Player")
		{
			Debug.Log("Player On Button");

			//Changes from door position 1 to 2
			if(firstState == true){
				door1.transform.position = secondPositionDoor1;
				door2.transform.position = secondPositionDoor2;
			}

			//Changes from door position 2 to 1
			else if(firstState == false){
				door1.transform.position = firstPositionDoor1;
				door2.transform.position = firstPositionDoor2;
			}

			//Alternates firstState boolean
			firstState = !firstState;
		}
	}
}
