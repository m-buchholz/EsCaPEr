using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundOnOff : MonoBehaviour
{
    public Button button;
    public Sprite soundOnImage;
    public Sprite soundOffImage;

    void Start()
    {
        button.onClick.AddListener(changeSound);
    }

    private void changeSound()
    {
        if (button.GetComponent<Image>().sprite == soundOnImage)
        {
            button.GetComponent<Image>().sprite = soundOffImage;
            soundOff();
        }
        else if (button.GetComponent<Image>().sprite == soundOffImage)
        {
            button.GetComponent<Image>().sprite = soundOnImage;
            soundOn();
        }
    }

    private void soundOn()
    {

    }

    private void soundOff()
    {

    }
}
