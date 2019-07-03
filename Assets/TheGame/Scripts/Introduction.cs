using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Introduction : MonoBehaviour
{
    public GameObject fox;

    void Start()
    {
        if (PlayerPrefs.GetInt("Intro") == 0)
        {
            fox.GetComponentInChildren<Text>().text = PlayerPrefs.GetString("Intro_T");
            PlayerPrefs.SetInt("Intro", 1);
            fox.SetActive(true);
        }
    }
}
