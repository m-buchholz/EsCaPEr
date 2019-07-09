using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBackgroundAudio : MonoBehaviour
{
    private Button button;
    public AudioClip audioClip;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ChangeAudio);
    }

    private void ChangeAudio()
    {
        if (GameObject.Find("Background Audio"))
        {
            GameObject.Find("Background Audio").GetComponent<AudioSource>().clip = audioClip;
            GameObject.Find("Background Audio").GetComponent<AudioSource>().Play();
        }
    }
}
