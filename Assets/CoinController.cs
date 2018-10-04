using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CoinController : MonoBehaviour {

	public GameObject getpoint;
	public GameObject score;

	// Use this for initialization
	void Start () {
		//回転を開始する角度を設定
		this.transform.Rotate (0, Random.Range (0, 360), 0);

		this.getpoint = GameObject.Find ("GetText");
		this.score = GameObject.Find ("ScoreText");
	}

	// Update is called once per frame
	void Update () {
		//回転
		this.transform.Rotate (0, 3, 0);
	


	}

	void OnTriggerEnter(Collider other) {
		
		if (other.gameObject.tag == "UnityChanTag") {
			//スコア処理を追加
			this.score.GetComponent<Score> ().AddPoint (15);

			this.getpoint.GetComponent<Text> ().text = "Got coin! 15 points!";


			Destroy (this.gameObject);
		}



	}
}