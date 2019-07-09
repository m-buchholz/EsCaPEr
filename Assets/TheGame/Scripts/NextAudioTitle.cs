using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextAudioTitle : MonoBehaviour
{
    private Button button;
    public AudioClip audio1, audio2, audio3;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(NextTitle);
    }

    private void NextTitle()
    {
        if (GameObject.Find("Background Audio"))
        {
            AudioSource bAudio = GameObject.Find("Background Audio").GetComponent<AudioSource>();
            if (bAudio.clip == audio1) bAudio.clip = audio2;
            else if (bAudio.clip == audio2) bAudio.clip = audio3;
            else bAudio.clip = audio1;
            bAudio.Play();
        }
    }
}
