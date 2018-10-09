using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletandObjectDestroyer2 : MonoBehaviour {


	public GameObject score;
	public GameObject getpoint;
	public GameObject explode;
	public GameObject explode2;
	public GameObject explode3;




	// Use this for initialization
	void Start () {

		//ScoreTextを取得
		this.score = GameObject.Find ("ScoreText");
		this.getpoint = GameObject.Find ("GetText");




	}

	// Update is called once per frame
	void Update () {

	}

	//他のオブジェクトと接触した場合の処理
	void OnTriggerEnter(Collider other) {

		//障害物に衝突した場合
		if (other.gameObject.tag == "CarTag") {

			//変数scoreはScoreTextに貼り付けたScoreコンポーネントを取得しAddPoint関数を括弧内のポイントで実行
			this.score.GetComponent<Score> ().AddPoint (10);
			this.getpoint.GetComponent<Text> ().text = "Car! 10 points!";

			Instantiate(explode, this.transform.position, Quaternion.identity);



			//破壊処理実行
			Destroy (other.gameObject);
			Destroy (this.gameObject);
		}

		if (other.gameObject.tag == "TrafficConeTag") {

			//変数scoreはScoreTextに貼り付けたScoreコンポーネントを取得しAddPoint関数を括弧内のポイントで実行
			this.score.GetComponent<Score> ().AddPoint (5);
			this.getpoint.GetComponent<Text> ().text = "Cone! 5 points!";


			Instantiate(explode2, this.transform.position, Quaternion.identity);

			//破壊処理実行(コーンは消さない)
			Destroy (this.gameObject);
		}

		if (other.gameObject.tag == "CoinTag") {
			this.score.GetComponent<Score> ().AddPoint (0);
			this.getpoint.GetComponent<Text> ().text = "Don't shoot coins!";


			Destroy (other.gameObject);
			Destroy (this.gameObject);
		}

		if (other.gameObject.tag == "EnemyTag") {
			this.score.GetComponent<Score> ().AddPoint (200);
			this.getpoint.GetComponent<Text> ().text = "Bonus!! 200 points!!";


			Instantiate(explode3, this.transform.position, Quaternion.identity);


			Destroy (other.gameObject);
			Destroy (this.gameObject);
		}
		if (other.gameObject.tag == "Enemy2Tag") {
			this.score.GetComponent<Score> ().AddPoint (250);
			this.getpoint.GetComponent<Text> ().text = "Bonus!! 250 points!!";


			Instantiate(explode3, this.transform.position, Quaternion.identity);

			Destroy (other.gameObject);
			Destroy (this.gameObject);
		}
	



	}

}

