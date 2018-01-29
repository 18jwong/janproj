using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour {
	
	void Update () {
		//Restarts Level
		if (Input.GetKey("space")) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}
