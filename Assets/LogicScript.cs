using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject gameQuit;
    public int debugValue = 0;
    public AudioSource dingSound;

    
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