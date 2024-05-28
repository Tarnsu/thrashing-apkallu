using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleLogicScript : MonoBehaviour
{
    

    public void doStartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void doExitGame()
    {
        Application.Quit();
    }
}
