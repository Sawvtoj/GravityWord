using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    int creditsTime;

    void Start()
    {
        creditsTime = 25000;
    }

    void Update()
    {
        if (creditsTime <= 0)
        {
            SceneManager.LoadScene("Menu");
        }
        else
        {
            creditsTime -= (int)Time.time;
            Debug.Log(creditsTime);
        }
    }
}
