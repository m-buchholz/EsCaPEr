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
            if (PlayerPrefs.GetString("ElementsInventory").Contains("8-O")) PlayerPrefs.SetInt("Room2_Minigame1", 1);
            PlayerPrefs.SetInt("Room3-Key", 1);
            Initiate.Fade("Room2", Color.black, 10f);
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
