using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Initialize all text
/// </summary>

public class InitializeText : MonoBehaviour
{
    void Start()
    {
        // SMOKINGFOX INSTRUCTIONS

        // Introduction
        PlayerPrefs.SetString("Intro_T", "Willkommen im Chemie-Labor!\nEs scheint, als hätte uns hier jemand eingesperrt! Dort am Periodensystem fehlen einige Elemente. Ich glaube wir müssen sie finden, um hier raus zu kommen! Wenn du Hilfe brauchst, bin ich jederzeit oben rechts!");
        // Foyer_Exit
        PlayerPrefs.SetString("F_E_T", "An den schwarzen Stellen im Periodensystem waren wohl auch mal Elemente...\nWenn du auf die Fläche über der Tür drückst, kannst du die andere Hälfte des Raumes sehen.");
        // Exit (open)
        PlayerPrefs.SetString("Exit_O", "Wow, sind das etwa alle fehlenden Elemente? Klasse, dann können wir endlich dieses Labor verlassen! Lass uns die Tür öffnen!");
        // Exit (closed)
        PlayerPrefs.SetString("Exit_C", "Du hast noch nicht alle fehlenden Elemente. Schau dich doch mal in den Räumen um!");
        // Exit
        PlayerPrefs.SetString("E_T", "Und die Moral von der Geschicht:\nDu bist eingesperrt oder nicht.\n\nHauste rein, aber nicht so feste!");
        // Foyer_Rooms
        PlayerPrefs.SetString("F_R_T", "Hier sind mehrere Räume. Vielleicht ist ja einer davon offen?");

        // Room1
        PlayerPrefs.SetString("R1_T", "Schau dir mal den Labortisch etwas genauer an! Und was liegt denn da auf dem Boden? Sieht aus, als wären das verschiedene Metalle. Ob die Poster an der Wand möglicherweise einen Nutzen haben?");
        // Room1_Minigame1
        PlayerPrefs.SetString("R1M1_T", "Sieht aus, als wäre dein Wissen gefragt! Irgendwo hab ich diese Utensilien schon mal gesehen. Schau dir das Poster im ersten Raum nochmal an, wenn du es nicht genau weißt.");
        // Room1_Minigame2
        PlayerPrefs.SetString("R1M2_T", "Hier hast du einen Ofen und eine Gussform. Auf dem Tisch liegen Metalle, schau sie dir genauer an! Halte doch mal das Thermometer an das Schloss. Scheinbar ist nicht jedes Metall geeignet, um daraus einen Schlüssel für dieses Schloss zu fertigen.");

        // Room2
        PlayerPrefs.SetString("R2_T", "Du hast es in den nächsten Raum geschafft, klasse! In diesem Raum geht es um Säuren und Basen. Ganz schön ÄTZEND, was? Schau mal, dort stehen Reagenzgläser und auf der Tafel kleben irgendwelche Symbole!");
        // Room2_Minigame1
        PlayerPrefs.SetString("R2M1_T", "Ich sehe einen Schlüssel! Doch Vorsicht, diese Lösungen sind stark ätzend! " +
            "Zuerst müssen wir herausfinden, ob die Stoffe sauer oder basisch sind, um sie später zu neutralisieren. Benutze dafür den Universalindikator. Damit kannst du den pH-Wert der Lösungen ermitteln. Der pH-Wert gibt an, wie sauer oder basisch ein Stoff ist. Das kannst du bestimmt für den Tresor gebrauchen...");
        // Room2_Minigame2
        PlayerPrefs.SetString("R2M2_T", "Das sieht aus wie die Reaktionsgleichung für die Neutralisation von Schwefelsäure - genau das, was wir brauchen! Aber da fehlt ja etwas. Anscheinend musst du die Gleichung selbst ausgleichen. Weißt du noch, wie das geht? Weise die Zahlen den Lücken so zu, dass die Anzahl der Teilchen auf beiden Seiten gleich ist.");
        // Room2_Minigame3
        PlayerPrefs.SetString("R2M3_T", "Jetzt können wir die Schwefelsäure neutralisieren! Nimm dazu das Glas mit der Natronlauge (NaOH) und benutze es mit der Schwefelsäure. Die Oxoniumionen der Natronlauge werden mit den Hydroxidionen der Schwefelsäure zu Wasser reagieren. Dadurch heben sich Base und Säure auf und du kannst dir gefahrlos den Schlüssel greifen. Du merkst es daran, dass sich die Lösung gelb-grünlich färbt, der Indikator für den neutralen pH-Wert 7.");
        // Room2_Minigame4
        PlayerPrefs.SetString("R2M4_T", "Hier musst du wohl die Gefahrensymbole richtig zuordnen. Im ersten Raum habe ich ein Poster gesehen, auf dem die Symbole abgebildet sind.");
        
        // Room3
        PlayerPrefs.SetString("R3_T", "Du bist im letzten Raum!\nSchau dir mal die Tafel an, darunter klebt auch eine Notiz! Was wohl der Professor hier möchte?");
        // Room3 Professor - if not all Quests are finished
        PlayerPrefs.SetString("Prof", "Hey, da bist du ja endlich!\nAber was ist das?\nScheinbar fehlen dir noch einige Kenntnisse.\nSchau dich nochmal in den Räumen um!");
        // Room3 Professor - if all Quests are finished
        PlayerPrefs.SetString("Prof_End", "Du hast alle Aufgaben bewältigt?\nDoch nun musst du noch meine Prüfung bestehen!\nMuhahahahaha...");
        // Room3 Professor - if all Quests are finished
        PlayerPrefs.SetString("Prof_Finished", "Du hast bereits bestanden!\nFreiversuche gibts hier nicht.\nGeh mir aus den Augen!");
        // Room3_Minigame1
        PlayerPrefs.SetString("R3M1_T", "Sieht aus, als müsstest du hier die einzelnen Bestandteile der Stoffe in den richtigen Mengen einsammeln. War da nicht eine Notiz unter der Tafel? Nutze die Pfeiltasten zum Ausweichen und Einsammeln.");
        // Room3_Minigame2
        PlayerPrefs.SetString("R3M2_T", "Hast du etwa jemand anderes erwartet?\nHier kann dir niemand helfen!\nNun los, zeig mir was du kannst!");
        // Room3_Minigame2 Win
        PlayerPrefs.SetString("R3M2_W", "Gibt's nicht!\nDu hast es tatsächlich gemeistert.\nDu hast dir das letzte Element verdient!");
        // Room3_Minigame2 Lose
        PlayerPrefs.SetString("R3M2_L", "Hahahaha, das war nichts!\nVielleicht beim nächsten Mal?\nSchau dir lieber nochmal alles an!");

        // Minigame already finished
        PlayerPrefs.SetString("Minigame_finished", "Sieht aus, als hättest du dieses Rätsel bereits gemeistert. Bestimmt gibt es noch mehr zu tun!");
        // Failure
        PlayerPrefs.SetString("Fail_T", "Ups, da ist etwas schief gelaufen...");

        // MINIGAMES

        // Room3_Minigame2 - FORMAT: Type(Q-Question or P-Picture)/Question/Right Answer/Answer2/Answer3
        // Text Questions - Q0-Q15
        PlayerPrefs.SetString("Q0", "T/Welcher Stoff ist Sauerstoff?/O2/NaOH/O3");
        PlayerPrefs.SetString("Q1", "T/Welcher Stoff ist Natriumhydroxid?/NaOH/HNO3/HCl");
        PlayerPrefs.SetString("Q2", "T/Welcher Stoff ist Wasser?/H2O/H3O/HO");
        PlayerPrefs.SetString("Q3", "T/Welcher Stoff ist Salzsäure?/HCl/HNO2/HF");
        PlayerPrefs.SetString("Q4", "T/Welches Element ist Aluminium?/Al/Mn/Au");
        PlayerPrefs.SetString("Q5", "T/Welches Element ist Titanium?/Ti/Tm/P");
        PlayerPrefs.SetString("Q6", "T/Welches Element ist Eisen?/Fe/Ce/Pb");
        PlayerPrefs.SetString("Q7", "T/Welches Element ist Nickel?/Ni/Ne/Co");
        PlayerPrefs.SetString("Q8", "T/Welcher Element ist Platin?/Pt/Ag/Pb");
        PlayerPrefs.SetString("Q9", "T/Was gibt der pH-Wert an?/Wie sauer oder basisch ein Stoff ist/Wie warm oder kalt ein Stoff ist/Wie fest oder flüssig ein Stoff ist");
        PlayerPrefs.SetString("Q10", "T/Welcher pH-Wert beschreibt am ehesten einen basischen Stoff?/12/7/2");
        PlayerPrefs.SetString("Q11", "T/Was trifft am ehesten auf Natriumhydroxid zu?/Basisch/Neutral/Sauer");
        PlayerPrefs.SetString("Q12", "T/Was trifft am ehesten auf Wasser zu?/Neutral/Basisch/Sauer");
        PlayerPrefs.SetString("Q13", "T/Was trifft am ehesten auf Salzsäure zu?/Sauer/Neutral/Basisch");
        PlayerPrefs.SetString("Q14", "Brandfördernd/Was bedeutet dieses Symbol?/Brandfördernd/Leicht entzündlich/Explosiv");
        PlayerPrefs.SetString("Q15", "Giftig/Was bedeutet dieses Symbol?/Giftig/Umweltschädlich/Gesundheitsschädlich");
        PlayerPrefs.SetString("Q16", "Leicht entzündlich/Was bedeutet dieses Symbol?/Leicht entzündlich/Brandfördernd/Explosiv");
        PlayerPrefs.SetString("Q17", "Gesundheitsschädlich/Was bedeutet dieses Symbol?/Gesundheitsschädlich/Giftig/Ätzend");
        PlayerPrefs.SetString("Q18", "Umweltschädlich/Was bedeutet dieses Symbol?/Umweltschädlich/Gesundheitsgefährdend/Giftig");
        // Image Questions
        PlayerPrefs.SetString("Q19", "Erlenmeyerkolben/Welches Utensil ist das?/Erlenmeyerkolben/Reagenzglas/Messzylinder");
        PlayerPrefs.SetString("Q20", "Spatellöffel/Welches Utensil ist das?/Spatellöffel/Pipette/Stopfen");
        PlayerPrefs.SetString("Q21", "Stehkolben/Welches Utensil ist das?/Stehkolben/Erlenmeyerkolben/Rundkolben");
        PlayerPrefs.SetString("Q22", "Pipette/Welches Utensil ist das?/Pipette/Stopfen/Reagenzglas");
        PlayerPrefs.SetString("Q23", "Stopfen/Welches Utensil ist das?/Stopfen/Messbecher/Rundkolben");

        // OTHER

        // Door is locked
        PlayerPrefs.SetString("Door_locked", "Oh, die Tür ist verschlossen.\nDu brauchst wohl einen Schlüssel!\nVielleicht findest du ihn in einem offenen Raum?");
        PlayerPrefs.SetString("Door_unlock", "Ah, du hast ja einen Schlüssel!\nDann schließen wir sie mal auf...");

    }
}
