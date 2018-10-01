using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopScript : MonoBehaviour {

	public bool pausing;

	public GameObject pauseText;

void Start(){

		pausing = false;
		this.pauseText = GameObject.Find("PauseText");
		this.pauseText.SetActive (false);
	}

void Update(){
		if (this.pausing) {
			Time.timeScale = 0f;
			this.pauseText.GetComponent<Text>().text = "PAUSE";
			pauseText.SetActive (true);
		} else {
			Time.timeScale = 1f;
			this.pauseText.GetComponent<Text>().text = "";
			pauseText.SetActive (false);
		}


		if (Input.GetKeyDown (KeyCode.X)) {
			pausing = true;
		}

		if (Input.GetKeyDown(KeyCode.X)){
			if (Time.timeScale == 0f) {
				pausing = false;
			}
	}

	}

}
