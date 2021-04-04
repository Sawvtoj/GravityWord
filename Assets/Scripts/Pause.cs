using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject PauseUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }

            else
            {
                Stop();
            }
        }
    }

    public void Resume()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Stop()
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        Debug.Log("Quitting Game");
        Time.timeScale = 1f;
        SceneManager.LoadScene("End");
    }

    public void Load()
    {
        Debug.Log("PLayer Name: " + PlayerPrefs.GetString("Player Name", PlayerName.username) + "\n");
        PlayerName.username = PlayerPrefs.GetString("Player Name", PlayerName.username);
        
        Debug.Log("Word Speed " + PlayerPrefs.GetFloat("Word Speed", WordDisplay.fallsSpeed) + "\n");
        WordDisplay.fallsSpeed = PlayerPrefs.GetFloat("Word Speed", WordDisplay.fallsSpeed);

        Debug.Log("Player Score: " + PlayerPrefs.GetInt("Score", Score.PlayerScore) + "\n");
        Score.PlayerScore = PlayerPrefs.GetInt("Score", Score.PlayerScore);
    }

    public void SavePrefs()
    {
        PlayerPrefs.SetString("Player Name", PlayerName.username);
        PlayerPrefs.SetFloat("Word Speed", WordDisplay.fallsSpeed);
        PlayerPrefs.SetInt("Score", Score.PlayerScore);
    }
    
}
