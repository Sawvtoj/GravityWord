using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = { "damage", "familiar", "strange", "hands", "uncovered", "amuse", "design", 
        "narrow", "flap", "refuse", "tough", "grandfather", "wren", "lyrical", "even", "crown", "blush", "mighty", 
        "spurious", "listen", "berserk", "lunchroom", "tremendous", "duck", "smell", "hole", "highfalutin", "upset", 
        "thick", "cows", "wool", "boot", "scratch", "puzzled", "solid", "defeated", "irate", "lick", "vegetable", 
        "extra-large", "beginner", "torpid", "slope", "sincere", "sheet", "uninterested", "horrible", "swanky", "cattle", "rat"};

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
