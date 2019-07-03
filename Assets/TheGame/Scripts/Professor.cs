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
    }

    private void openProf()
    {
        getText();
        profText.text = profSay;
        prof.SetActive(true);
    }

    private void getText()
    {
        if (PlayerPrefs.GetInt("Elements") < 5)
        {
            profSay = PlayerPrefs.GetString("Prof");
        }
        else if (PlayerPrefs.GetInt("Elements") >= 5 && PlayerPrefs.GetInt("Room3_Minigame2") == 0)
        {
            profSay = PlayerPrefs.GetString("Prof_End");
        }
        else if (PlayerPrefs.GetInt("Room3_Minigame2") == 1)
        {
            profSay = PlayerPrefs.GetString("Prof_Finished");
        }
        else
        {
            profSay = PlayerPrefs.GetString("Fail_T");
        }
    }
}
