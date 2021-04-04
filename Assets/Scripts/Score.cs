using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int PlayerScore;

    public Text ScoreText;

    void Update()
    {
        ScoreText.text = "Score: " + PlayerScore.ToString();
    }

}
