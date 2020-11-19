using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
	public Text scoreText;
	private int score = 0;

	void Update()
    {
		score += 1;
		scoreText.text = "SCORE: " + score.ToString();
	}
}
