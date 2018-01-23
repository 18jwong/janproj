using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButDoorOpenerPermanent : MonoBehaviour {

    public GameObject doorGameObject;
    public float Duration = 5;
    public Vector3 openedPosition;
    public Vector3 closedPosition;

    public bool doorOpen = false;
    public bool buttonPressed = false;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player" && !buttonPressed)
        {
            buttonPressed = true;
            Debug.Log("Player On Button");

            doorGameObject.transform.position = openedPosition;
        }
    }


}
