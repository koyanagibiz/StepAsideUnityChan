using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletandObjectDestroyer2 : MonoBehaviour {


	//スコアを表示するテキスト
	private GameObject scoreText;
	//得点
	private int score = 0;

	// Use this for initialization
	void Start () {
		//シーン中のscoreTextオブジェクトを取得
		this.scoreText = GameObject.Find("ScoreText");


	}

	// Update is called once per frame
	void Update () {

	}

	//他のオブジェクトと接触した場合の処理
	void OnTriggerEnter(Collider other) {

		//障害物に衝突した場合
		if (other.gameObject.tag == "CarTag" || 
			other.gameObject.tag == "TrafficConeTag"||
			other.gameObject.tag == "CoinTag")
		{
			Destroy (other.gameObject);
			Destroy(this.gameObject);
		}




	}

}

