using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	// スコアを表示する
	public Text scoreText;

	// スコア
	private int score = 0;

	void Start ()
	{
	}

	void Update ()
	{
		scoreText.text = "Score:" + score.ToString ();
	}


	// ポイントの追加
	public void AddPoint (int point)
	{
		score = score + point;
	}


}