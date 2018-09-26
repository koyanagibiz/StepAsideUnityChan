using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletandObjectDestroyer : MonoBehaviour {

	//ゲーム終了の判定
	private bool isEnd = false;

	//ゲーム終了時に表示するテキスト
	private GameObject stateText;


	// Use this for initialization
	void Start () {

		//シーン中のstateTextオブジェクトを取得
		this.stateText = GameObject.Find("GameResultText");
	}

	// Update is called once per frame
	void Update () {

	}

	//他のオブジェクトと接触した場合の処理
	void OnTriggerEnter(Collider other) {

		//障害物に衝突した場合
		if (other.gameObject.tag == "CarTag" || 
			other.gameObject.tag == "TrafficConeTag" ||
			other.gameObject.tag == "CoinTag")
		{
			Destroy (other.gameObject);
			Destroy(this.gameObject);
		}

		//障害物に衝突した場合
		if (other.gameObject.tag == "CoinTag" ) {
			this.isEnd = true;
			//stateTextにGAME OVERを表示
			this.stateText.GetComponent<Text>().text = "GAME OVER";
			Time.timeScale = 0;
		}

	}

}
