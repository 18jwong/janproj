using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public static bool GameIsPaused = false;

	public GameObject pauseMenuUI;

    public AudioSource music;
    public GameObject canvas;
    public GameObject FadeText;

    private void Start()
    {
        canvas = GameObject.Find("Canvas");
        FadeText = GameObject.Find("FadeText");
        GameIsPaused = false;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (GameIsPaused) {
				Resume();
			} else {
				Pause();
			}
		}
	}

	public void Resume (){
		pauseMenuUI.SetActive (false);
        canvas.SetActive(true);
        FadeText.SetActive(false);
		Time.timeScale = 1f;
        GameIsPaused = false;
        if (SoundPersist.instance != null && SceneManager.GetActiveScene().name == "L2 - A Little Thinking" || SceneManager.GetActiveScene().name == "L1 - Tutorial")
        {
            SoundPersist.instance.music.Play();
        }
        if (SceneManager.GetActiveScene().name == "V2 - Versus" || SceneManager.GetActiveScene().name == "V3 - Versus" || SceneManager.GetActiveScene().name == "V4 - Versus")
        {
            music.Play();
        }
    }

	void Pause (){
		pauseMenuUI.SetActive (true);
        canvas.SetActive(false);
		Time.timeScale = 0f;
		GameIsPaused = true;
        if (SoundPersist.instance != null && SceneManager.GetActiveScene().name == "L2 - A Little Thinking" || SceneManager.GetActiveScene().name == "L1 - Tutorial") {
            SoundPersist.instance.music.Pause();
        }
        if (SceneManager.GetActiveScene().name == "V2 - Versus" || SceneManager.GetActiveScene().name == "V3 - Versus" || SceneManager.GetActiveScene().name == "V4 - Versus") {
            music.Pause();
        }
	}

	public void LoadMenu(){
		SceneManager.LoadScene ("0 - Main Menu");
		SoundPersist.instance.music.Stop();
    }

	public void QuitGame(){
		Debug.Log ("Quit Game");
		Application.Quit ();
	}
}
