﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeText : MonoBehaviour
{
    void Start()
    {
        // SMOKINGFOX INSTRUCTIONS

         // Introduction + Foyer_Exit
        PlayerPrefs.SetString("F_E_T", "Willkommen im Labor!\nEs scheint, als hätte uns hier jemand eingesperrt! Ich glaube, wir müssen die fehlenden Elemente aus dem Periodensystems finden.");

        // Foyer_Rooms
        PlayerPrefs.SetString("F_R_T", "Hier sind mehrere Räume. Vielleicht ist ja einer davon offen?");

        // Room1
        PlayerPrefs.SetString("R1_T", "Schau dir mal den Labortisch an, dort liegt irgendetwas!");

        // Room1_Minigame1
        PlayerPrefs.SetString("R1M1_T", "Deine Aufgabe ist es, alle Utensilien richtig zuzuordnen.");

        // Room1_Minigame2
        PlayerPrefs.SetString("R1M2_T", "");

        // Room1_Minigame3
        PlayerPrefs.SetString("R1M3_T", "");

        // Room2
        PlayerPrefs.SetString("R2_T", "R2 Tipp");

        // Room2_Minigame1
        PlayerPrefs.SetString("R2M1_T", "");

        // Room2_Minigame2
        PlayerPrefs.SetString("R2M2_T", "");

        // Room2_Minigame3
        PlayerPrefs.SetString("R2M3_T", "");

        // Room3
        PlayerPrefs.SetString("R3_T", "R3 Tipp");

        // Room3 Professor - if not all Quests are finished
        PlayerPrefs.SetString("Prof", "Hey, da bist du ja endlich!\nAber was ist das?\nScheinbar fehlen dir noch einige Kenntnisse.\nSchau dich nochmal in den Räumen um!");

        // Room3 Professor - if all Quests are finished
        PlayerPrefs.SetString("Prof_End", "Unglaublich, du hast alle Aufgaben bewältigt!\nDoch nun musst du noch meine Prüfung bestehen!\nMuhahahahaha...");

        // Room3_Minigame1
        PlayerPrefs.SetString("R3M1_T", "");

        // Room3_Minigame2
        PlayerPrefs.SetString("R3M2_T", "");

        // OTHER

        // Door is locked
        PlayerPrefs.SetString("Door_locked", "Oh, die Tür ist verschlossen.\nDu brauchst wohl einen Schlüssel!\nVielleicht findest du ihn in einem offenen Raum?");
    }
}
