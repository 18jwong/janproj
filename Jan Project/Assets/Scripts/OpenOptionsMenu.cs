using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenOptionsMenu : MonoBehaviour {

    public GameObject go;

    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Q)) {
            go.SetActive(true);
            Debug.Log("hey");
        }
	}
}
