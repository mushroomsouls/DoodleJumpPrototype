using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreScript : MonoBehaviour
{
    public Text text;
    private float score;

    private void Start()
    {
        ScoreToPass();
    }

    void Update()
    {
        text.text = "Highscore: " + score.ToString();
    }

    void ScoreToPass()
    {
        if (PlayerPrefs.HasKey("HighscoreToPass"))
        {
            score = PlayerPrefs.GetFloat("HighscoreToPass");
        }
    }
}