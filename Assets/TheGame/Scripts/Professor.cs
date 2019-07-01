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
        if (PlayerPrefs.GetInt("Elements") < 5 && PlayerPrefs.GetInt("Minigame6") == 0)
        {
            profSay = PlayerPrefs.GetString("Prof");
        }
        else if (PlayerPrefs.GetInt("Elements") >= 5 && PlayerPrefs.GetInt("Minigame6") == 0)
        {
            profSay = PlayerPrefs.GetString("Prof_End");
        }
        else if (PlayerPrefs.GetInt("Minigame6") == 1)
        {
            profSay = PlayerPrefs.GetString("Prof_Finished");
        }
        else
        {
            profSay = PlayerPrefs.GetString("Fail_T");
        }
    }

    private void openProf()
    {
        profText.text = profSay;
        prof.SetActive(true);
    }
}
