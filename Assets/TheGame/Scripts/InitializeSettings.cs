using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Initialize all settings and progress
/// </summary>

public class InitializeSettings : MonoBehaviour
{
    void Start()
    {
        // READING STATUS

        // Tip: 0 - not readed, 1 - readed
        PlayerPrefs.SetInt("Intro", 0);
        PlayerPrefs.SetInt("F_E", 0);
        PlayerPrefs.SetInt("F_R", 0);
        PlayerPrefs.SetInt("R1", 0);
        PlayerPrefs.SetInt("R1M1", 0);
        PlayerPrefs.SetInt("R1M2", 0);
        PlayerPrefs.SetInt("R2", 0);
        PlayerPrefs.SetInt("R2M1", 0);
        PlayerPrefs.SetInt("R2M2", 0);
        PlayerPrefs.SetInt("R2M3", 0);
        PlayerPrefs.SetInt("R3", 0);
        PlayerPrefs.SetInt("R3M1", 0);
        PlayerPrefs.SetInt("R3M2", 0);
        PlayerPrefs.SetInt("Fail", 0);
        PlayerPrefs.SetInt("MW", 0);
        PlayerPrefs.SetInt("E", 0);

        // PROGRESS

        // Minigames: 0 - todo, 1 - finished;
        PlayerPrefs.SetInt("Room1_Minigame1", 0);
        PlayerPrefs.SetInt("Room1_Minigame2", 0);
        PlayerPrefs.SetInt("Room2_Minigame1", 0);
        PlayerPrefs.SetInt("Room2_Minigame4", 0);
        PlayerPrefs.SetInt("Room3_Minigame1", 0);
        PlayerPrefs.SetInt("Room3_Minigame2", 0);

        // Door: 0 - closed, 1 - opened
        PlayerPrefs.SetInt("Room2", 0);
        PlayerPrefs.SetInt("Room3", 0);
        PlayerPrefs.SetInt("Exit", 0);

        // Collected elements - in format "number-Element" e.g. "1-H" or "2-He"
        PlayerPrefs.SetInt("Elements", 0);
        // Collected elements - in format "number-Element" e.g. "1-H" seperated through ',' e.g. "1-H,2-He,"
        PlayerPrefs.SetString("ElementsInventory", "");
        PlayerPrefs.SetString("ElementsInventoryLast", "");
        // example (end result): "1-H,78-Pt,8-O,11-Na,17-Cl,54-Xe,"

        // Keys in inventory
        PlayerPrefs.SetInt("Room2-Key", 0);
        PlayerPrefs.SetInt("Room3-Key", 0);

        // SETTINGS
        // Sound: 0 - off, 1 - on
        PlayerPrefs.SetInt("Sound", 1);
    }
}
