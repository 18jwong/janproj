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

    //Pressing the Quit Button causes Unity to close the application
    public void QuitGame()
    {
        //Debug prints to console so you can see in the Unity editor
        Debug.Log("Quit");
        Application.Quit();
    }
}
