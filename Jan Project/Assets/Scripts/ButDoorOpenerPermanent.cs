using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButDoorOpenerPermanent : MonoBehaviour {

    public GameObject doorGameObject;
    public float Duration = 5;
    public Vector3 ClosedPosition;
    public Vector3 OpenedPosition;

    public bool doorOpen = false;
    public bool buttonPressed;
    public bool buttonTriggered = false;
    private float Timer;
    private Vector3 CurrentPosition;
    
    
    IEnumerator Slide()
    {
        buttonPressed = true;
        Timer = 0.0f;
        while(Timer < Duration)
        {
            if (!doorOpen)
            {
                CurrentPosition = Vector3.Lerp(ClosedPosition, OpenedPosition, Timer / Duration);
            }
            else if (doorOpen)
            {
                CurrentPosition = Vector3.Lerp(OpenedPosition, ClosedPosition, Timer / Duration);
            }
            doorGameObject.transform.localPosition = CurrentPosition;
            Timer += Time.deltaTime;
            yield return null;
        }

        doorOpen = !doorOpen;

        if (!doorOpen)
        {
            doorGameObject.transform.localPosition = ClosedPosition;
        }
        else if (doorOpen)
        {
            doorGameObject.transform.localPosition = OpenedPosition;
        }

        buttonPressed = false;
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player" && !buttonTriggered)
        {
            buttonTriggered = true;
            Slide();
            Debug.Log("Player On Button");
        }
    }


}
