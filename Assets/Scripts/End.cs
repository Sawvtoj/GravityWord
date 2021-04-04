using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class End : MonoBehaviour
{
    int endTime;

    void Awake()
    {
        endTime = 20000;
    }

    void Update()
    {
        if (endTime <= 0)
        {
            SceneManager.LoadScene("Credits");
        }
        else
        {
            endTime -= (int)Time.time;
            Debug.Log(endTime);
        }
    }
}
