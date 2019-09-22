using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager_Score : MonoBehaviour
{
    public Text scoreText;
    public Text highscoreText;
    public int score = 0;
    int highscore;

    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore");
        highscoreText.text = "Highscore: " + highscore.ToString();
    }

    public void UpdatingScore()
    {
        score++;
        scoreText.text = "Score: " + (score /4).ToString();

        if ((score / 4) >= highscore)
        {
            highscore = score / 4;
            highscoreText.text = "Highscore: " + highscore.ToString();

            PlayerPrefs.SetInt("highscore", highscore);
        }
        
    }
}