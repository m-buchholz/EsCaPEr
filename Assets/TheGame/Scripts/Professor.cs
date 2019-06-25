using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Professor : MonoBehaviour
{
    private Button button;
    private string profSay;
    public Text profText;
    public GameObject prof;

    void Start()
    {
        // hide Professor Overlay
        prof.SetActive(false);

        // include Button
        button = GetComponent<Button>();
        button.onClick.AddListener(openProf);

        // enter text
        if (PlayerPrefs.GetInt("Elements") != 5)
        {
            profSay = PlayerPrefs.GetString("Prof");
        }
        else
        {
            profSay = PlayerPrefs.GetString("Prof_End");
        }
    }

    private void openProf()
    {
        prof.SetActive(true);
        profText.text = profSay;
    }
}
