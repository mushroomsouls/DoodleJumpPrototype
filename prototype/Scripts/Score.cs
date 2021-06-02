using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public Transform target;
    public Text scoreText;
	public float currentScore;
	public float savedScore;

	void LateUpdate()
	{
		if (target != null)
		{
			if (target.position.y > transform.position.y)
			{
				Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
				scoreText.text = "Score: " + Mathf.Round((float)target.position.y * 10f);
				currentScore = Mathf.Round((float)target.position.y * 10f);
			}
		}
		else
        {
			SaveGame();
			PassScore();
		}
	}

	void SaveGame()
    {
		if (PlayerPrefs.HasKey("ScoreToPass"))
        {
			savedScore = PlayerPrefs.GetFloat("HighscoreToPass");
			PlayerPrefs.SetFloat("SavedScore", savedScore);
			if (savedScore < currentScore)
			{
				PlayerPrefs.SetFloat("HighscoreToPass", currentScore);
				PlayerPrefs.Save();
			}
        }
	}

	void PassScore()
    {
		PlayerPrefs.SetFloat("ScoreToPass", currentScore);
		PlayerPrefs.Save();
	}
}
