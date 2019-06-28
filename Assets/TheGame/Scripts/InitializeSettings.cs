using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeSettings : MonoBehaviour
{
    void Start()
    {
        // READING STATUS

        // Tip: 0 - not readed, 1 - readed
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
        PlayerPrefs.SetInt("Fail", 0);

        // PROGRESS

        // Door: 0 - closed, 1 - opened
        PlayerPrefs.SetInt("Room2", 1);
        PlayerPrefs.SetInt("Room3", 1);
        PlayerPrefs.SetInt("Exit", 0);

        // collected elements
        PlayerPrefs.SetInt("Elements", 5);

        // SETTINGS
        PlayerPrefs.SetInt("Sound", 1);
    }
}
