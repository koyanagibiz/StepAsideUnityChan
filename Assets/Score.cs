using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	// スコアを表示する
	public Text scoreText;

	// スコア
	private int score;

	public Text highScoreText; //ハイスコアを表示するText
	private int highScore; //ハイスコア用変数
	private string key = "HIGH SCORE"; //ハイスコアの保存先キー



	void Start ()
	{

		highScore = PlayerPrefs.GetInt(key, 0);
		//保存しておいたハイスコアをキーで呼び出し取得し保存されていなければ0になる
		highScoreText.text = "HighScore: " + highScore.ToString();
		//ハイスコアを表示
	}

	void Update ()
	{
		scoreText.text = "Score:" + score.ToString ();

		//ハイスコアより現在スコアが高い時
		if (score > highScore) {

			highScore = score;
			//ハイスコア更新

			PlayerPrefs.SetInt(key, highScore);
			//ハイスコアを保存

			highScoreText.text = "HighScore: " + highScore.ToString();
			//ハイスコアを表示
		}

	}


	// ポイントの追加
	public void AddPoint (int point)
	{
		score = score + point;
	}

	// ハイスコアの保存
	public void Save ()
	{
		// ハイスコアを保存する
		PlayerPrefs.SetInt (key, highScore);
		PlayerPrefs.Save ();
	}

}