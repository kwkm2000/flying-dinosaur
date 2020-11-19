using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
	public Text scoreText;
	private int score = 0;
	private int hiScore;

	void Start()
    {
		hiScore = PlayerPrefs.GetInt("hiScore");
	}
    void Update()
    {
		score += 1;
		scoreText.text = "SCORE: " + score.ToString();
		if (hiScore < score)
        {
			PlayerPrefs.SetInt("hiScore", score);
        }
		PlayerPrefs.SetInt("score", score);
		PlayerPrefs.Save();
	}
}
