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
            newHighscore.text = "You beat your highscore!";
        else
            newHighscore.text = "";
    }

    void Update()
    {
        text.text = "Your final score was " + score.ToString() + "!";
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
