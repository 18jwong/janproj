using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;
using UnityEngine.SceneManagement;

public class SoundPersist : MonoBehaviour {

    public static SoundPersist instance;
    public AudioSource music;

    // Use this for initialization
    void Awake()
	{
        music = GetComponent<AudioSource>();

        if (instance == null)
        {
            instance = this;
        }
		else {
            Destroy(gameObject);
            return;
        }
			
		DontDestroyOnLoad (gameObject);
    }

	/*public class AudioControl{

		public void StopAudio(){
			var _audio = this.GetComponent<AudioSource> ();
			if (SceneManager.GetActiveScene ().buildIndex == 0) {
				Debug.Log ("stopping audio");
				_audio.Stop ();
			}
		} else if (SceneManager.GetActiveScene ().buildIndex >= 1 && SceneManager.GetActiveScene ().buildIndex <= 4) {
			_audio.Play ();
		}
	}*/
}
