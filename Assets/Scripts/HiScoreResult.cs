using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HiScoreResult : MonoBehaviour
{
    public Text hiScoreText;

    void Start()
    {
        int hiScore = PlayerPrefs.GetInt("hiScore");
        hiScoreText.text = "HI: " + hiScore.ToString();
    }
}
