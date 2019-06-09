using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsAction : MonoBehaviour
{
    public Button button;
    public Text text;

    void Start()
    {
        button.onClick.AddListener(credit);
    }

    public void credit()
    {
        text.text = "\nDanke fürs Spielen\n\n- euer Team smokingFox";
    }
}