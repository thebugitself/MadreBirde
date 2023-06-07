using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Logic : MonoBehaviour
{
    public int playerScore;
    public GameObject GameOverScreen;
    public Text Score;
    public Text highScore;
    public int high;
    private void Start()
    {
        highScoreShow();
    }
    public void restartGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void addScore(int score)
    {
        playerScore += score;
        Score.text = playerScore.ToString();
    }

    public void gameOver()
    {
        if (playerScore > high)
        {
            high = playerScore;
        }
        PlayerPrefs.SetInt("highscore", high);
        PlayerPrefs.Save();
        GameOverScreen.SetActive(true);
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }

    public void highScoreShow()
    {
        high = PlayerPrefs.GetInt("highscore");
        highScore.text = PlayerPrefs.GetInt("highscore").ToString();
    }
}
