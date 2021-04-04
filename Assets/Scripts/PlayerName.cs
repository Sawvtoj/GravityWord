using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public InputField playerNameInput;
    public Text nameText;
    public static string username = "Player 1";
    public static string scoreName;

    public void FindName()
    {
        username = playerNameInput.text;
    }

    void Start()
    {
        nameText.text = username;
        scoreName = nameText.text;
    }
}
