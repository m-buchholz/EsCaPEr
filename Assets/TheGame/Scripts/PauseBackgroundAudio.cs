using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBackgroundAudio : MonoBehaviour
{
    void Start()
    {
        if (GameObject.Find("Background Audio")) GameObject.Find("Background Audio").GetComponent<AudioSource>().Pause();
    }
}
