using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformShrink : MonoBehaviour {

	public float scaleX;
	public float scaleZ;
	public float scaleMultiplier;

	// Update is called once per frame
	void Update () {
		//Shrinks Platform in the x direction
		if (transform.localScale.x > 0) {
			transform.localScale += new Vector3 (scaleX * Time.deltaTime, 0, 0);
			scaleX *= scaleMultiplier;

		}

		//Shrinks platform in the z direction
		if (transform.localScale.z > 0) {
			transform.localScale += new Vector3 (0, 0, scaleZ * Time.deltaTime);
			scaleZ *= scaleMultiplier;
		}

		//Makes sure platform does not go negative
		if (transform.localScale.x <= 0){
            Destroy(gameObject);
		}
		if (transform.localScale.z <= 0){
            Destroy(gameObject);
        }
	}
}
