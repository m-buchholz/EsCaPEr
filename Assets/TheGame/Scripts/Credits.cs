using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    private Text[] credits;
    public int creditEntries;
    public string creditsEntry0, creditsEntry1, creditsEntry2, creditsEntry3, creditsEntry4, creditsEntry5, creditsEntry6,
        creditsEntry7, creditsEntry8, creditsEntry9, creditsEntry10;


    void Start()
    {
        string[] creditsEntry = new string[creditEntries];
        creditsEntry[0] = creditsEntry0;
        creditsEntry[1] = creditsEntry1;
        creditsEntry[2] = creditsEntry2;
        creditsEntry[3] = creditsEntry3;
        creditsEntry[4] = creditsEntry4;
        creditsEntry[5] = creditsEntry5;
        creditsEntry[6] = creditsEntry6;
        creditsEntry[7] = creditsEntry7;
        creditsEntry[8] = creditsEntry8;
        creditsEntry[9] = creditsEntry9;
        creditsEntry[10] = creditsEntry10;

        credits = new Text[creditEntries];
        for (int i = 0; i < credits.Length; i++)
        {
            GameObject.Find("C" + i).GetComponent<Text>().text = creditsEntry[i];
        }
    }
}
