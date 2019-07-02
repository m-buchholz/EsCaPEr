using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class ElementO : MonoBehaviour
{
    private Button button;
    private Boolean elementCollected;

    // Use this for initialization
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(takeElement);

        if (PlayerPrefs.GetString("ElementsInventory").Contains("8-O"))
        {
            GameObject.Find("element_o").SetActive(false);
            elementCollected = true;
            Debug.Log(elementCollected);
        }
        else
        {
            elementCollected = false;
        }
    }

    void takeElement()
    {
        GameObject.Find("element_o").SetActive(false);
        PlayerPrefs.SetInt("Room2_Minigame1", 1);
        PlayerPrefs.SetInt("Elements", (PlayerPrefs.GetInt("Elements") + 1));
        PlayerPrefs.SetString("ElementsInventory", (PlayerPrefs.GetString("ElementsInventory") + "8-O,"));

        elementCollected = true;
    }

    public Boolean isCollected()
    {
        return elementCollected;
    }
}
