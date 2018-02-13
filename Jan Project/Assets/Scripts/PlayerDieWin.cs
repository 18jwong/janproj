using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerDieWin : MonoBehaviour {

	public GameObject P1;
	public GameObject P2;
	public GameObject P3;
	public GameObject P4;
	public TextMeshProUGUI P1WinsText;

	private bool P1Dead = false;
	private bool P2Dead = false;
	private bool P3Dead = false;
	private bool P4Dead = false;
	private int P1Wins = 0;
	private int P2Wins = 0;
	private int P3Wins = 0;
	private int P4Wins = 0;

	void Awake () {

		// Checks if each player exists each around or isn't already dead
		if (P1 == null) {
			P1Dead = true;
		}
		if (P2 == null) {
			P2Dead = true;
		}
		if (P3 == null) {
			P3Dead = true;
		}
		if (P4 == null) {
			P4Dead = true;
		}
	}
	
	// Update is called once per frame
	void Update () {

		CheckPlayers ();




	}

	void CheckPlayers(){
	
		if (P1.transform.localPosition.y < 0 && !P1Dead) {
			P1Dead = true;
		}

	}
}
