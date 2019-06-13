using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAudio : MonoBehaviour
{
    public static DontDestroyAudio instance;

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }
}
