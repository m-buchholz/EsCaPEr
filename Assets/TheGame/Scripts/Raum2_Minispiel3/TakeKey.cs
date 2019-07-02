using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class TakeKey : MonoBehaviour
{
    private Button button;
    Boolean isNeutralized;

    // Use this for initialization
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(takeKey);
        isNeutralized = false;
    }

    void takeKey()
    {
        if (isNeutralized)
        {
            SceneManager.LoadScene("Room2", LoadSceneMode.Single);
            PlayerPrefs.SetInt("Room2_Minigame3", 1);
            PlayerPrefs.SetInt("Room2", 1);
            PlayerPrefs.SetInt("Room3-Key", 1);
            Initiate.Fade("Room1", Color.black, 10f);
        }
    }

    public Boolean getNeutralized()
    {
        return isNeutralized;
    }

    public void setNeutralized(Boolean isNeutralized)
    {
        this.isNeutralized = isNeutralized;
    }
}
