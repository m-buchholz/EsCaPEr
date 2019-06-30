using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// loads sprites of collected elements into ElementsHUD
/// </summary>

public class InitializeInventory : MonoBehaviour
{
    private GameObject[] Elements;
    private string[] ElementsInventory;
    public int maxInventorySpace;

    void Start()
    {
        Elements = new GameObject[6];
        // split Elements at ',' in PlayerPrefs
        ElementsInventory = (PlayerPrefs.GetString("ElementsInventory")).Split(',');


       for (int i = 0; i <= ElementsInventory.Length-1 && i <= (maxInventorySpace-1); i++)
        {

            // Element Sprites starts at 1 to 6 (not 0 to 5)
            if (ElementsInventory[i] != "")
            {
                GameObject.Find("Element" + (i + 1)).GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/PSE/" + ElementsInventory[i]);
                GameObject.Find("Element" + (i + 1)).GetComponent<Image>().rectTransform.sizeDelta = new Vector2(0.9f, 0.9f);
                GameObject.Find("Element" + (i + 1)).GetComponent<Image>().color = Color.white;
            }
        }
    }
}