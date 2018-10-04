using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopScript : MonoBehaviour {

	public bool pausing;

	public GameObject pauseText;

	public GameObject forwardforceofunitychan;


void Start(){

		pausing = true;
		this.pauseText = GameObject.Find("PausePanel");
		this.pauseText.SetActive (true);
		this.forwardforceofunitychan.GetComponent<UnityChanController> ().forwardForce = 800.0f;



	}

void Update(){
		if (this.pausing) {
			Time.timeScale = 0f;
			this.forwardforceofunitychan.GetComponent<UnityChanController> ().forwardForce = 0f;

			pauseText.SetActive (true);
		} else {
			Time.timeScale = 1f;
			this.forwardforceofunitychan.GetComponent<UnityChanController> ().forwardForce = 800.0f;
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
