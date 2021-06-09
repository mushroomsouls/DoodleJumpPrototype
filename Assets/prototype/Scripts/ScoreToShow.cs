using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreToShow : MonoBehaviour
{
    public Text text;
    public Text newHighscore;
    private float score;
    private float highscore;
    private float savedScore;

    private void Start()
    {
        ScoreToPass();

        if (savedScore < score)
            newHighscore.text = "YOU BEAT YOUR HIGHSCORE!";
        else
            newHighscore.text = "";
    }

    void Update()
    {
        text.text = "YOUR FINAL SCORE WAS " + score.ToString() + "!";
    }

    void ScoreToPass()
    {
        if (PlayerPrefs.HasKey("ScoreToPass"))
        {
            score = PlayerPrefs.GetFloat("ScoreToPass");
            savedScore = PlayerPrefs.GetFloat("SavedScore");
        }
    }
}
