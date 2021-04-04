using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Play()
    {
        Score.PlayerScore = 0;
        SceneManager.LoadScene("MainLvl");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Highscores()
    {
        SceneManager.LoadScene("HighScore");
    }
}
