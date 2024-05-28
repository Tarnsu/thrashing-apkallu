using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public int highScore;
    public Text scoreText;
    public Text highScoreText;
    public GameObject gameOverScreen;
    public GameObject gameQuit;
    public int debugValue = 0;
    public AudioSource dingSound;


    void Start()
    {
        if (!PlayerPrefs.HasKey("highScore"))
        {
            PlayerPrefs.SetInt("highScore", 0);
            highScoreText.text = "High Score: 0";
        }
        else {
            highScoreText.text = "High Score: " + PlayerPrefs.GetInt("highScore").ToString();
        }

        highScore = PlayerPrefs.GetInt("highScore");
    }
    public void addScore(int scoreToAdd)
    {
        if (gameOverScreen.activeInHierarchy == false)
        {
            playerScore += scoreToAdd;
            scoreText.text = playerScore.ToString();
            dingSound.Play();
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);

        if (playerScore > highScore)
        {
            highScore = playerScore;
            PlayerPrefs.SetInt("highScore", playerScore);
            highScoreText.text = "High Score: " + highScore.ToString();
        }
    }

    public void doExitGame()
    {
        Application.Quit();
    }

    [ContextMenu("Increase Debug Value")]
    public void addDebug()
    {
        if (gameOverScreen.activeInHierarchy == false)
        {
            debugValue++;
        }
    }
}