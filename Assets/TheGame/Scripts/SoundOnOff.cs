using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundOnOff : MonoBehaviour
{
    private Button button;
    public Sprite soundOnImage;
    public Sprite soundOffImage;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(changeSound);

        if (PlayerPrefs.GetInt("Sound") == 0)
        {
            soundOff();
        }
        else if (PlayerPrefs.GetInt("Sound") == 1)
        {
            soundOn();
        }
    }

    private void changeSound()
    {
        if (PlayerPrefs.GetInt("Sound") == 1)
        {
            soundOff();
        }
        else if (PlayerPrefs.GetInt("Sound") == 0)
        {
            soundOn();
        }
    }

    private void soundOn()
    {
        AudioListener.volume = 1f;
        button.GetComponent<Image>().sprite = soundOnImage;
        PlayerPrefs.SetInt("Sound", 1);
    }

    private void soundOff()
    {
        AudioListener.volume = 0f;
        button.GetComponent<Image>().sprite = soundOffImage;
        PlayerPrefs.SetInt("Sound", 0);
    }
}
