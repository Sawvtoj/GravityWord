using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WordDisplay : MonoBehaviour
{
    public Text text;
    public static float fallsSpeed = 1f;

    public void SetWord(string word)
    {
        text.text = word;
    }

    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(0f, -fallsSpeed * Time.deltaTime, 0f);
        if(text.transform.position.y <= -5f)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("End");
            WordManager.hasActiveWord = false;
        }
            
    }
}
