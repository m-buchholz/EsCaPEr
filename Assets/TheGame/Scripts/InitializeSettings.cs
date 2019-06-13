using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeSettings : MonoBehaviour
{
    void Start()
    {
        // READING STATUS

        // 0 - not readed, 1 - readed
        PlayerPrefs.SetInt("F_E", 0);
        PlayerPrefs.SetInt("F_R", 0);
        PlayerPrefs.SetInt("R1", 0);
        PlayerPrefs.SetInt("R1M1", 0);
        PlayerPrefs.SetInt("R1M2", 0);
        PlayerPrefs.SetInt("R1M3", 0);
        PlayerPrefs.SetInt("R2", 0);
        PlayerPrefs.SetInt("R2M1", 0);
        PlayerPrefs.SetInt("R2M2", 0);
        PlayerPrefs.SetInt("R2M3", 0);
        PlayerPrefs.SetInt("R3", 0);
        PlayerPrefs.SetInt("R3M1", 0);
        PlayerPrefs.SetInt("R3M2", 0);

        // PROGRESS

        // collected elements
        PlayerPrefs.SetInt("Elements", 0);

        // SETTINGS
        PlayerPrefs.SetInt("Sound", 1);
    }
}
