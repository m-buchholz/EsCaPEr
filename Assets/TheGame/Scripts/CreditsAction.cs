using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsAction : MonoBehaviour
{

    public Button button;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(credit);
    }

    public void credit()
    {
        text.text = "\nDanke fürs Spielen\n\n- euer EsCaPEr Team";
    }
}
