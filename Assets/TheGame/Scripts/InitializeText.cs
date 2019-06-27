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
        PlayerPrefs.SetString("R2_T", "Du hast es in den nächsten Raum geschafft, klasse!");
        // Room2_Minigame1
        PlayerPrefs.SetString("R2M1_T", "");
        // Room2_Minigame2
        PlayerPrefs.SetString("R2M2_T", "");
        // Room2_Minigame3
        PlayerPrefs.SetString("R2M3_T", "");
        // Room3
        PlayerPrefs.SetString("R3_T", "Du bist im letzten Raum!\nSchau dir mal die Tafel an!\nWas wohl der Professor hier möchte?");
        // Room3 Professor - if not all Quests are finished
        PlayerPrefs.SetString("Prof", "Hey, da bist du ja endlich!\nAber was ist das?\nScheinbar fehlen dir noch einige Kenntnisse.\nSchau dich nochmal in den Räumen um!");
        // Room3 Professor - if all Quests are finished
        PlayerPrefs.SetString("Prof_End", "Du hast alle Aufgaben bewältigt?\nDoch nun musst du noch meine Prüfung bestehen!\nMuhahahahaha...");
        // Room3_Minigame1
        PlayerPrefs.SetString("R3M1_T", "");
        // Room3_Minigame2
        PlayerPrefs.SetString("R3M2_T", "Hast du etwa jemand anderes erwartet?\nHier kann dir niemand helfen!\nNun los, zeig mir was du kannst!");
        // Failure
        PlayerPrefs.SetString("Fail_T", "Ups, da ist etwas schief gelaufen...");

        // MINIGAMES

        // Room3_Minigame2 - Format: Type(Q-Question or P-Picture)/Question/Right Answer/Answer2/Answer3
        // Text Questions - Q0-Q15
        PlayerPrefs.SetString("Q0", "T/Welches Element ist Sauerstoff?/O2/NaOH/O3,");
        PlayerPrefs.SetString("Q1", "T/?/1/2/3");
        PlayerPrefs.SetString("Q2", "T/?/1/2/3");
        PlayerPrefs.SetString("Q3", "T/?/1/2/3");
        PlayerPrefs.SetString("Q4", "T/?/1/2/3");
        PlayerPrefs.SetString("Q5", "T/?/1/2/3");
        PlayerPrefs.SetString("Q6", "T/?/1/2/3");
        PlayerPrefs.SetString("Q7", "T/?/1/2/3");
        PlayerPrefs.SetString("Q8", "T/?/1/2/3");
        PlayerPrefs.SetString("Q9", "T/?/1/2/3");
        PlayerPrefs.SetString("Q10", "T/?/1/2/3");
        PlayerPrefs.SetString("Q11", "T/?/1/2/3");
        PlayerPrefs.SetString("Q12", "T/?/1/2/3");
        PlayerPrefs.SetString("Q13", "T/?/1/2/3");
        PlayerPrefs.SetString("Q14", "T/?/1/2/3");
        PlayerPrefs.SetString("Q15", "T/?/1/2/3");
        // Image Questions - Q16-Q20
        PlayerPrefs.SetString("Q16", "erlenmeyerkolben/Welches Utensil ist das?/Erlenmeyerkolben/Reagenzglas/Messzylinder");
        PlayerPrefs.SetString("Q17", "spatellöffel/Welches Utensil ist das?/Spatellöffel/Pipette/Stopfen");
        PlayerPrefs.SetString("Q18", "stehkolben/Welches Utensil ist das?/Stehkolben/Erlenmeyerkolben/Rundkolben");
        PlayerPrefs.SetString("Q19", "pipette/Welches Utensil ist das?/Pipette/Stopfen/Reagenzglas");
        PlayerPrefs.SetString("Q20", "stopfen/Welches Utensil ist das?/Stopfen/Messbecher/Rundkolben");

        // OTHER

        // Door is locked
        PlayerPrefs.SetString("Door_locked", "Oh, die Tür ist verschlossen.\nDu brauchst wohl einen Schlüssel!\nVielleicht findest du ihn in einem offenen Raum?");
    }
}
