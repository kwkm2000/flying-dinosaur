using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private bool firstPush = false;
    public void PressRetry()
    {
        if (!firstPush)
        {
            SceneManager.LoadScene("Main", LoadSceneMode.Single);
            firstPush = true;
        }
    }
}
