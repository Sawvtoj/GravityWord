using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WordSpeedSlider : MonoBehaviour
{
    public Slider slider;
    public Text wordSpeedDisplay;

    public void Awake()
    {
        slider = GameObject.FindWithTag("Speed").GetComponent<Slider>();
    }

    public void OnEnable()
    {
        slider.onValueChanged.AddListener(delegate { sliderCallBack(slider); });
    }

    public void sliderCallBack(Slider slider)
    {
        WordDisplay.fallsSpeed = slider.value;
        wordSpeedDisplay.text = slider.value.ToString();
    }
}
