using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreResult : MonoBehaviour
{
    public Text scoreText;

    void Start()
    {
        int resultScore = PlayerPrefs.GetInt("score");
        scoreText.text = "SCORE: " + resultScore.ToString();        
    }
}
