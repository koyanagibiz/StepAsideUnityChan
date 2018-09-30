using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {



	// Use this for initialization
	void Start () {
		//回転を開始する角度を設定
		this.transform.Rotate (0, Random.Range (0, 360), 0);
	}

	// Update is called once per frame
	void Update () {
		//回転
		this.transform.Rotate (0, 3, 0);
	


	}

	void OnTriggerEnter(Collider other) {
		
		if (other.gameObject.tag == "UnityChanTag") {
			//スコア処理を追加
			FindObjectOfType<Score> ().AddPoint (10);


			//相手のタグがBallならば、自分を消す
			Destroy (this.gameObject);
		}

		if (other.gameObject.tag == "BulletTag") {
			FindObjectOfType<Score> ().AddPoint (-10);
			Destroy (this.gameObject);


		}

	}
}