using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger: MonoBehaviour
{
    //Pressing the Play Button causes Unity to load the next scene
    public void PlayNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

	//Pressing Level 1 loads up level1
	public void PlaySPL1()
	{
		SceneManager.LoadScene("L1 - Tutorial");
        if(SoundPersist.instance != null) {
            SoundPersist.instance.music.Play();
        }
    }
	//Pressing Level 2 loads up level2
	public void PlaySPL2()
	{
		SceneManager.LoadScene("L2 - A Little Thinking");
        if (SoundPersist.instance != null)
        {
            SoundPersist.instance.music.Play();
        }
    }

    //Pressing Multiplayer loads up the 2 Player Versus Mode
    public void PlayMP2P()
    {
        SceneManager.LoadScene("V2 - Versus");
    }
	//Pressing Multiplayer loads up the 3 Player Versus Mode
	public void PlayMP3P()
	{
		SceneManager.LoadScene("V3 - Versus");
	}
	//Pressing Multiplayer loads up the 4 Player Versus Mode
	public void PlayMP4P()
	{
		SceneManager.LoadScene("V4 - Versus");
	}

    //Pressing the Quit Button causes Unity to close the application
    public void QuitGame()
    {
        //Debug prints to console so you can see in the Unity editor
        Debug.Log("Quit");
        Application.Quit();
    }
}
