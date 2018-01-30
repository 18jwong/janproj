using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public static bool GameIsPaused = false;

	public GameObject pauseMenuUI;

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
        if (SoundPersist.instance != null)
        {
            SoundPersist.instance.music.Play();
        }
    }

	void Pause (){
		pauseMenuUI.SetActive (true);
        canvas.SetActive(false);
		Time.timeScale = 0f;
		GameIsPaused = true;
        if (SoundPersist.instance != null) {
            SoundPersist.instance.music.Pause();
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
