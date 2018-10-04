using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class moveScene : MonoBehaviour {
	public Text text;
	private int highScore; //ハイスコア用変数
	private string key = "HIGH SCORE"; //ハイスコアの保存先キー

	void Start(){
		highScore = PlayerPrefs.GetInt(key, 0);
		//保存しておいたハイスコアをキーで呼び出し取得し保存されていなければ0になる
		text.text = "HighScore : " + highScore.ToString()+  "<size=25>\nReset score = press P</size>";
		//ハイスコアを表示
	}


	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
			SceneManager.LoadScene ("GameScene");



		if (Input.GetKeyDown (KeyCode.P))
			PlayerPrefs.DeleteAll ();
		highScore = PlayerPrefs.GetInt(key, 0);
		//保存しておいたハイスコアをキーで呼び出し取得し保存されていなければ0になる
		text.text = "HighScore : " + highScore.ToString() +"<size=25>\nReset score = press P</size>";
		//ハイスコアを表示

	}

}